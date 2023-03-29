namespace PSPSDO.Forms
{
    partial class frmCalificaciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCarreraCal = new System.Windows.Forms.ComboBox();
            this.lblGrupoCal = new System.Windows.Forms.Label();
            this.cmbMateriaCal = new System.Windows.Forms.ComboBox();
            this.lblCarreraCal = new System.Windows.Forms.Label();
            this.cmbAlumnoCal = new System.Windows.Forms.ComboBox();
            this.cmbGrupoCal = new System.Windows.Forms.ComboBox();
            this.txtParcialCal = new System.Windows.Forms.TextBox();
            this.txtCalificacionesCal = new System.Windows.Forms.TextBox();
            this.lblCalificacionCal = new System.Windows.Forms.Label();
            this.btnGuardarCapCal = new System.Windows.Forms.Button();
            this.lblParcialCal = new System.Windows.Forms.Label();
            this.btnCancelarCapCal = new System.Windows.Forms.Button();
            this.lblAlumnoCal = new System.Windows.Forms.Label();
            this.lblMateriaCal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::PSPSDO.Properties.Resources._1098321945g;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cmbCarreraCal);
            this.groupBox1.Controls.Add(this.lblGrupoCal);
            this.groupBox1.Controls.Add(this.cmbMateriaCal);
            this.groupBox1.Controls.Add(this.lblCarreraCal);
            this.groupBox1.Controls.Add(this.cmbAlumnoCal);
            this.groupBox1.Controls.Add(this.cmbGrupoCal);
            this.groupBox1.Controls.Add(this.txtParcialCal);
            this.groupBox1.Controls.Add(this.txtCalificacionesCal);
            this.groupBox1.Controls.Add(this.lblCalificacionCal);
            this.groupBox1.Controls.Add(this.btnGuardarCapCal);
            this.groupBox1.Controls.Add(this.lblParcialCal);
            this.groupBox1.Controls.Add(this.btnCancelarCapCal);
            this.groupBox1.Controls.Add(this.lblAlumnoCal);
            this.groupBox1.Controls.Add(this.lblMateriaCal);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1352, 865);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calificaciones";
            // 
            // cmbCarreraCal
            // 
            this.cmbCarreraCal.FormattingEnabled = true;
            this.cmbCarreraCal.Location = new System.Drawing.Point(302, 101);
            this.cmbCarreraCal.Name = "cmbCarreraCal";
            this.cmbCarreraCal.Size = new System.Drawing.Size(158, 47);
            this.cmbCarreraCal.TabIndex = 10;
            this.cmbCarreraCal.SelectedIndexChanged += new System.EventHandler(this.cmbCarreraCal_SelectedIndexChanged);
            // 
            // lblGrupoCal
            // 
            this.lblGrupoCal.AutoSize = true;
            this.lblGrupoCal.BackColor = System.Drawing.Color.Transparent;
            this.lblGrupoCal.ForeColor = System.Drawing.Color.Black;
            this.lblGrupoCal.Location = new System.Drawing.Point(601, 59);
            this.lblGrupoCal.Name = "lblGrupoCal";
            this.lblGrupoCal.Size = new System.Drawing.Size(96, 39);
            this.lblGrupoCal.TabIndex = 13;
            this.lblGrupoCal.Text = "Grupo";
            // 
            // cmbMateriaCal
            // 
            this.cmbMateriaCal.FormattingEnabled = true;
            this.cmbMateriaCal.Location = new System.Drawing.Point(6, 101);
            this.cmbMateriaCal.Name = "cmbMateriaCal";
            this.cmbMateriaCal.Size = new System.Drawing.Size(173, 47);
            this.cmbMateriaCal.TabIndex = 0;
            // 
            // lblCarreraCal
            // 
            this.lblCarreraCal.AutoSize = true;
            this.lblCarreraCal.BackColor = System.Drawing.Color.Transparent;
            this.lblCarreraCal.ForeColor = System.Drawing.Color.Black;
            this.lblCarreraCal.Location = new System.Drawing.Point(321, 59);
            this.lblCarreraCal.Name = "lblCarreraCal";
            this.lblCarreraCal.Size = new System.Drawing.Size(116, 39);
            this.lblCarreraCal.TabIndex = 12;
            this.lblCarreraCal.Text = "Carrera";
            // 
            // cmbAlumnoCal
            // 
            this.cmbAlumnoCal.FormattingEnabled = true;
            this.cmbAlumnoCal.Location = new System.Drawing.Point(898, 101);
            this.cmbAlumnoCal.Name = "cmbAlumnoCal";
            this.cmbAlumnoCal.Size = new System.Drawing.Size(173, 47);
            this.cmbAlumnoCal.TabIndex = 1;
            this.cmbAlumnoCal.SelectedIndexChanged += new System.EventHandler(this.cmbAlumnoCal_SelectedIndexChanged);
            // 
            // cmbGrupoCal
            // 
            this.cmbGrupoCal.FormattingEnabled = true;
            this.cmbGrupoCal.Location = new System.Drawing.Point(582, 101);
            this.cmbGrupoCal.Name = "cmbGrupoCal";
            this.cmbGrupoCal.Size = new System.Drawing.Size(158, 47);
            this.cmbGrupoCal.TabIndex = 11;
            this.cmbGrupoCal.SelectedIndexChanged += new System.EventHandler(this.cmbGrupoCal_SelectedIndexChanged);
            // 
            // txtParcialCal
            // 
            this.txtParcialCal.Location = new System.Drawing.Point(148, 234);
            this.txtParcialCal.Name = "txtParcialCal";
            this.txtParcialCal.Size = new System.Drawing.Size(173, 47);
            this.txtParcialCal.TabIndex = 2;
            this.txtParcialCal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParcial_KeyPress);
            // 
            // txtCalificacionesCal
            // 
            this.txtCalificacionesCal.Location = new System.Drawing.Point(597, 234);
            this.txtCalificacionesCal.Name = "txtCalificacionesCal";
            this.txtCalificacionesCal.Size = new System.Drawing.Size(173, 47);
            this.txtCalificacionesCal.TabIndex = 3;
            this.txtCalificacionesCal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalificaciones_KeyPress);
            // 
            // lblCalificacionCal
            // 
            this.lblCalificacionCal.AutoSize = true;
            this.lblCalificacionCal.BackColor = System.Drawing.Color.Transparent;
            this.lblCalificacionCal.ForeColor = System.Drawing.Color.Black;
            this.lblCalificacionCal.Location = new System.Drawing.Point(597, 192);
            this.lblCalificacionCal.Name = "lblCalificacionCal";
            this.lblCalificacionCal.Size = new System.Drawing.Size(173, 39);
            this.lblCalificacionCal.TabIndex = 9;
            this.lblCalificacionCal.Text = "Calificacion";
            // 
            // btnGuardarCapCal
            // 
            this.btnGuardarCapCal.Location = new System.Drawing.Point(377, 320);
            this.btnGuardarCapCal.Name = "btnGuardarCapCal";
            this.btnGuardarCapCal.Size = new System.Drawing.Size(142, 57);
            this.btnGuardarCapCal.TabIndex = 4;
            this.btnGuardarCapCal.Text = "Guardar";
            this.btnGuardarCapCal.UseVisualStyleBackColor = true;
            this.btnGuardarCapCal.Click += new System.EventHandler(this.btnGuardarCapCal_Click);
            // 
            // lblParcialCal
            // 
            this.lblParcialCal.AutoSize = true;
            this.lblParcialCal.BackColor = System.Drawing.Color.Transparent;
            this.lblParcialCal.ForeColor = System.Drawing.Color.Black;
            this.lblParcialCal.Location = new System.Drawing.Point(145, 192);
            this.lblParcialCal.Name = "lblParcialCal";
            this.lblParcialCal.Size = new System.Drawing.Size(108, 39);
            this.lblParcialCal.TabIndex = 8;
            this.lblParcialCal.Text = "Parcial";
            // 
            // btnCancelarCapCal
            // 
            this.btnCancelarCapCal.BackgroundImage = global::PSPSDO.Properties.Resources.Borrar_icon;
            this.btnCancelarCapCal.Location = new System.Drawing.Point(923, 320);
            this.btnCancelarCapCal.Name = "btnCancelarCapCal";
            this.btnCancelarCapCal.Size = new System.Drawing.Size(159, 57);
            this.btnCancelarCapCal.TabIndex = 5;
            this.btnCancelarCapCal.Text = "Cancelar";
            this.btnCancelarCapCal.UseVisualStyleBackColor = true;
            this.btnCancelarCapCal.Click += new System.EventHandler(this.btnCancelarCapCal_Click);
            // 
            // lblAlumnoCal
            // 
            this.lblAlumnoCal.AutoSize = true;
            this.lblAlumnoCal.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumnoCal.ForeColor = System.Drawing.Color.Black;
            this.lblAlumnoCal.Location = new System.Drawing.Point(925, 59);
            this.lblAlumnoCal.Name = "lblAlumnoCal";
            this.lblAlumnoCal.Size = new System.Drawing.Size(116, 39);
            this.lblAlumnoCal.TabIndex = 7;
            this.lblAlumnoCal.Text = "Alumno";
            // 
            // lblMateriaCal
            // 
            this.lblMateriaCal.AutoSize = true;
            this.lblMateriaCal.BackColor = System.Drawing.Color.Transparent;
            this.lblMateriaCal.ForeColor = System.Drawing.Color.Black;
            this.lblMateriaCal.Location = new System.Drawing.Point(14, 59);
            this.lblMateriaCal.Name = "lblMateriaCal";
            this.lblMateriaCal.Size = new System.Drawing.Size(117, 39);
            this.lblMateriaCal.TabIndex = 6;
            this.lblMateriaCal.Text = "Materia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-25, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::PSPSDO.Properties.Resources.ut_menu2;
            this.pictureBox2.Location = new System.Drawing.Point(1192, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // frmCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 842);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCalificaciones";
            this.Text = "Captura Calificaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMateriaCal;
        private System.Windows.Forms.ComboBox cmbAlumnoCal;
        private System.Windows.Forms.TextBox txtParcialCal;
        private System.Windows.Forms.TextBox txtCalificacionesCal;
        private System.Windows.Forms.Button btnGuardarCapCal;
        private System.Windows.Forms.Button btnCancelarCapCal;
        private System.Windows.Forms.Label lblMateriaCal;
        private System.Windows.Forms.Label lblAlumnoCal;
        private System.Windows.Forms.Label lblParcialCal;
        private System.Windows.Forms.Label lblCalificacionCal;
        private System.Windows.Forms.ComboBox cmbCarreraCal;
        private System.Windows.Forms.ComboBox cmbGrupoCal;
        private System.Windows.Forms.Label lblCarreraCal;
        private System.Windows.Forms.Label lblGrupoCal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}