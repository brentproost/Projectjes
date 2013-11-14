using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wcf
{
    public class User
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string Adres { get; set; }
        public int Nummer { get; set; }
        public string Plaats { get; set; }
        public int Postcode { get; set; }
        public string Gebruikersnaam { get; set; }
        public string Paswoord { get; set; }
        public int Rechten_ID { get; set; }
        public int AantalIngaven { get; set; }
    }
}