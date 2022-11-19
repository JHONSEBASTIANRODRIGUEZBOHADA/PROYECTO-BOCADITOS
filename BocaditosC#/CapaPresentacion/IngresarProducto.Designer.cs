namespace CapaPresentacion
{
    partial class IngresarProducto
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
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.SeaShell;
            this.txtEstado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEstado.ForeColor = System.Drawing.Color.Black;
            this.txtEstado.Location = new System.Drawing.Point(247, 87);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(364, 26);
            this.txtEstado.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(159, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Estado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.SeaShell;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(247, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(364, 26);
            this.txtNombre.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(153, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.SeaShell;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.Location = new System.Drawing.Point(247, 127);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(364, 26);
            this.txtPrecio.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(169, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.SeaShell;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantidad.ForeColor = System.Drawing.Color.Black;
            this.txtCantidad.Location = new System.Drawing.Point(247, 165);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(364, 26);
            this.txtCantidad.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(143, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cantidad:";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.buttonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIngresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIngresar.ForeColor = System.Drawing.Color.LightCoral;
            this.buttonIngresar.Location = new System.Drawing.Point(176, 212);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(188, 32);
            this.buttonIngresar.TabIndex = 14;
            this.buttonIngresar.Text = "Guardar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(423, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IngresarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(776, 290);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresarProducto";
            this.Text = "IngresarProducto";
            this.Load += new System.EventHandler(this.IngresarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEstado;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtCantidad;
        private Label label4;
        private Button buttonIngresar;
        private Button button1;
    }
}