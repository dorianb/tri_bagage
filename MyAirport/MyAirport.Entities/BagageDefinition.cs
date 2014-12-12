using System;
using System.Runtime.Serialization;

namespace MyAirport.Entities
{
 
    [DataContract]
    public class BagageDefinition
    {
        [DataMember]
        public int Id;
        [DataMember]
        public int? IdVol;
        [DataMember]
        public int CodeIATA;
        [DataMember]
        public DateTime DateCreation;
    }
}
