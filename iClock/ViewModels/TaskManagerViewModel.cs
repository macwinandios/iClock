using System;
using iClock.Base;

using System.Collections.Generic;
using System.Text;
using iClock.Factory;
using iClock.Interfaces;

namespace iClock.ViewModels
{
    public class TaskManagerViewModel : ViewModelBase
    {
        public TaskManagerViewModel(ITaskManager taskManager)
        {
            var loginModelObject = ObjectFactory.CreateTaskManager(Model.TaskManager);
            _taskManager = taskManager;
        }
        public TaskManagerViewModel()
        {

        }

        //PRIVATE MEMBERS
        ITaskManager _taskManager;
    }
}
