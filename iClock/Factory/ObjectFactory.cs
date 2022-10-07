using iClock.Interfaces;
using iClock.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace iClock.Factory
{
    public enum Model
    {
        LoginModel,
        PayEmployee,
        PayManager,
        TaskEmployee,
        TaskManager,
        TimeEmployee,
        TimeManager
    }
    public class ObjectFactory
    {
        public static ILoginModel CreateLoginModel(Model model)
        {
            return new LoginModel();
        }
        public static IPayEmployee CreatePayEmployee(Model model)
        {
            return new PayEmployee();
        }
        public static IPayManager CreatePayManager(Model model)
        {
            return new PayManager();
        }
        public static ITaskEmployee CreateTaskEmployee(Model model)
        {
            return new TaskEmployee();
        }
        public static ITaskManager CreateTaskManager(Model model)
        {
            return new TaskManager();
        }
        public static ITimeEmployee CreateTimeEmployee(Model model)
        {
            return new TimeEmployee();
        }
        public static ITimeManager CreateTimeManager(Model model)
        {
            return new TimeManager();
        }



    }
}
