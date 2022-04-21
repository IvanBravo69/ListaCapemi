using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCapemi.Clases
{
    class CE_Marca
    {
        private CD_Marca objetoCD = new CD_Marca();

        public DataTable MostrarMarc()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarMarca();
            return tabla;
        }
        public void InsertarMar(string marca)
        {

            objetoCD.InsertarMarca(marca);
        }



    }
}
