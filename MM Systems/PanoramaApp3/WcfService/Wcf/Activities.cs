using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Wcf
{
    [DataContract]
    public class Activities
    {
        [DataMember]
        public string OmschrijvingCat { get; set; }
        [DataMember]
        public string OmschrijvingAct { get; set; }
    }
}