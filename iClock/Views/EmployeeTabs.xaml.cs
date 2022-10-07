using iClock.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iClock.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeTabs : TabbedPage
    {
        public EmployeeTabs()
        {
            InitializeComponent();

            var timeEmployeeView = ViewModelLocator.Resolve<TimeEmployeeView>();
            timeEmployeeView.Title = "MY CLOCK";

            var payEmployeeView = ViewModelLocator.Resolve<PayEmployeeView>();
            payEmployeeView.Title = "MY PAY";

            var taskEmployeeView = ViewModelLocator.Resolve<TaskEmployeeView>();
            taskEmployeeView.Title = "MY TASKS";


            // ADD PAGES TO TABBED PAGE
            this.Children.Add(timeEmployeeView);
            this.Children.Add(payEmployeeView);
            this.Children.Add(taskEmployeeView);
        }
    }
}