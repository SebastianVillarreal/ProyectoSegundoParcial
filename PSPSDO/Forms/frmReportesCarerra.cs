using PSPSDO.Classes;
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
    }
}
