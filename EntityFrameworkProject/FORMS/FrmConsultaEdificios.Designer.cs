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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaEdificios));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cbContinente = new System.Windows.Forms.ComboBox();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.lbCont = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFiltres = new System.Windows.Forms.CheckBox();
            this.cbEnablePais = new System.Windows.Forms.CheckBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbResenya = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.btnMaps = new System.Windows.Forms.Button();
            this.btnWeb = new System.Windows.Forms.Button();
            this.btnWikipedia = new System.Windows.Forms.Button();
            this.lbUbicacion = new System.Windows.Forms.Label();
            this.lbCapacidad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbPais = new System.Windows.Forms.Label();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.pbGaleria = new System.Windows.Forms.PictureBox();
            this.lbSelectInfo = new System.Windows.Forms.Label();
            this.panelGrab = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGaleria)).BeginInit();
            this.panelGrab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Location = new System.Drawing.Point(12, 46);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.ShowEditingIcon = false;
            this.dgv.Size = new System.Drawing.Size(635, 563);
            this.dgv.TabIndex = 13;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // cbContinente
            // 
            this.cbContinente.Enabled = false;
            this.cbContinente.FormattingEnabled = true;
            this.cbContinente.Location = new System.Drawing.Point(97, 634);
            this.cbContinente.Name = "cbContinente";
            this.cbContinente.Size = new System.Drawing.Size(121, 24);
            this.cbContinente.TabIndex = 14;
            this.cbContinente.SelectedValueChanged += new System.EventHandler(this.cbContinente_SelectedValueChanged);
            // 
            // cbPais
            // 
            this.cbPais.Enabled = false;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(274, 634);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(121, 24);
            this.cbPais.TabIndex = 15;
            this.cbPais.SelectedValueChanged += new System.EventHandler(this.cbPais_SelectedValueChanged);
            // 
            // lbCont
            // 
            this.lbCont.AutoSize = true;
            this.lbCont.ForeColor = System.Drawing.Color.White;
            this.lbCont.Location = new System.Drawing.Point(14, 637);
            this.lbCont.Name = "lbCont";
            this.lbCont.Size = new System.Drawing.Size(77, 16);
            this.lbCont.TabIndex = 16;
            this.lbCont.Text = "Continentes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(234, 637);
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
            this.cbFiltres.Location = new System.Drawing.Point(430, 674);
            this.cbFiltres.Name = "cbFiltres";
            this.cbFiltres.Size = new System.Drawing.Size(111, 20);
            this.cbFiltres.TabIndex = 18;
            this.cbFiltres.Text = "Mostrar todos";
            this.cbFiltres.UseVisualStyleBackColor = true;
            this.cbFiltres.CheckedChanged += new System.EventHandler(this.cbFiltres_CheckedChanged);
            // 
            // cbEnablePais
            // 
            this.cbEnablePais.AutoSize = true;
            this.cbEnablePais.Checked = true;
            this.cbEnablePais.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEnablePais.Enabled = false;
            this.cbEnablePais.ForeColor = System.Drawing.Color.White;
            this.cbEnablePais.Location = new System.Drawing.Point(430, 637);
            this.cbEnablePais.Name = "cbEnablePais";
            this.cbEnablePais.Size = new System.Drawing.Size(114, 20);
            this.cbEnablePais.TabIndex = 19;
            this.cbEnablePais.Text = "Filtrar por pais";
            this.cbEnablePais.UseVisualStyleBackColor = true;
            this.cbEnablePais.CheckedChanged += new System.EventHandler(this.cbEnablePais_CheckedChanged);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.White;
            this.lbNombre.Location = new System.Drawing.Point(140, 3);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(101, 29);
            this.lbNombre.TabIndex = 20;
            this.lbNombre.Text = "Nombre";
            // 
            // lbResenya
            // 
            this.lbResenya.AutoSize = true;
            this.lbResenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResenya.ForeColor = System.Drawing.Color.White;
            this.lbResenya.Location = new System.Drawing.Point(8, 140);
            this.lbResenya.MaximumSize = new System.Drawing.Size(300, 200);
            this.lbResenya.Name = "lbResenya";
            this.lbResenya.Size = new System.Drawing.Size(66, 20);
            this.lbResenya.TabIndex = 21;
            this.lbResenya.Text = "Reseña";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(141, 47);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(55, 20);
            this.lbFecha.TabIndex = 22;
            this.lbFecha.Text = "Fecha";
            // 
            // btnMaps
            // 
            this.btnMaps.ForeColor = System.Drawing.Color.Black;
            this.btnMaps.Location = new System.Drawing.Point(12, 609);
            this.btnMaps.Name = "btnMaps";
            this.btnMaps.Size = new System.Drawing.Size(116, 23);
            this.btnMaps.TabIndex = 23;
            this.btnMaps.Text = "Google maps";
            this.btnMaps.UseVisualStyleBackColor = true;
            this.btnMaps.Click += new System.EventHandler(this.btnMaps_Click);
            // 
            // btnWeb
            // 
            this.btnWeb.ForeColor = System.Drawing.Color.Black;
            this.btnWeb.Location = new System.Drawing.Point(169, 609);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(117, 23);
            this.btnWeb.TabIndex = 24;
            this.btnWeb.Text = "Web";
            this.btnWeb.UseVisualStyleBackColor = true;
            this.btnWeb.Click += new System.EventHandler(this.btnWeb_Click);
            this.btnWeb.MouseLeave += new System.EventHandler(this.btnWeb_MouseLeave);
            this.btnWeb.MouseHover += new System.EventHandler(this.btnWeb_MouseHover);
            // 
            // btnWikipedia
            // 
            this.btnWikipedia.ForeColor = System.Drawing.Color.Black;
            this.btnWikipedia.Location = new System.Drawing.Point(317, 609);
            this.btnWikipedia.Name = "btnWikipedia";
            this.btnWikipedia.Size = new System.Drawing.Size(117, 23);
            this.btnWikipedia.TabIndex = 25;
            this.btnWikipedia.Text = "Wikipedia";
            this.btnWikipedia.UseVisualStyleBackColor = true;
            this.btnWikipedia.Click += new System.EventHandler(this.btnWikipedia_Click);
            // 
            // lbUbicacion
            // 
            this.lbUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUbicacion.ForeColor = System.Drawing.Color.White;
            this.lbUbicacion.Location = new System.Drawing.Point(291, 88);
            this.lbUbicacion.Name = "lbUbicacion";
            this.lbUbicacion.Size = new System.Drawing.Size(143, 51);
            this.lbUbicacion.TabIndex = 26;
            this.lbUbicacion.Text = "Ubicacion";
            // 
            // lbCapacidad
            // 
            this.lbCapacidad.AutoSize = true;
            this.lbCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapacidad.ForeColor = System.Drawing.Color.White;
            this.lbCapacidad.Location = new System.Drawing.Point(141, 88);
            this.lbCapacidad.Name = "lbCapacidad";
            this.lbCapacidad.Size = new System.Drawing.Size(88, 20);
            this.lbCapacidad.TabIndex = 27;
            this.lbCapacidad.Text = "Capacidad";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "<---";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(246, 567);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "--->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPais.ForeColor = System.Drawing.Color.White;
            this.lbPais.Location = new System.Drawing.Point(291, 47);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(42, 20);
            this.lbPais.TabIndex = 32;
            this.lbPais.Text = "Pais";
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.pbPortada);
            this.panelDetails.Controls.Add(this.btnWikipedia);
            this.panelDetails.Controls.Add(this.pbPreview);
            this.panelDetails.Controls.Add(this.lbCapacidad);
            this.panelDetails.Controls.Add(this.lbNombre);
            this.panelDetails.Controls.Add(this.pbGaleria);
            this.panelDetails.Controls.Add(this.lbUbicacion);
            this.panelDetails.Controls.Add(this.lbPais);
            this.panelDetails.Controls.Add(this.btnWeb);
            this.panelDetails.Controls.Add(this.btnMaps);
            this.panelDetails.Controls.Add(this.lbResenya);
            this.panelDetails.Controls.Add(this.button1);
            this.panelDetails.Controls.Add(this.lbFecha);
            this.panelDetails.Controls.Add(this.button2);
            this.panelDetails.Location = new System.Drawing.Point(653, 46);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(456, 648);
            this.panelDetails.TabIndex = 34;
            this.panelDetails.Visible = false;
            // 
            // pbPortada
            // 
            this.pbPortada.BackColor = System.Drawing.Color.Transparent;
            this.pbPortada.Location = new System.Drawing.Point(3, 3);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(132, 117);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPortada.TabIndex = 29;
            this.pbPortada.TabStop = false;
            // 
            // pbPreview
            // 
            this.pbPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbPreview.Location = new System.Drawing.Point(127, 427);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(197, 172);
            this.pbPreview.TabIndex = 33;
            this.pbPreview.TabStop = false;
            this.pbPreview.Visible = false;
            // 
            // pbGaleria
            // 
            this.pbGaleria.BackColor = System.Drawing.Color.Transparent;
            this.pbGaleria.Location = new System.Drawing.Point(12, 234);
            this.pbGaleria.Name = "pbGaleria";
            this.pbGaleria.Size = new System.Drawing.Size(422, 302);
            this.pbGaleria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGaleria.TabIndex = 28;
            this.pbGaleria.TabStop = false;
            // 
            // lbSelectInfo
            // 
            this.lbSelectInfo.AutoSize = true;
            this.lbSelectInfo.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbSelectInfo.Location = new System.Drawing.Point(691, 283);
            this.lbSelectInfo.Name = "lbSelectInfo";
            this.lbSelectInfo.Size = new System.Drawing.Size(359, 34);
            this.lbSelectInfo.TabIndex = 35;
            this.lbSelectInfo.Text = "Selecciona un edificio";
            // 
            // panelGrab
            // 
            this.panelGrab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.panelGrab.Controls.Add(this.pictureBox2);
            this.panelGrab.Controls.Add(this.pictureBox1);
            this.panelGrab.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGrab.Location = new System.Drawing.Point(0, 0);
            this.panelGrab.Name = "panelGrab";
            this.panelGrab.Size = new System.Drawing.Size(1120, 30);
            this.panelGrab.TabIndex = 36;
            this.panelGrab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGrab_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EntityFrameworkProject.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(1060, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EntityFrameworkProject.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(1146, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmConsultaEdificios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1120, 705);
            this.Controls.Add(this.panelGrab);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.cbEnablePais);
            this.Controls.Add(this.cbFiltres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCont);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.cbContinente);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbSelectInfo);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultaEdificios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmConsultaEdificios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGaleria)).EndInit();
            this.panelGrab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbResenya;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Button btnMaps;
        private System.Windows.Forms.Button btnWeb;
        private System.Windows.Forms.Button btnWikipedia;
        private System.Windows.Forms.Label lbUbicacion;
        private System.Windows.Forms.Label lbCapacidad;
        private System.Windows.Forms.PictureBox pbGaleria;
        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label lbSelectInfo;
        private System.Windows.Forms.Panel panelGrab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}