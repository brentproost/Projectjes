﻿#pragma checksum "C:\Users\senne\Documents\Projectjes\MM Systems\WebApp\WebApp\Views\Resultaten.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "714CE21038870F3DC11D9654DC1B0EDE"
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


namespace WebApp.Views {
    
    
    public partial class Resultaten : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox txtid;
        
        internal System.Windows.Controls.Button btn_ChangeUser;
        
        internal System.Windows.Controls.TextBlock txt_Naam_Voornaam;
        
        internal System.Windows.Controls.DataGrid dg_Ingaven;
        
        internal System.Windows.Controls.Button btn_export;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WebApp;component/Views/Resultaten.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.txtid = ((System.Windows.Controls.TextBox)(this.FindName("txtid")));
            this.btn_ChangeUser = ((System.Windows.Controls.Button)(this.FindName("btn_ChangeUser")));
            this.txt_Naam_Voornaam = ((System.Windows.Controls.TextBlock)(this.FindName("txt_Naam_Voornaam")));
            this.dg_Ingaven = ((System.Windows.Controls.DataGrid)(this.FindName("dg_Ingaven")));
            this.btn_export = ((System.Windows.Controls.Button)(this.FindName("btn_export")));
        }
    }
}

