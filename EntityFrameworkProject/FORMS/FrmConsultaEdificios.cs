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
    
    public partial class FrmConsultaEdificios : Form
    {
        practicaEdifEntities practicaCtx;
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
                                     Capacidad = ed.capacidad,
                                     País = ed.Paises.nombre_pais,
                                     Ubicación = ed.ubicacion,
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
                        select e;

            dgv.DataSource = query.ToList();
        }

        private void consultaPerContinent()
        {
            var query = from e in practicaCtx.EdificiosReligiosos
                        orderby e.nombre
                        where e.Paises.id_continente == (int)cbContinente.SelectedValue
                        select e;

            dgv.DataSource = query.ToList();
        }

        private void cbContinente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!cbFiltres.Checked) initCbPais();
        }

        private void cbPais_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!cbFiltres.Checked) consultaPerPais();
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
    }
}
