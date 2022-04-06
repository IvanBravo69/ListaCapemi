using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaCapemi
{
    public partial class FotoArticulo : Form
    {
        public FotoArticulo()
        {
            InitializeComponent();
        }

        private void FotoArticulo_Load(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select CODIGO,FOTO_ART from ARTICULO WHERE CODIGO BETWEEN '1000' AND '1001-1' AND CATEGORIA='Liviano'", DBConexion.ObtnerCOnexion());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            dgFotoArt.DataSource = tabla;



        }

        private void dgFotoArt_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*  if (((DataGridView)sender).Columns[e.ColumnIndex].Name == "Imagen")
              {

                  e.Value = (new Bitmap(Resources.ImagenUser)).GetThumbnailImage(17, 17, delegate { return false; }, System.IntPtr.Zero);
              }*/
        }
    }
}
