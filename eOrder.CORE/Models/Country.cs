namespace eOrder.CORE.Models
{
    public class Country : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string PrimaryCurrency { get; set; }
        public bool IsDeleted { get; set; }
    }
}