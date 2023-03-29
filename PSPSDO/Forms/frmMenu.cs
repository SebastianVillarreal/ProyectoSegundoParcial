using System;
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

        private void carrerasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReportesCarerra frmRCarreras = new frmReportesCarerra();
            this.Hide();
            frmRCarreras.ShowDialog();
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

        private void capturaCalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalificaciones  frmCal = new frmCalificaciones();
            this.Hide();
            frmCal.ShowDialog();
            this.Show();
        }

        private void gruposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReportesGrupos frmRGrupos = new frmReportesGrupos();
            this.Hide();
            frmRGrupos.ShowDialog();
            this.Show();
        }

        private void alumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReportesAlumnos frmRAlumnos = new frmReportesAlumnos();
            this.Hide();
            frmRAlumnos.ShowDialog();
            this.Show();
        }

        private void materiasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReportesMaterias frmRMaterias = new frmReportesMaterias();
            this.Hide();
            frmRMaterias.ShowDialog();
            this.Show();
        }

        private void alumnosToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmReportesAlumnos frmRAlumnos = new frmReportesAlumnos();
            this.Hide();
            frmRAlumnos.ShowDialog();
            this.Show();
        }

        private void gruposToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmReportesGrupos frmRGrupos = new frmReportesGrupos();
            this.Hide();
            frmRGrupos.ShowDialog();
            this.Show();
        }

        private void carrerasToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmReportesCarerra frmRCarreras = new frmReportesCarerra();
            this.Hide();
            frmRCarreras.ShowDialog();
            this.Show();
        }
    }
}
