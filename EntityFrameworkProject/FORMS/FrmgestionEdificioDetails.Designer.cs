namespace EntityFrameworkProject.FORMS
{
    partial class FrmgestionEdificioDetails
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbUbicacion = new System.Windows.Forms.TextBox();
            this.lbUbicacion = new System.Windows.Forms.Label();
            this.tbCapacidad = new System.Windows.Forms.TextBox();
            this.lbCapacidad = new System.Windows.Forms.Label();
            this.lbfecha = new System.Windows.Forms.Label();
            this.tbreligion = new System.Windows.Forms.TextBox();
            this.lbreligion = new System.Windows.Forms.Label();
            this.lbContinente = new System.Windows.Forms.Label();
            this.cbContinente = new System.Windows.Forms.ComboBox();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.lbPais = new System.Windows.Forms.Label();
            this.tbgoogleMaps = new System.Windows.Forms.TextBox();
            this.lbgoogleMaps = new System.Windows.Forms.Label();
            this.tbWikipedia = new System.Windows.Forms.TextBox();
            this.lbWikipedia = new System.Windows.Forms.Label();
            this.tbWeb = new System.Windows.Forms.TextBox();
            this.lbWeb = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btsubirimagen = new System.Windows.Forms.Button();
            this.btAccept = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbUrl = new System.Windows.Forms.GroupBox();
            this.gbLocation = new System.Windows.Forms.GroupBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.gbUrl.SuspendLayout();
            this.gbLocation.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.ForeColor = System.Drawing.Color.Black;
            this.lbId.Location = new System.Drawing.Point(38, 44);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(20, 16);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "ID";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(64, 41);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 22);
            this.tbId.TabIndex = 2;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(241, 41);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(203, 22);
            this.tbNombre.TabIndex = 4;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.ForeColor = System.Drawing.Color.Black;
            this.lbNombre.Location = new System.Drawing.Point(179, 44);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(56, 16);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre";
            // 
            // tbUbicacion
            // 
            this.tbUbicacion.Location = new System.Drawing.Point(81, 61);
            this.tbUbicacion.Name = "tbUbicacion";
            this.tbUbicacion.Size = new System.Drawing.Size(308, 22);
            this.tbUbicacion.TabIndex = 6;
            // 
            // lbUbicacion
            // 
            this.lbUbicacion.AutoSize = true;
            this.lbUbicacion.ForeColor = System.Drawing.Color.Black;
            this.lbUbicacion.Location = new System.Drawing.Point(7, 64);
            this.lbUbicacion.Name = "lbUbicacion";
            this.lbUbicacion.Size = new System.Drawing.Size(64, 16);
            this.lbUbicacion.TabIndex = 5;
            this.lbUbicacion.Text = "Direccion";
            // 
            // tbCapacidad
            // 
            this.tbCapacidad.Location = new System.Drawing.Point(89, 24);
            this.tbCapacidad.Name = "tbCapacidad";
            this.tbCapacidad.Size = new System.Drawing.Size(100, 22);
            this.tbCapacidad.TabIndex = 8;
            // 
            // lbCapacidad
            // 
            this.lbCapacidad.AutoSize = true;
            this.lbCapacidad.ForeColor = System.Drawing.Color.Black;
            this.lbCapacidad.Location = new System.Drawing.Point(9, 27);
            this.lbCapacidad.Name = "lbCapacidad";
            this.lbCapacidad.Size = new System.Drawing.Size(74, 16);
            this.lbCapacidad.TabIndex = 7;
            this.lbCapacidad.Text = "Capacidad";
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.ForeColor = System.Drawing.Color.Black;
            this.lbfecha.Location = new System.Drawing.Point(9, 75);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(123, 16);
            this.lbfecha.TabIndex = 9;
            this.lbfecha.Text = "Fecha construccion";
            // 
            // tbreligion
            // 
            this.tbreligion.Location = new System.Drawing.Point(293, 24);
            this.tbreligion.Name = "tbreligion";
            this.tbreligion.Size = new System.Drawing.Size(100, 22);
            this.tbreligion.TabIndex = 11;
            // 
            // lbreligion
            // 
            this.lbreligion.AutoSize = true;
            this.lbreligion.ForeColor = System.Drawing.Color.Black;
            this.lbreligion.Location = new System.Drawing.Point(230, 27);
            this.lbreligion.Name = "lbreligion";
            this.lbreligion.Size = new System.Drawing.Size(57, 16);
            this.lbreligion.TabIndex = 10;
            this.lbreligion.Text = "Religion";
            // 
            // lbContinente
            // 
            this.lbContinente.AutoSize = true;
            this.lbContinente.ForeColor = System.Drawing.Color.Black;
            this.lbContinente.Location = new System.Drawing.Point(6, 29);
            this.lbContinente.Name = "lbContinente";
            this.lbContinente.Size = new System.Drawing.Size(70, 16);
            this.lbContinente.TabIndex = 12;
            this.lbContinente.Text = "Continente";
            // 
            // cbContinente
            // 
            this.cbContinente.FormattingEnabled = true;
            this.cbContinente.Location = new System.Drawing.Point(82, 26);
            this.cbContinente.Name = "cbContinente";
            this.cbContinente.Size = new System.Drawing.Size(121, 24);
            this.cbContinente.TabIndex = 13;
            this.cbContinente.SelectedIndexChanged += new System.EventHandler(this.cbContinente_SelectedIndexChanged);
            this.cbContinente.SelectedValueChanged += new System.EventHandler(this.cbContinente_SelectedValueChanged);
            // 
            // cbPais
            // 
            this.cbPais.Enabled = false;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(267, 26);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(121, 24);
            this.cbPais.TabIndex = 15;
            this.cbPais.TextUpdate += new System.EventHandler(this.cbPais_TextUpdate);
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.ForeColor = System.Drawing.Color.Black;
            this.lbPais.Location = new System.Drawing.Point(227, 29);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(34, 16);
            this.lbPais.TabIndex = 14;
            this.lbPais.Text = "Pais";
            // 
            // tbgoogleMaps
            // 
            this.tbgoogleMaps.Location = new System.Drawing.Point(101, 26);
            this.tbgoogleMaps.Name = "tbgoogleMaps";
            this.tbgoogleMaps.Size = new System.Drawing.Size(100, 22);
            this.tbgoogleMaps.TabIndex = 17;
            // 
            // lbgoogleMaps
            // 
            this.lbgoogleMaps.AutoSize = true;
            this.lbgoogleMaps.ForeColor = System.Drawing.Color.Black;
            this.lbgoogleMaps.Location = new System.Drawing.Point(6, 29);
            this.lbgoogleMaps.Name = "lbgoogleMaps";
            this.lbgoogleMaps.Size = new System.Drawing.Size(89, 16);
            this.lbgoogleMaps.TabIndex = 16;
            this.lbgoogleMaps.Text = "Google Maps";
            // 
            // tbWikipedia
            // 
            this.tbWikipedia.Location = new System.Drawing.Point(292, 26);
            this.tbWikipedia.Name = "tbWikipedia";
            this.tbWikipedia.Size = new System.Drawing.Size(100, 22);
            this.tbWikipedia.TabIndex = 19;
            // 
            // lbWikipedia
            // 
            this.lbWikipedia.AutoSize = true;
            this.lbWikipedia.ForeColor = System.Drawing.Color.Black;
            this.lbWikipedia.Location = new System.Drawing.Point(218, 29);
            this.lbWikipedia.Name = "lbWikipedia";
            this.lbWikipedia.Size = new System.Drawing.Size(68, 16);
            this.lbWikipedia.TabIndex = 18;
            this.lbWikipedia.Text = "Wikipedia";
            // 
            // tbWeb
            // 
            this.tbWeb.Location = new System.Drawing.Point(449, 26);
            this.tbWeb.Name = "tbWeb";
            this.tbWeb.Size = new System.Drawing.Size(100, 22);
            this.tbWeb.TabIndex = 21;
            // 
            // lbWeb
            // 
            this.lbWeb.AutoSize = true;
            this.lbWeb.ForeColor = System.Drawing.Color.Black;
            this.lbWeb.Location = new System.Drawing.Point(407, 29);
            this.lbWeb.Name = "lbWeb";
            this.lbWeb.Size = new System.Drawing.Size(36, 16);
            this.lbWeb.TabIndex = 20;
            this.lbWeb.Text = "Web";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(551, 30);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(214, 199);
            this.pbImagen.TabIndex = 22;
            this.pbImagen.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btsubirimagen
            // 
            this.btsubirimagen.ForeColor = System.Drawing.Color.Black;
            this.btsubirimagen.Location = new System.Drawing.Point(551, 250);
            this.btsubirimagen.Name = "btsubirimagen";
            this.btsubirimagen.Size = new System.Drawing.Size(218, 25);
            this.btsubirimagen.TabIndex = 23;
            this.btsubirimagen.Text = "Subir portada";
            this.btsubirimagen.UseVisualStyleBackColor = true;
            this.btsubirimagen.Click += new System.EventHandler(this.btsubirimagen_Click);
            // 
            // btAccept
            // 
            this.btAccept.ForeColor = System.Drawing.Color.Black;
            this.btAccept.Location = new System.Drawing.Point(41, 433);
            this.btAccept.Name = "btAccept";
            this.btAccept.Size = new System.Drawing.Size(106, 37);
            this.btAccept.TabIndex = 24;
            this.btAccept.Text = "Accept";
            this.btAccept.UseVisualStyleBackColor = true;
            this.btAccept.Click += new System.EventHandler(this.btAccept_Click);
            // 
            // btCancel
            // 
            this.btCancel.ForeColor = System.Drawing.Color.Black;
            this.btCancel.Location = new System.Drawing.Point(163, 434);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(106, 36);
            this.btCancel.TabIndex = 25;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(551, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 25);
            this.button1.TabIndex = 26;
            this.button1.Text = "Subir imagenes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbUrl
            // 
            this.gbUrl.Controls.Add(this.lbgoogleMaps);
            this.gbUrl.Controls.Add(this.tbgoogleMaps);
            this.gbUrl.Controls.Add(this.lbWikipedia);
            this.gbUrl.Controls.Add(this.tbWikipedia);
            this.gbUrl.Controls.Add(this.lbWeb);
            this.gbUrl.Controls.Add(this.tbWeb);
            this.gbUrl.Location = new System.Drawing.Point(41, 344);
            this.gbUrl.Name = "gbUrl";
            this.gbUrl.Size = new System.Drawing.Size(571, 70);
            this.gbUrl.TabIndex = 27;
            this.gbUrl.TabStop = false;
            this.gbUrl.Text = "URL";
            // 
            // gbLocation
            // 
            this.gbLocation.Controls.Add(this.lbContinente);
            this.gbLocation.Controls.Add(this.lbUbicacion);
            this.gbLocation.Controls.Add(this.tbUbicacion);
            this.gbLocation.Controls.Add(this.cbContinente);
            this.gbLocation.Controls.Add(this.lbPais);
            this.gbLocation.Controls.Add(this.cbPais);
            this.gbLocation.Location = new System.Drawing.Point(41, 221);
            this.gbLocation.Name = "gbLocation";
            this.gbLocation.Size = new System.Drawing.Size(403, 103);
            this.gbLocation.TabIndex = 28;
            this.gbLocation.TabStop = false;
            this.gbLocation.Text = "Ubicacion";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lbCapacidad);
            this.gbInfo.Controls.Add(this.dateTimePicker1);
            this.gbInfo.Controls.Add(this.tbCapacidad);
            this.gbInfo.Controls.Add(this.lbfecha);
            this.gbInfo.Controls.Add(this.lbreligion);
            this.gbInfo.Controls.Add(this.tbreligion);
            this.gbInfo.Location = new System.Drawing.Point(41, 97);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(403, 106);
            this.gbInfo.TabIndex = 29;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Informacion";
            // 
            // FrmgestionEdificioDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 491);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbLocation);
            this.Controls.Add(this.gbUrl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAccept);
            this.Controls.Add(this.btsubirimagen);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Name = "FrmgestionEdificioDetails";
            this.Text = "gestionEdificioDetails";
            this.Load += new System.EventHandler(this.FrmgestionEdificioDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.gbUrl.ResumeLayout(false);
            this.gbUrl.PerformLayout();
            this.gbLocation.ResumeLayout(false);
            this.gbLocation.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox tbUbicacion;
        private System.Windows.Forms.Label lbUbicacion;
        private System.Windows.Forms.TextBox tbCapacidad;
        private System.Windows.Forms.Label lbCapacidad;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.TextBox tbreligion;
        private System.Windows.Forms.Label lbreligion;
        private System.Windows.Forms.Label lbContinente;
        private System.Windows.Forms.ComboBox cbContinente;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.TextBox tbgoogleMaps;
        private System.Windows.Forms.Label lbgoogleMaps;
        private System.Windows.Forms.TextBox tbWikipedia;
        private System.Windows.Forms.Label lbWikipedia;
        private System.Windows.Forms.TextBox tbWeb;
        private System.Windows.Forms.Label lbWeb;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btsubirimagen;
        private System.Windows.Forms.Button btAccept;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbUrl;
        private System.Windows.Forms.GroupBox gbLocation;
        private System.Windows.Forms.GroupBox gbInfo;
    }
}