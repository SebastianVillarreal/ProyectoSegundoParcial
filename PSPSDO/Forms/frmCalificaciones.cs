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
            cmbMateriaCal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlumnoCal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrupoCal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarreraCal.DropDownStyle = ComboBoxStyle.DropDownList;
            //materias
            MateriasClass materias = new MateriasClass();
            DataSet dsm = materias.GetMaterias();
            DataTable dtm = dsm.Tables[0];
            cmbMateriaCal.DataSource = dtm;
            cmbMateriaCal.ValueMember = "ID";
            cmbMateriaCal.DisplayMember = "Nombre";

            //carreras
            CarreraClass carrera = new CarreraClass();
            DataSet dsc = carrera.GetCarreras();
            DataTable dtc = dsc.Tables[0];
            cmbCarreraCal.DataSource = dtc;
            cmbCarreraCal.ValueMember = "Id";
            cmbCarreraCal.DisplayMember = "Clave";

            //grupos
            string filtro = cmbCarreraCal.SelectedValue.ToString();
            GrupoClass grupo = new GrupoClass();
            DataSet dsg = grupo.GetGrupoFiltro(filtro);
            DataTable dtg = dsg.Tables[0];
            cmbGrupoCal.DataSource = dtg;
            cmbGrupoCal.ValueMember = "Id";
            cmbGrupoCal.DisplayMember = "Clave";

            //alumnos
            AlumnosClass alumnos= new AlumnosClass();
            DataSet dsa = alumnos.GetAlumnos();
            DataTable dta= dsa.Tables[0];
            cmbAlumnoCal.DataSource = dta;
            cmbAlumnoCal.ValueMember = "ID";
            cmbAlumnoCal.DisplayMember= "NombreCompleto";
        }

        private void btnGuardarCapCal_Click(object sender, EventArgs e)
        {

            if (cmbMateriaCal.SelectedIndex <= 1 || cmbAlumnoCal.SelectedIndex <= 1 || string.IsNullOrWhiteSpace(txtParcial.Text) || string.IsNullOrWhiteSpace(txtCalificaciones.Text))
            {
                MessageBox.Show("Faltan Campos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CalificacionesModel calificaciones = new CalificacionesModel();
            CalificacionesClass calificacionesClass = new CalificacionesClass();
            calificaciones.IdMateria = int.Parse(cmbMateriaCal.SelectedValue.ToString());
            calificaciones.IdAlumno = int.Parse(cmbAlumnoCal.SelectedValue.ToString());
            calificaciones.IdParcial = int.Parse(txtParcial.Text);
            calificaciones.Calificacion = int.Parse(txtCalificaciones.Text);

            if (calificaciones.Calificacion < 80 || calificaciones.Calificacion > 100 || calificaciones.Calificacion < 0)
            {
                MessageBox.Show("Calificacion no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            calificacionesClass.InsertCalificaciones(calificaciones);
            MessageBox.Show("Calificacion guardada correctamente");

            cmbMateriaCal.SelectedIndex = 0;
            cmbAlumnoCal.SelectedIndex = 0;
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
            cmbMateriaCal.SelectedIndex = 0;
            cmbAlumnoCal.SelectedIndex = 0;
            txtParcial.Text = "";
            txtCalificaciones.Text = "";
        }

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
