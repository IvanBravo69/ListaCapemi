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
    public partial class frmEmpresa : Form
    {

        SqlConnection conexion = new SqlConnection("Data Source=BIVAN\\CAPEMI_TEST;Initial Catalog=ListaVenta;Integrated Security=True");
        
        public frmEmpresa()
        {
            InitializeComponent();
            cargar();
            cargarText();
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
        private void cargar()
        {
            string query = "SELECT OBSERVACIONES AS 'A.GIACOMELLI S.A' FROM EMPRESA";
            SqlCommand comando = new SqlCommand(query,conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();

            adaptador.SelectCommand = comando;

            DataTable tabla = new DataTable();

            adaptador.Fill(tabla);
            dtgObserva.DataSource = tabla;

            DataGridViewColumn column = dtgObserva.Columns[0];
            column.Width = 430;



        }
        private void cargarText()
        {
            conexion.Open();
            SqlCommand com = new SqlCommand("SELECT [DIRECCION],[LOCALIDAD],[MAIL],[TELEFONO] FROM EMPRESA", conexion);
            SqlDataReader reg = com.ExecuteReader();
            if (reg.Read())
            {
                txtDir.Text = reg["DIRECCION"].ToString();
                txtLoca.Text = reg["LOCALIDAD"].ToString();
                txtMail.Text = reg["MAIL"].ToString();
                txtTel.Text = reg["TELEFONO"].ToString();
            }

            conexion.Close();

        }
    }
}
