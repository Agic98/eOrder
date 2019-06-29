using AutoMapper;
using eOrder.CORE;
using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.EF;
using eOrder.DAL.IServices;

namespace eOrder.DAL.Services
{
    public class TagService :
        BaseCRUDService<
            Tag,
            TagDTO,
            TagSearchRequest,
            TagRequest,
            TagRequest
            >
        , ITagService
    {
        public TagService(
            EOrderDbContext dbContext, 
            IMapper mapper,
            Resources resources) :
            base(dbContext, mapper, resources)
        { }
    }
}
