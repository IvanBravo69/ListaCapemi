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
using ListaCapemi.Clases;
using MetroFramework.Forms;
using MetroFramework;

namespace ListaCapemi
{
    public partial class frmIngresoArticulo : MetroForm
    {
        //Data Source=BIVAN\\CAPEMI_TEST;Initial Catalog=ListaVenta;Integrated Security=True
        //Data Source=localhost;Initial Catalog=ListaVenta;Integrated Security=True
        SqlConnection conexion = new SqlConnection("Data Source=BIVAN\\CAPEMI_TEST;Initial Catalog=ListaVenta;Integrated Security=True");
        SqlCommand cmd,cmd1,cmd2,cmd3,cmd4,cmd5;
        CE_IngresoArticulos objetoCN = new CE_IngresoArticulos();
        string idCate,idGru,idMarca;
        private bool Editar = false;

        public frmIngresoArticulo()
        {
            InitializeComponent();
            this.cargar();
            this.cargarCategoria();
            this.cargarGrupo();
            this.cargarMarca();
            this.limpiarForm();
        }
        #region Metodos
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
        private void cargarMarca()
        {

            cboMarca.Items.Clear();
            conexion.Open();
            cmd2 = conexion.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT * FROM MARCA";
            cmd2.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cboMarca.Items.Add(dr["MARCA"].ToString());
            }
            conexion.Close();

        }
        private void limpiarForm() {

            txtCod.Text = "";
            txtDesc.Text = "";
            txtOem.Text = "";
            cboCategoria.SelectedIndex = 0;
            cboGrupo.SelectedIndex = 0;
            cboMarca.SelectedIndex = 0;            
            txtModelo.Text = "";
            txtAño.Text = "";
            txtPrecio.Text = "";
            txtDiamE.Text = "";
            txtDiamI.Text = "";
            txtLargoE.Text = "";
            txtLargoI.Text = "";
            dtpFecha.Text = "2000/01/01";
            pbIngresoArticulo.Image =Image.FromFile("F:\\Respaldo\\Héctor\\Fotos\\SinImagen.JPG");


        }
        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            Forms.Otros.Marcas ma = new Forms.Otros.Marcas();
            ma.Show();

        }
        #endregion
        #region Eventos Formulario
        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivo JPG|*.jpg";

            if (file.ShowDialog() == DialogResult.OK)
            {
                pbIngresoArticulo.Image = Image.FromFile(file.FileName);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    objetoCN.CE_InsertarArticulo(txtCod.Text, txtDesc.Text, Convert.ToDateTime(dtpFecha.Text), txtOem.Text, txtModelo.Text, txtDiamE.Text,
                txtDiamI.Text, txtLargoE.Text, txtLargoI.Text, ConvertImage.ImageToByteArray(pbIngresoArticulo.Image),
                Convert.ToInt32(txtAño.Text), txtPrecio.Text, Convert.ToInt32(idCate), Convert.ToInt32(idGru), Convert.ToInt32(idMarca));
                    MessageBox.Show("Se inserto correctamente");
                    cargar();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex);
                }
            }



        }
        private void cboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd3 = new SqlCommand("SELECT * FROM GRUPO where GRUPO = '" + cboGrupo.Text + "'", conexion);

            conexion.Open();
            cmd3.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd3.ExecuteReader();
            while (dr.Read())
            {
                idGru = (string)dr["ID_GRUPO"].ToString();
                
            }

            conexion.Close();
        }
        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmd4 = new SqlCommand("SELECT * FROM CATEGORIAS where CATEGORIA = '" + cboCategoria.Text + "'", conexion);

            conexion.Open();
            cmd4.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd4.ExecuteReader();
            while (dr.Read())
            {
                idCate = (string)dr["ID_CATEGORIA"].ToString();             
            }

            conexion.Close();
        }
        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd5 = new SqlCommand("SELECT * FROM MARCA where MARCA = '" + cboMarca.Text + "'", conexion);
            
            conexion.Open();
            cmd5.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd5.ExecuteReader();
            while (dr.Read())
            {
                 idMarca = (string)dr["ID_MARCA"].ToString();                
            }

            conexion.Close();
        }
        #endregion

    }
    
}
