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
    public partial class Weeromstandigheden : Page
    {
        ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();

        public Weeromstandigheden()
        {
            InitializeComponent();
            UpdateDataGrid();
        }

        void UpdateDataGrid()
        {
            dg_weers.ItemsSource = null;
            client.GetAllWeersOmstandighedenAsync();
            client.GetAllWeersOmstandighedenCompleted += client_GetAllWeersOmstandighedenCompleted;
        }

        void client_GetAllWeersOmstandighedenCompleted(object sender, ServiceReference.GetAllWeersOmstandighedenCompletedEventArgs e)
        {
            dg_weers.ItemsSource = e.Result.ToList();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            client.DeleteWeersomstandigheidAsync(Convert.ToInt32((((Image)sender).Tag).ToString()));
            client.DeleteWeersomstandigheidCompleted += client_DeleteWeersomstandigheidCompleted;
        }

        void client_DeleteWeersomstandigheidCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Weersomstandigheid verwijderd");
            UpdateDataGrid();
        }

    }
}
