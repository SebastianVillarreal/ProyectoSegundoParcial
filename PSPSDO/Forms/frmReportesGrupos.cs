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
    public partial class frmReportesGrupos : Form
    {
        public frmReportesGrupos()
        {
            InitializeComponent();
            cmbGrupos.DropDownStyle = ComboBoxStyle.DropDownList;

            GrupoClass Gpo = new GrupoClass();
            DataSet ds = Gpo.GetGrupos();
            DataTable dta = ds.Tables[0];
            cmbGrupos.DataSource = dta;
            cmbGrupos.ValueMember = "ID";
            cmbGrupos.DisplayMember = "Clave";
        }

        private void frmReportesGrupos_Load(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
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

                ReportesGruposModel RGM = new ReportesGruposModel();
                ReportesGruposCass ReportesG = new ReportesGruposCass();

                string grupo = cmbGrupos.Text;

                RGM.Parcial = parcialNum;
                RGM.Grupo = grupo;

                string resultados = ReportesG.ReporteGrupo(RGM);
                MessageBox.Show(resultados);

                DataSet ds = ReportesG.GetRepGrupos(parcialNum, grupo);
                dgvReportesGrupos.DataSource = ds.Tables[0];
            }
        }

        private void dgvReportesGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
