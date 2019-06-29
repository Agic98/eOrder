using AutoMapper;
using eOrder.CORE;
using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.EF;
using eOrder.DAL.IServices;

namespace eOrder.DAL.Services
{
    public class VehicleTypeService :
        BaseCRUDService<
            VehicleType,
            VehicleTypeDTO,
            VehicleTypeSearchRequest,
            VehicleTypeRequest,
            VehicleTypeRequest
            >
        , IVehicleTypeService
    {
        public VehicleTypeService(
            EOrderDbContext dbContext,
            IMapper mapper,
            Resources resources) :
            base(dbContext, mapper, resources)
        { }
    }
}
