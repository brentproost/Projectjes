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
    public partial class Login : Page
    {
        ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
        public Login()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string userName = txtUsername.Text;
            string passWord = txtPassword.Password;
            client.SigninUserAsync(userName, MD5Core.GetHashString(passWord));
            client.SigninUserCompleted += client_SigninUserCompleted;
        }

        void client_SigninUserCompleted(object sender, ServiceReference.SigninUserCompletedEventArgs e)
        {
            if (e.Result != 0)
            {
                User.ID = e.Result;
                if (User.ID != 0)
                {
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

        void client_GetUserInfoCompleted(object sender, ServiceReference.GetUserInfoCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                grid_Login.Visibility = Visibility.Collapsed;
                if (e.Result[0].Rechten_ID == 1)
                {
                    MessageBox.Show("Je bent nu ingelogd");
                    txtPassword.Password = "";
                    txtUsername.Text = "";
                    User.ID = e.Result[0].ID;

                    if (User.Settings.Contains("ID") == false)
                    {
                        User.Settings.Add("ID", User.ID);
                    }
                    else
                    {
                        User.Settings["ID"] = User.ID;
                    }
                    Frame frame = this.Parent as Frame;
                    frame.Navigate(new Uri("/Home", UriKind.Relative));

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

        private void txtPassword_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                Login_Click(this, e);
            }
        }

    }
}
