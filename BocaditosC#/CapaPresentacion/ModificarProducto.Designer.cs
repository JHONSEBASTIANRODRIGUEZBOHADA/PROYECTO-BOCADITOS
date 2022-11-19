namespace CapaPresentacion
{
    partial class ModificarProducto
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
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gridDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGuardar.ForeColor = System.Drawing.Color.LightCoral;
            this.buttonGuardar.Location = new System.Drawing.Point(296, 246);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(188, 32);
            this.buttonGuardar.TabIndex = 17;
            this.buttonGuardar.Text = "Guardar Cambios";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.SeaShell;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.Location = new System.Drawing.Point(89, 38);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(88, 26);
            this.txtPrecio.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(11, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Precio:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.SeaShell;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(311, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(227, 26);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(217, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.SeaShell;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(89, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(88, 26);
            this.txtId.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(44, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "ID:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.SeaShell;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantidad.ForeColor = System.Drawing.Color.Black;
            this.txtCantidad.Location = new System.Drawing.Point(311, 38);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(90, 26);
            this.txtCantidad.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(207, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cantidad:";
            // 
            // gridDatos
            // 
            this.gridDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatos.Location = new System.Drawing.Point(67, 82);
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.RowTemplate.Height = 25;
            this.gridDatos.Size = new System.Drawing.Size(648, 154);
            this.gridDatos.TabIndex = 26;
            this.gridDatos.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(561, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.SeaShell;
            this.txtEstado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEstado.ForeColor = System.Drawing.Color.Black;
            this.txtEstado.Location = new System.Drawing.Point(630, 6);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(118, 26);
            this.txtEstado.TabIndex = 28;
            // 
            // ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(776, 290);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridDatos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarProducto";
            this.ShowIcon = false;
            this.Text = "ModificarProducto";
            this.Load += new System.EventHandler(this.ModificarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonGuardar;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtId;
        private Label label4;
        private TextBox txtCantidad;
        private Label label5;
        private DataGridView gridDatos;
        private Label label1;
        private TextBox txtEstado;
    }
}