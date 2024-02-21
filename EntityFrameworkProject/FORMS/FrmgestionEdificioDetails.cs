using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkProject.FORMS
{
    public partial class FrmgestionEdificioDetails : Form
    {
        int op;
        practicaEdifEntities1 practicaCtx;
        string base64String;
        public FrmgestionEdificioDetails(practicaEdifEntities1 practicaCtx,int op)
        {
            this.practicaCtx = practicaCtx;
            this.op = op;   
            InitializeComponent();
        }

        private void btsubirimagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
            openFileDialog1.Title = "Seleccionar imagen";
            openFileDialog1.Multiselect = false; // Permitir solo la selección de un archivo

            // Mostrar el diálogo y verificar si el usuario ha seleccionado un archivo
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string filePath = openFileDialog1.FileName;
                pbImagen.Image = Image.FromFile(filePath);
                pbImagen.SizeMode = PictureBoxSizeMode.Zoom;

                
                base64String = ImageToBase64(pbImagen.Image, System.Drawing.Imaging.ImageFormat.Jpeg);


            }

            
        }

        private string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convertir la imagen a bytes
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convertir los bytes a una cadena Base64
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmgestionEdificioDetails_Load(object sender, EventArgs e)
        {
            if(op != 2)
            {

            }

            initCbContinente();
            initCbPais();



        }

        private void initCbContinente()
        {
            var queryContinent = from c in practicaCtx.Continentes
                                 orderby c.nombre_continente
                                 select new
                                 {
                                     ID = c.id_continente,
                                     Nombre = c.nombre_continente
                                 };
            cbContinente.DataSource = queryContinent.ToList();
            cbContinente.DisplayMember = "Nombre";
            cbContinente.ValueMember = "ID";
        }

        private void initCbPais()
        {
            var queryCountry = from co in practicaCtx.Paises
                               orderby co.nombre_pais
                               where (int)co.id_continente == (int)cbContinente.SelectedValue
                               select new
                               {
                                   ID = co.id_pais,
                                   Nombre = co.nombre_pais
                               };

            cbPais.DataSource = queryCountry.ToList();
            cbPais.DisplayMember = "Nombre";
            cbPais.ValueMember = "ID";
        }

        private void cbContinente_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbPais.SelectedValue  != null)
            {

                initCbPais();
            }
        }

        private void btAccept_Click(object sender, EventArgs e)
        {
            EdificiosReligiosos edificios = new EdificiosReligiosos();

            this.Cursor = Cursors.WaitCursor;
            
            

            edificios.nombre = tbNombre.Text.Trim();
            edificios.ubicacion = tbUbicacion.Text.Trim();
            edificios.capacidad = Convert.ToInt32(tbCapacidad.Text.Trim());
            edificios.fecha_construccion = dateTimePicker1.Value;
            edificios.denominacion_religiosa = tbreligion.Text.Trim();
            edificios.id_pais = (int)cbPais.SelectedValue;
            edificios.google_maps_link = tbgoogleMaps.Text.Trim();
            edificios.wikipedia_link = tbWikipedia.Text.Trim();
            edificios.web_link = tbWeb.Text.Trim();
            edificios.ImagenBase64 = base64String;

            try
            {
                practicaCtx.EdificiosReligiosos.Add(edificios);
                practicaCtx.SaveChanges();
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error al insertar el edificio religioso: {ex.Message}");
            }

                
                
            
        }
    }
}
