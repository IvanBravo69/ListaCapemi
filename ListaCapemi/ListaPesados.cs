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

namespace ListaCapemi
{
    public partial class frmListaPesados : Form
    {
        string guardaP;

        public frmListaPesados()
        {
            InitializeComponent();
        }

        private void ListaPesados_Load(object sender, EventArgs e)
        {
            this.grillaUnoP();
            this.SetearGrilla();
            txtPesado.Hide();
       
        }
        private void btnVolverLiv_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetearGrilla()
        {
            DataGridViewColumn column = dgArticulosPesado.Columns[0];
            column.Width = 70;
            DataGridViewColumn column1 = dgArticulosPesado.Columns[1];
            column1.Width = 630;
            DataGridViewColumn column2 = dgArticulosPesado.Columns[2];
            column2.Width = 100;

        }
        private void grillaUnoP()
        {



            dgArticulosPesado.ReadOnly = true;
            SqlCommand comando = new SqlCommand("select CODIGO,DESCRIPCION,CATEGORIAS.CATEGORIA from ARTICULO,CATEGORIAS " +
                "WHERE CATEGORIAS.ID_CATEGORIA=ARTICULO.ID_CATEGORIA AND ID_GRUPO=2", DBConexion.ObtnerCOnexion());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgArticulosPesado.DataSource = tabla;





        }
        private void grillaDosP()
        {
            dgArticulosPesado2.ReadOnly = true;
            string sql = "select OEM_,MARCA,MODELO,ANIO from ARTICULO WHERE ID_GRUPO=2 AND CODIGO='" + guardaP+"'";
            SqlCommand comandoPes = new SqlCommand(sql, DBConexion.ObtnerCOnexion());
            SqlDataAdapter adaptadorPes = new SqlDataAdapter();
            adaptadorPes.SelectCommand = comandoPes;
            DataTable tablaPes = new DataTable();
            adaptadorPes.Fill(tablaPes);
            dgArticulosPesado2.DataSource = tablaPes;

            //propiedades de grilla
            DataGridViewColumn column4 = dgArticulosPesado2.Columns[2];
            column4.Width = 250;
            DataGridViewColumn column5 = dgArticulosPesado2.Columns[0];
            column5.Width = 130;

        }
        private void ObtenerFotoP()
        {
            string sql = "select FOTO_ART from ARTICULO WHERE CODIGO='" + guardaP + "'";
            SqlCommand command = new SqlCommand(sql, DBConexion.ObtnerCOnexion());
            SqlDataAdapter dp = new SqlDataAdapter(command);
            DataSet ds = new DataSet("ARTICULO");

            byte[] MisDatos = new byte[0];

            dp.Fill(ds, "ARTICULO");

            DataRow myRow = ds.Tables["ARTICULO"].Rows[0];

            MisDatos = (byte[])myRow["FOTO_ART"];

            MemoryStream ms = new MemoryStream(MisDatos);

            pbPesado.Image = Image.FromStream(ms);
        }
            


        private void capturDatoPesado()
        {

            guardaP = dgArticulosPesado.CurrentCell.Value.ToString();
            txtPesado.Text = guardaP;


        }
        private void dgArticulosPesado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                capturDatoPesado();
                grillaDosP();
                ObtenerFotoP();

            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
