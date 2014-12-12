using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Entities
{
    [DataContract]
    public class Historique
    {
                [DataMember]
        public VolCriteres Recherche;
    }
}
