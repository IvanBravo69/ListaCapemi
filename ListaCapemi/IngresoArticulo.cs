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
    public partial class IngresoArticulo : Form
    {
        public IngresoArticulo()
        {
            InitializeComponent();
            this.cargar();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivo JPG|*.jpg";

            if (file.ShowDialog() == DialogResult.OK)
            {
                pbIngresoArticulo.Image = Image.FromFile(file.FileName);
            }
        }
        private void cargar()
        {
            string query = "SELECT * FROM ARTICULO";
            SqlCommand comando = new SqlCommand(query, DBConexion.ObtnerCOnexion());
            SqlDataAdapter adaptador = new SqlDataAdapter();

            adaptador.SelectCommand = comando;

            DataTable tabla = new DataTable();

            adaptador.Fill(tabla);
            dtgIngreso.DataSource = tabla;
       




            /* dtgIngreso.AutoGenerateColumns = false;
           dtgIngreso.DataSource = Datos.Cargar();*/
            

           /* foreach (DataGridViewRow row in dtgIngreso.Rows)
            {
                row.Height = 100;
                DataRowView rows = row.DataBoundItem as DataRowView;
                row.Cells["FOTO_ART"].Value = ((byte[])rows["FOTO_ART"]);
            }*/

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Datos.Insert(txtCod.Text, txtDesc.Text, Convert.ToDateTime(dtpFecha.Text), txtCate.Text, txtOem.Text, txtMarca.Text,
                txtModelo.Text, txtDiamE.Text, txtDiamI.Text, txtLargoE.Text, txtLargoI.Text, ConvertImage.ImageToByteArray(pbIngresoArticulo.Image),
                Convert.ToInt32(txtAño.Text), txtPrecio.Text);
            this.cargar();

        }


    }
}
