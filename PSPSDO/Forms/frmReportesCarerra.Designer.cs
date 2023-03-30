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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesCarreras)).BeginInit();
            this.gbReportesCarreras.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReportesCarreras
            // 
            this.dgvReportesCarreras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReportesCarreras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReportesCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportesCarreras.Location = new System.Drawing.Point(14, 280);
            this.dgvReportesCarreras.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReportesCarreras.Name = "dgvReportesCarreras";
            this.dgvReportesCarreras.RowHeadersWidth = 62;
            this.dgvReportesCarreras.RowTemplate.Height = 28;
            this.dgvReportesCarreras.Size = new System.Drawing.Size(938, 287);
            this.dgvReportesCarreras.TabIndex = 0;
            // 
            // gbReportesCarreras
            // 
            this.gbReportesCarreras.BackColor = System.Drawing.Color.Transparent;
            this.gbReportesCarreras.Controls.Add(this.cmbReportesCarreras);
            this.gbReportesCarreras.Controls.Add(this.rbParcialDos);
            this.gbReportesCarreras.Controls.Add(this.rbParcialUno);
            this.gbReportesCarreras.Controls.Add(this.lblReportesCarrerasParciales);
            this.gbReportesCarreras.Controls.Add(this.btnReporteCarreras);
            this.gbReportesCarreras.Controls.Add(this.lblReportesCarreras);
            this.gbReportesCarreras.Location = new System.Drawing.Point(14, 41);
            this.gbReportesCarreras.Margin = new System.Windows.Forms.Padding(2);
            this.gbReportesCarreras.Name = "gbReportesCarreras";
            this.gbReportesCarreras.Padding = new System.Windows.Forms.Padding(2);
            this.gbReportesCarreras.Size = new System.Drawing.Size(938, 183);
            this.gbReportesCarreras.TabIndex = 1;
            this.gbReportesCarreras.TabStop = false;
            this.gbReportesCarreras.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbReportesCarreras
            // 
            this.cmbReportesCarreras.FormattingEnabled = true;
            this.cmbReportesCarreras.Location = new System.Drawing.Point(17, 62);
            this.cmbReportesCarreras.Margin = new System.Windows.Forms.Padding(2);
            this.cmbReportesCarreras.Name = "cmbReportesCarreras";
            this.cmbReportesCarreras.Size = new System.Drawing.Size(382, 44);
            this.cmbReportesCarreras.TabIndex = 6;
            // 
            // rbParcialDos
            // 
            this.rbParcialDos.AutoSize = true;
            this.rbParcialDos.Location = new System.Drawing.Point(685, 66);
            this.rbParcialDos.Margin = new System.Windows.Forms.Padding(2);
            this.rbParcialDos.Name = "rbParcialDos";
            this.rbParcialDos.Size = new System.Drawing.Size(138, 40);
            this.rbParcialDos.TabIndex = 5;
            this.rbParcialDos.TabStop = true;
            this.rbParcialDos.Text = "Parcial 2";
            this.rbParcialDos.UseVisualStyleBackColor = true;
            // 
            // rbParcialUno
            // 
            this.rbParcialUno.AutoSize = true;
            this.rbParcialUno.Location = new System.Drawing.Point(513, 66);
            this.rbParcialUno.Margin = new System.Windows.Forms.Padding(2);
            this.rbParcialUno.Name = "rbParcialUno";
            this.rbParcialUno.Size = new System.Drawing.Size(134, 40);
            this.rbParcialUno.TabIndex = 4;
            this.rbParcialUno.TabStop = true;
            this.rbParcialUno.Text = "Parcial 1";
            this.rbParcialUno.UseVisualStyleBackColor = true;
            // 
            // lblReportesCarrerasParciales
            // 
            this.lblReportesCarrerasParciales.AutoSize = true;
            this.lblReportesCarrerasParciales.Location = new System.Drawing.Point(536, 19);
            this.lblReportesCarrerasParciales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportesCarrerasParciales.Name = "lblReportesCarrerasParciales";
            this.lblReportesCarrerasParciales.Size = new System.Drawing.Size(111, 36);
            this.lblReportesCarrerasParciales.TabIndex = 2;
            this.lblReportesCarrerasParciales.Text = "Parcial :";
            // 
            // btnReporteCarreras
            // 
            this.btnReporteCarreras.Location = new System.Drawing.Point(698, 132);
            this.btnReporteCarreras.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteCarreras.Name = "btnReporteCarreras";
            this.btnReporteCarreras.Size = new System.Drawing.Size(236, 47);
            this.btnReporteCarreras.TabIndex = 1;
            this.btnReporteCarreras.Text = "Genera Reportes";
            this.btnReporteCarreras.UseVisualStyleBackColor = true;
            this.btnReporteCarreras.Click += new System.EventHandler(this.btnReporteCarreras_Click);
            // 
            // lblReportesCarreras
            // 
            this.lblReportesCarreras.AutoSize = true;
            this.lblReportesCarreras.Location = new System.Drawing.Point(11, 29);
            this.lblReportesCarreras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportesCarreras.Name = "lblReportesCarreras";
            this.lblReportesCarreras.Size = new System.Drawing.Size(126, 36);
            this.lblReportesCarreras.TabIndex = 0;
            this.lblReportesCarreras.Text = "Carreras:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::PSPSDO.Properties.Resources._1098321945g;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.gbReportesCarreras);
            this.groupBox1.Controls.Add(this.dgvReportesCarreras);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1210, 719);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reportes Carreras";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PSPSDO.Properties.Resources.ut_menu2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1007, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 125);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmReportesCarerra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 659);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReportesCarerra";
            this.Text = "frmReportesCarerra";
            this.Load += new System.EventHandler(this.frmReportesCarerra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesCarreras)).EndInit();
            this.gbReportesCarreras.ResumeLayout(false);
            this.gbReportesCarreras.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}