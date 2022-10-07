using System;
using iClock.Base;
using System.Collections.Generic;
using System.Text;
using iClock.Interfaces;
using iClock.Factory;

namespace iClock.ViewModels
{
    public class PayManagerViewModel : ViewModelBase
    {
        public PayManagerViewModel(IPayManager payManager)
        {
            var loginModelObject = ObjectFactory.CreatePayManager(Model.PayManager);
            _payManager = payManager;
        }
        public PayManagerViewModel()
        {

        }

        //PRIVATE MEMBERS
        IPayManager _payManager;
    }
}
