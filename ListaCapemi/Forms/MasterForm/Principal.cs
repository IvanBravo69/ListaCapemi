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
        #region Declaracion Variables
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-3MG0KL8;Initial Catalog=ListaVenta;Integrated Security=True");
        frmListaLiviana listaL = new frmListaLiviana();
        frmListaPesados listaP = new frmListaPesados();
        frmListaCompleta listaCom = new frmListaCompleta();
        frmIngresoArticulo Ing = new frmIngresoArticulo();
        frmLanzamientos lz = new frmLanzamientos();
        frmEmpresa em = new frmEmpresa();
        frmContacto cont = new frmContacto();
        internal static string datoArticulo,datoGrupo,datoMarca;
       
        #endregion
        #region InicioPrograma
        public frmPrincipal()
        {
            InitializeComponent();
            lbltextoArticulo.Hide();
            lblLineaPesada.Hide();
            lblLineaLiviana.Hide();
            btnAdmiArt.Show();
            btnVentas.Hide();
            this.cargarGrupo();
        }
        #endregion
        #region Metodos Programas
        private void CargarCbo()
        {
            SqlCommand comando_Clave = new SqlCommand("SELECT ID_ARTICULO,MARCA FROM ARTICULO",conexion);
            SqlDataReader registro_Clave = comando_Clave.ExecuteReader();
            while (registro_Clave.Read())
            {
                cboGrupo.Items.Add(registro_Clave["MARCA"]).ToString();        
            }            
        }
        private void cargarGrupo()
         {
                    cboGrupo.Items.Clear();
                    conexion.Open();
                    SqlCommand cmd = conexion.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM GRUPO";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        cboGrupo.Items.Add(dr["GRUPO"].ToString());
                    }
                    conexion.Close();
        }
        private void capturarCodigo()
        {
            
            
            txtGrupo.Text = datoGrupo;
           txtMarca.Text = datoMarca;
            
        }
        #endregion
        #region Botones Formulario
        private void btnVentas_Click(object sender, EventArgs e)
        {            
            listaCom.Show();
        }
        private void btnAdmiArt_Click(object sender, EventArgs e)
        {            
            Ing.Show();
        }
        private void btnLanzamiento_Click(object sender, EventArgs e)
        {            
            lz.Show();
        }
        private void btnEmpresa_Click(object sender, EventArgs e)
        {            
            em.Show();
        }
        private void btnMensaje_Click(object sender, EventArgs e)
        {            
            cont.Show();
        }
        #endregion
        #region Eventos
        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM GRUPO where GRUPO = '" + cboGrupo.Text + "'", conexion);
            conexion.Open();
            cmd1.ExecuteNonQuery();
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                string idMaq = (string)dr["ID_GRUPO"].ToString();
                txtGrupo.Text = idMaq;
            }
            conexion.Close();
        }

        private void btnLiv_Click(object sender, EventArgs e)
        {
            try
            {
                listaL.Show();
            }
            catch
            {
                return;
            }

                                    
        }
        private void btnLiv_MouseMove(object sender, MouseEventArgs e)
        {   
           lblLineaLiviana.Show();
           lblLineaLiviana.Text = "LINEA LIVIANA";
           
        }
        private void btnLiv_MouseLeave(object sender, EventArgs e)
        {
            lblLineaLiviana.Hide();
            
        }
        private void btnPes_Click(object sender, EventArgs e)
        {
            listaP.Show();
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
        private void btnFerr_MouseLeave(object sender, EventArgs e)
        {
            lbltextoArticulo.Hide();
        }
        private void btnFerr_MouseMove(object sender, MouseEventArgs e)
        {
            lbltextoArticulo.Show();
            lbltextoArticulo.Text = "LINEA FERROVIARIA";            
        }
        #endregion

        private void btnBuscarPrincipal_Click(object sender, EventArgs e)
        {
            capturarCodigo();
            Forms.Listas.ListaBusqueda lb = new Forms.Listas.ListaBusqueda();
            lb.Show();
            
        }
    }
}
