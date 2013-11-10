using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WebApp.ServiceReference;


namespace WebApp.UC
{
    public partial class Login: UserControl
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            ServiceClient client = new ServiceClient();
            string userName = txtUsername.Text;
            string passWord = txtPassword.Password;
            client.SigninUserCompleted += client_SigninUserCompleted;
            client.SigninUserAsync(userName, MD5Core.GetHashString(passWord));
        }

        void client_SigninUserCompleted(object sender, ServiceReference.SigninUserCompletedEventArgs e)
        {
            if (e.Result != 0)
            {
                User.ID = e.Result;
                if (User.ID != 0)
                {
                    ServiceClient client = new ServiceClient();
                    client.GetUserInfoCompleted += client_GetUserInfoCompleted;
                    client.GetUserInfoAsync(User.ID);
                }
            }
            else
            {
                MessageBox.Show("Je referenties zijn niet gevonden");
                User.ID = 0;
            }
        }

        void client_GetUserInfoCompleted(object sender, GetUserInfoCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                if (e.Result[0].Rechten_ID == 1)
                {
                    MessageBox.Show("Je bent nu ingelogd");
                    Visibility = Visibility.Collapsed;
                }
                else
                {
                    MessageBox.Show("niet genoeg rechten");
                }
            }
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Collapsed;
        }
    }
}
