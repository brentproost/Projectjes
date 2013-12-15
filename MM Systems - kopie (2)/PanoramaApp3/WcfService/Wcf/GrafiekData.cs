using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Wcf
{
    [DataContract]
    public class GrafiekData
    {
        [DataMember]
        public TimeSpan X { get; set; }
        [DataMember]
        public double Y_value_line1 { get; set; }
        [DataMember]
        public double Y_value_line2 { get; set; }
        [DataMember]
        public double Y_value_line3 { get; set; }
    }
}