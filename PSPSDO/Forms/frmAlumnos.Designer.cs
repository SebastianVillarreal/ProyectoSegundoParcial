namespace PSPSDO.Forms
{
    partial class frmAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnActualiAlumnos = new System.Windows.Forms.Button();
            this.gpbDatoPersoAlumno = new System.Windows.Forms.GroupBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.txtIdGrupo = new System.Windows.Forms.TextBox();
            this.btnGuardarAlumno = new System.Windows.Forms.Button();
            this.btnElimiAlumnos = new System.Windows.Forms.Button();
            this.lblDirecciAlumno = new System.Windows.Forms.Label();
            this.lblMatriAlumno = new System.Windows.Forms.Label();
            this.lblApMaterAlumno = new System.Windows.Forms.Label();
            this.lblApPaterAlumno = new System.Windows.Forms.Label();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.txtMatriAlumno = new System.Windows.Forms.TextBox();
            this.txtDireccioAlumno = new System.Windows.Forms.TextBox();
            this.txtApMaterAlumno = new System.Windows.Forms.TextBox();
            this.txtApPaterAlumno = new System.Windows.Forms.TextBox();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbDatoPersoAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualiAlumnos
            // 
            this.btnActualiAlumnos.BackgroundImage = global::PSPSDO.Properties.Resources.Update_icon;
            this.btnActualiAlumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualiAlumnos.Location = new System.Drawing.Point(395, 169);
            this.btnActualiAlumnos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnActualiAlumnos.Name = "btnActualiAlumnos";
            this.btnActualiAlumnos.Size = new System.Drawing.Size(54, 44);
            this.btnActualiAlumnos.TabIndex = 0;
            this.btnActualiAlumnos.UseVisualStyleBackColor = true;
            this.btnActualiAlumnos.Click += new System.EventHandler(this.btnActualiAlumnos_Click);
            // 
            // gpbDatoPersoAlumno
            // 
            this.gpbDatoPersoAlumno.Controls.Add(this.lblGrupo);
            this.gpbDatoPersoAlumno.Controls.Add(this.txtIdGrupo);
            this.gpbDatoPersoAlumno.Controls.Add(this.btnGuardarAlumno);
            this.gpbDatoPersoAlumno.Controls.Add(this.btnElimiAlumnos);
            this.gpbDatoPersoAlumno.Controls.Add(this.lblDirecciAlumno);
            this.gpbDatoPersoAlumno.Controls.Add(this.lblMatriAlumno);
            this.gpbDatoPersoAlumno.Controls.Add(this.lblApMaterAlumno);
            this.gpbDatoPersoAlumno.Controls.Add(this.lblApPaterAlumno);
            this.gpbDatoPersoAlumno.Controls.Add(this.lblNombreAlumno);
            this.gpbDatoPersoAlumno.Controls.Add(this.txtMatriAlumno);
            this.gpbDatoPersoAlumno.Controls.Add(this.txtDireccioAlumno);
            this.gpbDatoPersoAlumno.Controls.Add(this.txtApMaterAlumno);
            this.gpbDatoPersoAlumno.Controls.Add(this.txtApPaterAlumno);
            this.gpbDatoPersoAlumno.Controls.Add(this.txtNombreAlumno);
            this.gpbDatoPersoAlumno.Controls.Add(this.btnActualiAlumnos);
            this.gpbDatoPersoAlumno.Location = new System.Drawing.Point(5, 74);
            this.gpbDatoPersoAlumno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbDatoPersoAlumno.Name = "gpbDatoPersoAlumno";
            this.gpbDatoPersoAlumno.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbDatoPersoAlumno.Size = new System.Drawing.Size(1330, 236);
            this.gpbDatoPersoAlumno.TabIndex = 1;
            this.gpbDatoPersoAlumno.TabStop = false;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(79, 130);
            this.lblGrupo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(154, 36);
            this.lblGrupo.TabIndex = 13;
            this.lblGrupo.Text = "Id de grupo:";
            // 
            // txtIdGrupo
            // 
            this.txtIdGrupo.Location = new System.Drawing.Point(69, 169);
            this.txtIdGrupo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtIdGrupo.Name = "txtIdGrupo";
            this.txtIdGrupo.Size = new System.Drawing.Size(174, 43);
            this.txtIdGrupo.TabIndex = 12;
            // 
            // btnGuardarAlumno
            // 
            this.btnGuardarAlumno.BackgroundImage = global::PSPSDO.Properties.Resources.Guardar_icon;
            this.btnGuardarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarAlumno.Location = new System.Drawing.Point(597, 169);
            this.btnGuardarAlumno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGuardarAlumno.Name = "btnGuardarAlumno";
            this.btnGuardarAlumno.Size = new System.Drawing.Size(44, 44);
            this.btnGuardarAlumno.TabIndex = 11;
            this.btnGuardarAlumno.UseVisualStyleBackColor = true;
            this.btnGuardarAlumno.Click += new System.EventHandler(this.btnGuardarAlumno_Click);
            // 
            // btnElimiAlumnos
            // 
            this.btnElimiAlumnos.BackgroundImage = global::PSPSDO.Properties.Resources.Borrar_icon;
            this.btnElimiAlumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnElimiAlumnos.Location = new System.Drawing.Point(495, 169);
            this.btnElimiAlumnos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnElimiAlumnos.Name = "btnElimiAlumnos";
            this.btnElimiAlumnos.Size = new System.Drawing.Size(51, 44);
            this.btnElimiAlumnos.TabIndex = 10;
            this.btnElimiAlumnos.UseVisualStyleBackColor = true;
            this.btnElimiAlumnos.Click += new System.EventHandler(this.btnElimiAlumnos_Click);
            // 
            // lblDirecciAlumno
            // 
            this.lblDirecciAlumno.AutoSize = true;
            this.lblDirecciAlumno.Location = new System.Drawing.Point(1153, 39);
            this.lblDirecciAlumno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDirecciAlumno.Name = "lblDirecciAlumno";
            this.lblDirecciAlumno.Size = new System.Drawing.Size(136, 36);
            this.lblDirecciAlumno.TabIndex = 9;
            this.lblDirecciAlumno.Text = "Dirección:";
            // 
            // lblMatriAlumno
            // 
            this.lblMatriAlumno.AutoSize = true;
            this.lblMatriAlumno.Location = new System.Drawing.Point(948, 39);
            this.lblMatriAlumno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatriAlumno.Name = "lblMatriAlumno";
            this.lblMatriAlumno.Size = new System.Drawing.Size(136, 36);
            this.lblMatriAlumno.TabIndex = 8;
            this.lblMatriAlumno.Text = "Matricula:";
            // 
            // lblApMaterAlumno
            // 
            this.lblApMaterAlumno.AutoSize = true;
            this.lblApMaterAlumno.Location = new System.Drawing.Point(665, 39);
            this.lblApMaterAlumno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApMaterAlumno.Name = "lblApMaterAlumno";
            this.lblApMaterAlumno.Size = new System.Drawing.Size(224, 36);
            this.lblApMaterAlumno.TabIndex = 7;
            this.lblApMaterAlumno.Text = "Apellido Materno:";
            // 
            // lblApPaterAlumno
            // 
            this.lblApPaterAlumno.AutoSize = true;
            this.lblApPaterAlumno.Location = new System.Drawing.Point(389, 39);
            this.lblApPaterAlumno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApPaterAlumno.Name = "lblApPaterAlumno";
            this.lblApPaterAlumno.Size = new System.Drawing.Size(218, 36);
            this.lblApPaterAlumno.TabIndex = 6;
            this.lblApPaterAlumno.Text = "Apellido Paterno:";
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Location = new System.Drawing.Point(119, 39);
            this.lblNombreAlumno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(114, 36);
            this.lblNombreAlumno.TabIndex = 5;
            this.lblNombreAlumno.Text = "Nombre:";
            // 
            // txtMatriAlumno
            // 
            this.txtMatriAlumno.Location = new System.Drawing.Point(939, 78);
            this.txtMatriAlumno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMatriAlumno.Name = "txtMatriAlumno";
            this.txtMatriAlumno.Size = new System.Drawing.Size(158, 43);
            this.txtMatriAlumno.TabIndex = 4;
            // 
            // txtDireccioAlumno
            // 
            this.txtDireccioAlumno.Location = new System.Drawing.Point(1121, 78);
            this.txtDireccioAlumno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDireccioAlumno.Name = "txtDireccioAlumno";
            this.txtDireccioAlumno.Size = new System.Drawing.Size(188, 43);
            this.txtDireccioAlumno.TabIndex = 4;
            // 
            // txtApMaterAlumno
            // 
            this.txtApMaterAlumno.Location = new System.Drawing.Point(671, 78);
            this.txtApMaterAlumno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtApMaterAlumno.Name = "txtApMaterAlumno";
            this.txtApMaterAlumno.Size = new System.Drawing.Size(210, 43);
            this.txtApMaterAlumno.TabIndex = 3;
            this.txtApMaterAlumno.TextChanged += new System.EventHandler(this.txtApMaterAlumno_TextChanged);
            // 
            // txtApPaterAlumno
            // 
            this.txtApPaterAlumno.Location = new System.Drawing.Point(389, 78);
            this.txtApPaterAlumno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtApPaterAlumno.Name = "txtApPaterAlumno";
            this.txtApPaterAlumno.Size = new System.Drawing.Size(218, 43);
            this.txtApPaterAlumno.TabIndex = 2;
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(44, 78);
            this.txtNombreAlumno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(254, 43);
            this.txtNombreAlumno.TabIndex = 1;
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(17, 478);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersWidth = 51;
            this.dgvAlumnos.RowTemplate.Height = 24;
            this.dgvAlumnos.Size = new System.Drawing.Size(1318, 400);
            this.dgvAlumnos.TabIndex = 2;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(319, 345);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(327, 43);
            this.txtBusqueda.TabIndex = 4;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(5, 345);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(283, 36);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Búsqueda por nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::PSPSDO.Properties.Resources._1098321945g;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Controls.Add(this.lblSearch);
            this.groupBox1.Controls.Add(this.gpbDatoPersoAlumno);
            this.groupBox1.Controls.Add(this.dgvAlumnos);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1583, 1064);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumnos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PSPSDO.Properties.Resources.ut_menu2;
            this.pictureBox1.Location = new System.Drawing.Point(1297, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 1061);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmAlumnos";
            this.Text = "frmAlumnos";
            this.Load += new System.EventHandler(this.frmAlumnos_Load);
            this.gpbDatoPersoAlumno.ResumeLayout(false);
            this.gpbDatoPersoAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActualiAlumnos;
        private System.Windows.Forms.GroupBox gpbDatoPersoAlumno;
        private System.Windows.Forms.Button btnGuardarAlumno;
        private System.Windows.Forms.Button btnElimiAlumnos;
        private System.Windows.Forms.Label lblDirecciAlumno;
        private System.Windows.Forms.Label lblMatriAlumno;
        private System.Windows.Forms.Label lblApMaterAlumno;
        private System.Windows.Forms.Label lblApPaterAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.TextBox txtMatriAlumno;
        private System.Windows.Forms.TextBox txtDireccioAlumno;
        private System.Windows.Forms.TextBox txtApMaterAlumno;
        private System.Windows.Forms.TextBox txtApPaterAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.TextBox txtIdGrupo;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}