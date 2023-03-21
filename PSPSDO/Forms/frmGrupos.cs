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
    public partial class frmGrupos : Form
    {
        public frmGrupos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarGrupos_Click(object sender, EventArgs e)
        {
            GrupoModels grupoModel = new GrupoModels();

            GrupoClass grupo = new GrupoClass();

            grupoModel.Clave = txtClaveGrupos.Text;
            grupoModel.Descripcion = txtDescripcionGrupos.Text;
            grupoModel.UsuarioUltima = int.Parse(txtUsuarioGrupo.Text);

            string resultado = grupo.InsertarGrupo(grupoModel);
            MessageBox.Show(resultado);

            DataSet ds = grupo.GetGrupos();

            dgvGrupos.DataSource = ds.Tables[0];
        }

        private void btnCargarGrupos_Click(object sender, EventArgs e)
        {
            ArrayList parametros = new ArrayList();
            BDContext bd = new BDContext();
            parametros.Add(new SqlParameter { ParameterName = "@pId", SqlDbType = System.Data.SqlDbType.VarChar, Value = 1 });
            DataSet ds = bd.Fill("sp_SelectGrupos", parametros);
            dgvGrupos.DataSource = ds.Tables[0];
        }

        private void btnActualizarGrupos_Click(object sender, EventArgs e)
        {
            GrupoModels grupoModels = new GrupoModels();

            GrupoClass grupo = new GrupoClass();

            grupoModels.Id = (int)dgvGrupos.Rows[dgvGrupos.CurrentCell.RowIndex].Cells[0].Value;

            grupoModels.Clave = txtClaveGrupos.Text;
            grupoModels.Descripcion = txtDescripcionGrupos.Text;
            grupoModels.UsuarioUltima = int.Parse(txtUsuarioGrupo.Text);

            string resultado = grupo.ActualizarGrupos(grupoModels);
            MessageBox.Show(resultado);

            DataSet ds = grupo.GetGrupos();



            dgvGrupos.DataSource = ds.Tables[0];
        }

        private void btnElimiarGrupos_Click(object sender, EventArgs e)
        {
            GrupoModels grupoModels = new GrupoModels();

            GrupoClass grupo = new GrupoClass();

            grupoModels.Id = (int)dgvGrupos.Rows[dgvGrupos.CurrentCell.RowIndex].Cells[0].Value;

            string resultado = grupo.BorrarGrupos(grupoModels);
            MessageBox.Show(resultado);

            DataSet ds = grupo.GetGrupos();

            dgvGrupos.DataSource = ds.Tables[0];
        }

        private void frmGrupos_Load(object sender, EventArgs e)
        {
            ArrayList parametros = new ArrayList();
            BDContext bd = new BDContext();
            parametros.Add(new SqlParameter { ParameterName = "@pId", SqlDbType = System.Data.SqlDbType.VarChar, Value = 1 });
            DataSet ds = bd.Fill("sp_SelectGrupos", parametros);
            dgvGrupos.DataSource = ds.Tables[0];
        }

        private void txtUsuarioGrupo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
