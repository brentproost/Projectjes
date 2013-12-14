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
<<<<<<< HEAD
using PanoramaApp3.ServiceReference1;
using Microsoft.Phone.Controls;
using PanoramaApp3.Classes;
using DagDataCompletedEventArgs = PanoramaApp3.ServiceReference1.DagDataCompletedEventArgs;
using ServiceClient = PanoramaApp3.ServiceReference1.ServiceClient;
=======
using CheckUserInput.ServiceReference;
using Microsoft.Phone.Controls;
using PanoramaApp3.Classes;
using DagDataCompletedEventArgs = PanoramaApp3.ServiceReference.DagDataCompletedEventArgs;
using ServiceClient = PanoramaApp3.ServiceReference.ServiceClient;
>>>>>>> 6ebdcc4ddfb0b180c8485fb28ddf566a4dfc1330

namespace PanoramaApp3.Pages
{
    public partial class Graphs : PhoneApplicationPage
    {
        ServiceClient client = new ServiceClient();
        private List<GrafiekData> fakedata;
        public Graphs()
        {
            InitializeComponent();

            dp_daggrafiek.Value = DateTime.Now;

            client.DagDataAsync(User.ID,((DateTime)dp_daggrafiek.Value).Date.ToString("d"));
            client.DagDataCompleted += client_DagDataCompleted;
            //linedata.Add(new LineData() { X = 1, Y_value_line1 = 20, Y_value_line2 = 45, Y_value_line3 = 89});
            //linedata.Add(new LineData() { X = 2, Y_value_line1 = 45, Y_value_line2 = 20, Y_value_line3 = 45});
            //linedata.Add(new LineData() { X = 3, Y_value_line1 = 89, Y_value_line3 = 20, Y_value_line2 = 12});

            fakedata = new List<GrafiekData>();
            fakedata.Add(new GrafiekData() { X = new TimeSpan(1, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(2, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(3, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(4, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(5, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(6, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(7, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(8, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(9, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(10, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(11, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(12, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(13, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(14, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(15, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(16, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(17, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(18, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(19, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(20, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(21, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(22, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(23, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
            fakedata.Add(new GrafiekData() { X = new TimeSpan(24, 0, 0), Y_value_line1 = 0, Y_value_line2 = 0, Y_value_line3 = 0 });
        }

        void client_DagDataCompleted(object sender, DagDataCompletedEventArgs e)
        {

            chart.DataSource = e.Result.ToList();

            //List<GrafiekData> linedata = new List<GrafiekData>();
            //linedata = e.Result.ToList();
            //foreach (var grafiekData in fakedata)
            //{
            //    linedata.Add(grafiekData);
            //}
            //linedata = linedata.OrderBy(h => h.X.Hours).ThenBy(h => h.X.Minutes).ToList();
            //chart.DataSource = linedata;
        }
    }
}