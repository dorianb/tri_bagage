using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Entities
{
    [DataContract]
    public class PersoFaultException
    {
        [DataMember]
        public string Message{get;set;}
        [DataMember]
        public int V1 {get;set;}
        [DataMember]
        public int V2 {get;set;}
    }
}
