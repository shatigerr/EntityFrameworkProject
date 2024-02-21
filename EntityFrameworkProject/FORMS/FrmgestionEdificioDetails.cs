using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EntityFrameworkProject.FORMS
{
    public partial class FrmgestionEdificioDetails : Form
    {
        int op;
        practicaEdifEntities2 practicaCtx;
        public FrmgestionEdificios ed;
        string base64String;
        EdificiosReligiosos edificiosReligiosos;


        public FrmgestionEdificioDetails(practicaEdifEntities2 practicaCtx,int op)
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

            public static Image Base64ToImage(string base64String)
            {
                // Convertir la cadena Base64 a un array de bytes
                byte[] imageBytes = Convert.FromBase64String(base64String);

                // Crear un flujo de memoria a partir del array de bytes
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    // Crear una imagen a partir del flujo de memoria
                    Image image = Image.FromStream(ms);
                    return image;
                }
            }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmgestionEdificioDetails_Load(object sender, EventArgs e)
        {
            edificiosReligiosos = new EdificiosReligiosos();
            initCbContinente();
            initCbPais();
            if (op == 2)
            {
                edificiosReligiosos.id_edificio = ed.edificiosReligios.id_edificio;
                tbId.Text = edificiosReligiosos.id_edificio.ToString();
                edificiosReligiosos = practicaCtx.EdificiosReligiosos.Find(ed.edificiosReligios.id_edificio);

                tbId.Text = edificiosReligiosos.id_edificio.ToString();
                tbNombre.Text = edificiosReligiosos.nombre.ToString();
                tbCapacidad.Text = edificiosReligiosos.capacidad.ToString();
                tbUbicacion.Text = edificiosReligiosos.ubicacion.ToString();
                dateTimePicker1.Text = edificiosReligiosos.fecha_construccion.ToString();
                tbreligion.Text = edificiosReligiosos.denominacion_religiosa.ToString();
                cbPais.Text = edificiosReligiosos.Paises.nombre_pais.ToString();
                cbContinente.Text = "";
                tbgoogleMaps.Text = edificiosReligiosos.google_maps_link.ToString();
                tbWikipedia.Text = edificiosReligiosos.wikipedia_link.ToString();
                pbImagen.Image = Base64ToImage(edificiosReligiosos.ImagenBase64);
                pbImagen.SizeMode = PictureBoxSizeMode.Zoom;


                tbWeb.Text = edificiosReligiosos.web_link.ToString();

                
                
                
                //cbContinente.Text = paises.Continentes.nombre_continente;
               
            }

            



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


            
            edificiosReligiosos.nombre = tbNombre.Text.Trim();
            edificiosReligiosos.ubicacion = tbUbicacion.Text.Trim();
            edificiosReligiosos.capacidad = Convert.ToInt32(tbCapacidad.Text.Trim());
            edificiosReligiosos.fecha_construccion = dateTimePicker1.Value;
            edificiosReligiosos.denominacion_religiosa = tbreligion.Text.Trim();
            edificiosReligiosos.id_pais = (int)cbPais.SelectedValue;
            edificiosReligiosos.google_maps_link = tbgoogleMaps.Text.Trim();
            edificiosReligiosos.wikipedia_link = tbWikipedia.Text.Trim();
            edificiosReligiosos.web_link = tbWeb.Text.Trim();
            edificiosReligiosos.ImagenBase64 = base64String;

            if(op == 2)
            {
                try
                {
                    
                    practicaCtx.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"NO SE HA PODIDO MODIFICAR EL EDIFICIO {ex}");

                }
            }
            else
            {
                try
                {

                    practicaCtx.EdificiosReligiosos.Add(edificios);
                    practicaCtx.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al insertar el edificio religioso: {ex.Message}");
                }
            }       
                
           
        }

        private void cbContinente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPais.Enabled = true;
        }

        private void cbPais_TextUpdate(object sender, EventArgs e)
        {
            if (!(cbContinente.Text == ""))
            {
                
            }
            else
            {
                cbPais.Enabled = false;
            }
        }
    }
}
