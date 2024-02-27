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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.fadeTimer = new System.Windows.Forms.Timer(this.components);
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
            this.toolStripMenuItem1,
            this.gestionarToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(84, 450);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro;
            this.toolStripMenuItem1.Image = global::EntityFrameworkProject.Properties.Resources.menuHamburger;
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(5, 10, 0, 30);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 54);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gestionarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionarToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.gestionarToolStripMenuItem.Image = global::EntityFrameworkProject.Properties.Resources.manageIcon;
            this.gestionarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gestionarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gestionarToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(68, 54);
            this.gestionarToolStripMenuItem.Text = "Gestionar Edificios";
            this.gestionarToolStripMenuItem.ToolTipText = "Gestionar Edificios";
            this.gestionarToolStripMenuItem.Click += new System.EventHandler(this.edificiosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.salirToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.salirToolStripMenuItem.Image = global::EntityFrameworkProject.Properties.Resources.exit;
            this.salirToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salirToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(68, 54);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.consultasToolStripMenuItem.Image = global::EntityFrameworkProject.Properties.Resources.lupa;
            this.consultasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.consultasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.consultasToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(68, 54);
            this.consultasToolStripMenuItem.Text = "Hacer Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.edificiosToolStripMenuItem1_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.userToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.userToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userToolStripMenuItem.Image")));
            this.userToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.userToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(68, 64);
            this.userToolStripMenuItem.Text = "Usuario";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // time
            // 
            this.time.Enabled = true;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // fadeTimer
            // 
            this.fadeTimer.Interval = 5;
            this.fadeTimer.Tick += new System.EventHandler(this.fade_Tick);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.Text = "Edificios Religiosos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Timer fadeTimer;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
    }
}

