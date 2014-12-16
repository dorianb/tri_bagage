using MyAirport.Entities;
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
            List<VolDefinition> res = new List<VolDefinition>();
            VolDefinition vol;

            //Le using est utilisé pour délimiter la validité de l'objet
            //On garantit ici que la connexion sera fermée, il n'y a pas besoin d'utiliser un bloc try-catch !
            //L'objet connexion n'est pas déclaré en variable de classe pour s'assurer que plusieurs requêtes puissents s'exécutées en même temps
            using (SqlConnection cnx = new SqlConnection(strConnectionString))
            {
                var cmd = new SqlCommand();
                cmd.Connection = cnx;

                if (criteres.dateDebut == null) criteres.dateDebut = DateTime.Now.Date;
                if (criteres.dateFin == null) criteres.dateFin = DateTime.Now.Date.AddDays(1);

                if (criteres.Compagnies != null)
                {
                    cmd.CommandText = "SELECT VOL.ID_VOL, VOL.LIG, VOL.DHC, CIE.NOM_CIE FROM VOL INNER JOIN CIE ON VOL.ID_CIE=CIE.ID_CIE WHERE CIE.NOM_CIE IN (@Compagnies);";
                    string compagnies = "";
                    int i=0;
                    foreach(string cie in criteres.Compagnies)
                    {
                        if(i < criteres.Compagnies.Count-1)
                        {
                            compagnies = compagnies + cie + ", ";
                        }
                        else
                        {
                            compagnies = compagnies + cie;
                        }
                        i++;
                    }
                    cmd.Parameters.AddWithValue("@Compagnies", compagnies);
                }
                else
                {
                    cmd.CommandText = "SELECT VOL.ID_VOL, VOL.LIG, VOL.DHC, CIE.NOM_CIE FROM VOL INNER JOIN CIE ON VOL.ID_CIE=CIE.ID_CIE";
                }

                cnx.Open();

                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            vol = new VolDefinition();
                            vol.Id = sdr.GetInt32(sdr.GetOrdinal("id_vol"));
                            vol.CIE = sdr.GetString(sdr.GetOrdinal("NOM_CIE"));
                            vol.Ligne = sdr.GetString(sdr.GetOrdinal("LIG"));
                            vol.Date = sdr.GetDateTime(sdr.GetOrdinal("DHC"));
                            res.Add(vol);
                        }

                        sdr.NextResult();
                    }
                }

                return res;
            }
        }

        public override Entities.BagageDefinition GetBagage(int idBagage)
        {
            throw new NotImplementedException();
        }

        public override List<Entities.BagageDefinition> GetBagages(Entities.BagageCriteres criteres)
        {
            List<Entities.BagageDefinition> bagages = new List<BagageDefinition>();
            BagageDefinition bagage;

            using (SqlConnection cnx = new SqlConnection(strConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select top 10 b.id_bsm, b.code_iata, b.lige, b.typ, b.recol, b.emb, b.dat_cre, b.cnt, b.id_vol " + 
                    "from bsm b where b.id_vol=@idVol", cnx);

                cmd.Parameters.AddWithValue("@idVol", criteres.idVol);

                cnx.Open();

                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            bagage = new BagageDefinition();
                            bagage.Id = sdr.GetInt32(sdr.GetOrdinal("id_bsm"));
                            bagage.CodeIATA = sdr.GetString(sdr.GetOrdinal("code_iata"));
                            bagage.IdVol = sdr.GetInt32(sdr.GetOrdinal("id_vol"));
                            bagage.DateCreation = sdr.GetDateTime(sdr.GetOrdinal("dat_cre"));
                            bagages.Add(bagage);
                        }

                        sdr.NextResult();
                    }
                }
            }
            return bagages;
        }
    }
}
