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
            this.gpbDatoPersoAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualiAlumnos
            // 
            this.btnActualiAlumnos.Location = new System.Drawing.Point(464, 125);
            this.btnActualiAlumnos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnActualiAlumnos.Name = "btnActualiAlumnos";
            this.btnActualiAlumnos.Size = new System.Drawing.Size(119, 44);
            this.btnActualiAlumnos.TabIndex = 0;
            this.btnActualiAlumnos.Text = "Actualizar registro";
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
            this.gpbDatoPersoAlumno.Location = new System.Drawing.Point(26, 27);
            this.gpbDatoPersoAlumno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbDatoPersoAlumno.Name = "gpbDatoPersoAlumno";
            this.gpbDatoPersoAlumno.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gpbDatoPersoAlumno.Size = new System.Drawing.Size(874, 195);
            this.gpbDatoPersoAlumno.TabIndex = 1;
            this.gpbDatoPersoAlumno.TabStop = false;
            this.gpbDatoPersoAlumno.Text = "Datos Personales del Alumno";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(21, 104);
            this.lblGrupo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(64, 13);
            this.lblGrupo.TabIndex = 13;
            this.lblGrupo.Text = "Id de grupo:";
            // 
            // txtIdGrupo
            // 
            this.txtIdGrupo.Location = new System.Drawing.Point(21, 125);
            this.txtIdGrupo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtIdGrupo.Name = "txtIdGrupo";
            this.txtIdGrupo.Size = new System.Drawing.Size(76, 20);
            this.txtIdGrupo.TabIndex = 12;
            // 
            // btnGuardarAlumno
            // 
            this.btnGuardarAlumno.Location = new System.Drawing.Point(740, 125);
            this.btnGuardarAlumno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGuardarAlumno.Name = "btnGuardarAlumno";
            this.btnGuardarAlumno.Size = new System.Drawing.Size(109, 44);
            this.btnGuardarAlumno.TabIndex = 11;
            this.btnGuardarAlumno.Text = "Guardar registro";
            this.btnGuardarAlumno.UseVisualStyleBackColor = true;
            this.btnGuardarAlumno.Click += new System.EventHandler(this.btnGuardarAlumno_Click);
            // 
            // btnElimiAlumnos
            // 
            this.btnElimiAlumnos.Location = new System.Drawing.Point(605, 125);
            this.btnElimiAlumnos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnElimiAlumnos.Name = "btnElimiAlumnos";
            this.btnElimiAlumnos.Size = new System.Drawing.Size(112, 44);
            this.btnElimiAlumnos.TabIndex = 10;
            this.btnElimiAlumnos.Text = "Eliminar registro";
            this.btnElimiAlumnos.UseVisualStyleBackColor = true;
            this.btnElimiAlumnos.Click += new System.EventHandler(this.btnElimiAlumnos_Click);
            // 
            // lblDirecciAlumno
            // 
            this.lblDirecciAlumno.AutoSize = true;
            this.lblDirecciAlumno.Location = new System.Drawing.Point(738, 29);
            this.lblDirecciAlumno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDirecciAlumno.Name = "lblDirecciAlumno";
            this.lblDirecciAlumno.Size = new System.Drawing.Size(55, 13);
            this.lblDirecciAlumno.TabIndex = 9;
            this.lblDirecciAlumno.Text = "Dirección:";
            // 
            // lblMatriAlumno
            // 
            this.lblMatriAlumno.AutoSize = true;
            this.lblMatriAlumno.Location = new System.Drawing.Point(559, 29);
            this.lblMatriAlumno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatriAlumno.Name = "lblMatriAlumno";
            this.lblMatriAlumno.Size = new System.Drawing.Size(53, 13);
            this.lblMatriAlumno.TabIndex = 8;
            this.lblMatriAlumno.Text = "Matricula:";
            // 
            // lblApMaterAlumno
            // 
            this.lblApMaterAlumno.AutoSize = true;
            this.lblApMaterAlumno.Location = new System.Drawing.Point(359, 29);
            this.lblApMaterAlumno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApMaterAlumno.Name = "lblApMaterAlumno";
            this.lblApMaterAlumno.Size = new System.Drawing.Size(89, 13);
            this.lblApMaterAlumno.TabIndex = 7;
            this.lblApMaterAlumno.Text = "Apellido Materno:";
            // 
            // lblApPaterAlumno
            // 
            this.lblApPaterAlumno.AutoSize = true;
            this.lblApPaterAlumno.Location = new System.Drawing.Point(175, 29);
            this.lblApPaterAlumno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApPaterAlumno.Name = "lblApPaterAlumno";
            this.lblApPaterAlumno.Size = new System.Drawing.Size(87, 13);
            this.lblApPaterAlumno.TabIndex = 6;
            this.lblApPaterAlumno.Text = "Apellido Paterno:";
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Location = new System.Drawing.Point(18, 29);
            this.lblNombreAlumno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(47, 13);
            this.lblNombreAlumno.TabIndex = 5;
            this.lblNombreAlumno.Text = "Nombre:";
            // 
            // txtMatriAlumno
            // 
            this.txtMatriAlumno.Location = new System.Drawing.Point(562, 48);
            this.txtMatriAlumno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMatriAlumno.Name = "txtMatriAlumno";
            this.txtMatriAlumno.Size = new System.Drawing.Size(76, 20);
            this.txtMatriAlumno.TabIndex = 4;
            // 
            // txtDireccioAlumno
            // 
            this.txtDireccioAlumno.Location = new System.Drawing.Point(740, 48);
            this.txtDireccioAlumno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDireccioAlumno.Name = "txtDireccioAlumno";
            this.txtDireccioAlumno.Size = new System.Drawing.Size(76, 20);
            this.txtDireccioAlumno.TabIndex = 4;
            // 
            // txtApMaterAlumno
            // 
            this.txtApMaterAlumno.Location = new System.Drawing.Point(361, 48);
            this.txtApMaterAlumno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtApMaterAlumno.Name = "txtApMaterAlumno";
            this.txtApMaterAlumno.Size = new System.Drawing.Size(133, 20);
            this.txtApMaterAlumno.TabIndex = 3;
            // 
            // txtApPaterAlumno
            // 
            this.txtApPaterAlumno.Location = new System.Drawing.Point(178, 48);
            this.txtApPaterAlumno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtApPaterAlumno.Name = "txtApPaterAlumno";
            this.txtApPaterAlumno.Size = new System.Drawing.Size(120, 20);
            this.txtApPaterAlumno.TabIndex = 2;
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(21, 48);
            this.txtNombreAlumno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(126, 20);
            this.txtNombreAlumno.TabIndex = 1;
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(38, 469);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersWidth = 51;
            this.dgvAlumnos.RowTemplate.Height = 24;
            this.dgvAlumnos.Size = new System.Drawing.Size(893, 361);
            this.dgvAlumnos.TabIndex = 2;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(141, 237);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(104, 20);
            this.txtBusqueda.TabIndex = 4;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(23, 240);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(114, 13);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Búsqueda por nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(948, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1022, 645);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 1061);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.gpbDatoPersoAlumno);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmAlumnos";
            this.Text = "frmAlumnos";
            this.Load += new System.EventHandler(this.frmAlumnos_Load);
            this.gpbDatoPersoAlumno.ResumeLayout(false);
            this.gpbDatoPersoAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}