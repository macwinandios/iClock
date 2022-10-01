using iClock.Base;
using iClock.Services;
using iClock.ViewModels;
using iClock.Views;
using System;
using System.Collections.Generic;
using System.Text;
using TinyIoC;
using Xamarin.Forms;

namespace iClock.Locator
{
    public class ViewModelLocator
    {
        static TinyIoCContainer _container;
        static Dictionary<Type, Type> _dictionary;

        static ViewModelLocator()
        {
            _container = new TinyIoCContainer();
            _dictionary = new Dictionary<Type, Type>();

            //REGISTER VIEWMODELS TO THEIR VIEWS
            Register<LoginViewModel, LoginView>();

            Register<PayEmployeeViewModel, PayEmployeeView>();
            Register<PayManagerViewModel, PayManagerView>();

            Register<TaskEmployeeViewModel, TaskEmployeeView>();
            Register<TaskManagerViewModel, TaskManagerView>();

            Register<TimeEmployeeViewModel, TimeEmployeeView>();
            Register<TimeManagerViewModel, TimeManagerView>();


            //REGISTER SERVICES (SERVICES ARE REGISTERED AS SINGLETONS BY DEFAULT)
            //_container.Register<IGuestLoginService, GuestLoginService>();
        }

        public static T Resolve<T>() where T : class
        {
            return _container.Resolve<T>();
        }

        public static Page CreatePageFor(Type viewModelType)
        {
            var viewType = _dictionary[viewModelType];
            var view = (Page)Activator.CreateInstance(viewType);
            var viewModel = _container.Resolve(viewModelType);
            view.BindingContext = viewModel;
            return view;
        }


        static void Register<TViewModel, TView>() where TViewModel : ViewModelBase where TView : Page
        {
            _dictionary.Add(typeof(TViewModel), typeof(TView));
            _container.Register<TViewModel>();
        }
    }
}
