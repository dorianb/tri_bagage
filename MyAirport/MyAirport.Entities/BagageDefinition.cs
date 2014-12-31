using System;
using System.Collections.Generic;
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
        public string CodeIATA;
        [DataMember]
        public string Ciee;
        [DataMember]
        public string Typ;
        [DataMember]
        public bool Recol;
        [DataMember]
        public bool Emb;
        [DataMember]
        public DateTime DateCreation;
        [DataMember]
        public string Creation;
        [DataMember]
        public string Description;
        [DataMember]
        public VolDefinition VolAuDepart;
        [DataMember]
        public VolDefinition VolContinuation;
        [DataMember]
        public VolDefinition VolApport;
        [DataMember]
        public List<TraceDefinition> Trace;
    }
}
