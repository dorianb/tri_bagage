using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Entities
{
    public class BagageCriteres
    {
        public int idVol;
        public string TemplateCodeIata;
        public List<string> Compagnies = null;
        public DateTime DateDebut;
        public DateTime DateFin;
        public int Ligne;
        public bool IncludeRecolle;
        public bool IncludeNoRecolle;
        public bool IncludePseudoBsm;
        public bool IncludeBsm;
        public List<String> StatutSuretes = null;   //NO, N1S, N1D, N2S, N2D, N3S, N3D,N4S, N4D, N5,...
        public List<String> SortieSuretes = null;   //WJ32, WJ33, WJ34, SJ01, SJ02,...
        public List<string> TypeTaches = null;  // ANT, TPS, DER, RAT, EMP, GLOB, SEC,...
    }
}
