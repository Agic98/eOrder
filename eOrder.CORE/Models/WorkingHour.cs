using eOrder.CORE.Constants;
using System;

namespace eOrder.CORE.Models
{
    public class WorkingHour : IEntity
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public TimePeriod TimePeriod { get; set; }
        public bool IsDeleted { get; set; }
    }
}