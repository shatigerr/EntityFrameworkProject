namespace EntityFrameworkProject.FORMS
{
    partial class gestionEdificios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionEdificios));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.PictureBox();
            this.btDel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 24);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(667, 514);
            this.dgv.TabIndex = 0;
            // 
            // btAdd
            // 
            this.btAdd.Image = global::EntityFrameworkProject.Properties.Resources.add;
            this.btAdd.Location = new System.Drawing.Point(897, 47);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(63, 61);
            this.btAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btAdd.TabIndex = 3;
            this.btAdd.TabStop = false;
            // 
            // btDel
            // 
            this.btDel.Image = global::EntityFrameworkProject.Properties.Resources.trash;
            this.btDel.Location = new System.Drawing.Point(897, 133);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(63, 61);
            this.btDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btDel.TabIndex = 4;
            this.btDel.TabStop = false;
            // 
            // gestionEdificios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1053, 561);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "gestionEdificios";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Gestion Edificios";
            this.Load += new System.EventHandler(this.gestionEdificios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.PictureBox btAdd;
        private System.Windows.Forms.PictureBox btDel;
    }
}