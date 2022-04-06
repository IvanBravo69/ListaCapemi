using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCapemi
{
    class DBConexion
    {
        public static SqlConnection ObtnerCOnexion()
        {
            try
            {
                SqlConnection Conn = new SqlConnection("Data Source=BIVAN\\CAPEMI_TEST;Initial Catalog=ListaVenta;Integrated Security=True");
                Conn.Open();
                return Conn;
            }
            catch
            {
                SqlConnection Conn1 = new SqlConnection("Data Source=localhost;Initial Catalog=ListaVenta;Integrated Security=True");
                Conn1.Open();
                return Conn1;
            }
                
            

        }


    

    }
}
