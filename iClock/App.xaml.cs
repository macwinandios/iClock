using iClock.Locator;
using iClock.ViewModels;
using iClock.Views;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iClock
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var loginView = ViewModelLocator.Resolve<LoginView>();
            MainPage = new NavigationPage(loginView);
            //MainPage = new MainPage();
        }
        //Task InitNavigation()
        //{
        //    var navService = ViewModelLocator.Resolve<IGuestLoginService>();
        //    return navService.GuestLoginAsync<LoginViewModel>();
        //}

        protected override void OnStart()
        {
            //await InitNavigation();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
