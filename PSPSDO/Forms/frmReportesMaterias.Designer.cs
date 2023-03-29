namespace PSPSDO.Forms
{
    partial class frmReportesMaterias
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
            this.btnReportes = new System.Windows.Forms.Button();
            this.dgvReportesMaterias = new System.Windows.Forms.DataGridView();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.gbReportesCalificaciones = new System.Windows.Forms.GroupBox();
            this.lblMat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesMaterias)).BeginInit();
            this.gbReportesCalificaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(675, 95);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(98, 22);
            this.btnReportes.TabIndex = 0;
            this.btnReportes.Text = "Generar reporte";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvReportesMaterias
            // 
            this.dgvReportesMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportesMaterias.Location = new System.Drawing.Point(13, 157);
            this.dgvReportesMaterias.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvReportesMaterias.Name = "dgvReportesMaterias";
            this.dgvReportesMaterias.RowHeadersWidth = 51;
            this.dgvReportesMaterias.RowTemplate.Height = 24;
            this.dgvReportesMaterias.Size = new System.Drawing.Size(769, 283);
            this.dgvReportesMaterias.TabIndex = 1;
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(4, 47);
            this.cmbCarrera.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(282, 21);
            this.cmbCarrera.TabIndex = 2;
            // 
            // gbReportesCalificaciones
            // 
            this.gbReportesCalificaciones.Controls.Add(this.lblMat);
            this.gbReportesCalificaciones.Controls.Add(this.btnReportes);
            this.gbReportesCalificaciones.Controls.Add(this.cmbCarrera);
            this.gbReportesCalificaciones.Location = new System.Drawing.Point(9, 16);
            this.gbReportesCalificaciones.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbReportesCalificaciones.Name = "gbReportesCalificaciones";
            this.gbReportesCalificaciones.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbReportesCalificaciones.Size = new System.Drawing.Size(782, 123);
            this.gbReportesCalificaciones.TabIndex = 3;
            this.gbReportesCalificaciones.TabStop = false;
            this.gbReportesCalificaciones.Text = "Reporte de calificaciones por materia";
            this.gbReportesCalificaciones.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Location = new System.Drawing.Point(4, 24);
            this.lblMat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(44, 13);
            this.lblMat.TabIndex = 3;
            this.lblMat.Text = "Carrera:";
            // 
            // frmReportesMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbReportesCalificaciones);
            this.Controls.Add(this.dgvReportesMaterias);
            this.Name = "frmReportesMaterias";
            this.Text = "frmReporteCalificacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesMaterias)).EndInit();
            this.gbReportesCalificaciones.ResumeLayout(false);
            this.gbReportesCalificaciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.DataGridView dgvReportesMaterias;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.GroupBox gbReportesCalificaciones;
        private System.Windows.Forms.Label lblMat;
    }
}