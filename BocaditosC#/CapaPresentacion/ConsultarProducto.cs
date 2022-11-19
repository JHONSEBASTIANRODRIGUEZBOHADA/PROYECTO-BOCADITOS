using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CapaNegocio;
using CapaEntidad;
using CapaDatos;



namespace CapaPresentacion
{

    public partial class ConsultarProducto : Form
    {
        string CadenaConexion = "server=localhost;User=root;Password=admin;Port=3306;database=bocaditos_bd;";

        CE ce = new CE();
        CN cn = new CN();
        public ConsultarProducto()
        {
            InitializeComponent();
        }

        private void ConsultarProducto_Load(object sender, EventArgs e)
        {
            gridDatos.DataSource = cn.ObtenerDatosPro().Tables["tbl"];
            
        }

     

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            ce.Consultar1 = txtconsulta.Text;
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "select * from producto where proNombre LIKE ('" + ce.Consultar1 + "%')";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            mySqlDataAdapter.Fill(dataTable);
            gridDatos.DataSource = dataTable;
            mySqlConnection.Close();
        }
    }
}
