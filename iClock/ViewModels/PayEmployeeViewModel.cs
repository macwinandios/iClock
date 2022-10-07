using iClock.Base;
using iClock.Interfaces;
using iClock.Factory;

namespace iClock.ViewModels
{
    public class PayEmployeeViewModel : ViewModelBase
    {
        public PayEmployeeViewModel(IPayEmployee payEmployee)
        {
            var loginModelObject = ObjectFactory.CreatePayEmployee(Model.PayEmployee);
            _payEmployee = payEmployee;
        }
        public PayEmployeeViewModel()
        {

        }

        //PRIVATE MEMBERS
        IPayEmployee _payEmployee;
    }
}
