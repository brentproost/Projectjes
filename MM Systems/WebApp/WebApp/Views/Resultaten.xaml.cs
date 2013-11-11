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
            client.GetIngave_GebruikerAsync(Convert.ToInt16(txtid.Text));
            client.GetIngave_GebruikerCompleted += client_GetIngave_GebruikerCompleted;
        }

        void client_GetIngave_GebruikerCompleted(object sender, ServiceReference.GetIngave_GebruikerCompletedEventArgs e)
        {
            dg_Ingaven.ItemsSource = e.Result;
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

    }
}
