using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Scheduler;
using Microsoft.Phone.Shell;

namespace PanoramaApp3.Pages
{
    public partial class reminderAlarm : PhoneApplicationPage
    {
        public reminderAlarm()
        {
            InitializeComponent();
        }
        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            string reminderName = Guid.NewGuid().ToString();
            // use guid for reminder name, since reminder names must be unique
            Reminder reminder = new Reminder(reminderName);
            // NOTE: setting the Title property is supported for reminders 
            // in contrast to alarms where setting the Title property is not supported
            reminder.Title = this.txtTitle.Text;
            reminder.Content = this.txtContent.Text;
            double seconds = 10.0;
            double.TryParse(this.txtSeconds.Text, out seconds);

            //NOTE: the value of BeginTime must be after the current time
            //set the BeginTime time property in order to specify when the reminder should be shown
            reminder.BeginTime = DateTime.Now.AddSeconds(seconds);

            // NOTE: ExpirationTime must be after BeginTime
            // the value of the ExpirationTime property specifies when the schedule of the reminder expires
            // very useful for recurring reminders, ex:
            // show reminder every day at 5PM but stop after 10 days from now
            reminder.ExpirationTime = reminder.BeginTime.AddSeconds(5.0);
            reminder.RecurrenceType = RecurrenceInterval.Daily;

            // NOTE: another difference from alerts
            // you can set a navigation uri that is passed to the application when it is launched from the reminder
            //reminder.NavigationUri = navigationUri;
            ScheduledActionService.Add(reminder);

            this.NavigationService.GoBack();
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}