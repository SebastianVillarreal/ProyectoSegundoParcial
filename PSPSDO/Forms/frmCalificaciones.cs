using PSPSDO.BD;
using PSPSDO.Classes;
using PSPSDO.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PSPSDO.Forms
{
    public partial class frmCalificaciones : Form
    {
        public frmCalificaciones()
        {
            InitializeComponent();
            cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlumno.DropDownStyle = ComboBoxStyle.DropDownList;

            MateriasClass materias = new MateriasClass();
            DataSet dsm = materias.GetMaterias();
            DataTable dtm = dsm.Tables[0];
            cmbMateria.DataSource = dtm;
            cmbMateria.ValueMember = "ID";
            cmbMateria.DisplayMember = "Nombre";

            AlumnosClass alumnos= new AlumnosClass();
            DataSet dsa = alumnos.GetAlumnos();
            DataTable dta= dsa.Tables[0];
            cmbAlumno.DataSource = dta;
            cmbAlumno.ValueMember = "ID";
            cmbAlumno.DisplayMember= "NombreCompleto";
        }

        private void btnGuardarCapCal_Click(object sender, EventArgs e)
        {

            if (cmbMateria.SelectedIndex <= 1 || cmbAlumno.SelectedIndex <= 1 || string.IsNullOrWhiteSpace(txtParcial.Text) || string.IsNullOrWhiteSpace(txtCalificaciones.Text))
            {
                MessageBox.Show("Faltan Campos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CalificacionesModel calificaciones = new CalificacionesModel();
            CalificacionesClass calificacionesClass = new CalificacionesClass();
            calificaciones.IdMateria = int.Parse(cmbMateria.SelectedValue.ToString());
            calificaciones.IdAlumno = int.Parse(cmbAlumno.SelectedValue.ToString());
            calificaciones.IdParcial = int.Parse(txtParcial.Text);
            calificaciones.Calificacion = int.Parse(txtCalificaciones.Text);

            if (calificaciones.Calificacion < 80 || calificaciones.Calificacion > 100 || calificaciones.Calificacion < 0)
            {
                MessageBox.Show("Calificacion no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            calificacionesClass.InsertCalificaciones(calificaciones);
            MessageBox.Show("Calificacion guardada correctamente");

            cmbMateria.SelectedIndex = 0;
            cmbAlumno.SelectedIndex = 0;
            txtParcial.Text = "";
            txtCalificaciones.Text = "";

        }

        private void txtParcial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCalificaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelarCapCal_Click(object sender, EventArgs e)
        {
            cmbMateria.SelectedIndex = 0;
            cmbAlumno.SelectedIndex = 0;
            txtParcial.Text = "";
            txtCalificaciones.Text = "";
        }
    }
}
