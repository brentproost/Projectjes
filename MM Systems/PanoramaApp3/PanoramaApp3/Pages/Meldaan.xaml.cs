using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Coding4Fun.Toolkit.Controls;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PanoramaApp3.Pages;
using PanoramaApp3.ServiceReference;
using Microsoft.Phone.Net.NetworkInformation;
using Microsoft.Phone.Tasks;

namespace PanoramaApp3
{
    public partial class Page1 : PhoneApplicationPage
    {
       public Page1()
        {   
            InitializeComponent();
            this.BackKeyPress += Page1_BackKeyPress;
            if (!User.CheckNetworkConnection())
            {
                MessageBox.Show("Er is geen netwerkverbinding gevonden");
                ConnectionSettingsTask connectionSettingsTask = new ConnectionSettingsTask();
                connectionSettingsTask.ConnectionSettingsType = ConnectionSettingsType.WiFi;
                connectionSettingsTask.Show();
            }
        }

       void Page1_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
       {
           if (User.ID == 0)
           {
               if (NavigationService.CanGoBack)
               {
                   while (NavigationService.RemoveBackEntry() != null)
                   {
                       NavigationService.RemoveBackEntry();
                   }
               }
           }
       }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var luc = new WindowsPhoneControl1(); // Customer user control with Login UI

            MessagePrompt messagePrompt = new MessagePrompt(); // Coding4Fun extensible MessagePrompt
            messagePrompt.IsCancelVisible = true; // Show cancel button
            messagePrompt.Body = luc; // Add user control as body of MessagePrompt
            messagePrompt.Completed += (str, res) => // Handler for MessagePrompt user action
            {
                if (res.PopUpResult == PopUpResult.Cancelled)
                {
                    luc.Username = luc.Password = "";
                    MessageBox.Show("Login Cancelled");
                }
                else
                {
                    if (luc.Username != null)
                    {
                        ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
                        client.SigninUserCompleted += client_SigninUserCompleted;
                        client.SigninUserAsync(luc.Username, MD5Core.GetHashString(luc.Password));
                    }
                    else
                    {
                        MessageBox.Show("Geen username ingegeven");
                    }
                    //MessageBox.Show(string.Format("Username: {0}, Password: {1}", luc.Username, luc.Password));
                }
            };

            messagePrompt.Show(); 

        }
        void client_SigninUserCompleted(object sender, ServiceReference.SigninUserCompletedEventArgs e)
        {
            if (e.Result != 0)
            {
                MessageBox.Show("Je bent nu ingelogd");//"Welkom " + r[0].Naam + " " + r[0].Voornaam + "!"; moet zoiets komen bekijk Service.svc.cs
                User.ID = e.Result;
                if (User.Settings.Contains("ID") == false)
                {
                    User.Settings.Add("ID", User.ID);
                }
                else
                {
                    User.Settings["ID"] = User.ID;
                }
                Uri nUri = new Uri("/MainPage.xaml", UriKind.Relative);
                ((App)Application.Current).RootFrame.Navigate(nUri);
            }
            else
            {
                MessageBox.Show("Je referenties zijn niet gevonden");
                User.ID = 0;
            }
        }

        private void Logoff_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Je bent nu uitgelogd");
            User.ID = 0;
            User.Settings["ID"] = User.ID;
        }

        private void scheduler_Click(object sender, RoutedEventArgs e)
        {
            Uri nUri = new Uri("/Pages/ScheduledAgent.xaml", UriKind.Relative);
            ((App)Application.Current).RootFrame.Navigate(nUri);
        }

    }
}