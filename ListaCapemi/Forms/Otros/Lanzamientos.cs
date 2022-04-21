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
    public partial class frmLanzamientos : Form
    {
        #region Declariacion Variables
        private DBConexion conn = new DBConexion();
        
        int codigo;
        string sql, sql1, sql2, sql3;
        SqlCommand cmd, cmd1,cmd3, cmd4;
        SqlDataAdapter da, da1,da3, da4;
        DataTable dt, dt1, dt3;
        #endregion
        #region Inicio Programa
        public frmLanzamientos()
        {
            InitializeComponent();
        }
        private void Lanzamientos_Load(object sender, EventArgs e)
        {
            this.grillaUno();
            this.metodoApertura();

        }
        
        #endregion
        #region Formato Grilla
        private void SetearGrilla1()
        {
            DataGridViewColumn column = dtLanza.Columns[0];
            column.Width = 70;
            DataGridViewColumn column1 = dtLanza.Columns[1];
            column1.Width = 585;
            DataGridViewColumn column2 = dtLanza.Columns[2];
            column2.Width = 100;


        }
        private void SetearGrilla2()
        {
            DataGridViewColumn column4 = dtLanza1.Columns[0];
            column4.Width = 180;
            DataGridViewColumn column5 = dtLanza1.Columns[2];
            column5.Width = 130;


        }
        #endregion
        #region Metodos
        private void grillaUno()
        {

            dtLanza.ReadOnly = true;
            sql = "select CODIGO,DESCRIPCION,LANZAMIENTO from ARTICULO  ORDER BY LANZAMIENTO DESC";
            cmd = new SqlCommand(sql, conn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            dtLanza.DataSource = dt;
            this.SetearGrilla1();


        }
        private void metodoApertura()
        {
            sql1 = "select TOP 1 OEM_,MODELO,ANIO from ARTICULO";
            cmd1 = new SqlCommand(sql1, conn.AbrirConexion());
            da1 = new SqlDataAdapter();
            da1.SelectCommand = cmd1;
            dt1 = new DataTable();
            da1.Fill(dt1);
            dtLanza1.DataSource = dt1;

            this.SetearGrilla2();
            this.ObtenerFoto();

        }
        private void grillaDos()
        {

            dtLanza1.ReadOnly = true;
            sql2 = "select OEM_,MARCA,MODELO,ANIO from ARTICULO WHERE CODIGO='" + codigo + "'";
            cmd4 = new SqlCommand(sql2, conn.AbrirConexion());
            da4 = new SqlDataAdapter(cmd4);
            da4.SelectCommand = cmd4;
            dt3 = new DataTable();
            da4.Fill(dt3);
            dtLanza1.DataSource = dt3;
            
            this.SetearGrilla2();

        }
        private void ObtenerFoto()
        {
            try
            {
                sql3 = "select FOTO_ART from ARTICULO WHERE CODIGO='" + codigo + "'";
                SqlCommand command = new SqlCommand(sql3, conn.AbrirConexion());
                SqlDataAdapter dp = new SqlDataAdapter(command);
                DataSet ds = new DataSet("ARTICULO");

                byte[] MisDatos = new byte[0];

                dp.Fill(ds, "ARTICULO");

                DataRow myRow = ds.Tables["ARTICULO"].Rows[0];

                MisDatos = (byte[])myRow["FOTO_ART"];

                MemoryStream ms = new MemoryStream(MisDatos);

                pbLanza.Image = Image.FromStream(ms);
            }
            catch (Exception)
            {
                DataGridViewRow row = dtLanza.CurrentRow;
                int idFoto = Convert.ToInt32(row.Cells["CODIGO"].Value);

                sql3 = "select FOTO_ART from ARTICULO WHERE CODIGO='" + idFoto + "'";
                cmd3 = new SqlCommand(sql3, conn.AbrirConexion());
                da3 = new SqlDataAdapter(cmd3);
                DataSet ds = new DataSet("ARTICULO");
                byte[] MisDatos = new byte[0];

                da3.Fill(ds, "ARTICULO");

                DataRow myRow = ds.Tables["ARTICULO"].Rows[0];

                MisDatos = (byte[])myRow["FOTO_ART"];

                MemoryStream ms = new MemoryStream(MisDatos);

                pbLanza.Image = Image.FromStream(ms);
            }

        }
        private void capturDato()
        {
            DataGridViewRow row = dtLanza.CurrentRow;
            codigo = Convert.ToInt32(row.Cells["CODIGO"].Value);
        }
        #endregion
        #region Evento Grilla
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close(); return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }
        private void dtLanza_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        private void dtLanza_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridViewRow row = dtLanza.CurrentRow;
            codigo = Convert.ToInt32(row.Cells["CODIGO"].Value);
            this.grillaDos();
            this.ObtenerFoto();
        }
        private void dtLanza_KeyUp(object sender, KeyEventArgs e)
        {
            DataGridViewRow row = dtLanza.CurrentRow;
            codigo = Convert.ToInt32(row.Cells["CODIGO"].Value);
            this.grillaDos();
            this.ObtenerFoto();
        }
        #endregion

    }
}
