using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using PanoramaApp3.Classes;
using PanoramaApp3.ServiceReference;

namespace PanoramaApp3.Pages
{
    public partial class CommentPage : PhoneApplicationPage
    {
        ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
        private ProgressIndicator _progressIndicator;
        public CommentPage()
        {
            InitializeComponent();
            if (!User.CheckNetworkConnection())
            {
                MessageBox.Show("Er is geen netwerkverbinding gevonden");
                ConnectionSettingsTask connectionSettingsTask = new ConnectionSettingsTask();
                connectionSettingsTask.ConnectionSettingsType = ConnectionSettingsType.WiFi;
                connectionSettingsTask.Show();
            }
        }

        private void btnok_Click(object sender, RoutedEventArgs e)
        {
            client.AddGebruikersIngaveCompleted += client_AddGebruikersIngaveCompleted;
            client.AddGebruikersIngaveAsync(User.ID, InputDatabase.ActivityID,DateTime.Now,InputDatabase.Date, InputDatabase.FromHour, InputDatabase.ToHour, txt_Commentaar.Text, InputDatabase.WeersomstandighedenIDs, InputDatabase.NachtrustIDs, InputDatabase.UrenSlaap, InputDatabase.Vermoeidheid, InputDatabase.Belangrijk, InputDatabase.Tevredenheid);
            _progressIndicator = new ProgressIndicator
            {
                IsIndeterminate = true,
                Text = "Loading...",
                IsVisible = true,
            };
            SystemTray.SetIsVisible(this, true);
            SystemTray.SetProgressIndicator(this, _progressIndicator);
            SystemTray.SetOpacity(this, 1);
        }
        void client_AddGebruikersIngaveCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Toegevoegd");
            _progressIndicator.IsVisible = false;
            SystemTray.SetIsVisible(this, false);
            NavigationService.Navigate(new Uri("/mainPage.xaml", UriKind.Relative));

        }
    }
}