using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PanoramaApp3.Classes;

namespace PanoramaApp3.Pages
{
    public partial class DatePage : PhoneApplicationPage
    {
        public DatePage()
        {
            InitializeComponent();
            txthour1.Value = TimeSpan.Parse((DateTime.Now.Hour-1).ToString()+":00:00");
            dtuurActiviteit.Value = DateTime.Now;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/CircumstancesPage.xaml", UriKind.Relative));
        }

        private void Txthour1_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<TimeSpan> e)
        {
            if (txthour1.Value != null)
                txthour2.Value = (txthour1.Value + TimeSpan.Parse("01:00:00"));
            InputDatabase.FromHour = TimeSpan.Parse(txthour1.Value.ToString());
            InputDatabase.ToHour = TimeSpan.Parse(txthour2.Value.ToString());
        }

        private void DtuurActiviteit_OnValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {
            InputDatabase.Date = ((DateTime) dtuurActiviteit.Value).ToString("dd-MM-yyyy");
        }
    }
}