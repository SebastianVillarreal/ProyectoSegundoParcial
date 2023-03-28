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
            this.SuspendLayout();
            // 
            // cmbMateriaCal
            // 
            this.cmbMateriaCal.FormattingEnabled = true;
            this.cmbMateriaCal.Location = new System.Drawing.Point(23, 58);
            this.cmbMateriaCal.Name = "cmbMateriaCal";
            this.cmbMateriaCal.Size = new System.Drawing.Size(173, 21);
            this.cmbMateriaCal.TabIndex = 0;
            // 
            // cmbAlumnoCal
            // 
            this.cmbAlumnoCal.FormattingEnabled = true;
            this.cmbAlumnoCal.Location = new System.Drawing.Point(615, 58);
            this.cmbAlumnoCal.Name = "cmbAlumnoCal";
            this.cmbAlumnoCal.Size = new System.Drawing.Size(173, 21);
            this.cmbAlumnoCal.TabIndex = 1;
            this.cmbAlumnoCal.SelectedIndexChanged += new System.EventHandler(this.cmbAlumnoCal_SelectedIndexChanged);
            // 
            // txtParcialCal
            // 
            this.txtParcialCal.Location = new System.Drawing.Point(160, 194);
            this.txtParcialCal.Name = "txtParcialCal";
            this.txtParcialCal.Size = new System.Drawing.Size(173, 20);
            this.txtParcialCal.TabIndex = 2;
            this.txtParcialCal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParcial_KeyPress);
            // 
            // txtCalificacionesCal
            // 
            this.txtCalificacionesCal.Location = new System.Drawing.Point(411, 194);
            this.txtCalificacionesCal.Name = "txtCalificacionesCal";
            this.txtCalificacionesCal.Size = new System.Drawing.Size(173, 20);
            this.txtCalificacionesCal.TabIndex = 3;
            this.txtCalificacionesCal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalificaciones_KeyPress);
            // 
            // btnGuardarCapCal
            // 
            this.btnGuardarCapCal.Location = new System.Drawing.Point(218, 306);
            this.btnGuardarCapCal.Name = "btnGuardarCapCal";
            this.btnGuardarCapCal.Size = new System.Drawing.Size(115, 40);
            this.btnGuardarCapCal.TabIndex = 4;
            this.btnGuardarCapCal.Text = "Guardar";
            this.btnGuardarCapCal.UseVisualStyleBackColor = true;
            this.btnGuardarCapCal.Click += new System.EventHandler(this.btnGuardarCapCal_Click);
            // 
            // btnCancelarCapCal
            // 
            this.btnCancelarCapCal.Location = new System.Drawing.Point(410, 306);
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
            this.lblMateriaCal.Location = new System.Drawing.Point(26, 45);
            this.lblMateriaCal.Name = "lblMateriaCal";
            this.lblMateriaCal.Size = new System.Drawing.Size(42, 13);
            this.lblMateriaCal.TabIndex = 6;
            this.lblMateriaCal.Text = "Materia";
            // 
            // lblAlumnoCal
            // 
            this.lblAlumnoCal.AutoSize = true;
            this.lblAlumnoCal.Location = new System.Drawing.Point(611, 45);
            this.lblAlumnoCal.Name = "lblAlumnoCal";
            this.lblAlumnoCal.Size = new System.Drawing.Size(42, 13);
            this.lblAlumnoCal.TabIndex = 7;
            this.lblAlumnoCal.Text = "Alumno";
            // 
            // lblParcialCal
            // 
            this.lblParcialCal.AutoSize = true;
            this.lblParcialCal.Location = new System.Drawing.Point(157, 178);
            this.lblParcialCal.Name = "lblParcialCal";
            this.lblParcialCal.Size = new System.Drawing.Size(39, 13);
            this.lblParcialCal.TabIndex = 8;
            this.lblParcialCal.Text = "Parcial";
            // 
            // lblCalificacionCal
            // 
            this.lblCalificacionCal.AutoSize = true;
            this.lblCalificacionCal.Location = new System.Drawing.Point(408, 178);
            this.lblCalificacionCal.Name = "lblCalificacionCal";
            this.lblCalificacionCal.Size = new System.Drawing.Size(61, 13);
            this.lblCalificacionCal.TabIndex = 9;
            this.lblCalificacionCal.Text = "Calificacion";
            // 
            // cmbCarreraCal
            // 
            this.cmbCarreraCal.FormattingEnabled = true;
            this.cmbCarreraCal.Location = new System.Drawing.Point(229, 58);
            this.cmbCarreraCal.Name = "cmbCarreraCal";
            this.cmbCarreraCal.Size = new System.Drawing.Size(158, 21);
            this.cmbCarreraCal.TabIndex = 10;
            this.cmbCarreraCal.SelectedIndexChanged += new System.EventHandler(this.cmbCarreraCal_SelectedIndexChanged);
            // 
            // cmbGrupoCal
            // 
            this.cmbGrupoCal.FormattingEnabled = true;
            this.cmbGrupoCal.Location = new System.Drawing.Point(424, 58);
            this.cmbGrupoCal.Name = "cmbGrupoCal";
            this.cmbGrupoCal.Size = new System.Drawing.Size(158, 21);
            this.cmbGrupoCal.TabIndex = 11;
            this.cmbGrupoCal.SelectedIndexChanged += new System.EventHandler(this.cmbGrupoCal_SelectedIndexChanged);
            // 
            // lblCarreraCal
            // 
            this.lblCarreraCal.AutoSize = true;
            this.lblCarreraCal.Location = new System.Drawing.Point(226, 45);
            this.lblCarreraCal.Name = "lblCarreraCal";
            this.lblCarreraCal.Size = new System.Drawing.Size(41, 13);
            this.lblCarreraCal.TabIndex = 12;
            this.lblCarreraCal.Text = "Carrera";
            // 
            // lblGrupoCal
            // 
            this.lblGrupoCal.AutoSize = true;
            this.lblGrupoCal.Location = new System.Drawing.Point(421, 45);
            this.lblGrupoCal.Name = "lblGrupoCal";
            this.lblGrupoCal.Size = new System.Drawing.Size(36, 13);
            this.lblGrupoCal.TabIndex = 13;
            this.lblGrupoCal.Text = "Grupo";
            // 
            // frmCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGrupoCal);
            this.Controls.Add(this.lblCarreraCal);
            this.Controls.Add(this.cmbGrupoCal);
            this.Controls.Add(this.cmbCarreraCal);
            this.Controls.Add(this.lblCalificacionCal);
            this.Controls.Add(this.lblParcialCal);
            this.Controls.Add(this.lblAlumnoCal);
            this.Controls.Add(this.lblMateriaCal);
            this.Controls.Add(this.btnCancelarCapCal);
            this.Controls.Add(this.btnGuardarCapCal);
            this.Controls.Add(this.txtCalificacionesCal);
            this.Controls.Add(this.txtParcialCal);
            this.Controls.Add(this.cmbAlumnoCal);
            this.Controls.Add(this.cmbMateriaCal);
            this.Name = "frmCalificaciones";
            this.Text = "Captura Calificaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}