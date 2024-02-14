namespace EntityFrameworkProject
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edificiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.continentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edificiosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.menuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.menuMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(70, 450);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menu";
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gestionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edificiosToolStripMenuItem,
            this.paisesToolStripMenuItem,
            this.continentesToolStripMenuItem});
            this.gestionarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gestionarToolStripMenuItem.Image = global::EntityFrameworkProject.Properties.Resources.manageIcon;
            this.gestionarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gestionarToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(57, 54);
            this.gestionarToolStripMenuItem.Text = "Gestionar";
            // 
            // edificiosToolStripMenuItem
            // 
            this.edificiosToolStripMenuItem.Name = "edificiosToolStripMenuItem";
            this.edificiosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.edificiosToolStripMenuItem.Text = "Edificios";
            this.edificiosToolStripMenuItem.Click += new System.EventHandler(this.edificiosToolStripMenuItem_Click);
            // 
            // paisesToolStripMenuItem
            // 
            this.paisesToolStripMenuItem.Name = "paisesToolStripMenuItem";
            this.paisesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.paisesToolStripMenuItem.Text = "Paises";
            // 
            // continentesToolStripMenuItem
            // 
            this.continentesToolStripMenuItem.Name = "continentesToolStripMenuItem";
            this.continentesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.continentesToolStripMenuItem.Text = "Continentes";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edificiosToolStripMenuItem1});
            this.consultasToolStripMenuItem.Image = global::EntityFrameworkProject.Properties.Resources.lupa;
            this.consultasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.consultasToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(57, 54);
            // 
            // edificiosToolStripMenuItem1
            // 
            this.edificiosToolStripMenuItem1.Name = "edificiosToolStripMenuItem1";
            this.edificiosToolStripMenuItem1.Size = new System.Drawing.Size(148, 26);
            this.edificiosToolStripMenuItem1.Text = "Edificios";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.salirToolStripMenuItem.Image = global::EntityFrameworkProject.Properties.Resources.exit;
            this.salirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salirToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 54);
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuMain);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "FrmMain";
            this.Text = "Edificios Religiosos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edificiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edificiosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

