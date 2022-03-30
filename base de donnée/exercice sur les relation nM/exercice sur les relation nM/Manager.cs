using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace exercice_sur_les_relation_nM
{
    class Manager
    {
        protected SqlConnection getConnexion() // permet d'acceder à get connexion seulement par l'héritage
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source= localhost ;Initial Catalog= AH_ecole ;Integrated Security=True";
            return connection;

        }
    }
}
