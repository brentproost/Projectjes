using System;
using System.IO.IsolatedStorage;
using System.Threading;
using System.Windows;
using CheckUserInput.ServiceReference;
using Microsoft.Phone.Scheduler;
using Microsoft.Phone.Shell;

namespace CheckUserInput
{
    public class ScheduledAgent : ScheduledTaskAgent
    {
        public int time { get; set; }
        public int ID { get; set; }
        public static IsolatedStorageSettings Settings =
            System.IO.IsolatedStorage.IsolatedStorageSettings.ApplicationSettings;
        private static volatile bool _classInitialized;
        private ScheduledTask taskt;
        /// <remarks>
        /// ScheduledAgent constructor, initializes the UnhandledException handler
        /// </remarks>
        public ScheduledAgent()
        {
            if (!_classInitialized)
            {
                _classInitialized = true;
                // Subscribe to the managed exception handler
                Deployment.Current.Dispatcher.BeginInvoke(delegate
                {
                    Application.Current.UnhandledException += ScheduledAgent_UnhandledException;
                });
            }
            if (Settings.Contains("ID") == true)
            {
                ID = (int)Settings["ID"];
            }
            time = 17;
        }

        /// Code to execute on Unhandled Exceptions
        private void ScheduledAgent_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // An unhandled exception has occurred; break into the debugger
                System.Diagnostics.Debugger.Break();
            }
        }

        /// <summary>
        /// Agent that runs a scheduled task
        /// </summary>
        /// <param name="task">
        /// The invoked task
        /// </param>
        /// <remarks>
        /// This method is called when a periodic or resource intensive task is invoked
        /// </remarks>
        protected override void OnInvoke(ScheduledTask task)
        {
            //TODO: Add code to perform your task in background
            taskt = task;
            ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
            client.GetLatestInputAsync(ID);
            client.GetLatestInputCompleted += client_GetLatestInputCompleted;
            
        }

        void client_GetLatestInputCompleted(object sender, GetLatestInputCompletedEventArgs e)
        {
            if (taskt.Name.Equals("ms", StringComparison.OrdinalIgnoreCase))
            {
                if (e.Result.Date == DateTime.Now.Date)
                {
                }
                else
                {
                    if (DateTime.Now.Hour >= time && DateTime.Now.Hour <= (time-1) )
                    {
                        ShellToast toast = new ShellToast();
                        Mutex mutex = new Mutex(true, "ScheduledAgentData");
                        mutex.WaitOne();
                        IsolatedStorageSettings setting = IsolatedStorageSettings.ApplicationSettings;
                        toast.Title = "ms patient";
                        mutex.ReleaseMutex();
                        toast.Content = "U heeft nog geen data ingevoerd vandaag";
                        toast.Show();
                    }
                }
            }
            NotifyComplete();
        }
    }
}