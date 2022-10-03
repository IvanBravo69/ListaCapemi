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

        #region Declariacion Variables
        private DBConexion conn = new DBConexion();
        string sql, sql1, sql2, sql3;
        internal static string codigo;
        SqlCommand cmd, cmd1, cmd2, cmd3, cmd4;
        SqlDataAdapter da, da1, da2, da3, da4;
        DataTable dt, dt1, dt3;




        #endregion
        #region Inicio Programa
        public frmListaPesados()
        {
            InitializeComponent();
        }

        private void ListaPesados_Load(object sender, EventArgs e)
        {
            this.grillaUnoP();

            this.txtAtrasPes.Hide();
            this.metodoApertura();

        }
        #endregion
        #region FormatoGrilla
        private void SetearGrilla()
        {
            DataGridViewColumn column = dgArticulosPesado.Columns[0];
            column.Width = 70;
            DataGridViewColumn column1 = dgArticulosPesado.Columns[1];
            column1.Width = 630;
            DataGridViewColumn column2 = dgArticulosPesado.Columns[2];
            column2.Width = 100;

        }
        private void SetearGrilla2()
        {
            DataGridViewColumn column4 = dgArticulosPesado2.Columns[0];
            column4.Width = 130;
            DataGridViewColumn column5 = dgArticulosPesado2.Columns[1];
            column5.Width = 250;
            DataGridViewColumn column6 = dgArticulosPesado2.Columns[2];
            column6.Width = 200;
        }
        #endregion
        #region Metodos
        private void metodoApertura()
        {
            sql = "select TOP 1 OEM_ as 'OEM',MODELO,MARCA from ARTICULO,MARCA" +
                " WHERE MARCA.ID_MARCA=ARTICULO.ID_MARCA AND ID_GRUPO=2";
            cmd4 = new SqlCommand(sql, conn.AbrirConexion());
            da4 = new SqlDataAdapter(cmd4);
            da4.SelectCommand = cmd4;
            dt3 = new DataTable();
            da4.Fill(dt3);
            dgArticulosPesado2.DataSource = dt3;
            this.SetearGrilla2();
            this.ObtenerFotoInicio();
            this.RegistroTabla();
        }
        private void grillaUnoP()
        {
            dgArticulosPesado.ReadOnly = true;
            sql1=("select CODIGO,DESCRIPCION,CATEGORIAS.CATEGORIA from ARTICULO,CATEGORIAS " +
                "WHERE CATEGORIAS.ID_CATEGORIA=ARTICULO.ID_CATEGORIA AND ID_GRUPO=2");
            cmd = new SqlCommand(sql1, conn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            dgArticulosPesado.DataSource = dt;
            this.SetearGrilla();
        }
        private void grillaDosP()
        {
            dgArticulosPesado2.ReadOnly = true;
            sql2 = "select OEM_ as'OEM',MODELO,MARCA from ARTICULO,MARCA " +
                "WHERE MARCA.ID_MARCA=ARTICULO.ID_MARCA AND ID_GRUPO=2 AND CODIGO='" + codigo + "'";
            cmd1 = new SqlCommand(sql2, conn.AbrirConexion());
            da1 = new SqlDataAdapter();
            da1.SelectCommand = cmd1;
            dt1 = new DataTable();
            da1.Fill(dt1);
            dgArticulosPesado2.DataSource = dt1;
            SetearGrilla2();
        }
        private void ObtenerFotoInicio()
        {

            sql3 = "select FOTO_ART from ARTICULO WHERE CODIGO='1975'";
            cmd3 = new SqlCommand(sql3, conn.AbrirConexion());
            da3 = new SqlDataAdapter(cmd3);
            DataSet ds = new DataSet("ARTICULO");
            byte[] MisDatos = new byte[0];

            da3.Fill(ds, "ARTICULO");

            DataRow myRow = ds.Tables["ARTICULO"].Rows[0];

            MisDatos = (byte[])myRow["FOTO_ART"];

            MemoryStream ms = new MemoryStream(MisDatos);

            pbPesado.Image = Image.FromStream(ms);


        }
        private void ObtenerFotoP()
        {

            try
            {
                sql2 = "select FOTO_ART from ARTICULO WHERE CODIGO='" + codigo + "'";

                cmd2 = new SqlCommand(sql2, conn.AbrirConexion());
                da2 = new SqlDataAdapter(cmd2);
                DataSet ds = new DataSet("ARTICULO");

                byte[] MisDatos = new byte[0];

                da2.Fill(ds, "ARTICULO");

                DataRow myRow = ds.Tables["ARTICULO"].Rows[0];

                MisDatos = (byte[])myRow["FOTO_ART"];

                MemoryStream ms = new MemoryStream(MisDatos);

                pbPesado.Image = Image.FromStream(ms);
            }
            catch (Exception)
            {
                /*DataGridViewRow row = dgArticulos.CurrentRow;
                int idFoto = Convert.ToInt32(row.Cells["CODIGO"].Value);

                sql3 = "select FOTO_ART from ARTICULO WHERE CODIGO='" + 1940/1 + "'";
                cmd3 = new SqlCommand(sql3, conn.AbrirConexion());
                da3 = new SqlDataAdapter(cmd3);
                DataSet ds = new DataSet("ARTICULO");
                byte[] MisDatos = new byte[0];

                da3.Fill(ds, "ARTICULO");

                DataRow myRow = ds.Tables["ARTICULO"].Rows[0];

                MisDatos = (byte[])myRow["FOTO_ART"];

                MemoryStream ms = new MemoryStream(MisDatos);

                pbA.Image = Image.FromStream(ms);*/
            }


        }
        private void capturDatoPesado()
        {
            DataGridViewRow row = dgArticulosPesado.CurrentRow;
            codigo = row.Cells["CODIGO"].Value.ToString();


        }
        private void RegistroTabla()
        {
            int registro =0;
            registro = dgArticulosPesado.RowCount-1;
            txtRegisP.Text = registro.ToString();
        }
        private void btnVolverLiv_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion
        #region Eventos de la Grilla
        private void dgArticulosPesado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                capturDatoPesado();
                ObtenerFotoP();
                grillaDosP();
                

            }
            catch (Exception)
            {
                return;
            }
        }
        private void btnVolverLiv_MouseLeave(object sender, EventArgs e)
        {
            txtAtrasPes.Hide();
        }
        private void btnVolverLiv_MouseMove(object sender, MouseEventArgs e)
        {
            txtAtrasPes.Show();
            txtAtrasPes.Text = "Ir al inicio";
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        
{
            if (keyData == Keys.Escape)
            {
                this.Hide(); return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }
        private void dgArticulosPesado_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridViewRow row = dgArticulosPesado.CurrentRow;
            codigo = row.Cells["CODIGO"].Value.ToString();
            ObtenerFotoP();
            grillaDosP();
            
        }
        private void dgArticulosPesado_KeyUp(object sender, KeyEventArgs e)
        {
            DataGridViewRow row = dgArticulosPesado.CurrentRow;
            codigo = row.Cells["CODIGO"].Value.ToString();
            ObtenerFotoP();
            grillaDosP();
            

        }
        #endregion

    }
}
