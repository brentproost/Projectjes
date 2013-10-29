using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PanoramaApp3.Pages
{
    public partial class WindowsPhoneControl1 : UserControl, INotifyPropertyChanged
    {
        public WindowsPhoneControl1()
        {
            InitializeComponent();
            DataContext = this;
        }

        public string _Username;
        public string Username
        {
            get
            {
                return _Username;
            }
            set
            {
                _Username = value;
                NotifyPropertyChanged("Username");
            }
        }

        public string _Password;
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
                NotifyPropertyChanged("Password");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        /*private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
            client.SigninUserCompleted += client_SigninUserCompleted;
            client.SigninUserAsync(txtUsername.Text, txtPassword.Password);
        }*/

        /*void client_SigninUserCompleted(object sender, ServiceReference.SigninUserCompletedEventArgs e)
        {
            MessageBox.Show("gelukt");
            if (e.Result != null)
            {
                ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
                client.SigninUserCompleted += client_SigninUserCompleted;
                client.SigninUserAsync(txtUsername.Text, txtPassword.Password);
                MessageBox.Show(e.Result);
            }
        }*/
    }
}
