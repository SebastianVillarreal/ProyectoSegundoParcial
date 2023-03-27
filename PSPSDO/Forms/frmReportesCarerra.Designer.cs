namespace PSPSDO.Forms
{
    partial class frmReportesCarerra
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
            this.dgvReportesCarreras = new System.Windows.Forms.DataGridView();
            this.gbReportesCarreras = new System.Windows.Forms.GroupBox();
            this.cmbReportesCarreras = new System.Windows.Forms.ComboBox();
            this.rbParcialDos = new System.Windows.Forms.RadioButton();
            this.rbParcialUno = new System.Windows.Forms.RadioButton();
            this.lblReportesCarrerasParciales = new System.Windows.Forms.Label();
            this.btnReporteCarreras = new System.Windows.Forms.Button();
            this.lblReportesCarreras = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesCarreras)).BeginInit();
            this.gbReportesCarreras.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReportesCarreras
            // 
            this.dgvReportesCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportesCarreras.Location = new System.Drawing.Point(12, 211);
            this.dgvReportesCarreras.Name = "dgvReportesCarreras";
            this.dgvReportesCarreras.RowHeadersWidth = 62;
            this.dgvReportesCarreras.RowTemplate.Height = 28;
            this.dgvReportesCarreras.Size = new System.Drawing.Size(992, 275);
            this.dgvReportesCarreras.TabIndex = 0;
            // 
            // gbReportesCarreras
            // 
            this.gbReportesCarreras.Controls.Add(this.cmbReportesCarreras);
            this.gbReportesCarreras.Controls.Add(this.rbParcialDos);
            this.gbReportesCarreras.Controls.Add(this.rbParcialUno);
            this.gbReportesCarreras.Controls.Add(this.lblReportesCarrerasParciales);
            this.gbReportesCarreras.Controls.Add(this.btnReporteCarreras);
            this.gbReportesCarreras.Controls.Add(this.lblReportesCarreras);
            this.gbReportesCarreras.Location = new System.Drawing.Point(12, 12);
            this.gbReportesCarreras.Name = "gbReportesCarreras";
            this.gbReportesCarreras.Size = new System.Drawing.Size(992, 177);
            this.gbReportesCarreras.TabIndex = 1;
            this.gbReportesCarreras.TabStop = false;
            this.gbReportesCarreras.Text = "Reportes por Carreras";
            this.gbReportesCarreras.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbReportesCarreras
            // 
            this.cmbReportesCarreras.FormattingEnabled = true;
            this.cmbReportesCarreras.Location = new System.Drawing.Point(21, 73);
            this.cmbReportesCarreras.Name = "cmbReportesCarreras";
            this.cmbReportesCarreras.Size = new System.Drawing.Size(571, 28);
            this.cmbReportesCarreras.TabIndex = 6;
            // 
            // rbParcialDos
            // 
            this.rbParcialDos.AutoSize = true;
            this.rbParcialDos.Location = new System.Drawing.Point(780, 74);
            this.rbParcialDos.Name = "rbParcialDos";
            this.rbParcialDos.Size = new System.Drawing.Size(94, 24);
            this.rbParcialDos.TabIndex = 5;
            this.rbParcialDos.TabStop = true;
            this.rbParcialDos.Text = "Parcial 2";
            this.rbParcialDos.UseVisualStyleBackColor = true;
            // 
            // rbParcialUno
            // 
            this.rbParcialUno.AutoSize = true;
            this.rbParcialUno.Location = new System.Drawing.Point(634, 74);
            this.rbParcialUno.Name = "rbParcialUno";
            this.rbParcialUno.Size = new System.Drawing.Size(94, 24);
            this.rbParcialUno.TabIndex = 4;
            this.rbParcialUno.TabStop = true;
            this.rbParcialUno.Text = "Parcial 1";
            this.rbParcialUno.UseVisualStyleBackColor = true;
            // 
            // lblReportesCarrerasParciales
            // 
            this.lblReportesCarrerasParciales.AutoSize = true;
            this.lblReportesCarrerasParciales.Location = new System.Drawing.Point(630, 46);
            this.lblReportesCarrerasParciales.Name = "lblReportesCarrerasParciales";
            this.lblReportesCarrerasParciales.Size = new System.Drawing.Size(64, 20);
            this.lblReportesCarrerasParciales.TabIndex = 2;
            this.lblReportesCarrerasParciales.Text = "Parcial :";
            // 
            // btnReporteCarreras
            // 
            this.btnReporteCarreras.Location = new System.Drawing.Point(842, 131);
            this.btnReporteCarreras.Name = "btnReporteCarreras";
            this.btnReporteCarreras.Size = new System.Drawing.Size(144, 40);
            this.btnReporteCarreras.TabIndex = 1;
            this.btnReporteCarreras.Text = "Crear Reporte";
            this.btnReporteCarreras.UseVisualStyleBackColor = true;
            this.btnReporteCarreras.Click += new System.EventHandler(this.btnReporteCarreras_Click);
            // 
            // lblReportesCarreras
            // 
            this.lblReportesCarreras.AutoSize = true;
            this.lblReportesCarreras.Location = new System.Drawing.Point(17, 45);
            this.lblReportesCarreras.Name = "lblReportesCarreras";
            this.lblReportesCarreras.Size = new System.Drawing.Size(74, 20);
            this.lblReportesCarreras.TabIndex = 0;
            this.lblReportesCarreras.Text = "Carreras:";
            // 
            // frmReportesCarerra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 498);
            this.Controls.Add(this.gbReportesCarreras);
            this.Controls.Add(this.dgvReportesCarreras);
            this.Name = "frmReportesCarerra";
            this.Text = "frmReportesCarerra";
            this.Load += new System.EventHandler(this.frmReportesCarerra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesCarreras)).EndInit();
            this.gbReportesCarreras.ResumeLayout(false);
            this.gbReportesCarreras.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReportesCarreras;
        private System.Windows.Forms.GroupBox gbReportesCarreras;
        private System.Windows.Forms.ComboBox cmbReportesCarreras;
        private System.Windows.Forms.RadioButton rbParcialDos;
        private System.Windows.Forms.RadioButton rbParcialUno;
        private System.Windows.Forms.Label lblReportesCarrerasParciales;
        private System.Windows.Forms.Button btnReporteCarreras;
        private System.Windows.Forms.Label lblReportesCarreras;
    }
}