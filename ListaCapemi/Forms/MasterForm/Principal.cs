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
using ListaCapemi.Forms.Otros;

namespace ListaCapemi
{
    public partial class frmPrincipal : Form
    {

       

        public frmPrincipal()
        {
            InitializeComponent();
            lbltextoArticulo.Hide();
            lblLineaPesada.Hide();
            lblLineaLiviana.Hide();
            btnAdmiArt.Hide();
            btnVentas.Hide();
            this.CargarCbo();
        }

        private void CargarCbo()
        {
            SqlCommand comando_Clave = new SqlCommand("SELECT ID_ARTICULO,MARCA FROM ARTICULO",DBConexion.ObtnerCOnexion());
            
            SqlDataReader registro_Clave = comando_Clave.ExecuteReader();
            while (registro_Clave.Read())
            {
                cboMarca.Items.Add(registro_Clave["MARCA"]).ToString();
              

            }
           


        }
        private void btnLiv_Click(object sender, EventArgs e)
        {
            frmListaLiviana listaL= new frmListaLiviana();
            listaL.Show();
            
        }

        private void btnPes_Click(object sender, EventArgs e)
        {
            frmListaPesados listaP = new frmListaPesados();
            listaP.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmListaLiviana listaL = new frmListaLiviana();
            listaL.Show();
        }

        //EVENTOS MOUSE

        private void btnFerr_MouseMove(object sender, MouseEventArgs e)
        {
            lbltextoArticulo.Show();
            lbltextoArticulo.Text = "LINEA FERROVIARIA";
            
        }
        private void btnLiv_MouseMove(object sender, MouseEventArgs e)
                {   
                    lblLineaLiviana.Show();
                    lblLineaLiviana.Text = "LINEA LIVIANA";
                }
        private void btnFerr_MouseLeave(object sender, EventArgs e)
        {
            lbltextoArticulo.Hide();
        }
        private void btnLiv_MouseLeave(object sender, EventArgs e)
        {
            lblLineaLiviana.Hide();
            
        }
        private void btnPes_MouseLeave(object sender, EventArgs e)
        {
            lblLineaPesada.Hide();
        }
        private void btnPes_MouseMove(object sender, MouseEventArgs e)
        {
            lblLineaPesada.Show();
            lblLineaPesada.Text = "LINEA PESADA";
        }
        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

           DataSet ds = new DataSet();
            //indicamos la consulta en SQL y conexion sql
            SqlDataAdapter da = new SqlDataAdapter("SELECT MARCA FROM ARTICULO", DBConexion.ObtnerCOnexion());
            //se indica el nombre de la tabla
            da.Fill(ds, "ARTICULO");
            cboMarca.DataSource = ds.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            cboMarca.ValueMember = "MARCA";
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmListaCompleta listaCom = new frmListaCompleta();
            listaCom.Show();
        }

        private void btnAdmiArt_Click(object sender, EventArgs e)
        {
            frmIngresoArticulo Ing = new frmIngresoArticulo();
            Ing.Show();
        }

        private void btnLanzamiento_Click(object sender, EventArgs e)
        {
            frmLanzamientos lz = new frmLanzamientos();
            lz.Show();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            frmEmpresa em = new frmEmpresa();
            em.Show();
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            frmContacto cont = new frmContacto();
            cont.Show();
        }
    }
}
