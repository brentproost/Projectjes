﻿#pragma checksum "C:\Users\senne\Documents\Projectjes\MM Systems\PanoramaApp3\PanoramaApp3\Pages\Graphs.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6299DAB534ADF477128BC969B640139C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AmCharts.Windows.QuickCharts;
using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PanoramaApp3.Pages {
    
    
    public partial class Graphs : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal AmCharts.Windows.QuickCharts.SerialChart chart;
        
        internal Microsoft.Phone.Controls.DatePicker dp_daggrafiek;
        
        internal AmCharts.Windows.QuickCharts.SerialChart chart2;
        
        internal Microsoft.Phone.Controls.DatePicker dp_maandgrafiek;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/MS%20Patient;component/Pages/Graphs.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.chart = ((AmCharts.Windows.QuickCharts.SerialChart)(this.FindName("chart")));
            this.dp_daggrafiek = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("dp_daggrafiek")));
            this.chart2 = ((AmCharts.Windows.QuickCharts.SerialChart)(this.FindName("chart2")));
            this.dp_maandgrafiek = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("dp_maandgrafiek")));
        }
    }
}

