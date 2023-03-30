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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbRG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesGrupos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRG
            // 
            this.gbRG.BackColor = System.Drawing.Color.Transparent;
            this.gbRG.Controls.Add(this.btnReporte);
            this.gbRG.Controls.Add(this.lblParcialGpo);
            this.gbRG.Controls.Add(this.lblGpo);
            this.gbRG.Controls.Add(this.rbParcialDos);
            this.gbRG.Controls.Add(this.rbParcialUno);
            this.gbRG.Controls.Add(this.cmbGrupos);
            this.gbRG.Location = new System.Drawing.Point(22, 53);
            this.gbRG.Margin = new System.Windows.Forms.Padding(2);
            this.gbRG.Name = "gbRG";
            this.gbRG.Padding = new System.Windows.Forms.Padding(2);
            this.gbRG.Size = new System.Drawing.Size(967, 170);
            this.gbRG.TabIndex = 0;
            this.gbRG.TabStop = false;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(646, 101);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(227, 47);
            this.btnReporte.TabIndex = 5;
            this.btnReporte.Text = "Generar  Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lblParcialGpo
            // 
            this.lblParcialGpo.AutoSize = true;
            this.lblParcialGpo.Location = new System.Drawing.Point(282, 25);
            this.lblParcialGpo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParcialGpo.Name = "lblParcialGpo";
            this.lblParcialGpo.Size = new System.Drawing.Size(106, 36);
            this.lblParcialGpo.TabIndex = 4;
            this.lblParcialGpo.Text = "Parcial:";
            // 
            // lblGpo
            // 
            this.lblGpo.AutoSize = true;
            this.lblGpo.Location = new System.Drawing.Point(23, 39);
            this.lblGpo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGpo.Name = "lblGpo";
            this.lblGpo.Size = new System.Drawing.Size(92, 36);
            this.lblGpo.TabIndex = 3;
            this.lblGpo.Text = "Grupo:";
            // 
            // rbParcialDos
            // 
            this.rbParcialDos.AutoSize = true;
            this.rbParcialDos.Location = new System.Drawing.Point(446, 74);
            this.rbParcialDos.Margin = new System.Windows.Forms.Padding(2);
            this.rbParcialDos.Name = "rbParcialDos";
            this.rbParcialDos.Size = new System.Drawing.Size(138, 40);
            this.rbParcialDos.TabIndex = 2;
            this.rbParcialDos.TabStop = true;
            this.rbParcialDos.Text = "Parcial 2";
            this.rbParcialDos.UseVisualStyleBackColor = true;
            // 
            // rbParcialUno
            // 
            this.rbParcialUno.AutoSize = true;
            this.rbParcialUno.Location = new System.Drawing.Point(288, 74);
            this.rbParcialUno.Margin = new System.Windows.Forms.Padding(2);
            this.rbParcialUno.Name = "rbParcialUno";
            this.rbParcialUno.Size = new System.Drawing.Size(134, 40);
            this.rbParcialUno.TabIndex = 1;
            this.rbParcialUno.TabStop = true;
            this.rbParcialUno.Text = "Parcial 1";
            this.rbParcialUno.UseVisualStyleBackColor = true;
            // 
            // cmbGrupos
            // 
            this.cmbGrupos.FormattingEnabled = true;
            this.cmbGrupos.Location = new System.Drawing.Point(8, 92);
            this.cmbGrupos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGrupos.Name = "cmbGrupos";
            this.cmbGrupos.Size = new System.Drawing.Size(171, 44);
            this.cmbGrupos.TabIndex = 0;
            // 
            // dgvReportesGrupos
            // 
            this.dgvReportesGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReportesGrupos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReportesGrupos.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvReportesGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportesGrupos.Location = new System.Drawing.Point(5, 260);
            this.dgvReportesGrupos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReportesGrupos.Name = "dgvReportesGrupos";
            this.dgvReportesGrupos.RowHeadersWidth = 62;
            this.dgvReportesGrupos.RowTemplate.Height = 28;
            this.dgvReportesGrupos.Size = new System.Drawing.Size(1086, 381);
            this.dgvReportesGrupos.TabIndex = 1;
            this.dgvReportesGrupos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportesGrupos_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::PSPSDO.Properties.Resources._1098321945g;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.gbRG);
            this.groupBox1.Controls.Add(this.dgvReportesGrupos);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1110, 647);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reportes por Grupos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PSPSDO.Properties.Resources.ut_menu2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::PSPSDO.Properties.Resources.ut_menu2;
            this.pictureBox1.Location = new System.Drawing.Point(994, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmReportesGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 673);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReportesGrupos";
            this.Text = "frmReportesGrupos";
            this.Load += new System.EventHandler(this.frmReportesGrupos_Load);
            this.gbRG.ResumeLayout(false);
            this.gbRG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesGrupos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}