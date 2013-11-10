using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;

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
        
        public List<Tbl_User> GetAllUsers()
        {
            return Data.Tbl_Users.ToList();
        }

        List<Activities> IService.GetAllActivities()
        {
            List<Activities> actlist = new List<Activities>();
            //actlist = (from act in Data.Tbl_Activiteitens select new Activities() { OmschrijvingAct = act.Omschrijving}).ToList();
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
        List<Tbl_User> IService.GetAllUsers()
        {
            return Data.Tbl_Users.ToList();
        }
        List<Tbl_User> IService.GetUserInfo(int ID)
        {
            IEnumerable<Tbl_User> result = Data.Tbl_Users.Where(a => a.ID == ID);
            List<Tbl_User> r = result.ToList();
            return r;
        }
        int IService.SigninUser(string uname, string pass)
        {
            try
            {
                IEnumerable<Tbl_User> result = Data.Tbl_Users.Where(a => a.Paswoord == pass && a.Gebruikersnaam == uname);
                List<Tbl_User> r = result.ToList();

                //return "Welkom " + r[0].Naam + " " + r[0].Voornaam + "!";
                return r[0].ID;
            }
            catch (Exception)
            {
                //return "Deze gebruikersnaam of paswoord wordt niet herkend.";
                return 0;
            }
        }

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

        List<Tbl_Categorien> IService.GetAllCategories()
        {
            return Data.Tbl_Categoriens.ToList();
        }

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


        void IService.DeleteActivity(int id)
        {
            var delete = from act in Data.Tbl_Activiteitens where act.ID == id select act;

            foreach (var del in delete)
            {
                Data.Tbl_Activiteitens.DeleteOnSubmit(del);
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

        void IService.DeleteUser(int id)
        {
            var delete = from usr in Data.Tbl_Users where usr.ID == id select usr;

            foreach (var del in delete)
            {
                Data.Tbl_Users.DeleteOnSubmit(del);
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


        void IService.AddGebruikersIngave(int usrID, int actID, DateTime datumuuringave, DateTime dtmuurActiviteit, string commentaar, int weersid, int nachtrid, int aantaluurgeslapen, float vermoeidheid, float belangrijkheid, float tevredenheid)
        {
            Tbl_GebruikersIngave gebi = new Tbl_GebruikersIngave()
            {
                User_ID = usrID,
                Activiteit_ID = actID,
                Datum_Uur_Ingave = datumuuringave,
                Datum_Uur_Activiteit = dtmuurActiviteit,
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
            //transaction id aanmaken
        }


        List<Tbl_Weersomstandigheden> IService.GetAllWeersOmstandigheden()
        {
            return Data.Tbl_Weersomstandighedens.ToList();
        }

        List<Tbl_Schaal_Nachtrust> IService.GetNachtrustSchaal()
        {
            return Data.Tbl_Schaal_Nachtrusts.ToList();
        }
    }
}