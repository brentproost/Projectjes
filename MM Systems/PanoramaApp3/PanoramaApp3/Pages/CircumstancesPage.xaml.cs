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
    public partial class CircumstancesPage : PhoneApplicationPage
    {
        ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
        List<int> weersomstandighedenids = new List<int>();
        List<int> nachtrustids = new List<int>();
        private ProgressIndicator _progressIndicator;
        public CircumstancesPage()
        {
            InitializeComponent();

            if (!User.CheckNetworkConnection())
            {
                MessageBox.Show("Er is geen netwerkverbinding gevonden");
                ConnectionSettingsTask connectionSettingsTask = new ConnectionSettingsTask();
                connectionSettingsTask.ConnectionSettingsType = ConnectionSettingsType.WiFi;
                connectionSettingsTask.Show();
            }
            else
            {
                _progressIndicator = new ProgressIndicator
                    {
                        IsIndeterminate = true,
                        Text = "Loading...",
                        IsVisible = true,
                    };
                ButtonOk.IsEnabled = false;
                SystemTray.SetIsVisible(this, true);
                SystemTray.SetProgressIndicator(this, _progressIndicator);
                SystemTray.SetOpacity(this, 1);
                try
                {
                    client.GetNachtrustSchaalCompleted += client_GetNachtrustSchaalCompleted;
                    client.GetNachtrustSchaalAsync();
                    client.GetAllWeersOmstandighedenCompleted += client_GetAllWeersOmstandighedenCompleted;
                    client.GetAllWeersOmstandighedenAsync();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        void client_GetNachtrustSchaalCompleted(object sender, GetNachtrustSchaalCompletedEventArgs e)
        {
            lpnachtrust.ItemsSource = e.Result.ToList();
            for (int i = 0; i < e.Result.Count; i++)
            {
                nachtrustids.Add(e.Result[i].ID);
            }
        }
        void client_GetAllWeersOmstandighedenCompleted(object sender, GetAllWeersOmstandighedenCompletedEventArgs e)
        {
            lpweersomstandigheden.ItemsSource = e.Result.ToList();
            for (int i = 0; i < e.Result.Count; i++)
            {
                weersomstandighedenids.Add(e.Result[i].ID);
            }
            _progressIndicator.IsVisible = false;
            SystemTray.SetIsVisible(this, false);
            ButtonOk.IsEnabled = true;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            InputDatabase.WeersomstandighedenIDs = weersomstandighedenids[lpweersomstandigheden.SelectedIndex];
            NavigationService.Navigate(new Uri("/Pages/ActivityPage.xaml", UriKind.Relative));
        }

        private void Lpnachtrust_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InputDatabase.NachtrustIDs = lpnachtrust.SelectedIndex;
        }

        private void Txtuurgeslapen_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<TimeSpan> e)
        {
            TimeSpan t = TimeSpan.Parse(txtuurgeslapen.Value.ToString());
            InputDatabase.UrenSlaap = Convert.ToInt32(t.Hours);
        }
    }
}