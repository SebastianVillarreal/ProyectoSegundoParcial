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
            ArrayList parametros = new ArrayList();
            BDContext bd = new BDContext();
            parametros.Add(new SqlParameter { ParameterName = "@pId", SqlDbType = System.Data.SqlDbType.VarChar, Value = 1 });
            DataSet ds = bd.Fill("sp_GetMateria", parametros);
            dgvMaterias.DataSource = ds.Tables[0];
        }

             private void btnInsertarMateria_Click(object sender, EventArgs e)
        {
            MateriasModel materias = new MateriasModel();
            MateriasClass materiasClass = new MateriasClass();
            materias.Nombre = txtNombreMateria.Text;
            materias.Clave = txtClaveMateria.Text;
            materias.Usuario = txtUsuarioMateria.Text;
            dtpFechaMateria.Value.ToString("yyyy-MM-dd");

            string fecha_format = dtpFechaMateria.Value.ToString("yyyy-MM-dd");

            materias.Fecha = fecha_format;
            string resultados = materiasClass.InsertMateria(materias);
            MessageBox.Show(resultados);

            DataSet ds = materiasClass.GetMaterias();
            dgvMaterias.DataSource = ds.Tables[0];
        }

        private void btnEditarMateria_Click(object sender, EventArgs e)
        {
            MateriasModel materias = new MateriasModel();
            MateriasClass materiasClass = new MateriasClass();
            materias.Id = (int)dgvMaterias.Rows[dgvMaterias.CurrentCell.RowIndex].Cells[0].Value;
            //   MessageBox.Show(resultado.ToString());

            materias.Nombre = txtNombreMateria.Text;
            materias.Clave = txtClaveMateria.Text;
            materias.Usuario = txtUsuarioMateria.Text;
            dtpFechaMateria.Value.ToString("yyyy-MM-dd");
            string fecha_format = dtpFechaMateria.Value.ToString("yyyy-MM-dd");

            materias.Fecha = fecha_format;
            string resultados = materiasClass.UpdateMateria(materias);
            MessageBox.Show(resultados);

            DataSet ds = materiasClass.GetMaterias();
            dgvMaterias.DataSource = ds.Tables[0];
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
    }
}
