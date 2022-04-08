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
    public partial class frmIngresoArticulo : Form
    {
        //Data Source=BIVAN\\CAPEMI_TEST;Initial Catalog=ListaVenta;Integrated Security=True
        //Data Source=localhost;Initial Catalog=ListaVenta;Integrated Security=True
        SqlConnection conexion = new SqlConnection("Data Source=BIVAN\\CAPEMI_TEST;Initial Catalog=ListaVenta;Integrated Security=True");
        SqlCommand cmd,cmd1;

        public frmIngresoArticulo()
        {
            InitializeComponent();
            this.cargar();
            this.cargarCategoria();
            this.cargarGrupo();


        }
        private void cargarCategoria()
        {

            cboCategoria.Items.Clear();
            conexion.Open();
            cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM CATEGORIAS";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cboCategoria.Items.Add(dr["CATEGORIA"].ToString());
            }
            conexion.Close();

        }

        private void cargarGrupo()
        {

            cboGrupo.Items.Clear();
            conexion.Open();
            cmd1 = conexion.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT * FROM GRUPO";
            cmd1.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cboGrupo.Items.Add(dr["GRUPO"].ToString());
            }
            conexion.Close();

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
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();

            adaptador.SelectCommand = comando;

            DataTable tabla = new DataTable();

            adaptador.Fill(tabla);
            dtgIngreso.DataSource = tabla;


        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Datos.Insert(txtCod.Text, txtDesc.Text, Convert.ToDateTime(dtpFecha.Text), txtOem.Text, txtMarca.Text,
                txtModelo.Text, txtDiamE.Text, txtDiamI.Text, txtLargoE.Text, txtLargoI.Text, ConvertImage.ImageToByteArray(pbIngresoArticulo.Image),
                Convert.ToInt32(txtAño.Text), txtPrecio.Text, Convert.ToInt32(txtCate.Text), Convert.ToInt32(txtGru.Text));
            this.cargar();

        }

        private void cboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd1 = new SqlCommand("SELECT * FROM GRUPO where GRUPO = '" + cboGrupo.Text + "'", conexion);

            conexion.Open();
            cmd1.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                string idMaq = (string)dr["ID_GRUPO"].ToString();
                txtGru.Text = idMaq;


            }

            conexion.Close();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmd = new SqlCommand("SELECT * FROM CATEGORIAS where CATEGORIA = '" + cboCategoria.Text + "'", conexion);

            conexion.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string idMaq = (string)dr["ID_CATEGORIA"].ToString();
                txtCate.Text = idMaq;


            }

            conexion.Close();
        }
    }
}
