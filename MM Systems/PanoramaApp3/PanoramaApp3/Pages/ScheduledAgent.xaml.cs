using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Scheduler;
using Microsoft.Phone.Shell;

namespace PanoramaApp3.Pages
{
    public partial class ScheduledAgent : PhoneApplicationPage
    {
        public ScheduledAgent()
        {
            InitializeComponent();
            ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
            client.GetLatestInputAsync(User.ID);
            client.GetLatestInputCompleted += client_GetLatestInputCompleted;
        }

        private void client_GetLatestInputCompleted(object sender, ServiceReference.GetLatestInputCompletedEventArgs e)
        {
                MessageBox.Show(e.Result.ToShortDateString());
        }

        private void StartPeriodicTask()
        {
            PeriodicTask periodicTask = new PeriodicTask("ms");
            periodicTask.Description = "Are presenting a periodic task";
            try
            {
                ScheduledActionService.Add(periodicTask);
                ScheduledActionService.LaunchForTest("ms", TimeSpan.FromSeconds(3));
                MessageBox.Show("Open the background agent success");
            }
            catch (InvalidOperationException exception)
            {
                if (exception.Message.Contains("exists already"))
                {
                    MessageBox.Show("Since then the background agent success is already running");
                }
                if (exception.Message.Contains("BNS Error: The action is disabled"))
                {
                    MessageBox.Show("Background processes for this application has been prohibited");
                }
                if (exception.Message.Contains("BNS Error: The maximum number of ScheduledActions of this type has already been added."))
                {
                    MessageBox.Show("You open the daemon has exceeded the hardware limitations");
                }
                else
                {
                    MessageBox.Show(exception.ToString());
                }
            }
            catch (SchedulerServiceException)
            {

            }
        }
        private void StopPeriodicTask()
        {
            try
            {
                ScheduledActionService.Remove("ms");
                MessageBox.Show("Turn off the background agent successfully");
            }
            catch (InvalidOperationException exception)
            {
                if (exception.Message.Contains("doesn't exist"))
                {
                    MessageBox.Show("Since then the background agent success is not running");
                }
            }
            catch (SchedulerServiceException)
            {

            }
        }
        private void StartPeriodicTask_Click(object sender, RoutedEventArgs e)
        {
            StartPeriodicTask();
            SetData();
        }
        private void StopPeriodicTask_Click(object sender, RoutedEventArgs e)
        {
            StopPeriodicTask();
        }
        public void SetData()
        {
            Mutex mutex = new Mutex(false, "ScheduledAgentData");
            mutex.WaitOne();
            IsolatedStorageSettings setting = IsolatedStorageSettings.ApplicationSettings;
            if (!setting.Contains("ScheduledAgentData"))
            {
                setting.Add("ScheduledAgentData", "Foreground data");
            }
            mutex.ReleaseMutex();
        }
    }
}