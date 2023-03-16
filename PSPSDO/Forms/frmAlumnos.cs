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
using System.Xml.Linq;

namespace PSPSDO.Forms
{
    public partial class frmAlumnos : Form
    {
        int ubi;

        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Si no funciona agregarle Content entre CellClick


            //ubi = e.RowIndex;
            //if (ubi != -1)
            //{
            //    txtMatriAlumno.Text = (string)dgvAlumnos[1, ubi].Value;
            //    txtNombreAlumno.Text = (string)dgvAlumnos[2, ubi].Value;
            //    txtApPaterAlumno.Text = (string)dgvAlumnos[3, ubi].Value;
            //    txtApMaterAlumno.Text = (string)dgvAlumnos[4, ubi].Value;
            //    txtDireccioAlumno.Text = (string)dgvAlumnos[5, ubi].Value;
            //}

        }

        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            AlumnosModel Alumnos = new AlumnosModel();
            AlumnosClass Alumn = new AlumnosClass();

            Alumnos.Matricula = int.Parse(txtMatriAlumno.Text);
            Alumnos.Nombre = txtNombreAlumno.Text;
            Alumnos.ApellidoPaterno = txtApPaterAlumno.Text;
            Alumnos.ApellidoMaterno = txtApMaterAlumno.Text;
            Alumnos.Direccion = txtDireccioAlumno.Text;

            string resultados = Alumn.InsertAlumnos(Alumnos);
            MessageBox.Show(resultados);

            DataSet ds = Alumn.GetAlumnos();
            dgvAlumnos.DataSource = ds.Tables[0];

            txtNombreAlumno.Text = "";
            txtApPaterAlumno.Text = "";
            txtApMaterAlumno.Text = "";
            txtMatriAlumno.Text = "";
            txtDireccioAlumno.Text = "";
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
            //ArrayList parametros = new ArrayList();
            //BDContext bd = new BDContext();
            //parametros.Add(new SqlParameter { ParameterName = "@pId", SqlDbType = System.Data.SqlDbType.VarChar, Value = 1 });
            //DataSet ds = bd.Fill("SP_SelectAlumnos", parametros);
            //dgvAlumnos.DataSource = ds.Tables[0];
        }

        private void btnElimiAlumnos_Click(object sender, EventArgs e)
        {
            AlumnosModel Alumnos = new AlumnosModel();
            AlumnosClass Alumn = new AlumnosClass();

            Alumnos.Id = (int)dgvAlumnos.Rows[dgvAlumnos.CurrentCell.RowIndex].Cells[0].Value;

            string resultados = Alumn.DeleteAlumnos(Alumnos);
            MessageBox.Show(resultados);

            DataSet ds = Alumn.GetAlumnos();
            dgvAlumnos.DataSource = ds.Tables[0];
        }

        private void Carga()
        {
            ArrayList parametros = new ArrayList();
            BDContext bd = new BDContext();
            parametros.Add(new SqlParameter { ParameterName = "@pId", SqlDbType = System.Data.SqlDbType.VarChar, Value = 1 });
            DataSet ds = bd.Fill("SP_SelectAlumnos", parametros);
            dgvAlumnos.DataSource = ds.Tables[0];
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
           
        }
    }
}
