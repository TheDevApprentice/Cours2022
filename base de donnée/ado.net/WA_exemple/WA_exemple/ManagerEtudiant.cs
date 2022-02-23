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
        public void ajouterEtudiant(string prenom, string nom, int age, string pays)
        {
            using(SqlConnection connection = getConnexion())
            {
                //créer ma commande
                string sql = "dbo.ajouterEtudiants";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // creer des paramètres

                cmd.Parameters.Add("@nom", SqlDbType.NVarChar,50);
                cmd.Parameters.Add("@prenom", SqlDbType.NChar,50);
                cmd.Parameters.Add("@age", SqlDbType.Int);
                cmd.Parameters.Add("@pays", SqlDbType.NChar,30) ;

                // donner valeur paramètre

                cmd.Parameters["@nom"].Value = nom;
                cmd.Parameters["@prenom"].Value = prenom;
                cmd.Parameters["@age"].Value = age;
                cmd.Parameters["@pays"].Value = pays;
                // ouvrir connexion 
                connection.Open();
                //exectue la commande
                cmd.ExecuteNonQuery();

                

            }
        }
    }
}
