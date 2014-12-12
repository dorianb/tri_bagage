using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Entities
{
    [DataContract]
    public class Parametres
    {
        [DataMember]
        public DateTime LastConnect;
        [DataMember]
        public string UserName;
        [DataMember]
        public string Param1;
        [DataMember]
        public string Param2;
    }
}
