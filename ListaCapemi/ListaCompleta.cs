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
    public partial class frmListaCompleta : Form
    {
        public frmListaCompleta()
        {
            InitializeComponent();
           
        }

        private void frmListaCompleta_Load(object sender, EventArgs e)
        {
            cargar();
            SetupDataGridView();
        }
        private void cargar()
        {
            string query = "SELECT CODIGO,FOTO_ART,OEM_,DESCRIPCION,MARCA,MODELO,ANIO,PRECIO,DIAM_EXT,DIAM_INT,LARGO_EXT,LARGO_INT FROM ARTICULO";
            SqlCommand comando = new SqlCommand(query, DBConexion.ObtnerCOnexion());
            SqlDataAdapter adaptador = new SqlDataAdapter();

            adaptador.SelectCommand = comando;

            DataTable tabla = new DataTable();

            adaptador.Fill(tabla);
            dgListaCompleta.DataSource = tabla;

            DataGridViewColumn column = dgListaCompleta.Columns[0];
            column.Width = 60;

           DataGridViewColumn column1 = dgListaCompleta.Columns[1];
            column1.Width = 100;



        }

        private void SetupDataGridView()
        {
            this.Controls.Add(dgListaCompleta);

            

            dgListaCompleta.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgListaCompleta.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgListaCompleta.ColumnHeadersDefaultCellStyle.Font = new Font(dgListaCompleta.Font, FontStyle.Bold);

            dgListaCompleta.Name = "dgListaCompleta";
            dgListaCompleta.Location = new Point(8, 8);
            dgListaCompleta.Size = new Size(500, 500);
            
            dgListaCompleta.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            dgListaCompleta.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgListaCompleta.GridColor = Color.Black;
            dgListaCompleta.RowHeadersVisible = false;

            dgListaCompleta.Columns[0].Name = "CODIGO";
            dgListaCompleta.Columns[1].Name = "FOTO_ART";
            dgListaCompleta.Columns[1].DefaultCellStyle.Padding = new Padding(Padding.All);
            dgListaCompleta.Columns[2].Name = "OEM_";
            dgListaCompleta.Columns[3].Name = "DESCRIPCION";
            dgListaCompleta.Columns[4].Name = "MARCA";
            dgListaCompleta.Columns[4].DefaultCellStyle.Font =
                new Font(dgListaCompleta.DefaultCellStyle.Font, FontStyle.Italic);

            

            dgListaCompleta.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgListaCompleta.MultiSelect = false;
            dgListaCompleta.Dock = DockStyle.Fill;


        }
    }
}
