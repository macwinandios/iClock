using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace iClock.DateAndTime
{
    public class DateAndTime : INotifyPropertyChanged
    {
        DateTime _dateTime;
        public DateAndTime()
        {
            Device.StartTimer(TimeSpan.FromSeconds (1) , () =>
            {
                this.DateTime = DateTime.Now;
                return true;
            });


        }

        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime DateTime
        {
            get => _dateTime;
            set
            {
                _dateTime = value;
                PropertyChanged(this, new PropertyChangedEventArgs("DateTime"));
            }
        }
    }
}

