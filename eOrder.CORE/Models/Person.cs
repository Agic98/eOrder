using System;

namespace eOrder.CORE.Models
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}