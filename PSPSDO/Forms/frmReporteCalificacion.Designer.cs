namespace PSPSDO.Forms
{
    partial class frmReporteCalificacion
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
            this.dgvReportesCalificaciones = new System.Windows.Forms.DataGridView();
            this.cmbCarreras = new System.Windows.Forms.ComboBox();
            this.gbReportesCalificaciones = new System.Windows.Forms.GroupBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesCalificaciones)).BeginInit();
            this.gbReportesCalificaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(879, 122);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(131, 23);
            this.btnReportes.TabIndex = 0;
            this.btnReportes.Text = "Crear Reporte";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvReportesCalificaciones
            // 
            this.dgvReportesCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportesCalificaciones.Location = new System.Drawing.Point(18, 193);
            this.dgvReportesCalificaciones.Name = "dgvReportesCalificaciones";
            this.dgvReportesCalificaciones.RowHeadersWidth = 51;
            this.dgvReportesCalificaciones.RowTemplate.Height = 24;
            this.dgvReportesCalificaciones.Size = new System.Drawing.Size(1026, 349);
            this.dgvReportesCalificaciones.TabIndex = 1;
            // 
            // cmbCarreras
            // 
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.Location = new System.Drawing.Point(6, 111);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(121, 24);
            this.cmbCarreras.TabIndex = 2;
            // 
            // gbReportesCalificaciones
            // 
            this.gbReportesCalificaciones.Controls.Add(this.lblCarrera);
            this.gbReportesCalificaciones.Controls.Add(this.btnReportes);
            this.gbReportesCalificaciones.Controls.Add(this.cmbCarreras);
            this.gbReportesCalificaciones.Location = new System.Drawing.Point(12, 19);
            this.gbReportesCalificaciones.Name = "gbReportesCalificaciones";
            this.gbReportesCalificaciones.Size = new System.Drawing.Size(1043, 151);
            this.gbReportesCalificaciones.TabIndex = 3;
            this.gbReportesCalificaciones.TabStop = false;
            this.gbReportesCalificaciones.Text = "Reporte de calificaciones";
            this.gbReportesCalificaciones.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(6, 92);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(55, 16);
            this.lblCarrera.TabIndex = 3;
            this.lblCarrera.Text = "Carrera:";
            // 
            // frmReporteCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gbReportesCalificaciones);
            this.Controls.Add(this.dgvReportesCalificaciones);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReporteCalificacion";
            this.Text = "frmReporteCalificacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesCalificaciones)).EndInit();
            this.gbReportesCalificaciones.ResumeLayout(false);
            this.gbReportesCalificaciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.DataGridView dgvReportesCalificaciones;
        private System.Windows.Forms.ComboBox cmbCarreras;
        private System.Windows.Forms.GroupBox gbReportesCalificaciones;
        private System.Windows.Forms.Label lblCarrera;
    }
}