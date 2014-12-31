using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyAirport.Entities
{
 
    [DataContract]
    public class VolDefinition
    {
        [DataMember]
        public int? Id;
        [DataMember]
        public string CIE;
        [DataMember]
        public string CodeCIE;
        [DataMember]
        public string Ligne;
        [DataMember]
        public DateTime Date;
        [DataMember]
        public int Jex;
        [DataMember]
        public string Aer;
        [DataMember]
        public List<string> Banques; 
    }
}
