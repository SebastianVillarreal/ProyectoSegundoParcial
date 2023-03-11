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

namespace PSPSDO.Forms
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            AlumnosModel Alumnos = new AlumnosModel();
            AlumnosClass Alumn = new AlumnosClass();

            Alumnos.Matricula = int.Parse(txtMatriAlumno .Text);
            Alumnos.Nombre = txtNombreAlumno.Text;
            Alumnos.ApellidoPaterno = txtApPaterAlumno.Text;
            Alumnos.ApellidoMaterno = txtApMaterAlumno.Text;
            Alumnos.Direccion = txtDireccioAlumno.Text;

            string resultados = Alumn.InsertAlumnos(Alumnos);
            MessageBox.Show(resultados);

            DataSet ds = Alumn.GetAlumnos();

            dgvAlumnos.DataSource = ds.Tables[0];
        }

        private void btnActualiAlumnos_Click(object sender, EventArgs e)
        {
            AlumnosModel Alumnos = new AlumnosModel();
            AlumnosClass Alumn = new AlumnosClass();

            Alumnos.Id = (int)dgvAlumnos.Rows[dgvAlumnos.CurrentCell.RowIndex].Cells[0].Value;
            Alumnos.Matricula = int.Parse(txtMatriAlumno.Text);
            Alumnos.Nombre = txtNombreAlumno.Text;
            Alumnos.ApellidoPaterno = txtApPaterAlumno.Text;
            Alumnos.ApellidoMaterno = txtApMaterAlumno.Text;
            Alumnos.Direccion = txtDireccioAlumno.Text;

            string resultados = Alumn.ActualizarAlumnos(Alumnos);
            MessageBox.Show(resultados);

            DataSet ds = Alumn.GetAlumnos();

            dgvAlumnos.DataSource = ds.Tables[0];
        }

        private void btncargarAlumnos_Click(object sender, EventArgs e)
        {
            ArrayList parametros = new ArrayList();
            BDContext bd = new BDContext();
            parametros.Add(new SqlParameter { ParameterName = "@pId", SqlDbType = System.Data.SqlDbType.VarChar, Value = 1 });
            DataSet ds = bd.Fill("SP_SelectAlumnos", parametros);
            dgvAlumnos.DataSource = ds.Tables[0];
        }

        private void btnElimiAlumnos_Click(object sender, EventArgs e)
        {
            AlumnosModel Alumnos = new AlumnosModel();
            AlumnosClass Alumn = new AlumnosClass();

            Alumnos.Matricula = int.Parse(txtMatriAlumno.Text);
            Alumnos.Nombre = txtNombreAlumno.Text;
            Alumnos.ApellidoPaterno = txtApPaterAlumno.Text;
            Alumnos.ApellidoMaterno = txtApMaterAlumno.Text;
            Alumnos.Direccion = txtDireccioAlumno.Text;

            string resultados = Alumn.DeleteAlumnos(Alumnos);
            MessageBox.Show(resultados);

            DataSet ds = Alumn.GetAlumnos();

            dgvAlumnos.DataSource = ds.Tables[0];
        }
    }
}
