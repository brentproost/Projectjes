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
using WebApp.UC;
using WebApp.Views;
using System.Windows.Controls.Primitives;



namespace WebApp
{
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }
        
        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void btn_AddUser_Click(object sender, RoutedEventArgs e)
        {
            var window = new DialogBoxes.AddUser();
            window.Closed += window_Closed;
            window.Show();
        }

        void window_Closed(object sender, EventArgs e)
        {
            
        }

        private void btn_AddActivity_Click(object sender, RoutedEventArgs e)
        {
            var window = new DialogBoxes.AddActivity();
            window.Closed += window_Closed;
            window.Show();
        }

        private void btn_AddCategory_Click(object sender, RoutedEventArgs e)
        {
            var window = new DialogBoxes.AddCategory();
            window.Closed += window_Closed;
            window.Show();
        }

        private void btn_GebruikerToevoegen_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var window = new DialogBoxes.AddUser();
            window.Closed += window_Closed;
            window.Show();
        }

        private void btn_Actiteittoevoegen_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var window = new DialogBoxes.AddActivity();
            window.Closed += window_Closed;
            window.Show();
        }

        private void btn_Categorietoevoegen_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var window = new DialogBoxes.AddCategory();
            window.Closed += window_Closed;
            window.Show();
        }

        void client_AddGebruikersIngaveCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            MessageBox.Show("ja");
        }

        private void btn_Weertoevoegen_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var window = new DialogBoxes.AddWeersomstandigheid();
            window.Closed += window_Closed;
            window.Show();
        }
    }
}