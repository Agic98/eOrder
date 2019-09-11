using eOrder.CORE.Constants;
using eOrder.CORE.Requests;
using eOrder.Mobile.Views;
using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eOrder.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _roleService = new APIService("Role");

        public ICommand LoginCommand { get; set; }
        

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            //var locator = CrossGeolocator.Current;
            //var position = await locator.GetPositionAsync(new TimeSpan(10000));
            //var locationLongitude = position.Longitude.ToString();
            //var locationLatitude = position.Latitude.ToString();

            try
            {
                var roleDTOs = await _roleService.Get<List<RoleSearchRequest>>(new RoleSearchRequest { Username = Username, Password = Password });

                if (roleDTOs == null || roleDTOs.Count() == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "You are not authenticated", "OK");
                }
                else if (roleDTOs.Select(x => x.Name).Contains(UserType.Client) || roleDTOs.Select(x => x.Name).Contains(UserType.DeliveryPerson))
                {
                    Application.Current.MainPage = new MainPage();
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "You are not authenticated as a client or delivery person", "OK");
                }
            }
            catch (System.Exception e)
            {
            }

            APIService.Username = "demo.client";
            APIService.Password = "demo";
        }
    }
}
