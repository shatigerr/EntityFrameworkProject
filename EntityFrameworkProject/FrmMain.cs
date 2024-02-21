﻿using EntityFrameworkProject.FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkProject
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        FrmgestionEdificios frmGestionEdificios;
        private void edificiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionEdificios = new FrmgestionEdificios();
            frmGestionEdificios.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (gestionarToolStripMenuItem.DisplayStyle == ToolStripItemDisplayStyle.Image)
            {
                gestionarToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                consultasToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                salirToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                toolStripMenuItem1.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
            else
            {
                gestionarToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
                consultasToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
                salirToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
                toolStripMenuItem1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            }
        }

        private void time_Tick(object sender, EventArgs e)
        {
            toolStripMenuItem1.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}