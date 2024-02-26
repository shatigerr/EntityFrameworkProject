namespace EntityFrameworkProject.FORMS
{
    partial class FrmConsultaEdificios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cbContinente = new System.Windows.Forms.ComboBox();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.lbCont = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFiltres = new System.Windows.Forms.CheckBox();
            this.cbEnablePais = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.ShowEditingIcon = false;
            this.dgv.Size = new System.Drawing.Size(635, 563);
            this.dgv.TabIndex = 13;
            // 
            // cbContinente
            // 
            this.cbContinente.Enabled = false;
            this.cbContinente.FormattingEnabled = true;
            this.cbContinente.Location = new System.Drawing.Point(755, 12);
            this.cbContinente.Name = "cbContinente";
            this.cbContinente.Size = new System.Drawing.Size(121, 24);
            this.cbContinente.TabIndex = 14;
            this.cbContinente.SelectedValueChanged += new System.EventHandler(this.cbContinente_SelectedValueChanged);
            // 
            // cbPais
            // 
            this.cbPais.Enabled = false;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(755, 79);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(121, 24);
            this.cbPais.TabIndex = 15;
            this.cbPais.SelectedValueChanged += new System.EventHandler(this.cbPais_SelectedValueChanged);
            // 
            // lbCont
            // 
            this.lbCont.AutoSize = true;
            this.lbCont.ForeColor = System.Drawing.Color.White;
            this.lbCont.Location = new System.Drawing.Point(672, 15);
            this.lbCont.Name = "lbCont";
            this.lbCont.Size = new System.Drawing.Size(77, 16);
            this.lbCont.TabIndex = 16;
            this.lbCont.Text = "Continentes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(706, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pais";
            // 
            // cbFiltres
            // 
            this.cbFiltres.AutoSize = true;
            this.cbFiltres.Checked = true;
            this.cbFiltres.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFiltres.ForeColor = System.Drawing.Color.White;
            this.cbFiltres.Location = new System.Drawing.Point(820, 133);
            this.cbFiltres.Name = "cbFiltres";
            this.cbFiltres.Size = new System.Drawing.Size(56, 20);
            this.cbFiltres.TabIndex = 18;
            this.cbFiltres.Text = "Tots";
            this.cbFiltres.UseVisualStyleBackColor = true;
            this.cbFiltres.CheckedChanged += new System.EventHandler(this.cbFiltres_CheckedChanged);
            // 
            // cbEnablePais
            // 
            this.cbEnablePais.AutoSize = true;
            this.cbEnablePais.Checked = true;
            this.cbEnablePais.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEnablePais.ForeColor = System.Drawing.Color.White;
            this.cbEnablePais.Location = new System.Drawing.Point(894, 79);
            this.cbEnablePais.Name = "cbEnablePais";
            this.cbEnablePais.Size = new System.Drawing.Size(123, 20);
            this.cbEnablePais.TabIndex = 19;
            this.cbEnablePais.Text = "Buscar per pais";
            this.cbEnablePais.UseVisualStyleBackColor = true;
            this.cbEnablePais.CheckedChanged += new System.EventHandler(this.cbEnablePais_CheckedChanged);
            // 
            // FrmConsultaEdificios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1095, 587);
            this.Controls.Add(this.cbEnablePais);
            this.Controls.Add(this.cbFiltres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCont);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.cbContinente);
            this.Controls.Add(this.dgv);
            this.Name = "FrmConsultaEdificios";
            this.Text = "FrmConsultaEdificios";
            this.Load += new System.EventHandler(this.FrmConsultaEdificios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cbContinente;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Label lbCont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbFiltres;
        private System.Windows.Forms.CheckBox cbEnablePais;
    }
}