namespace eOrder.DAL.Helpers
{
    public class Pagination
    {
        public int Page { get; set; } = 0;
        public int Amount { get; set; } = 10;
        public int SkipAmount { get => Page * Amount; private set { } }
        public int NumberOfRecords { get; set; }
    }
}
