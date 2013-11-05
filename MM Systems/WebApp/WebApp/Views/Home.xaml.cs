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
    }
}