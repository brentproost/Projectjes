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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WebApp.DialogBoxes
{
    public partial class AddUser : ChildWindow
    {
        BitmapImage juist;
        BitmapImage fout;
        public AddUser()
        {
            InitializeComponent();
            juist = new BitmapImage(new Uri("../icon-check.png", UriKind.Relative));
            fout = new BitmapImage(new Uri("../icon-checkfalse.png", UriKind.Relative));
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            bool juiste_input = false;
            foreach (var child in sp_images.Children)
            {
                if (child.GetType().ToString() == "System.Windows.Controls.Image")
                {
                    juiste_input = true;
                    if (((Image)child).Source == fout)
                    {
                        MessageBox.Show(((Image)child).Name);
                        juiste_input = false;
                    }
                }
            }
            if (juiste_input)
            {
                this.DialogResult = true;

                ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();

                client.AddUserAsync(txtNaam.Text, txtVoornaam.Text, txtAdres.Text, Convert.ToInt16(txtNummer.Text), txtPlaats.Text, Convert.ToInt16(txtPostcode.Text), txtgebruikersnaam.Text, MD5Core.GetHashString(pwpasw.Password));
                client.AddUserCompleted += client_AddUserCompleted;
                client.CloseAsync();
            }
        }

        void client_AddUserCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Gebruiker is toegevoegd");
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        bool CheckifNumber(object o)
        {
            try
            {
                Convert.ToInt16(((TextBox)o).Text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }    
        }

        bool CheckifTextInputOk(object o)
        {
            if (((TextBox)o).Text != "")
                return true;
            else
                return false;
        }

        bool CheckifPassword(object o)
        {
            if (((PasswordBox)o).Password != "" && ((PasswordBox)o).Password.Length >= 6 && ((PasswordBox)o).Password.Length <= 18)
                return true;
            else
                return false;
        }

        private void txtNaam_LostFocus_1(object sender, RoutedEventArgs e)
        {
            if (CheckifTextInputOk(sender))
                img_check_1.Source = juist;
            else
                img_check_1.Source = fout;
        }

        private void txtVoornaam_LostFocus(object sender, RoutedEventArgs e)
        {
            if (CheckifTextInputOk(sender))
                img_check_2.Source = juist;
            else
                img_check_2.Source = fout;
        }

        private void txtAdres_LostFocus(object sender, RoutedEventArgs e)
        {
            if (CheckifTextInputOk(sender))
                img_check_3.Source = juist;
            else
                img_check_3.Source = fout;
        }

        private void txtPlaats_LostFocus(object sender, RoutedEventArgs e)
        {
            if (CheckifTextInputOk(sender))
                img_check_5.Source = juist;
            else
                img_check_5.Source = fout;
        }

        private void txtgebruikersnaam_LostFocus(object sender, RoutedEventArgs e)
        {
            if (CheckifTextInputOk(sender))
                img_check_7.Source = juist;
            else
                img_check_7.Source = fout;
        }

        private void txtPostcode_LostFocus(object sender, RoutedEventArgs e)
        {
            if (CheckifNumber(sender))
                img_check_6.Source = juist;
            else
                img_check_6.Source = fout;
        }

        private void txtNummer_LostFocus(object sender, RoutedEventArgs e)
        {
            if (CheckifNumber(sender))
                img_check_4.Source = juist;
            else
                img_check_4.Source = fout;
        }

        private void pwpasw_LostFocus(object sender, RoutedEventArgs e)
        {
            if (CheckifPassword(sender))
                img_check_8.Source = juist;
            else
                img_check_8.Source = fout;
        }
    }
}

