using System.Collections.Generic;

namespace eOrder.Mobile.Services
{
    public static class Cart
    {
        public static int CurrentOrganization { get; set; }
        public static Dictionary<int, int> CompanyOrderCombination { get; set; } = new Dictionary<int, int>();
    }
}
