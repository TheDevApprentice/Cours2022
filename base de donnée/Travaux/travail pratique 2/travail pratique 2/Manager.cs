using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace travail_pratique_2
{
    class Manager
    {
        protected SqlConnection getConnexion() // permet d'acceder à get connexion seulement par l'héritage
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source= localhost ;Initial Catalog= Travail1bis ;Integrated Security=True";
            return connection;

        }

    }
}
