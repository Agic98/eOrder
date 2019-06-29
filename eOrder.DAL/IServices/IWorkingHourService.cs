using eOrder.CORE.Models;
using eOrder.CORE.Requests;

namespace eOrder.DAL.IServices
{
    public interface IWorkingHourService : 
        IBaseCRUDService<
            WorkingHour,
            WorkingHourDTO,
            WorkingHourSearchRequest,
            WorkingHourRequest,
            WorkingHourRequest
            >
    {
    }
}
