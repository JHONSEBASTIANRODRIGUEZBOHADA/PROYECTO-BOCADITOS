namespace CapaPresentacion
{
    partial class EliminarProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gridDatos = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(70, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id:";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEliminar.ForeColor = System.Drawing.Color.LightCoral;
            this.buttonEliminar.Location = new System.Drawing.Point(298, 65);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(188, 32);
            this.buttonEliminar.TabIndex = 19;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.SeaShell;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(104, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(91, 26);
            this.txtId.TabIndex = 20;
            // 
            // gridDatos
            // 
            this.gridDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatos.Location = new System.Drawing.Point(70, 105);
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.RowTemplate.Height = 25;
            this.gridDatos.Size = new System.Drawing.Size(626, 173);
            this.gridDatos.TabIndex = 21;
            this.gridDatos.DoubleClick += new System.EventHandler(this.gridDatos_DoubleClick);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.SeaShell;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(440, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(256, 26);
            this.txtNombre.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(357, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre:";
            // 
            // EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(776, 290);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridDatos);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarProducto";
            this.Text = "EliminarProducto";
            this.Load += new System.EventHandler(this.EliminarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button buttonEliminar;
        public TextBox txtId;
        private DataGridView gridDatos;
        public TextBox txtNombre;
        private Label label2;
    }
}