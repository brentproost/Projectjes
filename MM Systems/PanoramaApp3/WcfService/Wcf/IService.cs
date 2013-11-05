using System;
using System.Collections.Generic;
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

    }
}
