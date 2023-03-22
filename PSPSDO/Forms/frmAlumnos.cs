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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            DataGridViewRow row = dgvAlumnos.SelectedRows[0];

            txtMatriAlumno.Text = row.Cells["Matricula"].Value.ToString();
            txtNombreAlumno.Text = row.Cells["Nombre"].Value.ToString();
            txtApPaterAlumno.Text = row.Cells["ApPaterno"].Value.ToString();
            txtApMaterAlumno.Text = row.Cells["ApMaterno"].Value.ToString();
            txtDireccioAlumno.Text = row.Cells["Dirección"].Value.ToString();
            txtIdGrupo.Text = row.Cells["IdGrupo"].Value.ToString();
        }

        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            if (txtMatriAlumno.Text == "" || txtNombreAlumno.Text == "" || txtApPaterAlumno.Text == "" || txtApMaterAlumno.Text == "" || txtDireccioAlumno.Text == "" || txtIdGrupo.Text == "")
            {
                MessageBox.Show("Llena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AlumnosModel Alumnos = new AlumnosModel();
                AlumnosClass Alumn = new AlumnosClass();

                Alumnos.Matricula = int.Parse(txtMatriAlumno.Text);
                Alumnos.Nombre = txtNombreAlumno.Text;
                Alumnos.ApellidoPaterno = txtApPaterAlumno.Text;
                Alumnos.ApellidoMaterno = txtApMaterAlumno.Text;
                Alumnos.Direccion = txtDireccioAlumno.Text;
                Alumnos.IdGrupo = int.Parse(txtIdGrupo.Text);

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
        }

        private void btnActualiAlumnos_Click(object sender, EventArgs e)
        {
            if (txtMatriAlumno.Text == "" || txtNombreAlumno.Text == "" || txtApPaterAlumno.Text == "" || txtApMaterAlumno.Text == "" || txtDireccioAlumno.Text == "" || txtIdGrupo.Text == "")
            {
                MessageBox.Show("Para asegurarnos de que todos \nlos datos estén correctos, tebes \nllenarlos otra vez.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AlumnosModel Alumnos = new AlumnosModel();
                AlumnosClass Alumn = new AlumnosClass();

                Alumnos.Id = (int)dgvAlumnos.Rows[dgvAlumnos.CurrentCell.RowIndex].Cells[0].Value;
                Alumnos.Matricula = int.Parse(txtMatriAlumno.Text);
                Alumnos.Nombre = txtNombreAlumno.Text;
                Alumnos.ApellidoPaterno = txtApPaterAlumno.Text;
                Alumnos.ApellidoMaterno = txtApMaterAlumno.Text;
                Alumnos.Direccion = txtDireccioAlumno.Text;
                Alumnos.IdGrupo = int.Parse(txtIdGrupo.Text);

                string resultados = Alumn.ActualizarAlumnos(Alumnos);
                MessageBox.Show(resultados);

                DataSet ds = Alumn.GetAlumnos();
                dgvAlumnos.DataSource = ds.Tables[0];
            }
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
           
            Carga();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //AlumnosClass Alumn = new AlumnosClass();
            //string Busqueda = txtBusqueda.Text;
            //Alumn.BuscarAlumnos(Busqueda);
            //DataSet ds = Alumn.BuscarAlumnos(Busqueda);
            //dgvAlumnos.DataSource = ds.Tables[0];
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            AlumnosClass Alumn = new AlumnosClass();
            string Busqueda = txtBusqueda.Text;
            Alumn.BuscarAlumnos(Busqueda);
            DataSet ds = Alumn.BuscarAlumnos(Busqueda);
            dgvAlumnos.DataSource = ds.Tables[0];
        }
    }
}
