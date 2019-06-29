using eOrder.CORE.Constants;
using eOrder.Mobile.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eOrder.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdersHistoryPage : ContentPage
    {
        OrdersViewModel model = null;
        public OrdersHistoryPage()
        {
            InitializeComponent();
            BindingContext = model = new OrdersViewModel(OrderStatus.Completed);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}