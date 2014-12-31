using System;
using System.Runtime.Serialization;

namespace MyAirport.Entities
{
    [DataContract]
    public class TraceDefinition
    {
        [DataMember]
        public DateTime DatePassage;
        [DataMember]
        public string Type;
        [DataMember]
        public string Localisation;
        [DataMember]
        public string Statut;
        [DataMember]
        public string Informations;
    }
}
