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
        ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();

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
            dg_categorien.ItemsSource = null;
            client.GetAllActivitiesAsync();
            client.GetAllActivitiesCompleted += client_GetAllActivitiesCompleted;
            client.GetAllCategoriesAsync();
            client.GetAllCategoriesCompleted += client_GetAllCategoriesCompleted;
        }

        void client_GetAllCategoriesCompleted(object sender, ServiceReference.GetAllCategoriesCompletedEventArgs e)
        {
            dg_categorien.ItemsSource = e.Result.ToList();
        }

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
               MessageBoxResult msbResult = MessageBox.Show("De ingaven met deze activiteit worden ook verwijderd! Weet u zeker dat u deze activiteit wilt verwijderen?", "Verwijder", MessageBoxButton.OKCancel);
               if (msbResult == MessageBoxResult.OK)
               {
                   client.DeleteActivityAsync(Convert.ToInt32((((Image)sender).Tag).ToString()));
                   client.DeleteActivityCompleted += client_DeleteActivityCompleted;
               }
            
        }

        void client_DeleteActivityCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
         
                MessageBox.Show("activiteit verwijderd");
                UpdateDataGrid();
        }

        private void Image_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult msbResult = MessageBox.Show("De ingaven met deze categorie worden ook verwijderd! Weet u zeker dat u deze activiteit wilt verwijderen?", "Verwijder", MessageBoxButton.OKCancel);
            if (msbResult == MessageBoxResult.OK)
            {
                client.DeleteCategoryAsync(Convert.ToInt32((((Image)sender).Tag).ToString()));
                client.DeleteCategoryCompleted += client_DeleteCategoryCompleted;
            }            
        }

        void client_DeleteCategoryCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("categorie verwijderd");
            UpdateDataGrid();
        }
    }
}