using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCapemi
{
    class DBConexion
    {
        private SqlConnection ConexionV1 = new SqlConnection(@"Data Source=DESKTOP-3MG0KL8;Initial Catalog=ListaVenta;Integrated Security=True");


        public SqlConnection AbrirConexion()
        {
            if (ConexionV1.State == ConnectionState.Closed)
                ConexionV1.Open();
            return ConexionV1;
        }

        public SqlConnection CerrarConexion()
        {
            if (ConexionV1.State == ConnectionState.Open)
                ConexionV1.Close();
            return ConexionV1;
        }



     /*   public static SqlConnection ObtnerCOnexion()
        {
            
                SqlConnection Conn = new SqlConnection("Data Source=DESKTOP-3MG0KL8;Initial Catalog=ListaVenta;Integrated Security=True");
                Conn.Open();
                return Conn;
            
            
            {
                SqlConnection Conn1 = new SqlConnection("Data Source=localhost;Initial Catalog=ListaVenta;Integrated Security=True");
                Conn1.Open();
                return Conn1;
            }*/
              
    }
    
}



