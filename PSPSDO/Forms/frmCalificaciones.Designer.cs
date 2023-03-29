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
            this.cmbMateriaCal = new System.Windows.Forms.ComboBox();
            this.cmbAlumnoCal = new System.Windows.Forms.ComboBox();
            this.txtParcialCal = new System.Windows.Forms.TextBox();
            this.txtCalificacionesCal = new System.Windows.Forms.TextBox();
            this.btnGuardarCapCal = new System.Windows.Forms.Button();
            this.btnCancelarCapCal = new System.Windows.Forms.Button();
            this.lblMateriaCal = new System.Windows.Forms.Label();
            this.lblAlumnoCal = new System.Windows.Forms.Label();
            this.lblParcialCal = new System.Windows.Forms.Label();
            this.lblCalificacionCal = new System.Windows.Forms.Label();
            this.cmbCarreraCal = new System.Windows.Forms.ComboBox();
            this.cmbGrupoCal = new System.Windows.Forms.ComboBox();
            this.lblCarreraCal = new System.Windows.Forms.Label();
            this.lblGrupoCal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMateriaCal
            // 
            this.cmbMateriaCal.FormattingEnabled = true;
            this.cmbMateriaCal.Location = new System.Drawing.Point(6, 101);
            this.cmbMateriaCal.Name = "cmbMateriaCal";
            this.cmbMateriaCal.Size = new System.Drawing.Size(173, 47);
            this.cmbMateriaCal.TabIndex = 0;
            // 
            // cmbAlumnoCal
            // 
            this.cmbAlumnoCal.FormattingEnabled = true;
            this.cmbAlumnoCal.Location = new System.Drawing.Point(606, 101);
            this.cmbAlumnoCal.Name = "cmbAlumnoCal";
            this.cmbAlumnoCal.Size = new System.Drawing.Size(173, 47);
            this.cmbAlumnoCal.TabIndex = 1;
            this.cmbAlumnoCal.SelectedIndexChanged += new System.EventHandler(this.cmbAlumnoCal_SelectedIndexChanged);
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
            this.txtCalificacionesCal.Location = new System.Drawing.Point(398, 234);
            this.txtCalificacionesCal.Name = "txtCalificacionesCal";
            this.txtCalificacionesCal.Size = new System.Drawing.Size(173, 47);
            this.txtCalificacionesCal.TabIndex = 3;
            this.txtCalificacionesCal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalificaciones_KeyPress);
            // 
            // btnGuardarCapCal
            // 
            this.btnGuardarCapCal.Location = new System.Drawing.Point(206, 320);
            this.btnGuardarCapCal.Name = "btnGuardarCapCal";
            this.btnGuardarCapCal.Size = new System.Drawing.Size(115, 40);
            this.btnGuardarCapCal.TabIndex = 4;
            this.btnGuardarCapCal.Text = "Guardar";
            this.btnGuardarCapCal.UseVisualStyleBackColor = true;
            this.btnGuardarCapCal.Click += new System.EventHandler(this.btnGuardarCapCal_Click);
            // 
            // btnCancelarCapCal
            // 
            this.btnCancelarCapCal.Location = new System.Drawing.Point(398, 320);
            this.btnCancelarCapCal.Name = "btnCancelarCapCal";
            this.btnCancelarCapCal.Size = new System.Drawing.Size(115, 42);
            this.btnCancelarCapCal.TabIndex = 5;
            this.btnCancelarCapCal.Text = "Cancelar";
            this.btnCancelarCapCal.UseVisualStyleBackColor = true;
            this.btnCancelarCapCal.Click += new System.EventHandler(this.btnCancelarCapCal_Click);
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
            // lblAlumnoCal
            // 
            this.lblAlumnoCal.AutoSize = true;
            this.lblAlumnoCal.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumnoCal.ForeColor = System.Drawing.Color.Black;
            this.lblAlumnoCal.Location = new System.Drawing.Point(599, 59);
            this.lblAlumnoCal.Name = "lblAlumnoCal";
            this.lblAlumnoCal.Size = new System.Drawing.Size(116, 39);
            this.lblAlumnoCal.TabIndex = 7;
            this.lblAlumnoCal.Text = "Alumno";
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
            // lblCalificacionCal
            // 
            this.lblCalificacionCal.AutoSize = true;
            this.lblCalificacionCal.BackColor = System.Drawing.Color.Transparent;
            this.lblCalificacionCal.ForeColor = System.Drawing.Color.Black;
            this.lblCalificacionCal.Location = new System.Drawing.Point(396, 192);
            this.lblCalificacionCal.Name = "lblCalificacionCal";
            this.lblCalificacionCal.Size = new System.Drawing.Size(173, 39);
            this.lblCalificacionCal.TabIndex = 9;
            this.lblCalificacionCal.Text = "Calificacion";
            // 
            // cmbCarreraCal
            // 
            this.cmbCarreraCal.FormattingEnabled = true;
            this.cmbCarreraCal.Location = new System.Drawing.Point(221, 101);
            this.cmbCarreraCal.Name = "cmbCarreraCal";
            this.cmbCarreraCal.Size = new System.Drawing.Size(158, 47);
            this.cmbCarreraCal.TabIndex = 10;
            this.cmbCarreraCal.SelectedIndexChanged += new System.EventHandler(this.cmbCarreraCal_SelectedIndexChanged);
            // 
            // cmbGrupoCal
            // 
            this.cmbGrupoCal.FormattingEnabled = true;
            this.cmbGrupoCal.Location = new System.Drawing.Point(411, 101);
            this.cmbGrupoCal.Name = "cmbGrupoCal";
            this.cmbGrupoCal.Size = new System.Drawing.Size(158, 47);
            this.cmbGrupoCal.TabIndex = 11;
            this.cmbGrupoCal.SelectedIndexChanged += new System.EventHandler(this.cmbGrupoCal_SelectedIndexChanged);
            // 
            // lblCarreraCal
            // 
            this.lblCarreraCal.AutoSize = true;
            this.lblCarreraCal.BackColor = System.Drawing.Color.Transparent;
            this.lblCarreraCal.ForeColor = System.Drawing.Color.Black;
            this.lblCarreraCal.Location = new System.Drawing.Point(214, 59);
            this.lblCarreraCal.Name = "lblCarreraCal";
            this.lblCarreraCal.Size = new System.Drawing.Size(116, 39);
            this.lblCarreraCal.TabIndex = 12;
            this.lblCarreraCal.Text = "Carrera";
            // 
            // lblGrupoCal
            // 
            this.lblGrupoCal.AutoSize = true;
            this.lblGrupoCal.BackColor = System.Drawing.Color.Transparent;
            this.lblGrupoCal.ForeColor = System.Drawing.Color.Black;
            this.lblGrupoCal.Location = new System.Drawing.Point(409, 59);
            this.lblGrupoCal.Name = "lblGrupoCal";
            this.lblGrupoCal.Size = new System.Drawing.Size(96, 39);
            this.lblGrupoCal.TabIndex = 13;
            this.lblGrupoCal.Text = "Grupo";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::PSPSDO.Properties.Resources._1098321945g;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 561);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calificaciones";
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
    }
}