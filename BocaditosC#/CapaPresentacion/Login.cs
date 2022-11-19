using System.Runtime.InteropServices;
using CapaNegocio;
using CapaDatos;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace CapaPresentacion
    
{
    public partial class Login : Form
    {
        
        CN cn = new CN();   
        CE ce = new CE();
        public Login()
        {
            InitializeComponent();
        }

        int m, mx, my;

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //para arrastrar la barra
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;

        }

       

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
          if(m==1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        //boton login
        private void button1_Click(object sender, EventArgs e)
        {
            ce.Usuario = textemail.Text;
            ce.Contraseña = textpassword.Text;
           ValidarCampos();
           
            

        }

        string CadenaConexion = "server=localhost;User=root;Password=admin;Port=3306;database= bocaditos_bd;";

        //Validar campos y hacer conexion con mysql en el boton login
        private void ValidarCampos()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);

            try
            {
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse" + ex.Message);
                return;

            }
            MySqlCommand command = new MySqlCommand("SELECT usuCorreo, usuContraseña from usuario WHERE usuCorreo = '"+ ce.Usuario +"' AND usuContraseña = '"+ce.Contraseña + "' and rolId_fk = 1; '", mySqlConnection);;
            

            MySqlDataReader lector = command.ExecuteReader();
            
            if (textemail.Text == "")
            {
                
                errorProvider1.SetError(textemail, "Digite su correo electronico");
            }
            
            if (textpassword.Text == "")
            {
                
                errorProvider1.SetError(textpassword, "Digite su contraseña");
            }
            
            if (lector.Read())
            {
                this.Hide();
                MDI mdi = new MDI();
                mdi.Show();
            }
            else
            {
                errorProvider1.SetError(button1, "Datos Invalidos");
            }

            
        }

    }
}