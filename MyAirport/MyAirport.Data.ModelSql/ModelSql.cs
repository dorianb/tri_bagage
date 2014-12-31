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
            VolDefinition vol = null;

            using (SqlConnection cnx = new SqlConnection(strConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select v.id_vol, c.nom_cie as Compagnie, v.lig as NumLigne, v.dhc as Date from Vol v " + 
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
            VolDefinition vol = null;

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
                    cmd.CommandText = "select v.id_vol, c.nom_cie as Compagnie, v.lig as NumLigne, v.dhc as Date from Vol v " + 
                        "inner join cie c on c.id_cie = v.id_cie where c.nom_cie in (@Compagnies)";
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
                    cmd.CommandText = "select v.id_vol, c.nom_cie as Compagnie, v.lig as NumLigne, v.dhc as Date from Vol v " +
                        "inner join cie c on c.id_cie = v.id_cie";
                }

                cnx.Open();

                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            vol = new Entities.VolDefinition();
                            vol.Id = sdr.GetInt32(sdr.GetOrdinal("ID_VOL"));
                            vol.CIE = sdr.GetString(sdr.GetOrdinal("Compagnie"));
                            vol.Ligne = sdr.GetString(sdr.GetOrdinal("NumLigne"));
                            vol.Date = sdr.GetDateTime(sdr.GetOrdinal("Date"));
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
            BagageDefinition bagage = null;

            using (SqlConnection cnx = new SqlConnection(strConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select b.id_bsm, b.code_iata, b.ciee, b.typ, b.recol, b.emb, b.dat_cre, b.cre, b.id_vol, p.description " +
                    "from bsm b left join a_pour_part a on b.id_bsm = a.id_bsm left join part_bsm p " +
                    "on a.id_part = p.id_part where b.id_bsm=@idBsm", cnx);

                cmd.Parameters.AddWithValue("@idBsm", idBagage);

                cnx.Open();

                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        bagage = new BagageDefinition();
                        bagage.Id = sdr.GetInt32(sdr.GetOrdinal("id_bsm"));
                        bagage.IdVol = sdr.GetInt32(sdr.GetOrdinal("id_vol"));
                        bagage.CodeIATA = sdr.GetString(sdr.GetOrdinal("code_iata"));
                        bagage.Ciee = sdr.GetString(sdr.GetOrdinal("ciee"));
                        bagage.Typ = sdr.GetString(sdr.GetOrdinal("typ"));
                        bagage.Recol = sdr.GetBoolean(sdr.GetOrdinal("recol"));
                        bagage.Emb = sdr.GetBoolean(sdr.GetOrdinal("emb"));
                        bagage.DateCreation = sdr.GetDateTime(sdr.GetOrdinal("dat_cre"));
                        bagage.Creation = sdr.GetString(sdr.GetOrdinal("cre"));

                        if (!sdr.IsDBNull(sdr.GetOrdinal("description")))
                        {
                            bagage.Description = sdr.GetString(sdr.GetOrdinal("description"));
                        }
                    }
                }
            }

            return bagage;
        }

        public override VolDefinition GetBagageVolAuDepart(int idBagage)
        {
            VolDefinition volAuDepart = null;

            using (SqlConnection cnx = new SqlConnection(strConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select v.id_vol, c.code_cie, v.lig, v.jex, b.aer_des from bsm b inner join vol v " +
                    "on b.id_vol = v.id_vol inner join cie c on v.id_cie = c.id_cie where b.id_bsm=@idBsm", cnx);

                cmd.Parameters.AddWithValue("@idBsm", idBagage);

                cnx.Open();

                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        volAuDepart = new VolDefinition();
                        volAuDepart.Id = sdr.GetInt32(sdr.GetOrdinal("id_vol"));
                        volAuDepart.CodeCIE = sdr.GetString(sdr.GetOrdinal("code_cie"));
                        volAuDepart.Ligne = sdr.GetString(sdr.GetOrdinal("lig"));
                        volAuDepart.Jex = sdr.GetInt16(sdr.GetOrdinal("jex"));
                        volAuDepart.Aer = sdr.GetString(sdr.GetOrdinal("aer_des"));
                    }
                }
            }

            return volAuDepart;
        }

        public override VolDefinition GetBagageVolContinuation(int idBagage)
        {
            VolDefinition volContinuation = null;

            using (SqlConnection cnx = new SqlConnection(strConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select b.cie, b.lig, b.jex, b.aer from bsm_vol_cnt b where b.id_bsm=@idBsm", cnx);

                cmd.Parameters.AddWithValue("@idBsm", idBagage);

                cnx.Open();

                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        volContinuation = new VolDefinition();
                        volContinuation.CodeCIE = sdr.GetString(sdr.GetOrdinal("cie"));
                        volContinuation.Ligne = sdr.GetString(sdr.GetOrdinal("lig"));
                        volContinuation.Jex = sdr.GetInt16(sdr.GetOrdinal("jex"));
                        volContinuation.Aer = sdr.GetString(sdr.GetOrdinal("aer"));
                    }
                }
            }

            return volContinuation;
        }

        public override VolDefinition GetBagageVolApport(int idBagage)
        {
            VolDefinition volApport = null;

            using (SqlConnection cnx = new SqlConnection(strConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select b.cie, b.lig, b.jex, b.aer from bsm_vol_apport b where b.id_bsm=@idBsm", cnx);

                cmd.Parameters.AddWithValue("@idBsm", idBagage);

                cnx.Open();

                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        volApport = new VolDefinition();
                        volApport.CodeCIE = sdr.GetString(sdr.GetOrdinal("cie"));
                        volApport.Ligne = sdr.GetString(sdr.GetOrdinal("lig"));
                        volApport.Jex = sdr.GetInt16(sdr.GetOrdinal("jex"));
                        volApport.Aer = sdr.GetString(sdr.GetOrdinal("aer"));
                    }
                }
            }

            return volApport;
        }

        public override List<TraceDefinition> GetBagageTracabilite(int idBagage)
        {
            List<TraceDefinition> trace = null;

            return trace;
        }

        public override List<Entities.BagageDefinition> GetBagages(Entities.BagageCriteres criteres)
        {
            List<Entities.BagageDefinition> bagages = new List<BagageDefinition>();
            BagageDefinition bagage = null;

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
