﻿#pragma checksum "C:\Users\BrentProost\Documents\Projectjes\MM Systems\WebApp\WebApp\Views\Gebruikers.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "335E8C671F48C3F43CB1F4A42281CBC3"
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
    
    
    public partial class Gebruikers : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox txtNaam;
        
        internal System.Windows.Controls.TextBox txtVoornaam;
        
        internal System.Windows.Controls.TextBox txtAdres;
        
        internal System.Windows.Controls.TextBox txtNummer;
        
        internal System.Windows.Controls.TextBox txtPlaats;
        
        internal System.Windows.Controls.TextBox txtPostcode;
        
        internal System.Windows.Controls.TextBox txtgebruikersnaam;
        
        internal System.Windows.Controls.PasswordBox txtpasw;
        
        internal System.Windows.Controls.Button btnsubmit;
        
        internal System.Windows.Controls.DataGrid gridd;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WebApp;component/Views/Gebruikers.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.txtNaam = ((System.Windows.Controls.TextBox)(this.FindName("txtNaam")));
            this.txtVoornaam = ((System.Windows.Controls.TextBox)(this.FindName("txtVoornaam")));
            this.txtAdres = ((System.Windows.Controls.TextBox)(this.FindName("txtAdres")));
            this.txtNummer = ((System.Windows.Controls.TextBox)(this.FindName("txtNummer")));
            this.txtPlaats = ((System.Windows.Controls.TextBox)(this.FindName("txtPlaats")));
            this.txtPostcode = ((System.Windows.Controls.TextBox)(this.FindName("txtPostcode")));
            this.txtgebruikersnaam = ((System.Windows.Controls.TextBox)(this.FindName("txtgebruikersnaam")));
            this.txtpasw = ((System.Windows.Controls.PasswordBox)(this.FindName("txtpasw")));
            this.btnsubmit = ((System.Windows.Controls.Button)(this.FindName("btnsubmit")));
            this.gridd = ((System.Windows.Controls.DataGrid)(this.FindName("gridd")));
        }
    }
}

