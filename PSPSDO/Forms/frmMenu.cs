﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSPSDO.Forms
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos frmAlumn = new frmAlumnos();
            this.Hide();
            frmAlumn.ShowDialog();
            this.Show();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrupos frmGrup = new frmGrupos();
            this.Hide();
            frmGrup.ShowDialog();
            this.Show();
        }
    }
}
