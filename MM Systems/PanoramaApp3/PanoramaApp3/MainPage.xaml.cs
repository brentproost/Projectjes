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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using PanoramaApp3.ServiceReference;

namespace PanoramaApp3
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
            if (User.ID != 0)
            {
                ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
                client.GetAllUsersCompleted += ClientOnGetAllUsersCompleted;
                client.GetAllUsersAsync(User.ID);
            }
    }

        private void ClientOnGetAllUsersCompleted(object sender, GetAllUsersCompletedEventArgs getAllUsersCompletedEventArgs)
        {
            if (getAllUsersCompletedEventArgs.Result != null)
            {
                item1.Header ="Welkom "+ getAllUsersCompletedEventArgs.Result[0].Voornaam;
            }
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }

            ServiceReference.ServiceClient serviceClient = new ServiceReference.ServiceClient();

            serviceClient.GetAllActivitiesCompleted += serviceClient_GetAllActivitiesCompleted;
            serviceClient.GetAllActivitiesAsync();
        }

        void serviceClient_GetAllActivitiesCompleted(object sender, ServiceReference.GetAllActivitiesCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                lp_Activiteiten.ItemsSource = e.Result;
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigatedTo(2);
        }
        public void NavigatedTo(int e)
        {
            PanoramaApp.DefaultItem = "item2"/*"item"+e*/;

        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            PanoramaApp.DefaultItem = item2;
            //NavigatedTo(2);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PanoramaApp.DefaultItem = item3;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/Settings.xaml", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/Graphs.xaml", UriKind.Relative));
        }

    }
}