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
using ListaCapemi.Forms.Otros;
using MetroFramework;

namespace ListaCapemi
{
    public partial class frmListaLiviana : Form
    {
        #region Declariacion Variables
        private DBConexion conn = new DBConexion();
        string sql, sql1, sql2,sql4;
        internal static string codigo;
        SqlCommand cmd, cmd1, cmd2,cmd4;
        SqlDataAdapter da, da1, da2,da4;
        DataTable dt, dt1,dt3;
        #endregion
        #region Inicio Programa
        public frmListaLiviana()
        {
            InitializeComponent();
        }
        private void ListaLiviana_Load(object sender, EventArgs e)
        {
           this.grillaUno();
           this.metodoApertura();
           toolTip1.SetToolTip(pbA, "Presionar para agrandar imagen");
        }
        #endregion
        #region FormatoGrilla
        private void SetearGrilla()
        {
            DataGridViewColumn column = dgArticulos.Columns[0];
            column.Width = 70;
            DataGridViewColumn column1 = dgArticulos.Columns[1];
            column1.Width = 630; 
         }

        private void pbA_Click(object sender, EventArgs e)
        {
         
            Forms.Listas.ImgGrande imgs = new Forms.Listas.ImgGrande();
            imgs.Show();
        }

        private void SetearGrilla2()
        {
            DataGridViewColumn column4 = dgArticulos2.Columns[0];
            column4.Width = 130;
            DataGridViewColumn column5 = dgArticulos2.Columns[1];
            column5.Width = 250;
            DataGridViewColumn column6 = dgArticulos2.Columns[2];
            column6.Width = 200;

        }


        #endregion

        #region Metodos
        private void grillaUno() {
                                   
            dgArticulos.ReadOnly = true;
            sql =("select CODIGO,DESCRIPCION,CATEGORIAS.CATEGORIA from ARTICULO,CATEGORIAS " +
                "WHERE CATEGORIAS.ID_CATEGORIA=ARTICULO.ID_CATEGORIA AND ID_GRUPO=1");
            cmd = new SqlCommand(sql, conn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            dgArticulos.DataSource = dt;
            this.SetearGrilla();
                                 
        }
        private void grillaDos()
        {
            dgArticulos2.ReadOnly = true;
            sql1 = "select OEM_ as 'OEM',MODELO,MARCA from ARTICULO,MARCA WHERE MARCA.ID_MARCA=ARTICULO.ID_MARCA AND ID_GRUPO=1 AND CODIGO='" + codigo + "'";
            cmd1 = new SqlCommand(sql1, conn.AbrirConexion());
            da1 = new SqlDataAdapter();
            da1.SelectCommand = cmd1;
            dt1 = new DataTable();
            da1.Fill(dt1);
            dgArticulos2.DataSource = dt1;
            SetearGrilla2();
        }
        private void metodoApertura()
        {
            sql4 = "select TOP 1 OEM_ AS 'OEM',MODELO,MARCA from ARTICULO,MARCA" +
                " WHERE MARCA.ID_MARCA=ARTICULO.ID_MARCA AND ID_GRUPO=1";
            cmd4 = new SqlCommand(sql4, conn.AbrirConexion());
            da4 = new SqlDataAdapter(cmd4);
            da4.SelectCommand = cmd4;
            dt3 = new DataTable();
            da4.Fill(dt3);
            dgArticulos2.DataSource = dt3;
            this.SetearGrilla2();
            this.ObtenerFotoInicio();
            this.RegistroTabla();
        }
        private void ObtenerFotoInicio()
        {
            try
            {
                sql2 = "select FOTO_ART from ARTICULO WHERE CODIGO='1940/1'";

                cmd2 = new SqlCommand(sql2, conn.AbrirConexion());
                da2 = new SqlDataAdapter(cmd2);
                DataSet ds = new DataSet("ARTICULO");

                byte[] MisDatos = new byte[0];

                da2.Fill(ds, "ARTICULO");

                DataRow myRow = ds.Tables["ARTICULO"].Rows[0];

                MisDatos = (byte[])myRow["FOTO_ART"];

                MemoryStream ms = new MemoryStream(MisDatos);

                pbA.Image = Image.FromStream(ms);
            }
            catch (Exception)
            {

            }
         }
        private void ObtenerFoto()
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

                pbA.Image = Image.FromStream(ms);
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
        private void capturDato()
        {
            DataGridViewRow row = dgArticulos.CurrentRow;
            codigo = row.Cells["CODIGO"].Value.ToString();
         }
        private void RegistroTabla()
        {
            int registro=0;
            registro = dgArticulos.RowCount-1;
            txtRegis.Text = registro.ToString(); 
        }

        #endregion
        #region Eventos de la Grilla
        private void btnVolverLiv_Click(object sender, EventArgs e)
        {
            this.Hide();
        }        

        private void dgArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.capturDato();
                this.grillaDos();
                this.ObtenerFoto();

            }
            catch (Exception)
            {
                return;
            }
        }
        private void dgArticulos_KeyDown(object sender, KeyEventArgs e)
        {
                DataGridViewRow row = dgArticulos.CurrentRow;
                codigo = row.Cells["CODIGO"].Value.ToString();
                this.grillaDos();
                this.ObtenerFoto();
          }
        private void dgArticulos_KeyUp(object sender, KeyEventArgs e)
        {
                DataGridViewRow row = dgArticulos.CurrentRow;
                codigo = row.Cells["CODIGO"].Value.ToString();
                this.grillaDos();
                this.ObtenerFoto();
           }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Hide(); return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }
    }
        #endregion
}