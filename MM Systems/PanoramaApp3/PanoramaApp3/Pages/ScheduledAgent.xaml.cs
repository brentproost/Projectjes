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
            Loaded += ScheduledAgent_Loaded;
        }

        void ScheduledAgent_Loaded(object sender, RoutedEventArgs e)
        {
            if (ScheduledActionService.Find("ms")!= null)
            {
                StopTask.Visibility = Visibility.Visible;
                StartTask.Visibility = Visibility.Collapsed;
            }
            else
            {
                StopTask.Visibility = Visibility.Collapsed;
                StartTask.Visibility = Visibility.Visible;
            }
        }


        private void StartPeriodicTask()
        {
            PeriodicTask periodicTask = new PeriodicTask("ms");
            periodicTask.Description = "Are presenting a periodic task";
            try
            {
                ScheduledActionService.Add(periodicTask);
                ScheduledActionService.LaunchForTest("ms", TimeSpan.FromSeconds(3));
                MessageBox.Show("Herinnnering staan nu aan");
                StopTask.Visibility = Visibility.Visible;
                StartTask.Visibility = Visibility.Collapsed;
                
            }
            catch (InvalidOperationException exception)
            {
                if (exception.Message.Contains("exists already"))
                {
                    MessageBox.Show("De herinneringen staan al aan");
                }
                if (exception.Message.Contains("BNS Error: The action is disabled"))
                {
                    MessageBox.Show("Herinneringen voor deze applicatie zijn niet ingeschakeld");
                }
                if (exception.Message.Contains("BNS Error: The maximum number of ScheduledActions of this type has already been added."))
                {
                    MessageBox.Show("Er zijn al te veel herinneringen ingeschakeld");
                }
                else
                {
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
                MessageBox.Show("Herinneringen staan nu uit");
                StopTask.Visibility = Visibility.Collapsed;
                StartTask.Visibility = Visibility.Visible;
                
            }
            catch (InvalidOperationException exception)
            {
                if (exception.Message.Contains("doesn't exist"))
                {
                    MessageBox.Show("Herinneringen staan niet aan");
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