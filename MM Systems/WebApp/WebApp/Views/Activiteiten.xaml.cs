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
using System.ServiceModel;
using System.ComponentModel;
using System.IO;

namespace WebApp
{
    public partial class About : Page
    {
        public About()
        {
            InitializeComponent();
            UpdateDataGrid();
        }

        void client_GetAllActivitiesCompleted(object sender, ServiceReference.GetAllActivitiesCompletedEventArgs e)
        {
            gridd.ItemsSource = e.Result.ToList();
        }

        void UpdateDataGrid()
        {
            gridd.ItemsSource = null;

            ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();

            client.GetAllActivitiesCompleted += client_GetAllActivitiesCompleted;
            client.GetAllActivitiesAsync();
        }

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
               MessageBoxResult msbResult = MessageBox.Show("De ingaven met deze activiteit worden ook verwijderd! Weet u zeker dat u deze activiteit wilt verwijderen?", "Verwijder", MessageBoxButton.OKCancel);
               if (msbResult == MessageBoxResult.OK)
               {
                   ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
                   client.DeleteActivityCompleted += client_DeleteActivityCompleted;
                   client.DeleteActivityAsync(Convert.ToInt32((((Image)sender).Tag).ToString()));
               }
            
        }

        void client_DeleteActivityCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
         
                MessageBox.Show("activiteit verwijderd");
                UpdateDataGrid();
        }
    }
}