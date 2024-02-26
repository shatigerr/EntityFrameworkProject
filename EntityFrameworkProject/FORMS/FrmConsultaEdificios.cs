using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkProject.FORMS
{
    
    public partial class FrmConsultaEdificios : Form
    {
        practicaEdifEntities practicaCtx;
        EdificiosReligiosos edificiosReligiosos;
        List<string> galeria = new List<string>();
        int elements = 0;
        public FrmConsultaEdificios()
        {
            InitializeComponent();
        }

        private void FrmConsultaEdificios_Load(object sender, EventArgs e)
        {
            practicaCtx = new practicaEdifEntities();
            loadDataGrid();
            initCbContinente();
            initCbPais();

        }

        public void loadDataGrid()
        {

            var queryBuildings = from ed in practicaCtx.EdificiosReligiosos
                                 orderby ed.nombre
                                 select new
                                 {
                                     ID = ed.id_edificio,
                                     Nombre = ed.nombre,
                                     Reseña = ed.ressenya,
                                     País = ed.Paises.nombre_pais,
                                 };


            dgv.DataSource = queryBuildings.ToList();
            dgv.AutoResizeColumns();
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

        private void cbFiltres_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbFiltres.Checked)
            {
              
                consultaPerPais();
                cbContinente.Enabled = true;
                cbPais.Enabled = true;
                cbEnablePais.Enabled = true;
            }
            else
            {
                cbEnablePais.Enabled = false;
                loadDataGrid();
                cbContinente.Enabled = false;
                cbPais.Enabled = false;
            }
        }

        private void consultaPerPais()
        {
            var query = from e in practicaCtx.EdificiosReligiosos
                        orderby e.nombre
                        where e.id_pais == (int)cbPais.SelectedValue
                        select new
                        {
                            ID = e.id_edificio,
                            Nombre = e.nombre,
                            Reseña = e.ressenya,
                            País = e.Paises.nombre_pais,
                        };

            dgv.DataSource = query.ToList();
        }

        private void consultaPerContinent()
        {
            var query = from e in practicaCtx.EdificiosReligiosos
                        orderby e.nombre
                        where e.Paises.id_continente == (int)cbContinente.SelectedValue
                        select new
                        {
                            ID = e.id_edificio,
                            Nombre = e.nombre,
                            Reseña = e.ressenya,
                            País = e.Paises.nombre_pais,
                        };

            dgv.DataSource = query.ToList();
        }

        private void cbContinente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!cbFiltres.Checked)
            {
                initCbPais();
                if (!cbEnablePais.Checked)
                {
                    consultaPerContinent();
                }
            }
        }

        private void cbPais_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!cbFiltres.Checked && cbEnablePais.Checked) consultaPerPais();
        }

        private void cbEnablePais_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnablePais.Checked)
            {
                cbPais.Enabled = true;
                consultaPerPais();
            }
            else
            {
                cbPais.Enabled = false;
                consultaPerContinent();
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            edificiosReligiosos = new EdificiosReligiosos();
            edificiosReligiosos = practicaCtx.EdificiosReligiosos.Find(dgv.SelectedCells[0].Value);

            pbPortada.Image = edificiosReligiosos.ImagenBase64 != null ? Base64ToImage(edificiosReligiosos.ImagenBase64) : Properties.Resources.placeholder;
            pbPortada.SizeMode = PictureBoxSizeMode.Zoom;
            lbNombre.Text = edificiosReligiosos.nombre;
            lbResenya.Text = edificiosReligiosos.ressenya != null ? edificiosReligiosos.ressenya : "";
            lbFecha.Text = edificiosReligiosos.fecha_construccion.ToString();
            lbPais.Text = edificiosReligiosos.Paises.nombre_pais;
            lbUbicacion.Text = edificiosReligiosos.ubicacion;
            lbCapacidad.Text = $"{edificiosReligiosos.capacidad} Personas";

            galeria = consultarGaleria(edificiosReligiosos.id_edificio);

            pbGaleria.Image = galeria.Count > 0 ? Base64ToImage(galeria[0]) : Properties.Resources.placeholder;







        }

        private List<string> consultarGaleria(int id)
        {
            List<string> list = new List<string>();
            var query = from g in practicaCtx.Galeria
                        where g.id_edificio == id
                        select new
                        {
                            imagen = g.imagen_base64
                        };

            foreach (var item in query.ToList())
            {
                list.Add(item.imagen.ToString());
            }

            return list;
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

        private void btnMaps_Click(object sender, EventArgs e)
        {
            string x = edificiosReligiosos.cordX.ToString().Replace(",",".");
            string y = edificiosReligiosos.cordY.ToString().Replace(",", ".");
            string urlGoogleMaps = $"https://www.google.com/maps?q={x},{y}&t=k";

            Process.Start(urlGoogleMaps);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TODO Controlar limite array
            elements++;
            pbGaleria.Image = Base64ToImage(galeria[elements]);
        }
    }
}
