using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSPSDO.Classes;
using PSPSDO.Models;

namespace PSPSDO.Forms
{
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void btnCarreraAñadir_Click(object sender, EventArgs e)
        {
            CarreraClass CarreraManager = new CarreraClass();

        }

        private void btnCarreraBorrar_Click(object sender, EventArgs e)
        {
            CarreraClass CarreraManager = new CarreraClass();
            int ID = (int)dgvListaCarreras.Rows[dgvListaCarreras.CurrentCell.RowIndex].Cells[0].Value;
            CarreraManager.delete(dgvListaCarreras, ID);

        }

        private void btnCarreraMostrar_Click(object sender, EventArgs e)
        {
            CarreraClass CarreraManager = new CarreraClass();
            CarreraManager.show(dgvListaCarreras);
        }

        private void btnCarreraEditar_Click(object sender, EventArgs e)
        {
            CarreraClass CarreraManager = new CarreraClass();
            int ID = (int)dgvListaCarreras.Rows[dgvListaCarreras.CurrentCell.RowIndex].Cells[0].Value;
            CarreraManager.edit(dgvListaCarreras, ID,txtClaveCarrera.Text,txtNombreCarrera.Text,txtDescripcionCarrera.Text);
        }
    }
}
