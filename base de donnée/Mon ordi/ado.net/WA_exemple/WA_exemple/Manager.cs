using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace WA_exemple
{
    class Manager
    {
        protected SqlConnection getConnexion() // permet d'acceder à get connexion seulement par l'héritage
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source= DESKTOP-IKGTJB6 ;Initial Catalog=AH_ecole;Integrated Security=True";
            return connection; 

        }
    }
}
