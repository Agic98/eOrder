using eOrder.Mobile.Services;
using eOrder.Mobile.Views;
using Xamarin.Forms;

namespace eOrder.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            AdMaiora.RealXaml.Client.AppManager.Init(this);
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new MainPage();
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
