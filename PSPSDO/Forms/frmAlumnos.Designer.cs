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
            this.gpbDatoPersoAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualiAlumnos
            // 
            this.btnActualiAlumnos.Location = new System.Drawing.Point(319, 203);
            this.btnActualiAlumnos.Name = "btnActualiAlumnos";
            this.btnActualiAlumnos.Size = new System.Drawing.Size(99, 23);
            this.btnActualiAlumnos.TabIndex = 0;
            this.btnActualiAlumnos.Text = "Actualizar";
            this.btnActualiAlumnos.UseVisualStyleBackColor = true;
            this.btnActualiAlumnos.Click += new System.EventHandler(this.btnActualiAlumnos_Click);
            // 
            // gpbDatoPersoAlumno
            // 
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
            this.gpbDatoPersoAlumno.Location = new System.Drawing.Point(35, 33);
            this.gpbDatoPersoAlumno.Name = "gpbDatoPersoAlumno";
            this.gpbDatoPersoAlumno.Size = new System.Drawing.Size(653, 259);
            this.gpbDatoPersoAlumno.TabIndex = 1;
            this.gpbDatoPersoAlumno.TabStop = false;
            this.gpbDatoPersoAlumno.Text = "Datos Personales";
            // 
            // btnGuardarAlumno
            // 
            this.btnGuardarAlumno.Location = new System.Drawing.Point(530, 203);
            this.btnGuardarAlumno.Name = "btnGuardarAlumno";
            this.btnGuardarAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarAlumno.TabIndex = 11;
            this.btnGuardarAlumno.Text = "Guardar";
            this.btnGuardarAlumno.UseVisualStyleBackColor = true;
            this.btnGuardarAlumno.Click += new System.EventHandler(this.btnGuardarAlumno_Click);
            // 
            // btnElimiAlumnos
            // 
            this.btnElimiAlumnos.Location = new System.Drawing.Point(423, 203);
            this.btnElimiAlumnos.Name = "btnElimiAlumnos";
            this.btnElimiAlumnos.Size = new System.Drawing.Size(75, 23);
            this.btnElimiAlumnos.TabIndex = 10;
            this.btnElimiAlumnos.Text = "Eliminar";
            this.btnElimiAlumnos.UseVisualStyleBackColor = true;
            this.btnElimiAlumnos.Click += new System.EventHandler(this.btnElimiAlumnos_Click);
            // 
            // lblDirecciAlumno
            // 
            this.lblDirecciAlumno.AutoSize = true;
            this.lblDirecciAlumno.Location = new System.Drawing.Point(188, 116);
            this.lblDirecciAlumno.Name = "lblDirecciAlumno";
            this.lblDirecciAlumno.Size = new System.Drawing.Size(64, 16);
            this.lblDirecciAlumno.TabIndex = 9;
            this.lblDirecciAlumno.Text = "Direccion";
            // 
            // lblMatriAlumno
            // 
            this.lblMatriAlumno.AutoSize = true;
            this.lblMatriAlumno.Location = new System.Drawing.Point(22, 116);
            this.lblMatriAlumno.Name = "lblMatriAlumno";
            this.lblMatriAlumno.Size = new System.Drawing.Size(61, 16);
            this.lblMatriAlumno.TabIndex = 8;
            this.lblMatriAlumno.Text = "Matricula";
            // 
            // lblApMaterAlumno
            // 
            this.lblApMaterAlumno.AutoSize = true;
            this.lblApMaterAlumno.Location = new System.Drawing.Point(349, 28);
            this.lblApMaterAlumno.Name = "lblApMaterAlumno";
            this.lblApMaterAlumno.Size = new System.Drawing.Size(109, 16);
            this.lblApMaterAlumno.TabIndex = 7;
            this.lblApMaterAlumno.Text = "Apellido Materno";
            // 
            // lblApPaterAlumno
            // 
            this.lblApPaterAlumno.AutoSize = true;
            this.lblApPaterAlumno.Location = new System.Drawing.Point(188, 28);
            this.lblApPaterAlumno.Name = "lblApPaterAlumno";
            this.lblApPaterAlumno.Size = new System.Drawing.Size(107, 16);
            this.lblApPaterAlumno.TabIndex = 6;
            this.lblApPaterAlumno.Text = "Apellido Paterno";
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Location = new System.Drawing.Point(44, 28);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(56, 16);
            this.lblNombreAlumno.TabIndex = 5;
            this.lblNombreAlumno.Text = "Nombre";
            // 
            // txtMatriAlumno
            // 
            this.txtMatriAlumno.Location = new System.Drawing.Point(25, 135);
            this.txtMatriAlumno.Name = "txtMatriAlumno";
            this.txtMatriAlumno.Size = new System.Drawing.Size(100, 22);
            this.txtMatriAlumno.TabIndex = 4;
            // 
            // txtDireccioAlumno
            // 
            this.txtDireccioAlumno.Location = new System.Drawing.Point(191, 135);
            this.txtDireccioAlumno.Name = "txtDireccioAlumno";
            this.txtDireccioAlumno.Size = new System.Drawing.Size(100, 22);
            this.txtDireccioAlumno.TabIndex = 4;
            // 
            // txtApMaterAlumno
            // 
            this.txtApMaterAlumno.Location = new System.Drawing.Point(358, 47);
            this.txtApMaterAlumno.Name = "txtApMaterAlumno";
            this.txtApMaterAlumno.Size = new System.Drawing.Size(100, 22);
            this.txtApMaterAlumno.TabIndex = 3;
            // 
            // txtApPaterAlumno
            // 
            this.txtApPaterAlumno.Location = new System.Drawing.Point(195, 47);
            this.txtApPaterAlumno.Name = "txtApPaterAlumno";
            this.txtApPaterAlumno.Size = new System.Drawing.Size(100, 22);
            this.txtApPaterAlumno.TabIndex = 2;
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(25, 47);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(100, 22);
            this.txtNombreAlumno.TabIndex = 1;
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(35, 337);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersWidth = 51;
            this.dgvAlumnos.RowTemplate.Height = 24;
            this.dgvAlumnos.Size = new System.Drawing.Size(616, 213);
            this.dgvAlumnos.TabIndex = 2;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.gpbDatoPersoAlumno);
            this.Name = "frmAlumnos";
            this.Text = "frmAlumnos";
            this.Load += new System.EventHandler(this.frmAlumnos_Load);
            this.gpbDatoPersoAlumno.ResumeLayout(false);
            this.gpbDatoPersoAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
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
    }
}