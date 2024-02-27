using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkProject.FORMS
{
    public partial class FrmUsuarioReligion : Form
    {
        practicaEdifEntities practicaCtx;
        public FrmUsuarioReligion()
        {
            InitializeComponent();
        }

        private void FrmUsuarioReligion_Load(object sender, EventArgs e)
        {
            practicaCtx = new practicaEdifEntities();

            var queryEdif = from ed in practicaCtx.EdificiosReligiosos
                            select new
                            {
                                ID = ed.id_edificio,
                                Nombre = ed.nombre,
                            };
            cbEdificios.DataSource = queryEdif.ToList();
            cbEdificios.DisplayMember = "Nombre";
            cbEdificios.ValueMember = "ID";
            
        }

        private void btAccept_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.nombre = tbNom.Text;
            usuarios.id_denominacion_religiosa = (int)cbEdificios.SelectedValue;

            practicaCtx.Usuarios.Add(usuarios);
            practicaCtx.SaveChanges();
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void panelGrab_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
