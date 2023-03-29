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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesAlumno)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRA
            // 
            this.gbRA.BackColor = System.Drawing.Color.Transparent;
            this.gbRA.Controls.Add(this.btnCrearRA);
            this.gbRA.Controls.Add(this.lblRANombre);
            this.gbRA.Controls.Add(this.txtRANombre);
            this.gbRA.Location = new System.Drawing.Point(19, 41);
            this.gbRA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRA.Name = "gbRA";
            this.gbRA.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRA.Size = new System.Drawing.Size(1042, 230);
            this.gbRA.TabIndex = 0;
            this.gbRA.TabStop = false;
            // 
            // btnCrearRA
            // 
            this.btnCrearRA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearRA.Location = new System.Drawing.Point(720, 88);
            this.btnCrearRA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCrearRA.Name = "btnCrearRA";
            this.btnCrearRA.Size = new System.Drawing.Size(239, 42);
            this.btnCrearRA.TabIndex = 2;
            this.btnCrearRA.Text = "Genera Reportes";
            this.btnCrearRA.UseVisualStyleBackColor = true;
            // 
            // lblRANombre
            // 
            this.lblRANombre.AutoSize = true;
            this.lblRANombre.Location = new System.Drawing.Point(13, 91);
            this.lblRANombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRANombre.Name = "lblRANombre";
            this.lblRANombre.Size = new System.Drawing.Size(114, 36);
            this.lblRANombre.TabIndex = 1;
            this.lblRANombre.Text = "Nombre:";
            // 
            // txtRANombre
            // 
            this.txtRANombre.Location = new System.Drawing.Point(131, 88);
            this.txtRANombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRANombre.Name = "txtRANombre";
            this.txtRANombre.Size = new System.Drawing.Size(172, 43);
            this.txtRANombre.TabIndex = 0;
            this.txtRANombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvReportesAlumno
            // 
            this.dgvReportesAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportesAlumno.Location = new System.Drawing.Point(19, 291);
            this.dgvReportesAlumno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvReportesAlumno.Name = "dgvReportesAlumno";
            this.dgvReportesAlumno.RowHeadersWidth = 62;
            this.dgvReportesAlumno.RowTemplate.Height = 28;
            this.dgvReportesAlumno.Size = new System.Drawing.Size(1042, 261);
            this.dgvReportesAlumno.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.BackgroundImage = global::PSPSDO.Properties.Resources._1098321945g;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.gbRA);
            this.groupBox1.Controls.Add(this.dgvReportesAlumno);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1706, 974);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reportes Alumnos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PSPSDO.Properties.Resources.ut_menu2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1124, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 105);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmReportesAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 854);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmReportesAlumnos";
            this.Text = "frmReportesAlumnos";
            this.Load += new System.EventHandler(this.frmReportesAlumnos_Load);
            this.gbRA.ResumeLayout(false);
            this.gbRA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesAlumno)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRA;
        private System.Windows.Forms.Label lblRANombre;
        private System.Windows.Forms.TextBox txtRANombre;
        private System.Windows.Forms.Button btnCrearRA;
        private System.Windows.Forms.DataGridView dgvReportesAlumno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}