using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface IVehicleTypeService : 
        IBaseCRUDService<
            VehicleType,
            VehicleTypeDTO,
            VehicleTypeSearchRequest,
            VehicleTypeRequest,
            VehicleTypeRequest
            >
    {
    }
}
