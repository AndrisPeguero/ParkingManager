using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitemaDeParqueos
{
    using System.Data.SqlClient;
    using System.Configuration;

    public class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            return new SqlConnection(cadena);
        }
    }
}