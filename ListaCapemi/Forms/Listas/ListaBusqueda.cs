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

namespace ListaCapemi.Forms.Listas
{
    public partial class ListaBusqueda : Form
    {
        private DBConexion conn = new DBConexion();
        string sql, sql1;
        SqlCommand cmd, cmd1;
        SqlDataAdapter da, da1;
        DataTable dt, dt1;

        private void ListaBusqueda_Load(object sender, EventArgs e)
        {
            this.grillaUno();
            grillaDos();
            toolTip1.SetToolTip(pbusqueda, "Presionar para agrandar imagen");
        }
        private void SetearGrilla()
        {
            DataGridViewColumn column = dgArticulosBusqueda.Columns[0];
            column.Width = 70;
            DataGridViewColumn column1 = dgArticulosBusqueda.Columns[1];
            column1.Width = 630;
        }

        private void SetearGrilla2()
        {
            DataGridViewColumn column4 = dgArticuloBusqueda2.Columns[0];
            column4.Width = 130;
            DataGridViewColumn column5 = dgArticuloBusqueda2.Columns[1];
            column5.Width = 250;
            DataGridViewColumn column6 = dgArticuloBusqueda2.Columns[2];
            column6.Width = 200;

        }
        private void grillaUno()
        {

            dgArticulosBusqueda.ReadOnly = true;
            sql = ("select CODIGO,DESCRIPCION,CATEGORIAS.CATEGORIA from ARTICULO,CATEGORIAS " +
                "WHERE CATEGORIAS.ID_CATEGORIA=ARTICULO.ID_CATEGORIA AND CODIGO='" + frmPrincipal.datoArticulo + "'");
            cmd = new SqlCommand(sql, conn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            dgArticulosBusqueda.DataSource = dt;
            this.SetearGrilla();

        }
        private void grillaDos()
        {
            dgArticuloBusqueda2.ReadOnly = true;
            sql1 = "select OEM_ as 'OEM',MODELO,MARCA from ARTICULO,MARCA WHERE MARCA.ID_MARCA=ARTICULO.ID_MARCA AND ID_GRUPO=1 AND CODIGO='" + frmPrincipal.datoArticulo + "'";
            cmd1 = new SqlCommand(sql1, conn.AbrirConexion());
            da1 = new SqlDataAdapter();
            da1.SelectCommand = cmd1;
            dt1 = new DataTable();
            da1.Fill(dt1);
            dgArticuloBusqueda2.DataSource = dt1;
            SetearGrilla2();
        }

        public ListaBusqueda()
        {
            InitializeComponent();
        }
    }
}
