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
            UpdateDataGrid();
        }

        void UpdateDataGrid()
        {
            dg_Gebruikers.ItemsSource = null;
            ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
            client.GetAllUsersAsync();
            client.GetAllUsersCompleted += client_GetAllUsersCompleted;
        }


        void client_GetAllUsersCompleted(object sender, ServiceReference.GetAllUsersCompletedEventArgs e)
        {
            dg_Gebruikers.ItemsSource = e.Result.ToList();
        }

        void client_AddUserCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            btnsubmit.Content = "gebruiker toegevoegd";
            UpdateDataGrid();
        }

        private void btnsubmit_Click_1(object sender, RoutedEventArgs e)
        {

            btnsubmit.Content = "een momentje aub, gebruiker wordt toegevoegd...";
            ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();

            client.AddUserAsync(txtNaam.Text, txtVoornaam.Text, txtAdres.Text, Convert.ToInt16(txtNummer.Text), txtPlaats.Text, Convert.ToInt16(txtPostcode.Text), txtgebruikersnaam.Text, MD5Core.GetHashString(txtpasw.Text));
            client.AddUserCompleted += client_AddUserCompleted;
            txtNaam.Text = "";
            txtVoornaam.Text = "";
            txtAdres.Text = "";
            txtNummer.Text = "";
            txtPlaats.Text = "";
            txtPostcode.Text = "";
            txtgebruikersnaam.Text = "";
            txtpasw.Text = "";
        }

        private void txt_TextInputStart(object sender, TextCompositionEventArgs e)
        {
            btnsubmit.Content = "Submit";
        }
    }
}
