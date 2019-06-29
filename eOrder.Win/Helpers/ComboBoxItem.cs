namespace eOrder.Win.Helpers
{
    public class ComboBoxItem
    {
        public int Value { get; set; }
        public string DisplayText { get; set; }

        public override string ToString()
        {
            return DisplayText;
        }
    }
}
