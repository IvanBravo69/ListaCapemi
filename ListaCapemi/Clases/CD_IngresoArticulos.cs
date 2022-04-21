using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCapemi.Clases
{
    class CD_IngresoArticulos
    {
        private DBConexion conexion = new DBConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable MostrarArticulosIngreso()
        {

            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "MostrarArticulosIngreso";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void InsertarArticulos(string codigo, string descrip, DateTime lanza, string oem,
            string modelo, string diamE, string diamIn, string largoEx, string largoInt, byte[] foto,
            int anio, string precio, int cate, int grupo, int marca)
        {
            //PROCEDIMNIENTO

            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "InsertarArticulos";
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@CODIGO", codigo);
            cmd.Parameters.AddWithValue("@DESCRIPCION", descrip);
            cmd.Parameters.AddWithValue("@LANZAMIENTO", lanza);
            cmd.Parameters.AddWithValue("@OEM_", oem);
            cmd.Parameters.AddWithValue("@MODELO", modelo);
            cmd.Parameters.AddWithValue("@DIAM_EXT", diamE);
            cmd.Parameters.AddWithValue("@DIAM_INT", diamIn);
            cmd.Parameters.AddWithValue("@LARGO_EXT", largoEx);
            cmd.Parameters.AddWithValue("@LARGO_IN", largoInt);
            cmd.Parameters.Add("@FOTO_ART", System.Data.SqlDbType.Image).Value = foto;
            cmd.Parameters.AddWithValue("@ANIO", anio);
            cmd.Parameters.AddWithValue("@PRECIO", precio);
            cmd.Parameters.AddWithValue("@CATEGORIA", cate);
            cmd.Parameters.AddWithValue("@GRUPO", grupo);
            cmd.Parameters.AddWithValue("@MARCA", marca);
                                          
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

        }
    }
}
