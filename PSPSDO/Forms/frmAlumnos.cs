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
        //int ubi;

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
            //    txtIdGrupo.Text = (string)dgvAlumnos[6, ubi].Value;
            //}

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
            //Esto es del buscador
            int id = Convert.ToInt32(txtBusqueda.Text);

            string connectionString = "Data Source=104.254.247.128; Initial Catalog=BddSecParcial; User ID = sa; password=ABC1238f47!;";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Alumnos WHERE Id = @Id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Id", id);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                txtMatriAlumno.Text = reader["Matricula"].ToString();
                txtNombreAlumno.Text = reader["Nombre"].ToString();
                txtApPaterAlumno.Text = reader["ApPaterno"].ToString();
                txtApMaterAlumno.Text = reader["ApMaterno"].ToString();
                txtDireccioAlumno.Text = reader["Dirección"].ToString();
                txtIdGrupo.Text = reader["IdGrupo"].ToString();

                foreach (DataGridViewRow row in dgvAlumnos.Rows)//Esto sirve para que te seleccione la fila que buscaste
                {
                    if (Convert.ToInt32(row.Cells["Id"].Value) == id)
                    {
                        row.Selected = true;
                        dgvAlumnos.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontró ningún registro con el ID proporcionado.");
            }

            reader.Close();
            connection.Close();
        }
    }
}
