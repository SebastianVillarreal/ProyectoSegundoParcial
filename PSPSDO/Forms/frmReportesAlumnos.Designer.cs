namespace PSPSDO.Forms
{
    partial class frmReportesAlumnos
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
            this.gbRA = new System.Windows.Forms.GroupBox();
            this.btnCrearRA = new System.Windows.Forms.Button();
            this.lblRANombre = new System.Windows.Forms.Label();
            this.txtRANombre = new System.Windows.Forms.TextBox();
            this.dgvReportesAlumno = new System.Windows.Forms.DataGridView();
            this.gbRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRA
            // 
            this.gbRA.Controls.Add(this.btnCrearRA);
            this.gbRA.Controls.Add(this.lblRANombre);
            this.gbRA.Controls.Add(this.txtRANombre);
            this.gbRA.Location = new System.Drawing.Point(13, 13);
            this.gbRA.Name = "gbRA";
            this.gbRA.Size = new System.Drawing.Size(910, 119);
            this.gbRA.TabIndex = 0;
            this.gbRA.TabStop = false;
            this.gbRA.Text = "Reportes por Alumno";
            // 
            // btnCrearRA
            // 
            this.btnCrearRA.Location = new System.Drawing.Point(768, 78);
            this.btnCrearRA.Name = "btnCrearRA";
            this.btnCrearRA.Size = new System.Drawing.Size(136, 35);
            this.btnCrearRA.TabIndex = 2;
            this.btnCrearRA.Text = "Crear reporte";
            this.btnCrearRA.UseVisualStyleBackColor = true;
            this.btnCrearRA.Click += new System.EventHandler(this.btnCrearRA_Click);
            // 
            // lblRANombre
            // 
            this.lblRANombre.AutoSize = true;
            this.lblRANombre.Location = new System.Drawing.Point(7, 40);
            this.lblRANombre.Name = "lblRANombre";
            this.lblRANombre.Size = new System.Drawing.Size(77, 20);
            this.lblRANombre.TabIndex = 1;
            this.lblRANombre.Text = "Matrícula:";
            // 
            // txtRANombre
            // 
            this.txtRANombre.Location = new System.Drawing.Point(99, 37);
            this.txtRANombre.Name = "txtRANombre";
            this.txtRANombre.Size = new System.Drawing.Size(176, 26);
            this.txtRANombre.TabIndex = 0;
            this.txtRANombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvReportesAlumno
            // 
            this.dgvReportesAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportesAlumno.Location = new System.Drawing.Point(13, 150);
            this.dgvReportesAlumno.Name = "dgvReportesAlumno";
            this.dgvReportesAlumno.RowHeadersWidth = 62;
            this.dgvReportesAlumno.RowTemplate.Height = 28;
            this.dgvReportesAlumno.Size = new System.Drawing.Size(910, 288);
            this.dgvReportesAlumno.TabIndex = 1;
            // 
            // frmReportesAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.dgvReportesAlumno);
            this.Controls.Add(this.gbRA);
            this.Name = "frmReportesAlumnos";
            this.Text = "frmReportesAlumnos";
            this.Load += new System.EventHandler(this.frmReportesAlumnos_Load);
            this.gbRA.ResumeLayout(false);
            this.gbRA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesAlumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRA;
        private System.Windows.Forms.Label lblRANombre;
        private System.Windows.Forms.TextBox txtRANombre;
        private System.Windows.Forms.Button btnCrearRA;
        private System.Windows.Forms.DataGridView dgvReportesAlumno;
    }
}