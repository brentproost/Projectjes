﻿#pragma checksum "C:\Users\BrentProost\Documents\Projectjes\MM Systems\WebApp\WebApp\Views\Gebruikers.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E54ACE37CAF83C9BDD17B3020F0758AC"
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
        
        internal System.Windows.Controls.TextBox btnNaam;
        
        internal System.Windows.Controls.TextBox btnVoornaam;
        
        internal System.Windows.Controls.TextBox btnAdres;
        
        internal System.Windows.Controls.TextBox btnNummer;
        
        internal System.Windows.Controls.TextBox btnPlaats;
        
        internal System.Windows.Controls.TextBox btnPostcode;
        
        internal System.Windows.Controls.TextBox btngebruikersnaam;
        
        internal System.Windows.Controls.TextBox btnpasw;
        
        internal System.Windows.Controls.Button btnsubmit;
        
        internal System.Windows.Controls.DataGrid dg_Gebruikers;
        
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
            this.btnNaam = ((System.Windows.Controls.TextBox)(this.FindName("btnNaam")));
            this.btnVoornaam = ((System.Windows.Controls.TextBox)(this.FindName("btnVoornaam")));
            this.btnAdres = ((System.Windows.Controls.TextBox)(this.FindName("btnAdres")));
            this.btnNummer = ((System.Windows.Controls.TextBox)(this.FindName("btnNummer")));
            this.btnPlaats = ((System.Windows.Controls.TextBox)(this.FindName("btnPlaats")));
            this.btnPostcode = ((System.Windows.Controls.TextBox)(this.FindName("btnPostcode")));
            this.btngebruikersnaam = ((System.Windows.Controls.TextBox)(this.FindName("btngebruikersnaam")));
            this.btnpasw = ((System.Windows.Controls.TextBox)(this.FindName("btnpasw")));
            this.btnsubmit = ((System.Windows.Controls.Button)(this.FindName("btnsubmit")));
            this.dg_Gebruikers = ((System.Windows.Controls.DataGrid)(this.FindName("dg_Gebruikers")));
        }
    }
}

