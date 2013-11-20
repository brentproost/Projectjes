using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using PanoramaApp3.ServiceReference;
using System.Threading;
using GestureEventArgs = System.Windows.Input.GestureEventArgs;

namespace PanoramaApp3
{
    public partial class MainPage : PhoneApplicationPage
    {
/*
        List<string> cbitems = new List<string>();
        List<int> cbtag = new List<int>();
        List<int> weersomstandighedenids = new List<int>();
        List<int> nachtrustids = new List<int>();
        ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
        int activityid;*/
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
            /*if (User.ID != 0)
            {
                client.GetAllCategoriesCompleted += serviceClient_GetAllCategoriesCompleted;
                client.GetAllCategoriesAsync();
            }
            try
            {  client.GetNachtrustSchaalCompleted += client_GetNachtrustSchaalCompleted;
                client.GetNachtrustSchaalAsync();
               client.GetAllWeersOmstandighedenCompleted += client_GetAllWeersOmstandighedenCompleted;
                client.GetAllWeersOmstandighedenAsync();
               

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            txthour1.Text = DateTime.Now.Hour.ToString();*/
        
        }
/*
        void client_GetAllWeersOmstandighedenCompleted(object sender, GetAllWeersOmstandighedenCompletedEventArgs e)
        {
            lpweersomstandigheden.ItemsSource = e.Result.ToList();
            for (int i = 0; i < e.Result.Count; i++)
            {
                weersomstandighedenids.Add(e.Result[i].ID);
            }
        }

        void client_GetNachtrustSchaalCompleted(object sender, GetNachtrustSchaalCompletedEventArgs e)
        {
            lpnachtrust.ItemsSource = e.Result.ToList();
            for (int i = 0; i < e.Result.Count; i++)
            {
                nachtrustids.Add(e.Result[i].ID);
            }
        }*/

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }
/*
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
        }*/
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            //PanoramaApp.DefaultItem = item2;
            //NavigatedTo(2);
            NavigationService.Navigate(new Uri("/Pages/DatePage.xaml", UriKind.Relative));
        }

        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            PanoramaApp.DefaultItem = item5;
        }*/

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/Settings.xaml", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/Graphs.xaml", UriKind.Relative));
        }

       /* private void lp_Categorien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lp_Activiteiten.SelectionChanged-= lp_Activiteiten_SelectionChanged;
            lp_Categorien.SelectionChanged -= lp_Categorien_SelectionChanged;   
            client.GetAllActivitiesCompleted += client_GetAllActivitiesCompleted;
            client.GetAllActivitiesAsync();

        }

        void client_GetAllActivitiesCompleted(object sender, GetAllActivitiesCompletedEventArgs e)
        {
            List<int> activlistid = new List<int>();
            List<string> activlistomschr = new List<string>();
            if (lp_Categorien.SelectedIndex >= 0)
            {
                if (e.Result != null)
                {
                    foreach (var item in e.Result.ToList())
                    {
                        activlistid.Add(item.Categorie_ID);
                        activlistomschr.Add(item.Activiteit);
                    }
                    var id = cbtag[lp_Categorien.SelectedIndex];

                    var result = (from r in e.Result where r.Categorie_ID == id select r).ToList();

                    lp_Activiteiten.ItemsSource = result;

                    if (lp_Activiteiten.SelectedItem != null)
                    {
                        activityid = result[lp_Activiteiten.SelectedIndex].Activiteit_ID;

                        lp_Activiteiten.SelectionChanged+=lp_Activiteiten_SelectionChanged;
                        lp_Categorien.SelectionChanged+=lp_Categorien_SelectionChanged;
                    }
                }
            }


        }

        void client_AddGebruikersIngaveCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Toegevoegd");
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            PanoramaApp.DefaultItem = item4;
        }

        private void lp_Activiteiten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lp_Activiteiten.SelectionChanged -= lp_Activiteiten_SelectionChanged;
            lp_Categorien.SelectionChanged -= lp_Categorien_SelectionChanged;
            client.GetAllActivitiesCompleted += client_GetAllActivitiesCompleted;
            client.GetAllActivitiesAsync();
           
        }

        private void btnok_Click(object sender, RoutedEventArgs e)
        {            client.AddGebruikersIngaveCompleted += client_AddGebruikersIngaveCompleted;
            client.AddGebruikersIngaveAsync(User.ID, (lp_Activiteiten.SelectedItem as Activities).Activiteit_ID, DateTime.Now, Convert.ToDateTime(dtuurActiviteit.Value), new TimeSpan(Convert.ToInt32(txthour1.Text),0,0),new TimeSpan(Convert.ToInt32(txthour2.Text),0,0),txt_Commentaar.Text, weersomstandighedenids[lpweersomstandigheden.SelectedIndex], nachtrustids[lpnachtrust.SelectedIndex], Convert.ToInt32(txtuurgeslapen.Text), (float)SliderVermoeidheid.Value, (float)SliderBelangrijk.Value, (float)SliderTevredenheid.Value);

            PanoramaApp.DefaultItem = item1;
        }

        private void btnoknacht_Click(object sender, RoutedEventArgs e)
        {
            PanoramaApp.DefaultItem = item3;
        }

        private void txthour1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txthour1.Text != "")
            txthour2.Text = (Convert.ToInt32(txthour1.Text) + 1).ToString();
        }

        private void dtuurActiviteit_Loaded(object sender, RoutedEventArgs e)
        {
            dtuurActiviteit.Value = DateTime.Now;
        }*/
    }
}