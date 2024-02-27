using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
        practicaEdifEntities practicaCtx;
        public FrmgestionEdificios ed;
        string base64String;
        EdificiosReligiosos edificiosReligiosos;
        Paises pais;
        List<string> ListaBase64;   


        public FrmgestionEdificioDetails(practicaEdifEntities practicaCtx,int op)
        {
            this.practicaCtx = practicaCtx;
            this.op = op;   
            InitializeComponent();
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        

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

                
                //base64String = ImageToBase64(pbImagen.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                base64String = ImageB64.ImageToBase64Path(filePath);


            }

            
        }
        

        

        private void FrmgestionEdificioDetails_Load(object sender, EventArgs e)
        {
            ListaBase64 = new List<string>();
            edificiosReligiosos = new EdificiosReligiosos();
            if (op == 1)
            {
                pbClose.Visible = true;
                practicaCtx.EdificiosReligiosos.Add(edificiosReligiosos);
                practicaCtx.SaveChanges();
            }
            pais = new Paises();


            initCbContinente();
            initCbPais();
            if (op == 2)
            {
                pbClose.Visible = false;
                edificiosReligiosos.id_edificio = ed.edificiosReligios.id_edificio;
                
                edificiosReligiosos = practicaCtx.EdificiosReligiosos.Find(ed.edificiosReligios.id_edificio);
                pais = practicaCtx.Paises.Find(edificiosReligiosos.id_pais);

                formToQuery();
                updateDataGridGaleria();
                
                
                //cbContinente.Text = paises.Continentes.nombre_continente;
               
            }

            



        }
        private void formToQuery()
        {

            tbId.Text = edificiosReligiosos.id_edificio.ToString();
            tbId.Text = edificiosReligiosos.id_edificio.ToString();
            tbNombre.Text = edificiosReligiosos.nombre != null ? edificiosReligiosos.nombre : "";
            tbCapacidad.Text = edificiosReligiosos.capacidad != null ? edificiosReligiosos.capacidad.ToString() : "";
            tbUbicacion.Text = edificiosReligiosos.ubicacion != null ? edificiosReligiosos.ubicacion.ToString() : "";
            dateTimePicker1.Value = edificiosReligiosos.fecha_construccion.Value;
            tbreligion.Text = edificiosReligiosos.denominacion_religiosa != null ? edificiosReligiosos.denominacion_religiosa.ToString() : "";
            cbPais.Text = pais.nombre_pais.ToString();
            cbContinente.Text = pais.Continentes.nombre_continente.ToString();
            tbWikipedia.Text = edificiosReligiosos.wikipedia_link != null ? edificiosReligiosos.wikipedia_link.ToString() : "";
            tbResenya.Text = edificiosReligiosos.ressenya != null ? edificiosReligiosos.ressenya.ToString() : "";
            tbWeb.Text = edificiosReligiosos.web_link != null ? edificiosReligiosos.web_link.ToString() : "";
            tbX.Text = edificiosReligiosos.cordX != null ? edificiosReligiosos.cordX.ToString() : "";
            tbY.Text = edificiosReligiosos.cordY != null ? edificiosReligiosos.cordY.ToString() : "";

            pbImagen.Image = edificiosReligiosos.ImagenBase64 != null ? ImageB64.Base64ToImage(edificiosReligiosos.ImagenBase64) : EntityFrameworkProject.Properties.Resources.placeholder;
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            base64String = edificiosReligiosos.ImagenBase64;
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

            this.Cursor = Cursors.WaitCursor;

            
            try {
                FormToQuery();
            }catch(Exception ex)
            {
                MessageBox.Show("El formato de alguno de los datos insertados no es el correcto. Error: ");
                practicaCtx.EdificiosReligiosos.Remove(edificiosReligiosos);
                practicaCtx.SaveChanges();

                

            }

            try
            {
                
                if (Convert.ToInt32(tbCapacidad.Text.Trim()) > 0 && tbNombre.Text.Length > 0 && tbreligion.Text.Length > 0 
                    && correctUrl(edificiosReligiosos.web_link) && correctUrl(edificiosReligiosos.wikipedia_link))
                {
                    practicaCtx.SaveChanges();
                    ed.loadDataGrid();
                    if(op ==1) insertarPreview();



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"NO SE HA PODIDO REALIZAR LA OPERACION CORRECTAMENTE");
            }

            
 


            this.Cursor = Cursors.Default;
            this.Close();
        }

        private bool correctUrl(string url)
        {
            bool result = Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            return result;
        }
        private void FormToQuery()
        {
            edificiosReligiosos.nombre = tbNombre.Text.Trim();
            edificiosReligiosos.ubicacion = tbUbicacion.Text.Trim();
            edificiosReligiosos.capacidad = Convert.ToInt32(tbCapacidad.Text.Trim());
            edificiosReligiosos.fecha_construccion = dateTimePicker1.Value;
            edificiosReligiosos.denominacion_religiosa = tbreligion.Text.Trim();
            edificiosReligiosos.id_pais = (int)cbPais.SelectedValue;
            edificiosReligiosos.wikipedia_link = tbWikipedia.Text.Trim();
            edificiosReligiosos.web_link = tbWeb.Text.Trim();
            edificiosReligiosos.ressenya = tbResenya.Text;
            edificiosReligiosos.cordX = float.Parse(tbX.Text.Trim());
            edificiosReligiosos.cordY = float.Parse(tbY.Text.Trim());
            edificiosReligiosos.ImagenBase64 = base64String;
        }

        private void insertarPreview()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                Galeria galeria = new Galeria();
                driver.Navigate().GoToUrl(edificiosReligiosos.web_link);       
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                string base64Screenshot = ImageB64.ConvertScreenshotToBase64(screenshot);
                galeria.imagen_base64 = base64Screenshot;
                galeria.id_edificio = edificiosReligiosos.id_edificio;
                galeria.Preview = true;

                practicaCtx.Galeria.Add(galeria);
                practicaCtx.SaveChanges();
            }

        }

        private void insertarGaleria()
        {
            
            
            foreach (string item in ListaBase64)
            {
                try
                {
                    Galeria galeria = new Galeria();
                    galeria.id_edificio = edificiosReligiosos.id_edificio;
                    galeria.imagen_base64 = item;
                    practicaCtx.Galeria.Add(galeria);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("NO SE HAN PODIDO INSERTAR LAS IMAGENES " + ex);
                }
                

            }
            practicaCtx.SaveChanges();
        }

        private void cbContinente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPais.Enabled = true;
        }

        private void cbPais_TextUpdate(object sender, EventArgs e)
        {
            //if (!(cbContinente.Text == ""))
            //{
                
            //}
            //else
            //{
            //    cbPais.Enabled = false;
            //}
        }

       

        

        private void panelGrab_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
            practicaCtx.EdificiosReligiosos.Remove(edificiosReligiosos);
            practicaCtx.SaveChanges();
            }
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
            openFileDialog1.Title = "Seleccionar imagen";
            openFileDialog1.Multiselect = false; // Permitir solo la selección de un archivo

            // Mostrar el diálogo y verificar si el usuario ha seleccionado un archivo

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                ListaBase64.Clear();
                ListaBase64.Add(ImageB64.ImageToBase64Path(openFileDialog1.FileName));

                //dgv.DataSource = ListaBase64.ToList();
                insertarGaleria();
                updateDataGridGaleria();
            }
        }

        private void updateDataGridGaleria()
        {
            var queryGaleria = from g in practicaCtx.Galeria
                               orderby g.id_galeria
                               where (int)g.id_edificio == (int)edificiosReligiosos.id_edificio && g.Preview == null
                               select new
                               {
                                   ID = g.id_galeria,
                               };
            dgv.DataSource = null;
            dgv.DataSource = queryGaleria.ToList();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Galeria foto;

            foto = practicaCtx.Galeria.Find(dgv.SelectedCells[0].Value);


            pbImagenGaleria.Image = ImageB64.Base64ToImage(foto.imagen_base64);

            panelGaleriaPreview.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panelGaleriaPreview.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Galeria foto;
            foto = practicaCtx.Galeria.Find(dgv.SelectedCells[0].Value);
            practicaCtx.Galeria.Remove(foto);
            practicaCtx.SaveChanges();
            updateDataGridGaleria();
            panelGaleriaPreview.Visible =false;
        }
    }
}
