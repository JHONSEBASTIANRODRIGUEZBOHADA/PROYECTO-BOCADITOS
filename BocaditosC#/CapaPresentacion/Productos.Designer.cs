namespace CapaPresentacion
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.btnminus = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TitleBar.Controls.Add(this.btnminus);
            this.TitleBar.Controls.Add(this.btnclose);
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(800, 50);
            this.TitleBar.TabIndex = 2;
            // 
            // btnminus
            // 
            this.btnminus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminus.Image = ((System.Drawing.Image)(resources.GetObject("btnminus.Image")));
            this.btnminus.Location = new System.Drawing.Point(721, 12);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(25, 25);
            this.btnminus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminus.TabIndex = 5;
            this.btnminus.TabStop = false;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btnclose
            // 
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Image = global::CapaPresentacion.Properties.Resources.reject;
            this.btnclose.Location = new System.Drawing.Point(752, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(25, 25);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclose.TabIndex = 4;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 13);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonEliminar);
            this.panel2.Controls.Add(this.buttonModificar);
            this.panel2.Controls.Add(this.buttonConsultar);
            this.panel2.Controls.Add(this.buttonIngresar);
            this.panel2.Location = new System.Drawing.Point(12, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 40);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(365, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 4;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEliminar.ForeColor = System.Drawing.Color.LightCoral;
            this.buttonEliminar.Location = new System.Drawing.Point(583, 3);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(188, 32);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar Producto";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModificar.ForeColor = System.Drawing.Color.LightCoral;
            this.buttonModificar.Location = new System.Drawing.Point(391, 3);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(188, 32);
            this.buttonModificar.TabIndex = 2;
            this.buttonModificar.Text = "Modificar Producto";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.buttonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConsultar.ForeColor = System.Drawing.Color.LightCoral;
            this.buttonConsultar.Location = new System.Drawing.Point(199, 3);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(188, 32);
            this.buttonConsultar.TabIndex = 1;
            this.buttonConsultar.Text = "Consultar Producto";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.buttonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIngresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIngresar.ForeColor = System.Drawing.Color.LightCoral;
            this.buttonIngresar.Location = new System.Drawing.Point(7, 3);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(188, 32);
            this.buttonIngresar.TabIndex = 0;
            this.buttonIngresar.Text = "Ingresar Producto";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(273, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gestión de productos";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelChildForm.Location = new System.Drawing.Point(12, 131);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(776, 290);
            this.panelChildForm.TabIndex = 9;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnminus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel TitleBar;
        private PictureBox btnminus;
        private PictureBox btnclose;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button buttonEliminar;
        private Button buttonModificar;
        private Button buttonConsultar;
        private Button buttonIngresar;
        private Panel panel3;
        private Panel panelChildForm;
    }
}