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
    public partial class ManagerTabs : TabbedPage
    {
        public ManagerTabs()
        {
            InitializeComponent();

            var payManagerView = ViewModelLocator.Resolve<PayManagerView>();
            payManagerView.Title = "PAY";

            var taskManagerView = ViewModelLocator.Resolve<TaskManagerView>();
            taskManagerView.Title = "TASKS";

            var timeManagerView = ViewModelLocator.Resolve<TimeManagerView>();
            timeManagerView.Title = "CLOCK";

            // ADD PAGES TO TABBED PAGE
            this.Children.Add(payManagerView);
            this.Children.Add(taskManagerView);
            this.Children.Add(timeManagerView);
        }
    }
}