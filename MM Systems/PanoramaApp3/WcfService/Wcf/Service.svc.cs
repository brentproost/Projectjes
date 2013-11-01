using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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

        List<Tbl_Activiteiten> IService.GetAllActivities()
        {
            return Data.Tbl_Activiteitens.ToList();
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
    }
}