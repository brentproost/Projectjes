using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PanoramaApp3.Classes;
using PanoramaApp3.ServiceReference;

namespace PanoramaApp3.Pages
{
    public partial class ActivityPage : PhoneApplicationPage
    {
        
        List<string> cbitems = new List<string>();
        List<int> cbtag = new List<int>();
        ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
        private ProgressIndicator _progressIndicator;
        public ActivityPage()
        {
            InitializeComponent();
            _progressIndicator = new ProgressIndicator
            {
                IsIndeterminate = true,
                Text = "Loading...",
                IsVisible = true,
            };
            btn_ok.IsEnabled = false;
            SystemTray.SetIsVisible(this, true);
            SystemTray.SetProgressIndicator(this, _progressIndicator);
            SystemTray.SetOpacity(this, 1);
            if (User.ID != 0)
            {
                client.GetAllCategoriesCompleted += serviceClient_GetAllCategoriesCompleted;
                client.GetAllCategoriesAsync();
            }
        }
        void serviceClient_GetAllCategoriesCompleted(object sender, GetAllCategoriesCompletedEventArgs e)
        {
            for (int i = 0; i < e.Result.Count; i++)
            {
                cbitems.Add(e.Result[i].Omschrijving);
                cbtag.Add(e.Result[i].Id);
            }

            lp_Categorien.ItemsSource = cbitems;

            client.GetAllActivitiesCompleted += client_GetAllActivitiesCompleted;
            client.GetAllActivitiesAsync();
        }
        void client_GetAllActivitiesCompleted(object sender, GetAllActivitiesCompletedEventArgs e)
        {
            lp_Activiteiten.ItemsSource = null;
            if (lp_Categorien.SelectedIndex >= 0)
            {
                if (e.Result != null)
                {
                    var id = cbtag[lp_Categorien.SelectedIndex];
                    var result = (from r in e.Result where r.Categorie_ID == id select r).ToList();

                    lp_Activiteiten.ItemsSource = result;
                }
            }
            _progressIndicator.IsVisible = false;
            SystemTray.SetIsVisible(this, false);
            btn_ok.IsEnabled = true;
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            InputDatabase.ActivityID = (lp_Activiteiten.SelectedItem as Activities).Activiteit_ID;
            NavigationService.Navigate(new Uri("/Pages/CommentPage.xaml", UriKind.Relative));
        }

        private void SliderVermoeidheid_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            InputDatabase.Vermoeidheid = (float)SliderVermoeidheid.Value;
        }

        private void SliderBelangrijk_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            InputDatabase.Belangrijk = (float) SliderBelangrijk.Value;
        }

        private void SliderTevredenheid_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            InputDatabase.Tevredenheid = (float) SliderTevredenheid.Value;
        }

        private void lp_Categorien_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            client.GetAllActivitiesCompleted += client_GetAllActivitiesCompleted;
            client.GetAllActivitiesAsync();
        }

        private void lp_Categorien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            client.GetAllActivitiesAsync();
            client.GetAllActivitiesCompleted+=client_GetAllActivitiesCompleted;
        }

        private void SliderVermoeidheid_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            double pos = 0;
            if (SliderVermoeidheid.Orientation == System.Windows.Controls.Orientation.Horizontal)
            {
                pos = e.GetPosition(SliderVermoeidheid).X;
                double width = SliderVermoeidheid.ActualWidth;

                SliderVermoeidheid.Value = (pos / width) * SliderVermoeidheid.Maximum;

            }
            else
            {
                pos = e.GetPosition(SliderVermoeidheid).Y;
                //MessageBox.Show(pos.ToString());

                double height = SliderVermoeidheid.ActualHeight;
                SliderVermoeidheid.Value = ((height-pos) / height) * SliderVermoeidheid.Maximum;

            }

        }
        private void SliderBelangrijk_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            double pos = 0;
            if (SliderBelangrijk.Orientation == System.Windows.Controls.Orientation.Horizontal)
            {
                pos = e.GetPosition(SliderBelangrijk).X;
                double width = SliderBelangrijk.ActualWidth;

                SliderBelangrijk.Value = (pos / width) * SliderBelangrijk.Maximum;

            }
            else
            {
                pos = e.GetPosition(SliderBelangrijk).Y;
                //MessageBox.Show(pos.ToString());

                double height = SliderBelangrijk.ActualHeight;
                SliderBelangrijk.Value = ((height - pos) / height) * SliderBelangrijk.Maximum;

            }

        }
        private void SliderTevredenheid_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            double pos = 0;
            if (SliderTevredenheid.Orientation == System.Windows.Controls.Orientation.Horizontal)
            {
                pos = e.GetPosition(SliderTevredenheid).X;
                double width = SliderTevredenheid.ActualWidth;

                SliderTevredenheid.Value = (pos / width) * SliderTevredenheid.Maximum;

            }
            else
            {
                pos = e.GetPosition(SliderTevredenheid).Y;
                //MessageBox.Show(pos.ToString());

                double height = SliderTevredenheid.ActualHeight;
                SliderTevredenheid.Value = ((height - pos) / height) * SliderTevredenheid.Maximum;

            }

        }
    }
}