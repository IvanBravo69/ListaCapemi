using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCapemi
{
    public sealed class DBConexion
    {
        public static SqlConnection ObtnerCOnexion()
        {
            /*SqlConnection Conn = new SqlConnection("connectionString");
            Conn.Open();*/

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.InitialCatalog = "ListaVenta";


           /* return Conn;*/
            //Trabajo//Data Source=BIVAN\\CAPEMI_TEST;Initial Catalog=ListaVenta;Integrated Security=True
            //Casa/Data Source=DESKTOP-3MG0KL8;Initial Catalog=ListaVenta;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False

        }

    }
}
