using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;
using System.ComponentModel;

namespace WebApp.Views
{
    public partial class Gebruikers : Page
    {
        public Gebruikers()
        {
            InitializeComponent();
            ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
            client.GetAllUsersAsync();
            client.GetAllUsersCompleted += client_GetAllUsersCompleted;
        }

        void client_GetAllUsersCompleted(object sender, ServiceReference.GetAllUsersCompletedEventArgs e)
        {
            dg_Gebruikers.ItemsSource = e.Result.ToList();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }


        void client_AddUserCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            btnsubmit.Content = "gebruiker toegevoegd";
        }

        private void btnsubmit_Click_1(object sender, RoutedEventArgs e)
        {
            btnsubmit.Content = "een momentje aub, gebruiker wordt toegevoegd...";
            ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
            
            client.AddUserAsync(btnNaam.Text, btnVoornaam.Text, btnAdres.Text, Convert.ToInt16(btnNummer.Text), btnPlaats.Text, Convert.ToInt16(btnPostcode.Text), btngebruikersnaam.Text, MD5Core.GetHashString(btnpasw.Text));
            client.AddUserCompleted += client_AddUserCompleted;
        }
    }
}
