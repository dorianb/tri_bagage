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
        public string Ligne;
        [DataMember]
        public DateTime Date;
        [DataMember]
        public List<string> Banques; 
    }
}
