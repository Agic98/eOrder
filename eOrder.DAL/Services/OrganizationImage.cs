using AutoMapper;
using eOrder.CORE;
using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.EF;
using eOrder.DAL.IServices;

namespace eOrder.DAL.Services
{
    public class OrganizationImageService :
        BaseCRUDService<
            OrganizationImage,
            OrganizationImageDTO,
            OrganizationImageSearchRequest,
            OrganizationImageRequest,
            OrganizationImageRequest
            >
        , IOrganizationImageService
    {
        public OrganizationImageService(
            EOrderDbContext dbContext, 
            IMapper mapper,
            Resources resources) :
            base(dbContext, mapper, resources)
        { }
    }
}
