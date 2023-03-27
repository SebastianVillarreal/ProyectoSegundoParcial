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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PSPSDO.Forms
{
    public partial class frmReportesCarerra : Form
    {
        public frmReportesCarerra()
        {
            InitializeComponent();
            cmbReportesCarreras.DropDownStyle = ComboBoxStyle.DropDownList;

            CarreraClass carrera = new CarreraClass();
            DataSet ds = carrera.extract();
            DataTable dta = ds.Tables[0];
            cmbReportesCarreras.DataSource = dta;
            cmbReportesCarreras.ValueMember = "ID";
            cmbReportesCarreras.DisplayMember = "Nombre";
            //dgvReportesCarreras.DataSource = ds.Tables[0];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmReportesCarerra_Load(object sender, EventArgs e)
        {

        }

        private void btnReporteCarreras_Click(object sender, EventArgs e)
        {
            if (!rbParcialUno.Checked && !rbParcialDos.Checked)
            {
                MessageBox.Show("Llena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int parcialNum = 0;

                if (rbParcialUno.Checked)
                {
                    parcialNum = 1;
                }
                else
                {
                    parcialNum = 2;
                }

                ReportesCarrerasModel RCM = new ReportesCarrerasModel();
                ReportesCarerrasClass ReportesC = new ReportesCarerrasClass();

                string carrera = cmbReportesCarreras.Text;

                RCM.Parcial = parcialNum;
                RCM.Carrera = carrera;

                string resultados = ReportesC.ReporteCarrera(RCM);
                MessageBox.Show(resultados);

                DataSet ds = ReportesC.GetRepCarreras(parcialNum, carrera);
                dgvReportesCarreras.DataSource = ds.Tables[0];
            }
        }
    }
}
