﻿#pragma checksum "C:\Users\senne\Documents\Projectjes\MM Systems\PanoramaApp3\PanoramaApp3\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0D401FB23700474C82F0890C3B169DED"
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
        
        internal System.Windows.Controls.TextBlock txt_user;
        
        internal Microsoft.Phone.Controls.PanoramaItem item2;
        
        internal Microsoft.Phone.Controls.DatePicker dtuurActiviteit;
        
        internal System.Windows.Controls.TextBox txthour1;
        
        internal System.Windows.Controls.TextBox txthour2;
        
        internal Microsoft.Phone.Controls.PanoramaItem item5;
        
        internal Microsoft.Phone.Controls.ListPicker lpnachtrust;
        
        internal Microsoft.Phone.Controls.ListPicker lpweersomstandigheden;
        
        internal System.Windows.Controls.TextBox txtuurgeslapen;
        
        internal Microsoft.Phone.Controls.PanoramaItem item3;
        
        internal Microsoft.Phone.Controls.ListPicker lp_Categorien;
        
        internal Microsoft.Phone.Controls.ListPicker lp_Activiteiten;
        
        internal System.Windows.Controls.Slider SliderVermoeidheid;
        
        internal System.Windows.Controls.Slider SliderBelangrijk;
        
        internal System.Windows.Controls.Slider SliderTevredenheid;
        
        internal System.Windows.Controls.Button btn_ok;
        
        internal Microsoft.Phone.Controls.PanoramaItem item4;
        
        internal System.Windows.Controls.TextBox txt_Commentaar;
        
        internal System.Windows.Controls.Button btnok;
        
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
            this.txt_user = ((System.Windows.Controls.TextBlock)(this.FindName("txt_user")));
            this.item2 = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("item2")));
            this.dtuurActiviteit = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("dtuurActiviteit")));
            this.txthour1 = ((System.Windows.Controls.TextBox)(this.FindName("txthour1")));
            this.txthour2 = ((System.Windows.Controls.TextBox)(this.FindName("txthour2")));
            this.item5 = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("item5")));
            this.lpnachtrust = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("lpnachtrust")));
            this.lpweersomstandigheden = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("lpweersomstandigheden")));
            this.txtuurgeslapen = ((System.Windows.Controls.TextBox)(this.FindName("txtuurgeslapen")));
            this.item3 = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("item3")));
            this.lp_Categorien = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("lp_Categorien")));
            this.lp_Activiteiten = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("lp_Activiteiten")));
            this.SliderVermoeidheid = ((System.Windows.Controls.Slider)(this.FindName("SliderVermoeidheid")));
            this.SliderBelangrijk = ((System.Windows.Controls.Slider)(this.FindName("SliderBelangrijk")));
            this.SliderTevredenheid = ((System.Windows.Controls.Slider)(this.FindName("SliderTevredenheid")));
            this.btn_ok = ((System.Windows.Controls.Button)(this.FindName("btn_ok")));
            this.item4 = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("item4")));
            this.txt_Commentaar = ((System.Windows.Controls.TextBox)(this.FindName("txt_Commentaar")));
            this.btnok = ((System.Windows.Controls.Button)(this.FindName("btnok")));
        }
    }
}

