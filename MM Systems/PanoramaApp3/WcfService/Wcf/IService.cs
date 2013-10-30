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
        List<Tbl_User> GetAllUsers();

        [OperationContract]
        List<Tbl_Activiteiten> GetAllActivities();

        [OperationContract]
        bool SigninUser(string uname, string pass);
    }
}
