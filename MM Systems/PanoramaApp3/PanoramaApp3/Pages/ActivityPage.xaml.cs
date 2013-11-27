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

        public ActivityPage()
        {
            InitializeComponent();
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
    }
}