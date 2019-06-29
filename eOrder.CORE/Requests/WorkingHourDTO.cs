using eOrder.CORE.Constants;
using System;

namespace eOrder.CORE.Requests
{
    public class WorkingHourDTO
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public OrganizationDTO Organization { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public TimePeriod TimePeriod { get; set; }
    }
}
