using Microsoft.Phone.Net.NetworkInformation;
using Microsoft.Phone.Tasks;
using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Windows;

namespace PanoramaApp3
{
    public static class User
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

        public static bool CheckNetworkConnection()
        {
            if (NetworkInterface.NetworkInterfaceType == Microsoft.Phone.Net.NetworkInformation.NetworkInterfaceType.None)
                return false;
            else
                return true;
        }
    }
}
