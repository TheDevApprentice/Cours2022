using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace WA_exemple
{
    class ManagerEtudiant:Manager // hérite de manager
    {
        public void ajouterEtudiant(string prenom, string nom, int no_provenance)
        {
            using(SqlConnection connection = getConnexion())
            {
                //créer ma commande
                string sql = "dbo.ajouterEtudiant";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // creer des paramètres

                cmd.Parameters.Add("@nom", SqlDbType.NVarChar,50);
                cmd.Parameters.Add("@prenom", SqlDbType.NChar,50);
                cmd.Parameters.Add("@cellulaire", SqlDbType.NChar,13);
                cmd.Parameters.Add("@humour", SqlDbType.Int);
                cmd.Parameters.Add("@no_provenance", SqlDbType.Int);

                // donner valeur paramètre

                cmd.Parameters["@nom"].Value = nom;
                cmd.Parameters["@prenom"].Value = prenom;
                //cmd.Parameters["@cellulaire"].Value = cellulaire;
                //cmd.Parameters["@humour"].Value = humour;
                cmd.Parameters["@no_provenance"].Value = no_provenance;
                // ouvrir connexion 
                connection.Open();

                cmd.ExecuteNonQuery();

                

            }
        }
    }
}
