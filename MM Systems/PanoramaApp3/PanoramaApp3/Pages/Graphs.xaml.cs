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
using Microsoft.Phone.Controls;
using PanoramaApp3.Classes;
using PanoramaApp3.ServiceReference;

namespace PanoramaApp3.Pages
{
    public partial class Graphs : PhoneApplicationPage
    {
        ServiceClient client = new ServiceClient();
        public Graphs()
        {
            InitializeComponent();

            client.DagDataAsync(User.ID);
            client.DagDataCompleted += client_DagDataCompleted;
            //linedata.Add(new LineData() { X = 1, Y_value_line1 = 20, Y_value_line2 = 45, Y_value_line3 = 89});
            //linedata.Add(new LineData() { X = 2, Y_value_line1 = 45, Y_value_line2 = 20, Y_value_line3 = 45});
            //linedata.Add(new LineData() { X = 3, Y_value_line1 = 89, Y_value_line3 = 20, Y_value_line2 = 12});

        }

        void client_DagDataCompleted(object sender, DagDataCompletedEventArgs e)
        {
            List<GrafiekData> linedata = new List<GrafiekData>();
            linedata = e.Result.ToList();
            chart_1.DataSource = linedata;
        }
    }
}