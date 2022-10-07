using System;
using iClock.Base;

using System.Collections.Generic;
using System.Text;
using iClock.Interfaces;
using iClock.Factory;

namespace iClock.ViewModels
{
    public class TimeManagerViewModel : ViewModelBase
    {
        public TimeManagerViewModel(ITimeManager timeManager)
        {
            var loginModelObject = ObjectFactory.CreateTimeManager(Model.TimeManager);
            _timeManager = timeManager;
        }
        public TimeManagerViewModel()
        {

        }

        //PRIVATE MEMBERS
        ITimeManager _timeManager;
    }
}
