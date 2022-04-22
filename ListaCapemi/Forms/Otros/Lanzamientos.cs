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
        
        
        string sql, sql1, sql2, sql3, codigo;
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
            txtVolver.Hide();
            this.RegistroTabla();
        }

        private void btnVolverLanza_MouseMove(object sender, MouseEventArgs e)
        {
            txtVolver.Show();
            txtVolver.Text = "Ir al inicio";
        }

        private void btnVolverLanza_MouseLeave(object sender, EventArgs e)
        {
            txtVolver.Hide();
        }
        #endregion
        #region Formato Grilla
        private void SetearGrilla1()
        {
            DataGridViewColumn column = dtLanza.Columns[0];
            column.Width = 90;
            DataGridViewColumn column1 = dtLanza.Columns[1];
            column1.Width = 612;
            DataGridViewColumn column2 = dtLanza.Columns[2];
            column2.Width = 100;


        }
        private void SetearGrilla2()
        {
            DataGridViewColumn column4 = dtLanza1.Columns[0];
            column4.Width = 100;
            DataGridViewColumn column5 = dtLanza1.Columns[2];
            column5.Width = 280;
            DataGridViewColumn column6 = dtLanza1.Columns[3];
            column6.Width = 100;

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
            sql1 = "select TOP 1 OEM_,MARCA,MODELO,ANIO from ARTICULO,MARCA WHERE MARCA.ID_MARCA=ARTICULO.ID_MARCA";
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
            sql2 = "select OEM_,MARCA,MODELO,ANIO from ARTICULO,MARCA WHERE MARCA.ID_MARCA=ARTICULO.ID_MARCA AND CODIGO='" + codigo + "'";
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
            codigo = row.Cells["CODIGO"].Value.ToString();
        }
        private void RegistroTabla()
        {
            int registro = 0;
            registro = dtLanza.RowCount - 1;
            txtRegis.Text = registro.ToString();
        }
        #endregion
        #region Evento Grilla
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Hide(); return true;
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
            codigo = row.Cells["CODIGO"].Value.ToString();
            this.grillaDos();
            this.ObtenerFoto();
        }
        private void dtLanza_KeyUp(object sender, KeyEventArgs e)
        {
            DataGridViewRow row = dtLanza.CurrentRow;
            codigo = row.Cells["CODIGO"].Value.ToString();
            this.grillaDos();
            this.ObtenerFoto();
        }
        private void btnVolverLanza_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

    }
}
