using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        List<Tbl_User> GetUser(int ID);

        [OperationContract]
        List<Tbl_User> GetAllUsers();
        [OperationContract]
        List<Tbl_User> GetUserInfo(int ID);

        [OperationContract]
        List<Activities> GetAllActivities();

        [OperationContract]
        List<Tbl_Categorien> GetAllCategories();

        [OperationContract]
        int SigninUser(string uname, string pass);

        [OperationContract]
        void AddUser(string naam, string voornaam, string adres, int nummer, string plaats, int postcode, string gebruikersn, string pasw);

        [OperationContract]
        void AddActivity(string omschr, int catid);

        [OperationContract]
        void AddCategory(string omschr);

        [OperationContract]
        void DeleteActivity(int id);

        [OperationContract]
        void DeleteUser(int id);

        [OperationContract]
        void AddGebruikersIngave(int usrID, int actID, DateTime datumuuringave, DateTime dtmuurActiviteit, TimeSpan beginuur, TimeSpan einduur, string commentaar, int weersid, int nachtrid, int aantaluurgeslapen, float vermoeidheid, float belangrijkheid, float tevredenheid);

        [OperationContract]
        List<Tbl_Weersomstandigheden> GetAllWeersOmstandigheden();

        [OperationContract]
        List<Tbl_Schaal_Nachtrust> GetNachtrustSchaal();

        [OperationContract]
        List<Tbl_GebruikersIngave> GetIngave_Gebruiker(int gebruikersid);

    }
}
