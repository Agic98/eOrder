using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eOrder.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void OpenRegisterPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new RegisterPage()));
        }
    }
}