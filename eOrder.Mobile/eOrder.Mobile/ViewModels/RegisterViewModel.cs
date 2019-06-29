using eOrder.CORE.Requests;
using eOrder.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eOrder.Mobile.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        APIService _personService = new APIService("Person");

        public ICommand RegisterCommand { get; set; }

        string _firstName;
        public string FirstName
        {
            get => _firstName;
            set => SetProperty(ref _firstName, value);
        }

        string _lastName;
        public string LastName
        {
            get => _lastName;
            set => SetProperty(ref _lastName, value);
        }

        string _username;
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        string _passwordConfirm;
        public string PasswordConfirm
        {
            get => _passwordConfirm;
            set => SetProperty(ref _passwordConfirm, value);
        }

        public RegisterViewModel()
        {
            RegisterCommand = new Command(async () => await Register());
        }

        async Task Register()
        {
            try
            {
                if(string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(PasswordConfirm))
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Username or Password or PasswordConfirm is empty!", "OK");
                    return;
                }

                var newPerson = await _personService.Insert<PersonDTO>(new PersonRequest
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    User = new UserRequest
                    {
                        Username = Username,
                        Password = Password,
                        PasswordConfirmed = PasswordConfirm
                    }
                });

                if (newPerson != null)
                {
                    APIService.Username = Username;
                    APIService.Password = Password;
                    Application.Current.MainPage = new MainPage();
                }
            }
            catch (Exception)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "An error occured while creating a new account!", "OK");
            }
        }
    }
}
