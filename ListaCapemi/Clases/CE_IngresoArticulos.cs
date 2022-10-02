using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaCapemi.Clases
{
    class CE_IngresoArticulos
    {
        private CD_IngresoArticulos objetoCD = new CD_IngresoArticulos();

        public DataTable MostrarArticulos()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarArticulosIngreso();
            return tabla;
        }
            public void CE_InsertarArticulo(string codigo, 
                                            string descrip, 
                                            DateTime lanza, 
                                            string oem,
                                            string modelo,
                                            PictureBox foto,
                                            int cate, 
                                            int grupo, 
                                            int marca)
            {

                objetoCD.InsertarArticulos(
                                             codigo,
                                             descrip,
                                             lanza,
                                             oem,
                                             modelo,
                                             foto,
                                             cate,
                                             grupo,
                                             marca
                                                );
            }
        }
    }

