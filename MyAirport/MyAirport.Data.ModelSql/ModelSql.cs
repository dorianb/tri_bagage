using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Data
{
    public class ModelSql:AbstractModel
    {
        ConnectionStringSettingsCollection connectionStrings = ConfigurationManager.ConnectionStrings;

        string strConnectionString;

        public ModelSql()
        {
            this.strConnectionString = connectionStrings["MyAirport.Service.Properties.Settings.MyAirportBDD"].ConnectionString;
        }
        public override Entities.VolDefinition GetVol(int idVol)
        {
            Entities.VolDefinition vol = null;
            using (SqlConnection cnx = new SqlConnection(strConnectionString))
            {
                SqlCommand cmd = new SqlCommand(
"select v.id_vol, c.nom_cie as Compagnie, v.lig as NumLigne, v.dhc as Date from Vol v "+
"inner join cie c on c.id_cie = v.id_cie where id_vol = @idVol", cnx);
                cmd.Parameters.AddWithValue("@idVol", idVol);

                cnx.Open();
                
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        vol = new Entities.VolDefinition();
                        vol.Id = sdr.GetInt32(sdr.GetOrdinal("ID_VOL"));
                        vol.CIE = sdr.GetString(sdr.GetOrdinal("Compagnie"));
                        vol.Ligne = sdr.GetString(sdr.GetOrdinal("NumLigne"));
                        vol.Date = sdr.GetDateTime(sdr.GetOrdinal("Date"));
                        //vol.parking = sdr.GetInt32(sdr.GetOrdinal("Parking"));
                        //vol.statut = sdr.GetInt32(sdr.GetOrdinal("Statut"));
                        //vol.idRessource = sdr.GetInt32(sdr.GetOrdinal("idRessource"));
                        //vol.origineCreation = sdr.GetInt32(sdr.GetOrdinal("OrigineDeCreation"));

                    }
                }
            }
            return vol;
        }

        public override List<Entities.VolDefinition> GetVols(Entities.VolCriteres criteres)
        {
            throw new NotImplementedException();
        }

        public override Entities.BagageDefinition GetBagage(int idBagage)
        {
            throw new NotImplementedException();
        }

        public override List<Entities.BagageDefinition> GetBagages(Entities.BagageCriteres criteres)
        {
            throw new NotImplementedException();
        }
    }
}
