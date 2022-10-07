using System;
using System.Collections.Generic;
using System.Text;
using iClock.Base;
using iClock.Factory;
using iClock.Interfaces;

namespace iClock.ViewModels
{
    public class TaskEmployeeViewModel : ViewModelBase
    {
        public TaskEmployeeViewModel(ITaskEmployee taskEmployee)
        {
            var loginModelObject = ObjectFactory.CreateTaskEmployee(Model.TaskEmployee);
            _taskEmployee = taskEmployee;
        }
        public TaskEmployeeViewModel()
        {

        }

        //PRIVATE MEMBERS
        ITaskEmployee _taskEmployee;
    }
}
