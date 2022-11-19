using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE
    {


        //Producto
        public string Estado { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public int Id { get; set; }

        public string Consultar1 { get; set; }

        //Administrador
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
    }

}
