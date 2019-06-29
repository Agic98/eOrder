using AutoMapper;
using eOrder.CORE;
using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.EF;
using eOrder.DAL.IServices;

namespace eOrder.DAL.Services
{
    public class CategoryService :
        BaseCRUDService<
            Category,
            CategoryDTO,
            CategorySearchRequest,
            CategoryRequest,
            CategoryRequest
            >
        , ICategoryService
    {
        public CategoryService(
            EOrderDbContext dbContext, 
            IMapper mapper,
            Resources resources) :
            base(dbContext, mapper, resources)
        { }
    }
}
