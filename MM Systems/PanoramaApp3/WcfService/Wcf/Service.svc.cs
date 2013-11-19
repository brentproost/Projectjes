using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Web;

namespace Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        public DataClassesDataContext Data { get; set; }

        public Service()
        {
            Data = new DataClassesDataContext();
        }

        //Functie om alle activiteiten met de bijhorende categorie (id) weer te geven, deze worden opgeslagen als een lijst van objecten van de klasse 'Activities'
        List<Activities> IService.GetAllActivities()
        {
            List<Activities> actlist = new List<Activities>();
            actlist = (from act in Data.Tbl_Activiteitens
                       join cat in Data.Tbl_Categoriens on act.Categorie_ID equals cat.Id
                       select new Activities()
                       {
                           Activiteit = act.Omschrijving,
                           Categorie = cat.Omschrijving,
                           Activiteit_ID = act.ID,
                           Categorie_ID = cat.Id
                       }).ToList();
            return actlist; 
        }

        //Functie vraagt aan de hand van een gegeven ID userinformatie over deze persoon op.
        List<Tbl_User> IService.GetUser(int ID)
        {
            try
            {
                IEnumerable<Tbl_User> result = Data.Tbl_Users.Where(a => a.ID == ID);
                List<Tbl_User> user = result.ToList();
                return user;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        //Functie om alle users op te vragen met alle bijhorende informatie en deze als een lijst van de klasse 'User' terug te geven, 
        //er wordt ook bijgehouden hoeveel ingaven deze persoon al gedaan heeft.
        List<User> IService.GetAllUsers()
        {
            List<User> userlist = new List<User>();
            userlist = (from u in Data.Tbl_Users
                        join i in Data.Tbl_GebruikersIngaves on u.ID equals i.User_ID
                        into Joined
                        from p in Joined.DefaultIfEmpty()
                        //left join ^
                       group p by new { u.ID, u.Naam, u.Voornaam, u.Adres, u.Nummer, u.Plaats, u.Postcode, u.Gebruikersnaam, u.Paswoord, u.Rechten_ID }
                       into grp select new User()
                       {
                            Id = grp.Key.ID,
                            Naam = grp.Key.Naam,
                            Voornaam = grp.Key.Voornaam,
                            Adres = grp.Key.Adres,
                            Nummer = grp.Key.Nummer,
                            Plaats = grp.Key.Plaats,
                            Postcode = grp.Key.Postcode,
                            Gebruikersnaam = grp.Key.Gebruikersnaam,
                            Paswoord = grp.Key.Paswoord,
                            Rechten_ID = grp.Key.Rechten_ID,
                            AantalIngaven = grp.Count(t => t.User_ID != null)
                       }).ToList();

            List<string> rechtenomschrijving = (from u in userlist join r in Data.Tbl_Rechtens on u.Rechten_ID equals r.ID select r.Omschrijving).ToList();

            for (int i = 0; i < userlist.Count; i++)
            {
                userlist[i].Rechten_Omschrijving = rechtenomschrijving[i];
            }

            return userlist;
        }

        //Functie om een user en het bijhorende paswoord te zoeken in de database, en als deze bestaat de id terug te geven.
        int IService.SigninUser(string uname, string pass)
        {
            try
            {
                IEnumerable<Tbl_User> result = Data.Tbl_Users.Where(a => a.Paswoord == pass && a.Gebruikersnaam == uname);
                List<Tbl_User> r = result.ToList();

                return r[0].ID;
            }
            catch (Exception)
            {
                //return "Deze gebruikersnaam of paswoord wordt niet herkend.";
                return 0;
            }
        }
        
        //Functie om een record toe te voegen aan de tabel Tbl_Users
        void IService.AddUser(string naam, string voornaam, string adres, int nummer, string plaats, int postcode, string gebruikersn, string pasw)
        {
            Tbl_User usr = new Tbl_User
            {
                Naam = naam,
                Voornaam = voornaam,
                Adres = adres,
                Nummer = nummer,
                Plaats = plaats,
                Postcode = postcode,
                Gebruikersnaam = gebruikersn,
                Paswoord = pasw,
                Rechten_ID = 2,
            };

            Data.Tbl_Users.InsertOnSubmit(usr);
           
            try
            {
                Data.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        //Functie om een record toe te voegen aan de tabel Tbl_Activiteiten
        void IService.AddActivity(string omschr, int catid)
        {
            Tbl_Activiteiten act = new Tbl_Activiteiten{Omschrijving = omschr, Categorie_ID = catid};
            Data.Tbl_Activiteitens.InsertOnSubmit(act);

            try
            {
                Data.SubmitChanges();
            }

             catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        //Functie om de categorien op te vragen
        List<Tbl_Categorien> IService.GetAllCategories()
        {
            return Data.Tbl_Categoriens.ToList();
        }

        //Functie om een record toe te voegen aan de tabel Tbl_Categorien
        void IService.AddCategory(string omschr)
        {
            Tbl_Categorien cat = new Tbl_Categorien() {Omschrijving = omschr};
            Data.Tbl_Categoriens.InsertOnSubmit(cat);

            try
            {
                Data.SubmitChanges();
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        //Functie om een Activiteit te verwijderen, de ingaven in Tbl_GebruikersIngave die deze activiteit bevat worden ook verwijderd
        void IService.DeleteActivity(int id)
        {
            var delete = from act in Data.Tbl_Activiteitens where act.ID == id select act;
            var deleteingavenmetactivity = from i in Data.Tbl_GebruikersIngaves where i.Activiteit_ID == id select i;

            foreach (var del in delete)
            {
                Data.Tbl_Activiteitens.DeleteOnSubmit(del);
            }

            foreach (var ing in deleteingavenmetactivity)
            {
                Data.Tbl_GebruikersIngaves.DeleteOnSubmit(ing);
            }

            try
            {
                Data.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        //Functie om een gebruiker te verwijderen aan de hand van een id uit de tabel Tbl_Users
        void IService.DeleteUser(int id)
        {
            var delete = from usr in Data.Tbl_Users where usr.ID == id select usr;
            var deleteingavengebruiker = from ing in Data.Tbl_GebruikersIngaves where ing.User_ID == id select ing;

            foreach (var del in delete)
            {
                Data.Tbl_Users.DeleteOnSubmit(del);
            }

            foreach (var i in deleteingavengebruiker)
            {
                Data.Tbl_GebruikersIngaves.DeleteOnSubmit(i);
            }

            try
            {
                Data.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        //Functie om een record toe te voegen aan de tabel Tbl_GebruikersIngave
        void IService.AddGebruikersIngave(int usrID, int actID, DateTime datumuuringave, DateTime dtmuurActiviteit, TimeSpan beginuur, TimeSpan einduur, string commentaar, int weersid, int nachtrid, int aantaluurgeslapen, float vermoeidheid, float belangrijkheid, float tevredenheid)
        {
            Tbl_GebruikersIngave gebi = new Tbl_GebruikersIngave()
            {
                User_ID = usrID,
                Activiteit_ID = actID,
                Datum_Uur_Ingave = datumuuringave,
                Datum_Uur_Activiteit = dtmuurActiviteit.Day+"-" + dtmuurActiviteit.Month+"-"+dtmuurActiviteit.Year,
                Beginuur_Activiteit = beginuur,
                Einduur_Activiteit = einduur,
                Commentaar = commentaar,
                Weersomstandigheden_ID = weersid,
                Schaal_Nachtrust_ID = nachtrid,
                Aantal_Uren_Geslapen = aantaluurgeslapen,
                Vermoeidheid = vermoeidheid,
                Belangrijkheid = belangrijkheid,
                Tevredenheid = tevredenheid
            };

            Data.Tbl_GebruikersIngaves.InsertOnSubmit(gebi);

            try
            {
                Data.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        //Functie om de Weersomstandigheden op te vragen
        List<Tbl_Weersomstandigheden> IService.GetAllWeersOmstandigheden()
        {
            return Data.Tbl_Weersomstandighedens.ToList();
        }

        //Functie om de nachtrustschaal op te vragen
        List<Tbl_Schaal_Nachtrust> IService.GetNachtrustSchaal()
        {
            return Data.Tbl_Schaal_Nachtrusts.ToList();
        }

        //Functie om de ingaven per gebruiker op te vragen
        List<Tbl_GebruikersIngave> IService.GetIngave_Gebruiker(int gebruikersid)
        {
            return (from i in Data.Tbl_GebruikersIngaves where i.User_ID == gebruikersid select i).ToList();
        }

        List<Tbl_User> IService.GetUserInfo(int ID)
        {
            return (from i in Data.Tbl_Users where i.ID == ID select i).ToList();
        }
    }
}