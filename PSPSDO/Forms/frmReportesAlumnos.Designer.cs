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
            this.gbRA.Location = new System.Drawing.Point(9, 8);
            this.gbRA.Margin = new System.Windows.Forms.Padding(2);
            this.gbRA.Name = "gbRA";
            this.gbRA.Padding = new System.Windows.Forms.Padding(2);
            this.gbRA.Size = new System.Drawing.Size(607, 77);
            this.gbRA.TabIndex = 0;
            this.gbRA.TabStop = false;
            this.gbRA.Text = "Reportes por Alumno";
            // 
            // btnCrearRA
            // 
            this.btnCrearRA.Location = new System.Drawing.Point(512, 46);
            this.btnCrearRA.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearRA.Name = "btnCrearRA";
            this.btnCrearRA.Size = new System.Drawing.Size(91, 27);
            this.btnCrearRA.TabIndex = 2;
            this.btnCrearRA.Text = "Generar reporte";
            this.btnCrearRA.UseVisualStyleBackColor = true;
            this.btnCrearRA.Click += new System.EventHandler(this.btnCrearRA_Click);
            // 
            // lblRANombre
            // 
            this.lblRANombre.AutoSize = true;
            this.lblRANombre.Location = new System.Drawing.Point(5, 26);
            this.lblRANombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRANombre.Name = "lblRANombre";
            this.lblRANombre.Size = new System.Drawing.Size(55, 13);
            this.lblRANombre.TabIndex = 1;
            this.lblRANombre.Text = "Matrícula:";
            // 
            // txtRANombre
            // 
            this.txtRANombre.Location = new System.Drawing.Point(66, 24);
            this.txtRANombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtRANombre.Name = "txtRANombre";
            this.txtRANombre.Size = new System.Drawing.Size(119, 20);
            this.txtRANombre.TabIndex = 0;
            this.txtRANombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvReportesAlumno
            // 
            this.dgvReportesAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportesAlumno.Location = new System.Drawing.Point(9, 98);
            this.dgvReportesAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReportesAlumno.Name = "dgvReportesAlumno";
            this.dgvReportesAlumno.RowHeadersWidth = 62;
            this.dgvReportesAlumno.RowTemplate.Height = 28;
            this.dgvReportesAlumno.Size = new System.Drawing.Size(607, 187);
            this.dgvReportesAlumno.TabIndex = 1;
            // 
            // frmReportesAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 292);
            this.Controls.Add(this.dgvReportesAlumno);
            this.Controls.Add(this.gbRA);
            this.Margin = new System.Windows.Forms.Padding(2);
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