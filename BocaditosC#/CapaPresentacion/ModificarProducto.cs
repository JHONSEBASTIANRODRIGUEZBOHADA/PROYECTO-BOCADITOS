using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using MySql.Data.MySqlClient;

namespace CapaPresentacion
{
    public partial class ModificarProducto : Form
    {
        string CadenaConexion = "server=localhost;User=root;Password=admin;Port=3306;database=`bocaditos_bd`;";
        CE ce = new CE();
        CN cn = new CN();
        public ModificarProducto()
        {
            InitializeComponent();

                
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ce.Estado = txtEstado.Text;
            ce.Nombre = txtNombre.Text;
            ce.Precio = int.Parse(txtPrecio.Text);
            ce.Cantidad = int.Parse(txtCantidad.Text);
            ce.Id = int.Parse(txtId.Text);
            cn.EditarPro(ce);
            CargarDatos();
            

        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtId.Text = gridDatos.CurrentRow.Cells["proId"].Value.ToString();
            txtNombre.Text = gridDatos.CurrentRow.Cells["proNombre"].Value.ToString();
            txtPrecio.Text = gridDatos.CurrentRow.Cells["proPrecio"].Value.ToString();
            txtCantidad.Text = gridDatos.CurrentRow.Cells["proCantidad"].Value.ToString();
            txtEstado.Text = gridDatos.CurrentRow.Cells["proEstado"].Value.ToString();
        }

        private void CargarDatos()
        {
            gridDatos.DataSource = cn.ObtenerDatosPro().Tables["tbl"];
        }
    }
}
