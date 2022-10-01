using iClock.Base;
using iClock.Commands;
using iClock.Models;
using iClock.Services;
using iClock.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace iClock.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {

        public LoginViewModel(LoginModel loginModel)
        {
            LoginModel = loginModel;
        }

        //PRIVATE MEMBERS
        ICommand _guestLoginCommand;
        LoginModel _loginModel;


        //PUBLIC PROPERTIES 
        public LoginModel LoginModel
        {
            get => _loginModel;
            set => SetProperty(ref _loginModel, value);
        }
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
            await Application.Current.MainPage.Navigation.PushAsync(new ManagerTabs());
        }
        public ICommand GuestLoginCommand => _guestLoginCommand ?? (_guestLoginCommand = new Command(GuestLoginAsync));
    }
}
