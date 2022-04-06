using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCapemi
{
    class Articulo
    {
        public Int64 IdArticulo { get; set; }
        public String Codigo { get; set; }
        public String Descripcion { get; set; }
        public DateTime Lanzamiento { get; set; }
        public String OEM { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String DiamEx { get; set; }
        public String DiamInt { get; set; }
        public String Foto { get; set; }

        public Articulo() { }

        public Articulo(long pidArticulo, string pcodigo, string pdescripcion, DateTime planzamiento, string poEM, string pmarca, string pmodelo, string pdiamEx, string pdiamInt, string pfoto)
        {
            this.IdArticulo = pidArticulo;
            this.Codigo = pcodigo;
            this.Descripcion = pdescripcion;
            this.Lanzamiento = planzamiento;
            this.OEM = poEM;
            this.Marca = pmarca;
            this.Modelo = pmodelo;
            this.DiamEx = pdiamEx;
            this.DiamInt = pdiamInt;
            this.Foto = pfoto;
        }

        

        
    }
}
