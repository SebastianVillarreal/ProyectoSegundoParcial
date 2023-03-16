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

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterias frmMat = new frmMaterias();
            this.Hide();
            frmMat.ShowDialog();
            this.Show();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarreras frmCar = new frmCarreras();
            this.Hide();
            frmCar.ShowDialog();
            this.Show();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonas frmPers = new frmPersonas();
            this.Hide();
            frmPers.ShowDialog();
            this.Show();
        }
    }
}
