namespace PSPSDO.Forms
{
    partial class frmCapturaCalificaciones
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
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.cmbAlumno = new System.Windows.Forms.ComboBox();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.txtCalificaciones = new System.Windows.Forms.TextBox();
            this.btnGuardarCapCal = new System.Windows.Forms.Button();
            this.btnCancelarCapCal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(160, 87);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(173, 21);
            this.cmbMateria.TabIndex = 0;
            // 
            // cmbAlumno
            // 
            this.cmbAlumno.FormattingEnabled = true;
            this.cmbAlumno.Location = new System.Drawing.Point(411, 87);
            this.cmbAlumno.Name = "cmbAlumno";
            this.cmbAlumno.Size = new System.Drawing.Size(173, 21);
            this.cmbAlumno.TabIndex = 1;
            // 
            // txtParcial
            // 
            this.txtParcial.Location = new System.Drawing.Point(160, 194);
            this.txtParcial.Name = "txtParcial";
            this.txtParcial.Size = new System.Drawing.Size(173, 20);
            this.txtParcial.TabIndex = 2;
            // 
            // txtCalificaciones
            // 
            this.txtCalificaciones.Location = new System.Drawing.Point(411, 194);
            this.txtCalificaciones.Name = "txtCalificaciones";
            this.txtCalificaciones.Size = new System.Drawing.Size(173, 20);
            this.txtCalificaciones.TabIndex = 3;
            // 
            // btnGuardarCapCal
            // 
            this.btnGuardarCapCal.Location = new System.Drawing.Point(218, 306);
            this.btnGuardarCapCal.Name = "btnGuardarCapCal";
            this.btnGuardarCapCal.Size = new System.Drawing.Size(115, 40);
            this.btnGuardarCapCal.TabIndex = 4;
            this.btnGuardarCapCal.Text = "Guardar";
            this.btnGuardarCapCal.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCapCal
            // 
            this.btnCancelarCapCal.Location = new System.Drawing.Point(410, 306);
            this.btnCancelarCapCal.Name = "btnCancelarCapCal";
            this.btnCancelarCapCal.Size = new System.Drawing.Size(115, 42);
            this.btnCancelarCapCal.TabIndex = 5;
            this.btnCancelarCapCal.Text = "Cancelar";
            this.btnCancelarCapCal.UseVisualStyleBackColor = true;
            // 
            // frmCapturaCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelarCapCal);
            this.Controls.Add(this.btnGuardarCapCal);
            this.Controls.Add(this.txtCalificaciones);
            this.Controls.Add(this.txtParcial);
            this.Controls.Add(this.cmbAlumno);
            this.Controls.Add(this.cmbMateria);
            this.Name = "frmCapturaCalificaciones";
            this.Text = "frmCapturaCalificaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.ComboBox cmbAlumno;
        private System.Windows.Forms.TextBox txtParcial;
        private System.Windows.Forms.TextBox txtCalificaciones;
        private System.Windows.Forms.Button btnGuardarCapCal;
        private System.Windows.Forms.Button btnCancelarCapCal;
    }
}