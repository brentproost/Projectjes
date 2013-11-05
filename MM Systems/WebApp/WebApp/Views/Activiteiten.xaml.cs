﻿using System;
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

namespace WebApp
{
    public partial class About : Page
    {
        public About()
        {
            InitializeComponent();
            ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
            client.GetAllActivitiesCompleted += client_GetAllActivitiesCompleted;
            client.GetAllActivitiesAsync();
        }

        void client_GetAllActivitiesCompleted(object sender, ServiceReference.GetAllActivitiesCompletedEventArgs e)
        {
            gridd.ItemsSource = e.Result.ToList();
        }
    }
}