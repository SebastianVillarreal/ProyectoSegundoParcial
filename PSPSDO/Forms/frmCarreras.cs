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
            CarreraModel Carrera = new CarreraModel();
            CarreraClass CarreraManager = new CarreraClass();
            Carrera.Id = (int)dgvListaCarreras.Rows[dgvListaCarreras.CurrentCell.RowIndex].Cells[0].Value;
        }

        private void btnCarreraMostrar_Click(object sender, EventArgs e)
        {
            CarreraClass CarreraManager = new CarreraClass();
        }
    }
}
