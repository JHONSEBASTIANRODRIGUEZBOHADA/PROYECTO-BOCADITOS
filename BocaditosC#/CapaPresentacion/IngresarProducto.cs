using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class IngresarProducto : Form
    {
        CE ce = new CE();
        CN cn = new CN();
        public IngresarProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            
            ce.Estado = txtEstado.Text;
            ce.Nombre = txtNombre.Text;
            ce.Precio = int.Parse(txtPrecio.Text);
            ce.Cantidad = int.Parse(txtCantidad.Text);

            cn.CrearPro(ce);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEstado.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtCantidad.Text = string.Empty;

        }

        private void IngresarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
