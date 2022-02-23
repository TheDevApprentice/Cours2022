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
        public SqlDataReader listeLespays()
        {
            // déclarer une connexion on ne veut pas la fermer pour l'utilisation de datareader donc on n'utilise pas le using ici
            SqlConnection connection = getConnexion();

            // déclarer une commande
            string sql = ""; //Ici on rentre le code select que l'on a généré (voir après)// ici nous n'avons pas la table de la provenance quand j'aurais rempris le projet tout ira mieux mais pour l'instant on suit le cours 
                             // dans sql manager faire une requete concepteur avec la table proveannce avec les teux colone trié et la proveancen en ordre croissant
            SqlCommand cmdProvenance = new SqlCommand(sql, connection);

            // ouvrir une connexion 
            connection.Open();
            // executer la commande

            SqlDataReader readerDeCommande = cmdProvenance.ExecuteReader(CommandBehavior.CloseConnection);

            return readerDeCommande;
        }
        public void ajouterEtudiant(string prenom, string nom, int age, string pays)
        {
            using(SqlConnection connection = getConnexion()) // le using fermera la connexion
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
