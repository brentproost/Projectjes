using System.Runtime.Serialization;

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
        public int Activiteit_ID{ get; set; }

        [DataMember]
        public int CategorieId{ get; set; }
    }
}