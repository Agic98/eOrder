namespace eOrder.Mobile.Models
{
    public enum MenuItemType
    {
        Home,
        Search,
        Cart,
        OrdersHistory,
        OrdersActive,
        Profile,
        FavoritePlaces,
        FavoriteFood,
        Payments,
        Register
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
