using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void InsertarArticulos(string codigo, string descrip, DateTime lanza, string oem,string modelo, PictureBox foto,
             int cate, int grupo, int marca)
        {
            //PROCEDIMNIENTO

            cmd = new SqlCommand("Insert into ARTICULO(CODIGO,DESCRIPCION,LANZAMIENTO,OEM_,MODELO,FOTO_ART,ID_CATEGORIA,ID_GRUPO,ID_MARCA)" +
                " VALUES(@codigo, @descripcion, @lanzamiento, @oem_, @modelo, @foto, @id_cate, @id_grupo, @id_marca)", conexion.AbrirConexion());

            /*cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "InsertarArticulos";
            cmd.CommandType = CommandType.StoredProcedure;*/


            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Parameters.AddWithValue("@descripcion", descrip);
            cmd.Parameters.AddWithValue("@lanzamiento", lanza);
            cmd.Parameters.AddWithValue("@oem_", oem);
            cmd.Parameters.AddWithValue("@modelo", modelo);
            cmd.Parameters.Add("@foto", SqlDbType.Image);            
            cmd.Parameters.AddWithValue("@id_cate", cate);
            cmd.Parameters.AddWithValue("@id_grupo", grupo);
            cmd.Parameters.AddWithValue("@id_marca", marca);

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd.Parameters["@foto"].Value = ms.GetBuffer();

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

        }
    }
}
