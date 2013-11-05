﻿using System;
using System.Collections.Generic;
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
                          OmschrijvingAct = act.Omschrijving,
                          OmschrijvingCat = cat.Omschrijving
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
            catch (Exception)
            {
                Data.SubmitChanges();
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

            catch (Exception)
            {
                Data.SubmitChanges();
            }
        }

        List<Tbl_Categorien> IService.GetAllCategories()
        {
            return Data.Tbl_Categoriens.ToList();
        }
    }
}