using AutoMapper;
using eOrder.CORE;
using eOrder.CORE.Models;
using eOrder.CORE.Requests;
using eOrder.DAL.EF;
using eOrder.DAL.IServices;

namespace eOrder.DAL.Services
{
    public class WorkingHourService :
        BaseCRUDService<
            WorkingHour,
            WorkingHourDTO,
            WorkingHourSearchRequest,
            WorkingHourRequest,
            WorkingHourRequest
            >
        , IWorkingHourService
    {
        public WorkingHourService(
            EOrderDbContext dbContext, 
            IMapper mapper,
            Resources resources) :
            base(dbContext, mapper, resources)
        { }
    }
}
