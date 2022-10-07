using System;
using iClock.Base;

using System.Collections.Generic;
using System.Text;
using iClock.Interfaces;
using iClock.Factory;

namespace iClock.ViewModels
{
    public class TimeEmployeeViewModel : ViewModelBase
    {
        public TimeEmployeeViewModel(ITimeEmployee timeEmployee)
        {
            var loginModelObject = ObjectFactory.CreateTimeEmployee(Model.TimeEmployee);
            _timeEmployee = timeEmployee;
        }
        public TimeEmployeeViewModel()
        {

        }

        //PRIVATE MEMBERS
        ITimeEmployee _timeEmployee;
    }
}
