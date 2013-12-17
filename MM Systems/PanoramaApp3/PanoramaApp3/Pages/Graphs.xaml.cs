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
using PanoramaApp3.ServiceReference;
using Microsoft.Phone.Controls;
using PanoramaApp3.Classes;
using DagDataCompletedEventArgs = PanoramaApp3.ServiceReference.DagDataCompletedEventArgs;
using ServiceClient = PanoramaApp3.ServiceReference.ServiceClient;

namespace PanoramaApp3.Pages
{
    public partial class Graphs : PhoneApplicationPage
    {
        ServiceClient client = new ServiceClient();
        public Graphs()
        {
            InitializeComponent();
            dp_daggrafiek.Value = DateTime.Now;
            dp_maandgrafiek.Value = DateTime.Now;
        }

        private void dp_daggrafiek_ValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {
            client.DagDataAsync(User.ID, ((DateTime)dp_daggrafiek.Value).Date.ToString("dd-MM-yyyy"));
            //client.DagDataAsync(User.ID,DateTime.Now.Date.ToString("dd-MM-yyyy"));
            client.DagDataCompleted += client_DagDataCompleted;
        }

        private void dp_maandgrafiek_ValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {
            client.MaandDataAsync(User.ID, ((DateTime)dp_maandgrafiek.Value).Date.ToString("MM-yyyy"));
            client.MaandDataCompleted += client_MaandDataCompleted;
        }

        void client_DagDataCompleted(object sender, DagDataCompletedEventArgs e)
        {
            if (e.Result.Count != 0)
                chart.DataSource = e.Result.ToList();
            else
            {
                MessageBox.Show("Er zijn nog geen ingaven voor deze dag");
            }
        }

        void client_MaandDataCompleted(object sender, MaandDataCompletedEventArgs e)
        {
            if (e.Result.Count != 0)
                chart2.DataSource = e.Result.ToList();
            else
            {
                MessageBox.Show("Er zijn nog geen ingaven voor deze maand");
            }
        }
    }
}