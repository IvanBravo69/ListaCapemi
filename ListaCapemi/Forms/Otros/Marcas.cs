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

namespace ListaCapemi.Forms.Otros
{
    public partial class Marcas : Form
    {
        CE_Marca objetoCN = new CE_Marca();
        private DBConexion conn = new DBConexion();        
        private bool Editar = false;

        public Marcas()
        {
            InitializeComponent();
            MostrarMar();
        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            MostrarMar();
        }
        private void MostrarMar()
        {

            CE_Marca objeto = new CE_Marca();
            dgvMarca.DataSource = objeto.MostrarMarc();
        }
        private void limpiarForm()
        {

            txtMarcaIns.Text = "";
         
        }


        private void btnGrabarMarca_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarMar(txtMarcaIns.Text);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarMar();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
         
        }
    }
}
