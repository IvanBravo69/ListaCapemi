using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaCapemi.Forms.Listas
{
    public partial class ImgGrande : Form
    {
        private DBConexion conn = new DBConexion();
        string sql2;
        SqlCommand  cmd2;
        SqlDataAdapter da2;
        public ImgGrande()
        {
            InitializeComponent();
            cargar();
        }
      
        private void cargar()
        {     
            
            sql2 = "select FOTO_ART from ARTICULO WHERE CODIGO='" + frmListaLiviana.codigo + "'";

            cmd2 = new SqlCommand(sql2, conn.AbrirConexion());
           da2 = new SqlDataAdapter(cmd2);
           DataSet ds = new DataSet("ARTICULO");

           byte[] MisDatos = new byte[0];

            da2.Fill(ds, "ARTICULO");

            DataRow myRow = ds.Tables["ARTICULO"].Rows[0];

            MisDatos = (byte[])myRow["FOTO_ART"];

            MemoryStream ms = new MemoryStream(MisDatos);

            pbImg.Image = Image.FromStream(ms);

                                             
        }

        
                

        
    }
}
