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
                                     Capacidad = ed.capacidad,
                                     País = ed.Paises.nombre_pais,
                                     Ubicación = ed.ubicacion,
                                     Nombre = ed.nombre
                                 };

            dgv.DataSource = queryBuildings.ToList();

        }

    }
}
