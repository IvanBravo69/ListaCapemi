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
        string guarda;
        string guardaC;
        
        public frmListaLiviana()
        {
            InitializeComponent();
        }
        //Metodo para cerrar formulario
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        { if (keyData == Keys.Escape)
            {
                this.Close(); return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }
        private void ListaLiviana_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'listaVentaDataSet.Articulo' Puede moverla o quitarla según sea necesario.

           this.grillaUno();
           this.SetearGrilla();
           this.lblBoton.Hide(); 
           this.textBox1.Hide();
  


        }
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

        private void grillaUno() {
                                   
            dgArticulos.ReadOnly = true;
            SqlCommand comando = new SqlCommand("select CODIGO,DESCRIPCION,CATEGORIAS.CATEGORIA from ARTICULO,CATEGORIAS " +
                "WHERE CATEGORIAS.ID_CATEGORIA=ARTICULO.ID_CATEGORIA AND ID_GRUPO=1", DBConexion.ObtnerCOnexion());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgArticulos.DataSource = tabla;

            this.metodoApertura();
       

        }
        private void metodoApertura()
        {
            string sql = "select OEM_,MARCA,MODELO,ANIO from ARTICULO WHERE ID_GRUPO=1 AND ID_ARTICULO=1";
            SqlCommand comando2 = new SqlCommand(sql, DBConexion.ObtnerCOnexion());
            SqlDataAdapter adaptador2 = new SqlDataAdapter();
            adaptador2.SelectCommand = comando2;
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dgArticulos2.DataSource = tabla2;


            SetearGrilla2();

            
        }
        private void grillaDos()
        {
            
            dgArticulos2.ReadOnly = true;
            string sql = "select OEM_,MARCA,MODELO,ANIO from ARTICULO WHERE ID_GRUPO=1  AND CODIGO='" + guarda +"'";
            SqlCommand comando2 = new SqlCommand(sql, DBConexion.ObtnerCOnexion());
            SqlDataAdapter adaptador2 = new SqlDataAdapter();
            adaptador2.SelectCommand = comando2;
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dgArticulos2.DataSource = tabla2;

            SetearGrilla2();
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

                pbA.Image = Image.FromStream(ms);
            }
            catch (Exception)
            {
                
            }

        }
        private void btnVolverLiv_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgArticulos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string codigo = this.dgArticulos.SelectedRows[0].Cells[0].Value.ToString();
                string descrp = this.dgArticulos.SelectedRows[0].Cells[1].Value.ToString();
                string lanza = this.dgArticulos.SelectedRows[0].Cells[2].Value.ToString();
                MessageBox.Show(
                    $"Codigo:{codigo}\nDescripcion:{descrp}\nLanzamiento:{lanza}","Informacion Adicional"
                    );
            }
            catch(Exception)
            {
                return;
            }

        }
        private void capturDato()
        {

            int contador = 0;
            guarda = dgArticulos.CurrentCell.Value.ToString();
            contador = guarda.Length;
             try
            {       if (contador >= 4)
                            {
                                guardaC = guarda.PadLeft(4, '0');
                            }
                else
                    if(contador==2 | contador == 3)
                {
                    guardaC = guarda.PadLeft(4, '0');
                }

                            {
                                return;
                       
                            } 
            }
            catch
            { 
                    textBox1.Text = guarda;
                
            }
          

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
    }
}