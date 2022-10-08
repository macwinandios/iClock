using iClock.Base;
using iClock.Commands;
using iClock.Factory;
using iClock.Interfaces;
using iClock.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace iClock.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel(ILoginModel loginModel)
        {
            var loginModelObject = ObjectFactory.CreateLoginModel(Model.LoginModel);
            _loginModel = loginModel;
        }
        public LoginViewModel()
        {
            
        }

        //PRIVATE MEMBERS
        ICommand _guestLoginCommand;
        ILoginModel _loginModel;

        //PUBLIC PROPERTIES 
        public string AdminPassword
        {
            get => _loginModel.AdminPassword;
            set
            {
                _loginModel.AdminPassword = value;
                OnPropertyChanged(nameof(AdminPassword));
            }
        }

        public string AdminUsername
        {
            get => _loginModel.AdminUsername;
            set
            {
                _loginModel.AdminUsername = value;
                OnPropertyChanged(nameof(AdminUsername));
            }
        }

        public string Password
        {
            get => _loginModel.Password;
            set
            {
                _loginModel.Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string Username
        {
            get => _loginModel.Username;
            set
            {
                _loginModel.Username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        //METHOD FOR GUEST TO BYPASS LOGIN CREDENTIALS
        public async void GuestLoginAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EmployeeTabs());
        }
        public ICommand GuestLoginCommand => _guestLoginCommand ?? (_guestLoginCommand = new Command(GuestLoginAsync));
    } 
}
