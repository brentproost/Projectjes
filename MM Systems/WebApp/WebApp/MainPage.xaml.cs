using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
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
    public partial class MainPage 
    {
        public Popup p;

        public MainPage()
        {
            InitializeComponent();
            NavigationGrid.Visibility= Visibility.Collapsed;
            showPopup();
            p.Closed += p_Closed;
        }

        void p_Closed(object sender, EventArgs e)
        {
            NavigationGrid.Visibility = Visibility.Visible;
            this.ContentFrame.Navigate(new Uri("/Home", UriKind.Relative));
        }
        private void showPopup()
        {
            p = new Popup();
            p.Child = new Login();
            p.VerticalOffset = 768/2;
            p.HorizontalOffset = 1024/2;
            p.IsOpen = true;   
            
        }
        // After the Frame navigates, ensure the HyperlinkButton representing the current page is selected
        private void ContentFrame_Navigated(object sender, NavigationEventArgs e)
        {
            foreach (UIElement child in LinksStackPanel.Children)
            {
                HyperlinkButton hb = child as HyperlinkButton;
                if (hb != null && hb.NavigateUri != null)
                {
                    
                        if (hb.NavigateUri.ToString().Equals(e.Uri.ToString()))
                        {
                            VisualStateManager.GoToState(hb, "ActiveLink", true);
                        }
                        else
                        {
                            VisualStateManager.GoToState(hb, "InactiveLink", true);
                        }
                    
                }
            }
        }

        private void Afmelden(object sender, RoutedEventArgs e)
        {
            NavigationGrid.Visibility = Visibility.Collapsed;
            this.ContentFrame.Navigate(new Uri("/empty",UriKind.Relative));
            p.IsOpen = true;
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