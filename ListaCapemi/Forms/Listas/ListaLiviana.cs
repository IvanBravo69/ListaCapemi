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
    public partial class frmListaLiviana : Form
    {
        #region Declariacion Variables
        SqlConnection conn = DBConexion.ObtnerCOnexion();
        int codigo;
        string sql, sql1, sql2, sql3,sql4;
        SqlCommand cmd, cmd1, cmd2, cmd3,cmd4;
        SqlDataAdapter da, da1, da2, da3,da4;
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
           this.lblBoton.Hide(); 
           this.textBox1.Hide();
           this.metodoApertura();
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
        private void SetearGrilla2()
        {
            DataGridViewColumn column4 = dgArticulos2.Columns[2];
            column4.Width = 250;
            DataGridViewColumn column5 = dgArticulos2.Columns[0];
            column5.Width = 130;
        }
        #endregion
        #region Metodos
        private void grillaUno() {
                                   
            dgArticulos.ReadOnly = true;
            sql =("select CODIGO,DESCRIPCION,CATEGORIAS.CATEGORIA from ARTICULO,CATEGORIAS " +
                "WHERE CATEGORIAS.ID_CATEGORIA=ARTICULO.ID_CATEGORIA AND ID_GRUPO=1");
            cmd = new SqlCommand(sql, conn);
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
            sql1 = "select OEM_,MARCA,MODELO,ANIO from ARTICULO WHERE ID_GRUPO=1  AND CODIGO='" + codigo + "'";
            cmd1 = new SqlCommand(sql1, conn);
            da1 = new SqlDataAdapter();
            da1.SelectCommand = cmd1;
            dt1 = new DataTable();
            da1.Fill(dt1);
            dgArticulos2.DataSource = dt1;

            SetearGrilla2();
        }
        private void metodoApertura()
        {

            sql4 = "select TOP 1 OEM_,MARCA,MODELO,ANIO from ARTICULO WHERE ID_GRUPO=1";
            cmd4 = new SqlCommand(sql4, conn);
            da4 = new SqlDataAdapter(cmd4);
            da4.SelectCommand = cmd4;
            dt3 = new DataTable();
            da4.Fill(dt3);
            dgArticulos2.DataSource = dt3;
            this.SetearGrilla2();
            this.ObtenerFoto();
        }
        private void ObtenerFoto()
        {
            try
            {
                sql2 = "select FOTO_ART from ARTICULO WHERE CODIGO='" + codigo + "'";

                cmd2 = new SqlCommand(sql2,conn);
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
                DataGridViewRow row = dgArticulos.CurrentRow;
                int idFoto = Convert.ToInt32(row.Cells["CODIGO"].Value);

                sql3 = "select FOTO_ART from ARTICULO WHERE CODIGO='" + idFoto + "'";
                cmd3 = new SqlCommand(sql3, conn);
                da3 = new SqlDataAdapter(cmd3);
                DataSet ds = new DataSet("ARTICULO");
                byte[] MisDatos = new byte[0];

                da3.Fill(ds, "ARTICULO");

                DataRow myRow = ds.Tables["ARTICULO"].Rows[0];

                MisDatos = (byte[])myRow["FOTO_ART"];

                MemoryStream ms = new MemoryStream(MisDatos);

                pbA.Image = Image.FromStream(ms);
            }

        }
        private void capturDato()
        {

            DataGridViewRow row = dgArticulos.CurrentRow;

            codigo = Convert.ToInt32(row.Cells["CODIGO"].Value);

            textBox1.Text = Convert.ToString(codigo);


        }
        #endregion
        #region Eventos de la Grilla
        private void btnVolverLiv_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void btnVolverLiv_MouseMove(object sender, MouseEventArgs e)
        {
            
                lblBoton.Show();
                lblBoton.Text = "Ir al inicio";
            
        }
        private void btnVolverLiv_MouseLeave(object sender, EventArgs e)
        {

                lblBoton.Hide();
            
        }
        private void dgArticulos_KeyDown(object sender, KeyEventArgs e)
        {


            
                DataGridViewRow row = dgArticulos.CurrentRow;
                codigo = Convert.ToInt32(row.Cells["CODIGO"].Value);
                textBox1.Text = Convert.ToString(codigo);
                this.grillaDos();
                this.ObtenerFoto();
          


        }
        private void dgArticulos_KeyUp(object sender, KeyEventArgs e)
        {

                DataGridViewRow row = dgArticulos.CurrentRow;
                codigo = Convert.ToInt32(row.Cells["CODIGO"].Value);
                textBox1.Text = Convert.ToString(codigo);
                this.grillaDos();
                this.ObtenerFoto();

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {

                DialogResult dialogResult = MessageBox.Show("Esta seguro de cerrar la ventana", "Atencion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }


            }
            return base.ProcessCmdKey(ref msg, keyData);

        }
    }
        #endregion
}