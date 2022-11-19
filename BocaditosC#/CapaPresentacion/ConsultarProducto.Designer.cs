namespace CapaPresentacion
{
    partial class ConsultarProducto
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
            this.gridDatos = new System.Windows.Forms.DataGridView();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.buttonConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(154, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Producto:";
            // 
            // gridDatos
            // 
            this.gridDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatos.Location = new System.Drawing.Point(59, 97);
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.RowTemplate.Height = 25;
            this.gridDatos.Size = new System.Drawing.Size(649, 173);
            this.gridDatos.TabIndex = 16;
            // 
            // txtconsulta
            // 
            this.txtconsulta.BackColor = System.Drawing.Color.SeaShell;
            this.txtconsulta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtconsulta.ForeColor = System.Drawing.Color.Black;
            this.txtconsulta.Location = new System.Drawing.Point(246, 20);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(368, 26);
            this.txtconsulta.TabIndex = 17;
            // 
            // buttonConsulta
            // 
            this.buttonConsulta.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.buttonConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsulta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConsulta.ForeColor = System.Drawing.Color.LightCoral;
            this.buttonConsulta.Location = new System.Drawing.Point(288, 59);
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.Size = new System.Drawing.Size(188, 32);
            this.buttonConsulta.TabIndex = 18;
            this.buttonConsulta.Text = "Consultar";
            this.buttonConsulta.UseVisualStyleBackColor = true;
            this.buttonConsulta.Click += new System.EventHandler(this.buttonConsulta_Click);
            // 
            // ConsultarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(776, 290);
            this.Controls.Add(this.buttonConsulta);
            this.Controls.Add(this.txtconsulta);
            this.Controls.Add(this.gridDatos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarProducto";
            this.Text = "ConsultarProductos";
            this.Load += new System.EventHandler(this.ConsultarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView gridDatos;
        public TextBox txtconsulta;
        public Button buttonConsulta;
    }
}