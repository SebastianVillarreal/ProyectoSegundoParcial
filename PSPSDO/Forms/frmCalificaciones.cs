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
        }

        private void btnGuardarCapCal_Click(object sender, EventArgs e)
        {

            if (cmbMateriaCal.SelectedIndex < 0 || cmbAlumnoCal.SelectedIndex < 0 || string.IsNullOrWhiteSpace(txtParcialCal.Text) || string.IsNullOrWhiteSpace(txtCalificacionesCal.Text))
            {
                MessageBox.Show("Faltan Campos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CalificacionesModel calificaciones = new CalificacionesModel();
            CalificacionesClass calificacionesClass = new CalificacionesClass();
            calificaciones.IdMateria = int.Parse(cmbMateriaCal.SelectedValue.ToString());
            calificaciones.IdAlumno = int.Parse(cmbAlumnoCal.SelectedValue.ToString());
            calificaciones.IdParcial = int.Parse(txtParcialCal.Text);
            calificaciones.Calificacion = int.Parse(txtCalificacionesCal.Text);

            if (calificaciones.Calificacion < 80 || calificaciones.Calificacion > 100 || calificaciones.Calificacion < 0)
            {
                MessageBox.Show("Calificacion no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            calificacionesClass.InsertCalificaciones(calificaciones);
            MessageBox.Show("Calificacion guardada correctamente");

            cmbMateriaCal.SelectedIndex = 0;
            cmbAlumnoCal.SelectedIndex = 0;
            txtParcialCal.Text = "";
            txtCalificacionesCal.Text = "";

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
            txtParcialCal.Text = "";
            txtCalificacionesCal.Text = "";
        }

        private void cmbCarreraCal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //grupos
                GrupoClass grupo = new GrupoClass();
                string filtro = cmbCarreraCal.Text;
                DataSet dsg = grupo.GetGrupoFiltro(filtro);
                DataTable dtg = dsg.Tables[0];
                cmbGrupoCal.DataSource = dtg;
                cmbGrupoCal.ValueMember = "Id";
                cmbGrupoCal.DisplayMember = "Clave";

                MateriasClass Materia = new MateriasClass();
                int Filtro = Convert.ToInt32(cmbCarreraCal.SelectedValue);
                DataSet dsm = Materia.GetMateriaFiltro(Filtro);
                DataTable dtm = dsm.Tables[0];
                cmbMateriaCal.DataSource = dtm;
                cmbMateriaCal.ValueMember = "Id";
                cmbMateriaCal.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }
            
        }

        private void cmbAlumnoCal_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

        private void cmbGrupoCal_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlumnosClass alumnos = new AlumnosClass();
            int filtro = Convert.ToInt32(cmbGrupoCal.SelectedValue);
            DataSet dsa = alumnos.GetAlumnoFiltro(filtro);
            DataTable dta = dsa.Tables[0];
            cmbAlumnoCal.DataSource = dta;
            cmbAlumnoCal.ValueMember = "Id";
            cmbAlumnoCal.DisplayMember = "Nombre";
        }
    }
}
