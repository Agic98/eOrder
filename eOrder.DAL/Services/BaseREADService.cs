using AutoMapper;
using eOrder.CORE;
using eOrder.CORE.Helpers;
using eOrder.DAL.EF;
using eOrder.DAL.Helpers;
using eOrder.DAL.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace eOrder.DAL.Services
{
    public class BaseREADService<
        TEntity,
        TEntityDTO,
        TSearchObject
        >
        : IBaseREADService<
        TEntity,
        TEntityDTO,
        TSearchObject
        >
        where TEntity : class, IEntity, new()
        where TEntityDTO : class, new()
        where TSearchObject : class
    {
        protected EOrderDbContext _dbContext;
        protected IMapper _mapper;
        protected Resources _resources;

        protected IQueryable<TEntity> Query;

        public BaseREADService(
            EOrderDbContext dbContext, 
            IMapper mapper,
            Resources resources)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _resources = resources;
            Query = _dbContext.Set<TEntity>();
        }

        public virtual IEnumerable<TEntityDTO> Get(TSearchObject searchObject = null, Pagination pagination = null)
        {
            var query = Query.Where(x => !x.IsDeleted).AsQueryable();

            if (searchObject != null)
            {
                query = SetWhereClause(query, searchObject);
                query = SetIncludes(query, searchObject);
            }

            if (pagination != null)
            {
                query = query.Skip(pagination.SkipAmount).Take(pagination.Amount);
            }

            var result = query.ToList();

            if (pagination != null)
            {
                pagination.NumberOfRecords = result.Count + pagination.SkipAmount;
            }

            return _mapper.Map<List<TEntityDTO>>(result);
        }

        public virtual TEntityDTO GetById(object id)
        {
            var result = Query
                .Where(x => id.Equals(x.Id))
                .FirstOrDefault();

            return _mapper.Map<TEntityDTO>(result);
        }

        IQueryable<TEntity> SetWhereClause(IQueryable<TEntity> query, object searchObject, string childObjectName = "")
        {
            foreach (var prop in searchObject.GetType().GetProperties())
            {
                try
                {
                    //If the property has default value that means
                    //this property won't be used as a parameter for searching
                    var propType = prop.PropertyType;
                    var defaultPropValue = ObjectExtension.GetDefaultTypeValue(propType);
                    var propValue = prop.GetValue(searchObject, null);
                    if (propValue.Equals(defaultPropValue))
                    {
                        continue;
                    }

                    string propName = childObjectName != "" ? $"{childObjectName}.{prop.Name}" : prop.Name;

                    if (!propType.IsValueType && propType != typeof(string))
                    {
                        query = SetWhereClause(query, propValue, propName);
                        continue;
                    }

                    var value = prop.PropertyType == typeof(string) ? $"\"{prop.GetValue(searchObject, null)}\"" : prop.GetValue(searchObject, null);
                    if(value is Enum){
                        value = (int)value;
                    }

                    query = query.Where($"{propName} = {value}");
                }
                catch (Exception)
                {
                    continue;
                }
            }

            return query;
        }

        IQueryable<TEntity> SetIncludes(IQueryable<TEntity> query, object searchObject)
        {
            foreach (var prop in searchObject.GetType().GetProperties())
            {
                try
                {
                    var propType = prop.PropertyType;
                    if (propType.IsValueType || propType == typeof(string) || propType == typeof(DateTime))
                    {
                        continue;
                    }
                    var propValue = prop.GetValue(searchObject, null);
                    if (propValue == null)
                    {
                        continue;
                    }

                    query = query.Include($"{prop.Name}");
                }
                catch (Exception e)
                {
                    continue;
                }
            }

            return query;
        }

    }
}
