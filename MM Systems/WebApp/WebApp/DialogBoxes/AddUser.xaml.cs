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

namespace WebApp.DialogBoxes
{
    public partial class AddUser : ChildWindow
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;

            ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();

            client.AddUserAsync(btnNaam.Text, btnVoornaam.Text, btnAdres.Text, Convert.ToInt16(btnNummer.Text), btnPlaats.Text, Convert.ToInt16(btnPostcode.Text), btngebruikersnaam.Text, btnpasw.Text);
            client.AddUserCompleted += client_AddUserCompleted;

        }

        void client_AddUserCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Gebruiker is toegevoegd");
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}

