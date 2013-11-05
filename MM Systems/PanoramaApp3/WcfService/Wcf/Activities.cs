using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Wcf
{
    [DataContract]
    public class Activities
    {
        [DataMember]
        public string Categorie { get; set; }
        [DataMember]
        public string Activiteit { get; set; }
        [DataMember]
        public int Activiteit_ID { get; set; }
    }
}