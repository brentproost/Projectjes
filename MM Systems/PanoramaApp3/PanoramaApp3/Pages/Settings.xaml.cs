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

namespace PanoramaApp3
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
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
                    ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
                    client.SigninUserCompleted += client_SigninUserCompleted;
                    client.SigninUserAsync(luc.Username, luc.Password);

                    //MessageBox.Show(string.Format("Username: {0}, Password: {1}", luc.Username, luc.Password));
                }
            };

            messagePrompt.Show(); 

        }
        void client_SigninUserCompleted(object sender, ServiceReference.SigninUserCompletedEventArgs e)
        {
            if (e.Result)
            {
                MessageBox.Show("Je bent nu ingelogd");//"Welkom " + r[0].Naam + " " + r[0].Voornaam + "!"; moet zoiets komen bekijk Service.svc.cs
            }
            if (e.Result == false)
            {
                MessageBox.Show("Je referenties zijn niet gevonden");
            }
        }
    }
}