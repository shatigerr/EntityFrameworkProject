namespace EntityFrameworkProject.FORMS
{
    partial class FrmUsuarioReligion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioReligion));
            this.lbNom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lbReligion = new System.Windows.Forms.Label();
            this.cbEdificios = new System.Windows.Forms.ComboBox();
            this.btAccept = new System.Windows.Forms.Button();
            this.panelGrab = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelGrab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.ForeColor = System.Drawing.Color.White;
            this.lbNom.Location = new System.Drawing.Point(43, 46);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(62, 16);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Nombre";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(46, 65);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(194, 22);
            this.tbNom.TabIndex = 1;
            // 
            // lbReligion
            // 
            this.lbReligion.AutoSize = true;
            this.lbReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReligion.ForeColor = System.Drawing.Color.White;
            this.lbReligion.Location = new System.Drawing.Point(43, 130);
            this.lbReligion.Name = "lbReligion";
            this.lbReligion.Size = new System.Drawing.Size(115, 16);
            this.lbReligion.TabIndex = 2;
            this.lbReligion.Text = "Edificio favorito";
            // 
            // cbEdificios
            // 
            this.cbEdificios.FormattingEnabled = true;
            this.cbEdificios.Location = new System.Drawing.Point(46, 149);
            this.cbEdificios.Name = "cbEdificios";
            this.cbEdificios.Size = new System.Drawing.Size(194, 24);
            this.cbEdificios.TabIndex = 3;
            // 
            // btAccept
            // 
            this.btAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAccept.ForeColor = System.Drawing.Color.Black;
            this.btAccept.Location = new System.Drawing.Point(46, 283);
            this.btAccept.Name = "btAccept";
            this.btAccept.Size = new System.Drawing.Size(194, 37);
            this.btAccept.TabIndex = 25;
            this.btAccept.Text = "Aceptar";
            this.btAccept.UseVisualStyleBackColor = true;
            this.btAccept.Click += new System.EventHandler(this.btAccept_Click);
            // 
            // panelGrab
            // 
            this.panelGrab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.panelGrab.Controls.Add(this.pictureBox2);
            this.panelGrab.Controls.Add(this.pictureBox1);
            this.panelGrab.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGrab.Location = new System.Drawing.Point(0, 0);
            this.panelGrab.Name = "panelGrab";
            this.panelGrab.Size = new System.Drawing.Size(293, 30);
            this.panelGrab.TabIndex = 32;
            this.panelGrab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGrab_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EntityFrameworkProject.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(742, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EntityFrameworkProject.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(233, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmUsuarioReligion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(293, 358);
            this.Controls.Add(this.panelGrab);
            this.Controls.Add(this.btAccept);
            this.Controls.Add(this.cbEdificios);
            this.Controls.Add(this.lbReligion);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsuarioReligion";
            this.Text = "FrmUsuarioReligion";
            this.Load += new System.EventHandler(this.FrmUsuarioReligion_Load);
            this.panelGrab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lbReligion;
        private System.Windows.Forms.ComboBox cbEdificios;
        private System.Windows.Forms.Button btAccept;
        private System.Windows.Forms.Panel panelGrab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}