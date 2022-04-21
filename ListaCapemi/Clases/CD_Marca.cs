using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCapemi.Clases
{
    class CD_Marca
    {
        private DBConexion conexion = new DBConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarMarca()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarMarca";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void InsertarMarca(string marca)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarMarca";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@MARCA", marca);
        


            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }


    }
}
