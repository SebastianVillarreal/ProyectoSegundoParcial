namespace PSPSDO.Forms
{
    partial class frmReportesGrupos
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
            this.gbRG = new System.Windows.Forms.GroupBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.lblParcialGpo = new System.Windows.Forms.Label();
            this.lblGpo = new System.Windows.Forms.Label();
            this.rbParcialDos = new System.Windows.Forms.RadioButton();
            this.rbParcialUno = new System.Windows.Forms.RadioButton();
            this.cmbGrupos = new System.Windows.Forms.ComboBox();
            this.dgvReportesGrupos = new System.Windows.Forms.DataGridView();
            this.gbRG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRG
            // 
            this.gbRG.Controls.Add(this.btnReporte);
            this.gbRG.Controls.Add(this.lblParcialGpo);
            this.gbRG.Controls.Add(this.lblGpo);
            this.gbRG.Controls.Add(this.rbParcialDos);
            this.gbRG.Controls.Add(this.rbParcialUno);
            this.gbRG.Controls.Add(this.cmbGrupos);
            this.gbRG.Location = new System.Drawing.Point(13, 13);
            this.gbRG.Name = "gbRG";
            this.gbRG.Size = new System.Drawing.Size(775, 130);
            this.gbRG.TabIndex = 0;
            this.gbRG.TabStop = false;
            this.gbRG.Text = "Reportes por Grupos";
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(645, 86);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(124, 38);
            this.btnReporte.TabIndex = 5;
            this.btnReporte.Text = "Crear Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lblParcialGpo
            // 
            this.lblParcialGpo.AutoSize = true;
            this.lblParcialGpo.Location = new System.Drawing.Point(298, 39);
            this.lblParcialGpo.Name = "lblParcialGpo";
            this.lblParcialGpo.Size = new System.Drawing.Size(60, 20);
            this.lblParcialGpo.TabIndex = 4;
            this.lblParcialGpo.Text = "Parcial:";
            // 
            // lblGpo
            // 
            this.lblGpo.AutoSize = true;
            this.lblGpo.Location = new System.Drawing.Point(35, 39);
            this.lblGpo.Name = "lblGpo";
            this.lblGpo.Size = new System.Drawing.Size(58, 20);
            this.lblGpo.TabIndex = 3;
            this.lblGpo.Text = "Grupo:";
            // 
            // rbParcialDos
            // 
            this.rbParcialDos.AutoSize = true;
            this.rbParcialDos.Location = new System.Drawing.Point(417, 66);
            this.rbParcialDos.Name = "rbParcialDos";
            this.rbParcialDos.Size = new System.Drawing.Size(94, 24);
            this.rbParcialDos.TabIndex = 2;
            this.rbParcialDos.TabStop = true;
            this.rbParcialDos.Text = "Parcial 2";
            this.rbParcialDos.UseVisualStyleBackColor = true;
            // 
            // rbParcialUno
            // 
            this.rbParcialUno.AutoSize = true;
            this.rbParcialUno.Location = new System.Drawing.Point(302, 66);
            this.rbParcialUno.Name = "rbParcialUno";
            this.rbParcialUno.Size = new System.Drawing.Size(94, 24);
            this.rbParcialUno.TabIndex = 1;
            this.rbParcialUno.TabStop = true;
            this.rbParcialUno.Text = "Parcial 1";
            this.rbParcialUno.UseVisualStyleBackColor = true;
            // 
            // cmbGrupos
            // 
            this.cmbGrupos.FormattingEnabled = true;
            this.cmbGrupos.Location = new System.Drawing.Point(35, 65);
            this.cmbGrupos.Name = "cmbGrupos";
            this.cmbGrupos.Size = new System.Drawing.Size(159, 28);
            this.cmbGrupos.TabIndex = 0;
            // 
            // dgvReportesGrupos
            // 
            this.dgvReportesGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportesGrupos.Location = new System.Drawing.Point(13, 161);
            this.dgvReportesGrupos.Name = "dgvReportesGrupos";
            this.dgvReportesGrupos.RowHeadersWidth = 62;
            this.dgvReportesGrupos.RowTemplate.Height = 28;
            this.dgvReportesGrupos.Size = new System.Drawing.Size(775, 277);
            this.dgvReportesGrupos.TabIndex = 1;
            // 
            // frmReportesGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvReportesGrupos);
            this.Controls.Add(this.gbRG);
            this.Name = "frmReportesGrupos";
            this.Text = "frmReportesGrupos";
            this.Load += new System.EventHandler(this.frmReportesGrupos_Load);
            this.gbRG.ResumeLayout(false);
            this.gbRG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesGrupos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRG;
        private System.Windows.Forms.RadioButton rbParcialDos;
        private System.Windows.Forms.RadioButton rbParcialUno;
        private System.Windows.Forms.ComboBox cmbGrupos;
        private System.Windows.Forms.DataGridView dgvReportesGrupos;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label lblParcialGpo;
        private System.Windows.Forms.Label lblGpo;
    }
}