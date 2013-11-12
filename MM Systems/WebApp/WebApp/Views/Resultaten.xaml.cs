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

namespace WebApp.Views
{
    public partial class Resultaten : Page
    {
        ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
        public Resultaten()
        {
            InitializeComponent();
            txtid.Text = Public_Informatie_Gebruiker.id.ToString();
            UpdateUserInfo();
        }

        void client_GetUserCompleted(object sender, ServiceReference.GetUserCompletedEventArgs e)
        {
            Public_Informatie_Gebruiker.Voornaam = e.Result[0].Voornaam.Replace(" ", string.Empty);
            Public_Informatie_Gebruiker.Naam = e.Result[0].Naam.Replace(" ", string.Empty);
            
            if (Public_Informatie_Gebruiker.Voornaam != null && Public_Informatie_Gebruiker.Naam != null)
            {
                txt_Naam_Voornaam.Text = "Informatie over: " + Public_Informatie_Gebruiker.Voornaam.ToString() + " " + Public_Informatie_Gebruiker.Naam.ToString();
            }
        }

        void client_GetIngave_GebruikerCompleted(object sender, ServiceReference.GetIngave_GebruikerCompletedEventArgs e)
        {
            dg_Ingaven.ItemsSource = null;
            dg_Ingaven.ItemsSource = e.Result;
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        void UpdateUserInfo()
        {
            client.GetIngave_GebruikerAsync(Convert.ToInt16(txtid.Text));
            client.GetIngave_GebruikerCompleted += client_GetIngave_GebruikerCompleted;
            client.GetUserAsync(Convert.ToInt16(txtid.Text));
            client.GetUserCompleted += client_GetUserCompleted;
        }

        private void btn_ChangeUser_Click(object sender, RoutedEventArgs e)
        {
            UpdateUserInfo();
        }

    }
}
