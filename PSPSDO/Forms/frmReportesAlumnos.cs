using PSPSDO.Classes;
using PSPSDO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PSPSDO.Classes.frmReportesAlumnosClass;

namespace PSPSDO.Forms
{
    public partial class frmReportesAlumnos : Form
    {
        public frmReportesAlumnos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmReportesAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearRA_Click(object sender, EventArgs e)
        {
            if (txtRANombre.Text == "")
            {
                MessageBox.Show("Llena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ReportesAlumnosModel RAM = new ReportesAlumnosModel();
                ReportesAlumnosClass ReportesA = new ReportesAlumnosClass();

                int matricula = int.Parse(txtRANombre.Text);

                RAM.Matricula = matricula;

                string resultados = ReportesA.ReporteAlumnos(RAM);
                MessageBox.Show(resultados);

                DataSet ds = ReportesA.GetRepAlumnos(matricula);
                dgvReportesAlumno.DataSource = ds.Tables[0];
            }
        }
    }
}
