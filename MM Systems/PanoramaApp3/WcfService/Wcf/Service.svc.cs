﻿using System;
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
    }
}
