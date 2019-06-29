using eOrder.DAL.Helpers;
using System.Collections.Generic;

namespace eOrder.DAL.IServices
{
    public interface IBaseREADService<
        TEntity,
        TEntityDTO,
        TSearchObject
        >
        where TEntity : class, new()
        where TEntityDTO : class, new()
        where TSearchObject : class
    {
        TEntityDTO GetById(object id);
        IEnumerable<TEntityDTO> Get(TSearchObject searchObject = null, Pagination pagination = null);
    }
}
