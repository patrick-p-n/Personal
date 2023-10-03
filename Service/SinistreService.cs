using monitor.Modele;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace monitor.Service
{
    public class SinistreService
    {
        public List<Sinistre> GetListeSinistreService()
        {
            List<Sinistre> sinistres = new List<Sinistre>();

             //String connectionString = "Data Source = FRAWIPDB001121.mpc.aon.net; Initial Catalog = CFE; Integrated Security = True";

            String connectionString = "Data Source = FRAWIQDB001016.mpc.aon.net; Initial Catalog = CFE; User ID = cfe_owner; Password = cfe_owner";
            using (var conn = new SqlConnection(connectionString))
            {
                using (var cmd = conn.CreateCommand()) // on crée la commande 
                {
                    // cmd.Parameters.AddWithValue();
                    conn.Open();

                    cmd.CommandText = @"	SELECT 			TAC_CODE,
					DateCreation,
					EtatDemande,
					libetat.libelle,
					NatureDemande,
					nat.libelleLong,
					Immatriculation, 
					contactMail,
					sin_lieu_ville	
	 FROM			CFE.CFE_ASS.ASS_DECLA_SINISTRE sini  JOIN
	   				CFE.CFE_ASS.ASS_DEMANDE  dem 
	  ON			sini.Demande_Id = dem.Demande_Id
					 INNER JOIN  [CFE].[CFE_SVC].[Etat_Demande] libetat 
						ON libetat.ID_Etat_Demande = dem.EtatDemande
	  				 INNER JOIN [CFE].[CFE_ASS].[ASS_NATUREDEMANDE]  nat 
	  					ON nat.enum =dem.natureDemande
	   ORDER BY 	DateCreation DESC";



                    //cmd.Parameters.AddWithValue("@id", index);
                    //utiliser cette ligne pour les filtres 
                    //guid type particulier (objet spécifique)

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Sinistre sinistre1 = new Sinistre();

                            //newsinistre1.SinistreId = reader.GetGuid(reader.GetOrdinal("SinistreId")).ToString();


                            //sinistre1.dateCreation = reader.GetString(reader.GetOrdinal("dateCreation"));

                            //sinistre1.dateCreation ="dateCreation);
                            //int ContratCode = reader.GetInt32(ContratCodePosition);
                            //newsinistre1.ContratatCode = ContratCode.ToString();
                            //reader.IsDBNull(reader.GetOrdinal(("contactMail")) ? null : (string?)/

                            sinistre1.TAC_CODE = reader.IsDBNull(reader.GetOrdinal("TAC_CODE")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("TAC_CODE"));
                            //sinistre1.TAC_CODE = reader.GetInt32(reader.GetOrdinal("TAC_CODE"));
                            sinistre1.DateCreation = reader.GetDateTime(reader.GetOrdinal("DateCreation"));
                            sinistre1.EtatDemande = reader.GetInt32(reader.GetOrdinal("EtatDemande"));
                            sinistre1.libelle = reader.GetString(reader.GetOrdinal("libelle"));
                            sinistre1.NatureDemande = reader.GetInt32(reader.GetOrdinal("NatureDemande"));
                            sinistre1.libelleLong = reader.GetString(reader.GetOrdinal("libelleLong"));
                            sinistre1.Immatriculation = reader.GetString(reader.GetOrdinal("Immatriculation"));
                            sinistre1.contactMail = reader.IsDBNull(reader.GetOrdinal("contactMail")) ? null : (string)reader.GetString(reader.GetOrdinal("contactMail"));
                           // sinistre1.sin_lieu_ville = reader.GetString(reader.GetOrdinal("sin_lieu_ville"));
                            sinistres.Add(sinistre1);
                            //learerLabel.Text = reader.GetString(reader.GetOrdinal("somecolumn")) 
                        }
                        return sinistres;
                    }
                }
            }
        }
    }
}
