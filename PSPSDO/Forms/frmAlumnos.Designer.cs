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
            this.btncargarAlumnos = new System.Windows.Forms.Button();
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
            this.btnActualiAlumnos.Location = new System.Drawing.Point(359, 254);
            this.btnActualiAlumnos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualiAlumnos.Name = "btnActualiAlumnos";
            this.btnActualiAlumnos.Size = new System.Drawing.Size(111, 29);
            this.btnActualiAlumnos.TabIndex = 0;
            this.btnActualiAlumnos.Text = "Actualizar";
            this.btnActualiAlumnos.UseVisualStyleBackColor = true;
            this.btnActualiAlumnos.Click += new System.EventHandler(this.btnActualiAlumnos_Click);
            // 
            // gpbDatoPersoAlumno
            // 
            this.gpbDatoPersoAlumno.Controls.Add(this.btncargarAlumnos);
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
            this.gpbDatoPersoAlumno.Location = new System.Drawing.Point(39, 41);
            this.gpbDatoPersoAlumno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbDatoPersoAlumno.Name = "gpbDatoPersoAlumno";
            this.gpbDatoPersoAlumno.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbDatoPersoAlumno.Size = new System.Drawing.Size(735, 324);
            this.gpbDatoPersoAlumno.TabIndex = 1;
            this.gpbDatoPersoAlumno.TabStop = false;
            this.gpbDatoPersoAlumno.Text = "Datos Personales";
            // 
            // btncargarAlumnos
            // 
            this.btncargarAlumnos.Location = new System.Drawing.Point(604, 18);
            this.btncargarAlumnos.Name = "btncargarAlumnos";
            this.btncargarAlumnos.Size = new System.Drawing.Size(125, 37);
            this.btncargarAlumnos.TabIndex = 12;
            this.btncargarAlumnos.Text = "Resfrescar";
            this.btncargarAlumnos.UseVisualStyleBackColor = true;
            this.btncargarAlumnos.Click += new System.EventHandler(this.btncargarAlumnos_Click);
            // 
            // btnGuardarAlumno
            // 
            this.btnGuardarAlumno.Location = new System.Drawing.Point(596, 254);
            this.btnGuardarAlumno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardarAlumno.Name = "btnGuardarAlumno";
            this.btnGuardarAlumno.Size = new System.Drawing.Size(84, 29);
            this.btnGuardarAlumno.TabIndex = 11;
            this.btnGuardarAlumno.Text = "Guardar";
            this.btnGuardarAlumno.UseVisualStyleBackColor = true;
            this.btnGuardarAlumno.Click += new System.EventHandler(this.btnGuardarAlumno_Click);
            // 
            // btnElimiAlumnos
            // 
            this.btnElimiAlumnos.Location = new System.Drawing.Point(476, 254);
            this.btnElimiAlumnos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnElimiAlumnos.Name = "btnElimiAlumnos";
            this.btnElimiAlumnos.Size = new System.Drawing.Size(84, 29);
            this.btnElimiAlumnos.TabIndex = 10;
            this.btnElimiAlumnos.Text = "Eliminar";
            this.btnElimiAlumnos.UseVisualStyleBackColor = true;
            this.btnElimiAlumnos.Click += new System.EventHandler(this.btnElimiAlumnos_Click);
            // 
            // lblDirecciAlumno
            // 
            this.lblDirecciAlumno.AutoSize = true;
            this.lblDirecciAlumno.Location = new System.Drawing.Point(212, 145);
            this.lblDirecciAlumno.Name = "lblDirecciAlumno";
            this.lblDirecciAlumno.Size = new System.Drawing.Size(75, 20);
            this.lblDirecciAlumno.TabIndex = 9;
            this.lblDirecciAlumno.Text = "Direccion";
            // 
            // lblMatriAlumno
            // 
            this.lblMatriAlumno.AutoSize = true;
            this.lblMatriAlumno.Location = new System.Drawing.Point(25, 145);
            this.lblMatriAlumno.Name = "lblMatriAlumno";
            this.lblMatriAlumno.Size = new System.Drawing.Size(73, 20);
            this.lblMatriAlumno.TabIndex = 8;
            this.lblMatriAlumno.Text = "Matricula";
            // 
            // lblApMaterAlumno
            // 
            this.lblApMaterAlumno.AutoSize = true;
            this.lblApMaterAlumno.Location = new System.Drawing.Point(393, 35);
            this.lblApMaterAlumno.Name = "lblApMaterAlumno";
            this.lblApMaterAlumno.Size = new System.Drawing.Size(128, 20);
            this.lblApMaterAlumno.TabIndex = 7;
            this.lblApMaterAlumno.Text = "Apellido Materno";
            // 
            // lblApPaterAlumno
            // 
            this.lblApPaterAlumno.AutoSize = true;
            this.lblApPaterAlumno.Location = new System.Drawing.Point(212, 35);
            this.lblApPaterAlumno.Name = "lblApPaterAlumno";
            this.lblApPaterAlumno.Size = new System.Drawing.Size(125, 20);
            this.lblApPaterAlumno.TabIndex = 6;
            this.lblApPaterAlumno.Text = "Apellido Paterno";
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Location = new System.Drawing.Point(50, 35);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(65, 20);
            this.lblNombreAlumno.TabIndex = 5;
            this.lblNombreAlumno.Text = "Nombre";
            // 
            // txtMatriAlumno
            // 
            this.txtMatriAlumno.Location = new System.Drawing.Point(28, 169);
            this.txtMatriAlumno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatriAlumno.Name = "txtMatriAlumno";
            this.txtMatriAlumno.Size = new System.Drawing.Size(112, 26);
            this.txtMatriAlumno.TabIndex = 4;
            // 
            // txtDireccioAlumno
            // 
            this.txtDireccioAlumno.Location = new System.Drawing.Point(215, 169);
            this.txtDireccioAlumno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccioAlumno.Name = "txtDireccioAlumno";
            this.txtDireccioAlumno.Size = new System.Drawing.Size(112, 26);
            this.txtDireccioAlumno.TabIndex = 4;
            // 
            // txtApMaterAlumno
            // 
            this.txtApMaterAlumno.Location = new System.Drawing.Point(403, 59);
            this.txtApMaterAlumno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApMaterAlumno.Name = "txtApMaterAlumno";
            this.txtApMaterAlumno.Size = new System.Drawing.Size(112, 26);
            this.txtApMaterAlumno.TabIndex = 3;
            // 
            // txtApPaterAlumno
            // 
            this.txtApPaterAlumno.Location = new System.Drawing.Point(219, 59);
            this.txtApPaterAlumno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApPaterAlumno.Name = "txtApPaterAlumno";
            this.txtApPaterAlumno.Size = new System.Drawing.Size(112, 26);
            this.txtApPaterAlumno.TabIndex = 2;
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(28, 59);
            this.txtNombreAlumno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(112, 26);
            this.txtNombreAlumno.TabIndex = 1;
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(39, 421);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersWidth = 51;
            this.dgvAlumnos.RowTemplate.Height = 24;
            this.dgvAlumnos.Size = new System.Drawing.Size(693, 266);
            this.dgvAlumnos.TabIndex = 2;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 702);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.gpbDatoPersoAlumno);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAlumnos";
            this.Text = "frmAlumnos";
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
        private System.Windows.Forms.Button btncargarAlumnos;
    }
}