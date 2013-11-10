using System;
using System.ComponentModel;
using System.IO.IsolatedStorage;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace WebApp
{
    public class User
    {
        public static int ID { get; set; }
        public static string Naam { get; set; }
        public static string Voornaam { get; set; }
        public static string Adres { get; set; }
        public static int Nummer { get; set; }
        public static string Plaats { get; set; }
        public static int Postcode { get; set; }
        public static string Gebruikersnaam { get; set; }
        public static string Paswoord { get; set; }
        public static int Rechten_ID { get; set; }
        public static IsolatedStorageSettings Settings =
            System.IO.IsolatedStorage.IsolatedStorageSettings.ApplicationSettings;
    }
}
