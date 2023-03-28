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

namespace PSPSDO.Forms
{
    public partial class frmReportesMaterias : Form
    {
        public frmReportesMaterias()
        {
            InitializeComponent();
            cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;

            CarreraClass carrera = new CarreraClass();
            DataSet ds = carrera.extract();
            DataTable dta = ds.Tables[0];
            cmbCarrera.DataSource = dta;
            cmbCarrera.ValueMember = "ID";
            cmbCarrera.DisplayMember = "Nombre";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportesMateriasModel RMM = new ReportesMateriasModel();
            ReportesMateriasClass ReportesM = new ReportesMateriasClass();

            string carrera = cmbCarrera.Text;

            RMM.Carrera = carrera;

            string resultados = ReportesM.ReporteMaterias(RMM);
            MessageBox.Show(resultados);

            DataSet ds = ReportesM.GetRepMaterias(carrera);
           dgvReportesMaterias.DataSource = ds.Tables[0];
        }
    }
}
