﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ListaCapemi
{
    public partial class frmListaCompleta : MetroForm
    {
        private DBConexion conn = new DBConexion();
        public frmListaCompleta()
        {
            InitializeComponent();
           
        }

        private void frmListaCompleta_Load(object sender, EventArgs e)
        {
            cargar();
            SetupDataGridView();
        }
        private void cargar()
        {
            string query = "SELECT CODIGO,FOTO_ART,OEM_,DESCRIPCION,MARCA,MODELO,ANIO,PRECIO,DIAM_EXT,DIAM_INT,LARGO_EXT,LARGO_INT FROM ARTICULO";
            SqlCommand comando = new SqlCommand(query, conn.AbrirConexion());
            SqlDataAdapter adaptador = new SqlDataAdapter();

            adaptador.SelectCommand = comando;

            DataTable tabla = new DataTable();

            adaptador.Fill(tabla);
            dgListaCompleta.DataSource = tabla;

            DataGridViewColumn column = dgListaCompleta.Columns[0];
            column.Width = 70;
            DataGridViewColumn column1 = dgListaCompleta.Columns[3];
            column1.Width = 270;


        }

        private void SetupDataGridView()
        {
            this.Controls.Add(dgListaCompleta);

            

            dgListaCompleta.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgListaCompleta.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgListaCompleta.ColumnHeadersDefaultCellStyle.Font = new Font(dgListaCompleta.Font, FontStyle.Bold);

            dgListaCompleta.Name = "dgListaCompleta";
      
            
            dgListaCompleta.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            dgListaCompleta.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgListaCompleta.GridColor = Color.Black;
            dgListaCompleta.RowHeadersVisible = false;

            dgListaCompleta.Columns[0].Name = "CODIGO";
            dgListaCompleta.Columns[1].Name = "FOTO_ART";
            dgListaCompleta.Columns[2].Name = "OEM_";
            dgListaCompleta.Columns[3].Name = "DESCRIPCION";
            dgListaCompleta.Columns[4].Name = "MARCA";
            dgListaCompleta.Columns[4].DefaultCellStyle.Font =
                new Font(dgListaCompleta.DefaultCellStyle.Font, FontStyle.Italic);

            


          


        }
    }
}
