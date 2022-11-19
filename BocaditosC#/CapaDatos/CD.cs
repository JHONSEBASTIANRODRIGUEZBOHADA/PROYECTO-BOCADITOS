using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CapaEntidad;
using System.Data;




namespace CapaDatos
{
    public class CD
    {

        string CadenaConexion = "server=localhost;User=root;Password=admin;Port=3306;database=bocaditos_bd;";



        public void CrearProducto(CE ce)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "INSERT INTO `producto` (`proNombre`, `proPrecio`, `proCantidad`, `proEstado`) VALUES ('" + ce.Nombre + "', '" + ce.Precio + "', '" + ce.Cantidad + "', '" + ce.Estado +"'"+");";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Se ha ingresado el producto.");
        }

        public DataSet ListarProductos()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "select * from `producto` limit 1000";
            MySqlDataAdapter Adaptador;
            DataSet dataSet = new DataSet();

            Adaptador = new MySqlDataAdapter(Query, mySqlConnection);
            Adaptador.Fill(dataSet, "tbl");
            return dataSet;

        }



        public void EditarProductos(CE ce)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "UPDATE `producto` SET `proNombre`= '" + ce.Nombre + "', `proPrecio`= '" + ce.Precio + "', `proCantidad`= '" + ce.Cantidad + "', `proEstado`= '" + ce.Estado + "' WHERE `proId` = " + ce.Id + ";";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Producto Actualizado.");

        }


        public void EliminarProductos(CE ce)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "Delete from `producto` where `proId` =" + ce.Id + ";";
            MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Producto Eliminado.");

        }




    }
}

