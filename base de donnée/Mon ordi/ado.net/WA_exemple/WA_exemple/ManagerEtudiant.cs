using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

using System.Data.SqlTypes;

namespace WA_exemple
{
    class ManagerEtudiant:Manager // hérite de manager
    {
        public SqlDataReader listeLespays()
        {
            // déclarer une connexion on ne veut pas la fermer pour l'utilisation de datareader donc on n'utilise pas le using ici
            SqlConnection connection = getConnexion();

            // déclarer une commande
            string sql = "SELECT no_provenance, nom_provenance FROM tbl_provenance ORDER BY nom_provenance"; //Ici on rentre le code select que l'on a généré (voir après)// ici nous n'avons pas la table de la provenance quand j'aurais rempris le projet tout ira mieux mais pour l'instant on suit le cours 
                                                                                                             // dans sql manager faire une requete concepteur avec la table proveannce avec les teux colone trié et la proveancen en ordre croissant
            SqlCommand cmdProvenance = new SqlCommand(sql, connection);

            // ouvrir une connexion 
            connection.Open();
            // executer la commande

            SqlDataReader readerDeProvenance = cmdProvenance.ExecuteReader(CommandBehavior.CloseConnection);

            return readerDeProvenance;
        }

        public void ajouterEtudiant(string prenom, string nom, string cellulaire, int humour, int no_provenance)
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
                cmd.Parameters["@cellulaire"].Value = cellulaire;
                cmd.Parameters["@humour"].Value = humour;
                cmd.Parameters["@no_provenance"].Value = no_provenance;
                // ouvrir connexion 
                connection.Open();
                //exectue la commande
                cmd.ExecuteNonQuery();

                

            }
        }

}
}
