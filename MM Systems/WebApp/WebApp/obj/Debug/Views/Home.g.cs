﻿#pragma checksum "C:\Users\senne\Documents\Projectjes\MM Systems\WebApp\WebApp\Views\Home.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "281659E6C421AF1AEB19A4BEB89F6CF0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace WebApp {
    
    
    public partial class Home : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.ScrollViewer PageScrollViewer;
        
        internal System.Windows.Controls.StackPanel ContentStackPanel;
        
        internal System.Windows.Controls.TextBlock HeaderText;
        
        internal System.Windows.Controls.Button btn_AddUser;
        
        internal System.Windows.Controls.Button btn_AddActivity;
        
        internal System.Windows.Controls.Button btn_AddCategory;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WebApp;component/Views/Home.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.PageScrollViewer = ((System.Windows.Controls.ScrollViewer)(this.FindName("PageScrollViewer")));
            this.ContentStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentStackPanel")));
            this.HeaderText = ((System.Windows.Controls.TextBlock)(this.FindName("HeaderText")));
            this.btn_AddUser = ((System.Windows.Controls.Button)(this.FindName("btn_AddUser")));
            this.btn_AddActivity = ((System.Windows.Controls.Button)(this.FindName("btn_AddActivity")));
            this.btn_AddCategory = ((System.Windows.Controls.Button)(this.FindName("btn_AddCategory")));
        }
    }
}

