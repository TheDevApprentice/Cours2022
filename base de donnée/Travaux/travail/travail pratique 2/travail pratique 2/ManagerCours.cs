using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

using System.Data.SqlTypes;
namespace travail_pratique_2
{
    class ManagerCours : Manager
    {
        public SqlDataReader afficherInformationCours(int no_cours)
        {
            // déclarer une connexion on ne veut pas la fermer pour l'utilisation de datareader donc on n'utilise pas le using ici
            SqlConnection afficherInformationConnection = getConnexion();

            // déclarer une commande
            string sql = "afficherInformationCours"+ no_cours.ToString(); //Ici on rentre le code select que l'on a généré (voir après)// ici nous n'avons pas la table de la provenance quand j'aurais rempris le projet tout ira mieux mais pour l'instant on suit le cours 
                                                                                                             // dans sql manager faire une requete concepteur avec la table proveannce avec les teux colone trié et la proveancen en ordre croissant
            SqlCommand cmdAfficherInformationCours = new SqlCommand(sql, afficherInformationConnection);
            cmdAfficherInformationCours.CommandType = CommandType.StoredProcedure;
            // ouvrir une connexion 
            afficherInformationConnection.Open();
            // executer la commande

            SqlDataReader readerInformationCours = cmdAfficherInformationCours.ExecuteReader(CommandBehavior.CloseConnection);

            return readerInformationCours;
        }
        public SqlDataReader afficherLesCategories()
        {
            // déclarer une connexion on ne veut pas la fermer pour l'utilisation de datareader donc on n'utilise pas le using ici
            SqlConnection AfficherLesCategorieConnection = getConnexion();

            // déclarer une commande
            string sql = "afficherLesCategories"; //Ici on rentre le code select que l'on a généré (voir après)// ici nous n'avons pas la table de la provenance quand j'aurais rempris le projet tout ira mieux mais pour l'instant on suit le cours 
                                           // dans sql manager faire une requete concepteur avec la table proveannce avec les teux colone trié et la proveancen en ordre croissant
            SqlCommand cmdAfficherLesCategories = new SqlCommand(sql, AfficherLesCategorieConnection);
            cmdAfficherLesCategories.CommandType = CommandType.StoredProcedure;

            // ouvrir une connexion 
            AfficherLesCategorieConnection.Open();
            // executer la commande

            SqlDataReader readerDeCategorie = cmdAfficherLesCategories.ExecuteReader(CommandBehavior.CloseConnection);

            return readerDeCategorie;
        }
        public SqlDataReader afficherLesCours()
        {
            // déclarer une connexion on ne veut pas la fermer pour l'utilisation de datareader donc on n'utilise pas le using ici
            SqlConnection afficherLesCoursConnection = getConnexion();

            // déclarer une commande
            string sql = "afficherLesCours"; //Ici on rentre le code select que l'on a généré (voir après)// ici nous n'avons pas la table de la provenance quand j'aurais rempris le projet tout ira mieux mais pour l'instant on suit le cours 
                                           // dans sql manager faire une requete concepteur avec la table proveannce avec les teux colone trié et la proveancen en ordre croissant
            SqlCommand cmdAfficherLesCours = new SqlCommand(sql, afficherLesCoursConnection);
            cmdAfficherLesCours.CommandType = CommandType.StoredProcedure;

            // ouvrir une connexion 
            afficherLesCoursConnection.Open();
            // executer la commande

            SqlDataReader readerDeCours = cmdAfficherLesCours.ExecuteReader(CommandBehavior.CloseConnection);

            return readerDeCours;
        }
        public void ajouterCours(string nom_cours, string nbHeureDeCours, string mixte, int no_categorie)
        {
            using (SqlConnection ajoutConnection = getConnexion())
            {
                //créer ma commande
                string sql = "ajouterCours";
                SqlCommand cmd = new SqlCommand(sql, ajoutConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // creer des paramètres

                cmd.Parameters.Add("@nom_cours", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@nbHeureDeCours", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@mixte", SqlDbType.NVarChar, 10);
                cmd.Parameters.Add("@no_categorie", SqlDbType.Int);

                // donner valeur paramètre

                cmd.Parameters["@nom_cours"].Value = nom_cours;
                cmd.Parameters["@nbHeureDeCours"].Value = nbHeureDeCours;
                cmd.Parameters["@mixte"].Value = mixte;
                cmd.Parameters["@no_categorie"].Value = no_categorie;
                // ouvrir connexion 
                ajoutConnection.Open();
                //exectue la commande
                cmd.ExecuteNonQuery();
            }
        }
        public void modifierCours(int no_cours, string nom_cours, string nbHeureDeCours, string mixte, int no_categorie)
        {
            using (SqlConnection updateConnection = getConnexion())
            {
                //créer ma commande
                string sql = "modifierCours";
                SqlCommand cmd = new SqlCommand(sql, updateConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // creer des paramètres
                cmd.Parameters.Add("@no_cours", SqlDbType.Int);
                cmd.Parameters.Add("@nom_cours", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@nbHeureDeCours", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@mixte", SqlDbType.NVarChar, 10);
                cmd.Parameters.Add("@no_categorie", SqlDbType.Int);

                // donner valeur paramètre
                cmd.Parameters["@no_cours"].Value = no_cours;
                cmd.Parameters["@nom_cours"].Value = nom_cours;
                cmd.Parameters["@nbHeureDeCours"].Value = nbHeureDeCours;
                cmd.Parameters["@mixte"].Value = mixte;
                cmd.Parameters["@no_categorie"].Value = no_categorie;
                // ouvrir connexion 
                updateConnection.Open();
                //exectue la commande
                cmd.ExecuteNonQuery();
            }
        }
        public void detruireCours(int no_cours)
        {
            using (SqlConnection destroyConnection = getConnexion())
            {
                //créer ma commande
                string sql = "detruireCours";
                SqlCommand destroyCmd = new SqlCommand(sql, destroyConnection);
                destroyCmd.CommandType = System.Data.CommandType.StoredProcedure;

                // creer des paramètres

                destroyCmd.Parameters.Add("@no_cours", SqlDbType.Int);
        
                // donner valeur paramètre

                destroyCmd.Parameters["@no_cours"].Value = no_cours;
 
                // ouvrir connexion 
                destroyConnection.Open();
                //exectue la commande
                destroyCmd.ExecuteNonQuery();
            }
        }


        /**************/
        public void ajouterCategorie(string nom_categorie)
        {
            using (SqlConnection ajouterConnection = getConnexion())
            {
                //créer ma commande
                string sql = "ajouterCategorie";
                SqlCommand cmd = new SqlCommand(sql, ajouterConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // creer des paramètres

                cmd.Parameters.Add("@nom_categorie", SqlDbType.NChar, 50);


                // donner valeur paramètre

                cmd.Parameters["@nom_categorie"].Value = nom_categorie;

                // ouvrir connexion 
                ajouterConnection.Open();
                //exectue la commande
                cmd.ExecuteNonQuery();
            }
        }
        public void modifierCategorie(int no_categorie, string nom_categorie)
        {
            using (SqlConnection updateConnection = getConnexion())
            {
                //créer ma commande
                string sql = "modifierCategorie";
                SqlCommand cmd = new SqlCommand(sql, updateConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // creer des paramètres
                cmd.Parameters.Add("@no_categorie", SqlDbType.Int);
                cmd.Parameters.Add("@nom", SqlDbType.NChar, 50);
       

                // donner valeur paramètre

                cmd.Parameters["@no_etudiant"].Value = no_categorie;
                cmd.Parameters["@nom"].Value = nom_categorie;
  
                // ouvrir connexion 
                updateConnection.Open();
                //exectue la commande
                cmd.ExecuteNonQuery();
            }
        }
        public void detruireCategorie(int no_categorie)
        {
            using (SqlConnection detruireConnection = getConnexion())
            {
                //créer ma commande
                string sql = "detruireCategorie";
                SqlCommand cmd = new SqlCommand(sql, detruireConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // creer des paramètres

                cmd.Parameters.Add("@no_categorie", SqlDbType.Int);
           
                // donner valeur paramètre

                cmd.Parameters["@no_categorie"].Value = no_categorie;
 
   
                // ouvrir connexion 
                detruireConnection.Open();
                //exectue la commande
                cmd.ExecuteNonQuery();
            }
        }
       
    }
}
