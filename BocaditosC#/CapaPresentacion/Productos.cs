using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        //int m, mx, my;

        //private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        //{
        //    m = 1;
        //    mx = e.X;
        //    my = e.Y;
        //}



        //private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (m == 1)
        //    {
        //        this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
        //    }
        //}



        //private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        //{
        //    m = 0;
        //}

        private void Productos_Load(object sender, EventArgs e)
        {

        }



        private void btnminus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new IngresarProducto());
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ConsultarProducto());
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ModificarProducto());
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EliminarProducto());
        }

        private Form activeform = null;
        private void OpenChildForm(Form ChildForm)
        {
            if(activeform != null)
            
                activeform.Close();
                activeform = ChildForm;
                    ChildForm.TopLevel = false;
                    ChildForm.FormBorderStyle = FormBorderStyle.None;
                ChildForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(ChildForm);
                panelChildForm.Tag = ChildForm;
                ChildForm.BringToFront();
                ChildForm.Show();
            
        }
    }
}
