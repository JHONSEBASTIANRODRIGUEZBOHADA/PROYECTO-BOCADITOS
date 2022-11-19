using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN
    {

        CD cd = new CD();
        

        public void CrearPro(CE ce)
        {
            cd.CrearProducto(ce);
        }
        public DataSet ObtenerDatosPro()
        {
            return cd.ListarProductos();
        }

        public void EditarPro(CE ce)
        {
            cd.EditarProductos(ce);
        }

        public void EliminarPro(CE ce)
        {
            cd.EliminarProductos(ce);
        }


    }
}
