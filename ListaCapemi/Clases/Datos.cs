using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ListaCapemi
{
        

    class Datos
    {
        private DBConexion cone = new DBConexion();
        SqlCommand coman = new SqlCommand();
        public  DataTable Cargar()
        {
            
            string query = "SELECT CODIGO FROM ARTICULO";
            coman= new SqlCommand(query,cone.AbrirConexion());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = coman;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
                                         
        }
        
        /*public void Insert(string codigo, string descrip, DateTime lanza, string oem ,
            string modelo, string diamE, string diamIn, string largoEx, string largoInt,byte[] foto,
            int anio, string precio,int cate,int grupo,int marca)
        {
            
            {
               
                string query = "INSERT INTO ARTICULO([CODIGO],[DESCRIPCION],[LANZAMIENTO],[OEM_],[MODELO]," +
                    "[DIAM_EXT],[DIAM_INT],[LARGO_EXT],[LARGO_INT],[FOTO_ART],[ANIO],[PRECIO],[ID_CATEGORIA],[ID_GRUPO],[ID_MARCA])" +
                    " VALUES(@CODIGO,@DESCRIPCION,@LANZAMIENTO,@OEM_,@MODELO,@DIAM_EXT,@DIAM_INT,@LARGO_EXT," +
                    "@LARGO_IN,@FOTO_ART,@ANIO,@PRECIO,@CATEGORIA,@GRUPO,@MARCA)";
                SqlCommand cmd = new SqlCommand(query, cone.AbrirConexion());

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

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro Ingresado con Exito...");
                    cone.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }*/
    }
}
