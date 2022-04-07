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
        string guarda;
        string guardaC;

        public frmLanzamientos()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close(); return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void Lanzamientos_Load(object sender, EventArgs e)
        {
            this.grillaUno();
            this.SetearGrilla1();
          
            this.txtLanza.Hide();
        }

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
        private void grillaUno()
        {

            dtLanza.ReadOnly = true;
            SqlCommand comando = new SqlCommand("select CODIGO,DESCRIPCION,LANZAMIENTO from ARTICULO  ORDER BY LANZAMIENTO DESC", DBConexion.ObtnerCOnexion());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtLanza.DataSource = tabla;

            this.metodoApertura();


        }
        private void metodoApertura()
        {
            string sql = "select OEM_,MARCA,MODELO,ANIO from ARTICULO WHERE LANZAMIENTO BETWEEN '2022-01-01'AND '2022-06-30'";
            SqlCommand comando2 = new SqlCommand(sql, DBConexion.ObtnerCOnexion());
            SqlDataAdapter adaptador2 = new SqlDataAdapter();
            adaptador2.SelectCommand = comando2;
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dtLanza1.DataSource = tabla2;
            this.SetearGrilla2();

            //poner la grilla en orden


            string sql1 = "select FOTO_ART from ARTICULO WHERE LANZAMIENTO='2022-04-06'";
            SqlCommand command = new SqlCommand(sql1, DBConexion.ObtnerCOnexion());
            SqlDataAdapter dp = new SqlDataAdapter(command);
            DataSet ds = new DataSet("ARTICULO");

            byte[] MisDatos = new byte[0];

            dp.Fill(ds, "ARTICULO");

            DataRow myRow = ds.Tables["ARTICULO"].Rows[0];

            MisDatos = (byte[])myRow["FOTO_ART"];

            MemoryStream ms = new MemoryStream(MisDatos);

            pbLanza.Image = Image.FromStream(ms);
        }
        private void grillaDos()
        {

            dtLanza1.ReadOnly = true;
            string sql = "select OEM_,MARCA,MODELO,ANIO from ARTICULO WHERE CODIGO='" + guarda + "'";
            SqlCommand comando2 = new SqlCommand(sql, DBConexion.ObtnerCOnexion());
            SqlDataAdapter adaptador2 = new SqlDataAdapter();
            adaptador2.SelectCommand = comando2;
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dtLanza1.DataSource = tabla2;

            //propiedades de grilla
            this.SetearGrilla2();

        }
        private void ObtenerFoto()
        {
            try
            {
                string sql = "select FOTO_ART from ARTICULO WHERE CODIGO='" + guarda + "'";
                SqlCommand command = new SqlCommand(sql, DBConexion.ObtnerCOnexion());
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

            }

        }

        private void capturDato()
        {

            int contador = 0;
            guarda = dtLanza.CurrentCell.Value.ToString();
            contador = guarda.Length;
            try
            {
                if (contador >= 4)
                {
                    guardaC = guarda.PadLeft(4, '0');
                }
                else
                if (contador == 2 | contador == 3)
                {
                    guardaC = guarda.PadLeft(4, '0');
                }

                {
                    return;

                }
            }
            catch
            {
                txtLanza.Text = guarda;

            }


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
    }
}
