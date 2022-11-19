namespace CapaPresentacion
{
    partial class MDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.btnminus = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TitleBar.Controls.Add(this.btnminus);
            this.TitleBar.Controls.Add(this.btnclose);
            this.TitleBar.Location = new System.Drawing.Point(-1, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(1084, 50);
            this.TitleBar.TabIndex = 1;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // btnminus
            // 
            this.btnminus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminus.Image = ((System.Drawing.Image)(resources.GetObject("btnminus.Image")));
            this.btnminus.Location = new System.Drawing.Point(1001, 12);
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
            this.btnclose.Location = new System.Drawing.Point(1032, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(25, 25);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclose.TabIndex = 4;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(0, 774);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 13);
            this.panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúPrincipalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 50);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(242, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúPrincipalToolStripMenuItem
            // 
            this.menúPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem});
            this.menúPrincipalToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menúPrincipalToolStripMenuItem.ForeColor = System.Drawing.Color.LightCoral;
            this.menúPrincipalToolStripMenuItem.Name = "menúPrincipalToolStripMenuItem";
            this.menúPrincipalToolStripMenuItem.Size = new System.Drawing.Size(114, 21);
            this.menúPrincipalToolStripMenuItem.Text = "Menú Principal";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productosToolStripMenuItem.ForeColor = System.Drawing.Color.LightCoral;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(0, 546);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 13);
            this.panel2.TabIndex = 5;
            // 
            // MDI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI";
            this.Load += new System.EventHandler(this.MDI_Load);
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnminus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel TitleBar;
        private PictureBox btnminus;
        private PictureBox btnclose;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menúPrincipalToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private Panel panel2;
    }
}