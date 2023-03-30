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
    public partial class frmMaterias : Form
    {
        public frmMaterias()
        {
            InitializeComponent();
            cmbCarreraMat.DropDownStyle = ComboBoxStyle.DropDownList;
            ArrayList parametros = new ArrayList();
            BDContext bd = new BDContext();
            parametros.Add(new SqlParameter { ParameterName = "@pId", SqlDbType = System.Data.SqlDbType.VarChar, Value = 1 });
            DataSet ds = bd.Fill("sp_GetMateria", parametros);
            dgvMaterias.DataSource = ds.Tables[0];

            CarreraClass carrera = new CarreraClass();
            DataSet dsc = carrera.GetCarreras();
            DataTable dtc = dsc.Tables[0];
            cmbCarreraMat.DataSource = dtc;
            cmbCarreraMat.ValueMember = "Id";
            cmbCarreraMat.DisplayMember = "Clave";
        }

        private void btnInsertarMateria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreMateria.Text) || string.IsNullOrWhiteSpace(txtClaveMateria.Text) || string.IsNullOrWhiteSpace(txtUsuarioMateria.Text))
            {
                MessageBox.Show("Los campos Nombre, Clave y Usuario son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MateriasModel materias = new MateriasModel();
            MateriasClass materiasClass = new MateriasClass();
            materias.Nombre = txtNombreMateria.Text;
            materias.Clave = txtClaveMateria.Text;
            materias.Usuario = txtUsuarioMateria.Text;
            materias.IdCarrera = int.Parse(cmbCarreraMat.SelectedValue.ToString());
            dtpFechaMateria.Value.ToString("yyyy-MM-dd");

            string fecha_format = dtpFechaMateria.Value.ToString("yyyy-MM-dd");

            materias.Fecha = fecha_format;
            string resultados = materiasClass.InsertMateria(materias);
            MessageBox.Show(resultados);

            DataSet ds = materiasClass.GetMaterias();
            dgvMaterias.DataSource = ds.Tables[0];

            txtNombreMateria.Text ="" ;
            txtClaveMateria.Text = "";
            txtUsuarioMateria.Text ="";
        }

        private void btnEditarMateria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreMateria.Text) || string.IsNullOrWhiteSpace(txtClaveMateria.Text) || string.IsNullOrWhiteSpace(txtUsuarioMateria.Text))
            {
                MessageBox.Show("Los campos Nombre, Clave y Usuario son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MateriasModel materias = new MateriasModel();
            MateriasClass materiasClass = new MateriasClass();
            materias.Id = (int)dgvMaterias.Rows[dgvMaterias.CurrentCell.RowIndex].Cells[0].Value;
            //   MessageBox.Show(resultado.ToString());

            materias.Nombre = txtNombreMateria.Text;
            materias.Clave = txtClaveMateria.Text;
            materias.Usuario = txtUsuarioMateria.Text;
            materias.IdCarrera = int.Parse(cmbCarreraMat.SelectedValue.ToString());
            dtpFechaMateria.Value.ToString("yyyy-MM-dd");
            string fecha_format = dtpFechaMateria.Value.ToString("yyyy-MM-dd");

            materias.Fecha = fecha_format;
            string resultados = materiasClass.UpdateMateria(materias);
            MessageBox.Show(resultados);

            DataSet ds = materiasClass.GetMaterias();

            dgvMaterias.DataSource = ds.Tables[0];
            txtNombreMateria.Text = "";
            txtClaveMateria.Text = "";
            txtUsuarioMateria.Text = "";
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            MateriasModel materias = new MateriasModel();
            MateriasClass materiasClass = new MateriasClass();
            materias.Id = (int)dgvMaterias.Rows[dgvMaterias.CurrentCell.RowIndex].Cells[0].Value;
            materiasClass.DeleteMateria(materias);
            DataSet ds = materiasClass.GetMaterias();
            dgvMaterias.DataSource = ds.Tables[0];
        }

        private void txtBuscarMateria_TextChanged(object sender, EventArgs e)
        {
            MateriasClass materiasClass = new MateriasClass();
            string Busqueda = txtBuscarMateria.Text;
            materiasClass.BuscarMaterias(Busqueda);
            DataSet ds = materiasClass.BuscarMaterias(Busqueda);
            dgvMaterias.DataSource = ds.Tables[0];
        }

        private void dgvMaterias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvMaterias.SelectedRows[0];

                string Nombre = row.Cells["Nombre"].Value.ToString();
                string clave = row.Cells["Clave"].Value.ToString();
                string Usuario = row.Cells["UsuarioUltimaModificacion"].Value.ToString();

                txtNombreMateria.Text = Nombre;
                txtClaveMateria.Text = clave;
                txtUsuarioMateria.Text = Usuario;
                dtpFechaMateria.Value = Convert.ToDateTime(row.Cells["FechaActualizacion"].Value);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
