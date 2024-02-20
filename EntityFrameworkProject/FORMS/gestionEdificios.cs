using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkProject.FORMS
{
    public partial class gestionEdificios : Form
    {
        practicaEdifEntities practicaCtx = new practicaEdifEntities();
        public gestionEdificios()
        {
            InitializeComponent();
        }

        private void gestionEdificios_Load(object sender, EventArgs e)
        {
            var queryBuildings = from ed in practicaCtx.EdificiosReligiosos
                                 orderby ed.nombre
                                 select new
                                 {
                                     ID = ed.id_edificio,
                                     Ubicación = ed.ubicacion,
                                     Nombre = ed.nombre,
                                     Capacidad = ed.capacidad,
                                     País = ed.Paises.nombre_pais,
                                     
                                 };


            dgv.DataSource = queryBuildings.ToList();
            dgv.AutoResizeColumns();

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            int id = (int)dgv.SelectedCells[0].Value;
            try
            {
                EdificiosReligiosos edif = practicaCtx.EdificiosReligiosos.FirstOrDefault(ed => ed.id_edificio == id);                           // busquem a la taula de cursos per clau primària
                practicaCtx.EdificiosReligiosos.DeleteObject(edif);
                
            }
            catch
            {
                MessageBox.Show("No se ha podido borrar el registro con el id " + id);
            }
            finally
            {
                practicaCtx.SaveChanges();
            }
            
        }
    }
}
