using System.Data;
using System.Data.SqlClient;

namespace exercice_sur_les_relation_nM
{
    class ManagerEtudiant : Manager
    {

        public SqlDataReader AfficherLesInformationsDeEtudiant(int no_etudiant)
        {
            // déclarer une connexion on ne veut pas la fermer pour l'utilisation de datareader donc on n'utilise pas le using ici
            SqlConnection afficherInformationConnection = getConnexion();
            // déclarer une commande
            string sql = "afficherInformationCours "; //Ici on rentre le code select que l'on a généré (voir après)// ici nous n'avons pas la table de la provenance quand j'aurais rempris le projet tout ira mieux mais pour l'instant on suit le cours 
                                                      // dans sql manager faire une requete concepteur avec la table proveannce avec les teux colone trié et la proveancen en ordre croissant

            SqlCommand cmdAfficherInformationCours = new SqlCommand(sql, afficherInformationConnection);
            cmdAfficherInformationCours.CommandType = CommandType.StoredProcedure;
            // creer des paramètres
            cmdAfficherInformationCours.Parameters.Add("@no_cours", SqlDbType.Int);
            // donner valeur paramètre
            cmdAfficherInformationCours.Parameters["@no_cours"].Value = no_etudiant;
            // ouvrir une connexion 
            afficherInformationConnection.Open();
            // executer la commande

            SqlDataReader readerInformationCours = cmdAfficherInformationCours.ExecuteReader(CommandBehavior.CloseConnection);

            return readerInformationCours;
        }
        public SqlDataReader AfficherLesEtudiants()
        {
            // déclarer une connexion on ne veut pas la fermer pour l'utilisation de datareader donc on n'utilise pas le using ici
            SqlConnection listerEtudiantConnection = getConnexion();

            // déclarer une commande
            string sql = "listerEtudiant"; //Ici on rentre le code select que l'on a généré (voir après)// ici nous n'avons pas la table de la provenance quand j'aurais rempris le projet tout ira mieux mais pour l'instant on suit le cours 
                                           // dans sql manager faire une requete concepteur avec la table proveannce avec les teux colone trié et la proveancen en ordre croissant
            SqlCommand cmdListerEtudiant = new SqlCommand(sql, listerEtudiantConnection);
            cmdListerEtudiant.CommandType = CommandType.StoredProcedure;

            // ouvrir une connexion 
            listerEtudiantConnection.Open();
            // executer la commande

            SqlDataReader readerEtudiants = cmdListerEtudiant.ExecuteReader(CommandBehavior.CloseConnection);

            return readerEtudiants;
        }
        public SqlDataReader AfficherLesHobbys()
        {
            // déclarer une connexion on ne veut pas la fermer pour l'utilisation de datareader donc on n'utilise pas le using ici
            SqlConnection listerHobbyConnection = getConnexion();

            // déclarer une commande
            string sql = "listerHobbys"; //Ici on rentre le code select que l'on a généré (voir après)// ici nous n'avons pas la table de la provenance quand j'aurais rempris le projet tout ira mieux mais pour l'instant on suit le cours 
                                         // dans sql manager faire une requete concepteur avec la table proveannce avec les teux colone trié et la proveancen en ordre croissant
            SqlCommand cmdAfficherLesCours = new SqlCommand(sql, listerHobbyConnection);
            cmdAfficherLesCours.CommandType = CommandType.StoredProcedure;

            // ouvrir une connexion 
            listerHobbyConnection.Open();
            // executer la commande

            SqlDataReader readerDeHobbys = cmdAfficherLesCours.ExecuteReader(CommandBehavior.CloseConnection);

            return readerDeHobbys;
        }

        public void AssocierEtudiantHobby(int no_etudiant, int no_hobby)
        {
            using (SqlConnection AssocierEtudiantHobby = getConnexion())
            {
                //créer ma commande
                string sql = "associerEtudiantHobby";
                SqlCommand cmdAssocierEtudiantHobby = new SqlCommand(sql, AssocierEtudiantHobby);
                cmdAssocierEtudiantHobby.CommandType = System.Data.CommandType.StoredProcedure;

                // creer des paramètres

                cmdAssocierEtudiantHobby.Parameters.Add("@no_etudiant", SqlDbType.Int);
                cmdAssocierEtudiantHobby.Parameters.Add("@no_hobby", SqlDbType.Int);


                // donner valeur paramètre

                cmdAssocierEtudiantHobby.Parameters["@no_etudiant"].Value = no_etudiant;
                cmdAssocierEtudiantHobby.Parameters["@no_hobby"].Value = no_hobby;

                // ouvrir connexion 
                AssocierEtudiantHobby.Open();
                //exectue la commande
                cmdAssocierEtudiantHobby.ExecuteNonQuery();
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
                cmd.Parameters.Add("@nom_categorie", SqlDbType.NChar, 50);


                // donner valeur paramètre

                cmd.Parameters["@no_categorie"].Value = no_categorie;
                cmd.Parameters["@nom_categorie"].Value = nom_categorie;

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
