﻿#pragma checksum "C:\Users\BrentProost\Documents\Projectjes\MM Systems\PanoramaApp3\PanoramaApp3\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9D7FD38E4D96EBB13166DACD6F268448"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace PanoramaApp3 {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Panorama PanoramaApp;
        
        internal Microsoft.Phone.Controls.PanoramaItem item1;
        
        internal Microsoft.Phone.Controls.PanoramaItem item2;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PanoramaApp3;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.PanoramaApp = ((Microsoft.Phone.Controls.Panorama)(this.FindName("PanoramaApp")));
            this.item1 = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("item1")));
            this.item2 = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("item2")));
        }
    }
}

