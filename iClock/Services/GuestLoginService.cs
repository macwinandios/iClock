using iClock.Base;
using iClock.Locator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using iClock.Views;
using Xamarin.Forms;

namespace iClock.Services
{
    public class GuestLoginService 
    {


        //public Task GoBackAsync()
        //{
        //    return Application.Current.MainPage.Navigation.PopAsync();
        //}

        //public async Task GuestLoginAsync<TViewModelBase>(object loginViewModel = null, bool setRoot = false)
        //{
        //    var page = ViewModelLocator.CreatePageFor(typeof(TViewModelBase));
        //    if (setRoot) App.Current.MainPage = new NavigationPage(page);
        //    else
        //    {
        //        if(App.Current.MainPage is NavigationPage navPage)
        //        {
        //            await navPage.PushAsync(page);
        //        }
        //        else
        //        {
        //            App.Current.MainPage = new NavigationPage(page);
        //        }
        //    }
        //    if(page.BindingContext is ViewModelBase vmBase)
        //    {
        //        await vmBase.InitializeAsync(loginViewModel);
        //    }
        //}
    }
}
