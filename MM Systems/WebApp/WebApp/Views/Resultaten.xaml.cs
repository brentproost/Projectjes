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
using System.IO;

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

        void client_GetIngave_GebruikerCompleted(object sender, ServiceReference.GetIngave_GebruikerCompletedEventArgs e)
        {
            dg_Ingaven.ItemsSource = null;
            var output = from o in e.Result where o.User_ID == Convert.ToInt16(txtid.Text) select o;
            dg_Ingaven.ItemsSource = output.ToList();
        }

        void UpdateUserInfo()
        {
            client.GetIngave_GebruikerAsync();
            client.GetIngave_GebruikerCompleted += client_GetIngave_GebruikerCompleted;
            client.GetUserInfoAsync(Convert.ToInt16(txtid.Text));
            client.GetUserInfoCompleted += client_GetUserInfoCompleted;
        }

        void client_GetUserInfoCompleted(object sender, ServiceReference.GetUserInfoCompletedEventArgs e)
        {
            var resultaat = (from i in e.Result where i.ID == Convert.ToInt16(txtid.Text) select i).ToList();

            Public_Informatie_Gebruiker.Voornaam = resultaat[0].Voornaam.Replace(" ", string.Empty);
            Public_Informatie_Gebruiker.Naam = resultaat[0].Naam.Replace(" ", string.Empty);

            if (Public_Informatie_Gebruiker.Voornaam != null && Public_Informatie_Gebruiker.Naam != null)
            {
                txt_Naam_Voornaam.Text = "Informatie over: " + Public_Informatie_Gebruiker.Voornaam.ToString() + " " + Public_Informatie_Gebruiker.Naam.ToString();
            }
        }

        private void btn_ChangeUser_Click(object sender, RoutedEventArgs e)
        {
            UpdateUserInfo();
        }

        private void btn_export_Click(object sender, RoutedEventArgs e)
        {
            Export export = new Export(dg_Ingaven);
        }
    }
}


