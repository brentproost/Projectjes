using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Windows;
using System.Windows.Browser;
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
    public partial class MainPage 
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationGrid.Visibility= Visibility.Collapsed;
            Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains("ID"))
            {
                User.ID = (int)User.Settings["ID"];
            }
            else
            {
                User.Settings.Add("ID", 0);
            }
            if (User.ID == 0)
            {
                this.ContentFrame.Navigate(new Uri("/Login", UriKind.Relative));
            }
            else
            {
                this.ContentFrame.Navigate(new Uri("/Home", UriKind.Relative));
                NavigationGrid.Visibility = Visibility.Visible;
            }
        }
        
        // After the Frame navigates, ensure the HyperlinkButton representing the current page is selected
        private void ContentFrame_Navigated(object sender, NavigationEventArgs e)
        {
            if (User.ID == 0)
            {
                this.ContentFrame.Navigate(new Uri("/Login", UriKind.Relative));
                NavigationGrid.Visibility = Visibility.Collapsed;
            }
            else
                NavigationGrid.Visibility = Visibility.Visible;

            //foreach (UIElement child in LinksStackPanel.Children)
            //{
            //    HyperlinkButton hb = child as HyperlinkButton;
            //    if (hb != null && hb.NavigateUri != null)
            //    {

            //        if (hb.NavigateUri.ToString().Equals(e.Uri.ToString()))
            //        {
            //            VisualStateManager.GoToState(hb, "ActiveLink", true);
            //        }
            //        else
            //        {
            //            VisualStateManager.GoToState(hb, "InactiveLink", true);
            //        }
            //    }
            //}
        }

        private void Afmelden(object sender, RoutedEventArgs e)
        {
            NavigationGrid.Visibility = Visibility.Collapsed;
            User.ID = 0;
            User.Settings["ID"] = User.ID;
            this.ContentFrame.Navigate(new Uri("/Login",UriKind.Relative));
            
        }

        // If an error occurs during navigation, show an error window
        private void ContentFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            e.Handled = true;
            ChildWindow errorWin = new ErrorWindow(e.Uri);
            errorWin.Show();
        }
        
    }
}