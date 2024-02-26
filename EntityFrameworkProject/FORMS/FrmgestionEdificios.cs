using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EntityFrameworkProject.FORMS
{
    public partial class FrmgestionEdificios : Form
    {
        practicaEdifEntities practicaCtx = new practicaEdifEntities();
        public EdificiosReligiosos edificiosReligios;
        public FrmgestionEdificios()
        {
            InitializeComponent();
        }

        private void gestionEdificios_Load(object sender, EventArgs e)
        {
            
            loadDataGrid();
        }

        public void loadDataGrid()
        {
            
            var queryBuildings = from ed in practicaCtx.EdificiosReligiosos
                                 orderby ed.nombre
                                 select new
                                 {
                                     ID = ed.id_edificio,
                                     Nombre = ed.nombre,
                                     Capacidad = ed.capacidad,
                                     País = ed.Paises.nombre_pais,
                                     Ubicación = ed.ubicacion,
                                 };


            dgv.DataSource = queryBuildings.ToList();
            dgv.AutoResizeColumns();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            int id = (int)dgv.SelectedCells[0].Value;
            try
            {
                EdificiosReligiosos edif = practicaCtx.EdificiosReligiosos.FirstOrDefault(ed => ed.id_edificio == id);
                practicaCtx.EdificiosReligiosos.Remove(edif);
            }
            catch
            {
                MessageBox.Show("No se ha podido borrar el registro con el id " + id);
            }
            finally
            {
                practicaCtx.SaveChanges();
                loadDataGrid();
            }
            
        }



        private void btAdd_Click(object sender, EventArgs e)
        {
            FrmgestionEdificioDetails edificioDetails = new FrmgestionEdificioDetails(practicaCtx, 1);
            edificioDetails.MdiParent = (FrmMain)this.MdiParent;
            edificioDetails.ed = this;
            edificioDetails.Show();

        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            edificiosReligios = new EdificiosReligiosos();
            edificiosReligios.id_edificio = (int)dgv.SelectedCells[0].Value;

            FrmgestionEdificioDetails edificioDetails = new FrmgestionEdificioDetails(practicaCtx, 2);
            edificioDetails.MdiParent = (FrmMain)this.MdiParent;
            edificioDetails.ed = this;
            edificioDetails.Show();
        }

        private IEnumerable<Galeria> consultarGaleriaPerIdEdifici(int id)
        {
            return from g in practicaCtx.Galeria
                        where g.id_edificio == id
                        select g;
            

            
        }
    }
}
