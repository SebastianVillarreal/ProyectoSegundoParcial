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
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.cmbAlumno = new System.Windows.Forms.ComboBox();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.txtCalificaciones = new System.Windows.Forms.TextBox();
            this.btnGuardarCapCal = new System.Windows.Forms.Button();
            this.btnCancelarCapCal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Items.AddRange(new object[] {
            "",
            "Funciones Matematicas",
            "Metodologias y Modelado de Desarollo de Software",
            "Interconexion de Redes",
            "Programacion Orientada a Objetos",
            "Introduccion al Diseño Digital",
            "Base de Datos",
            "Ingles II",
            "Formacion Sociocultural II",
            "Calculo Diferencial",
            "Probabilidad y Estadistica",
            "Sistemas Operativos",
            "Integradora I",
            "Aplicaciones Web",
            "Bases de Datos para Aplicaciones",
            "Ingles III",
            "Formacion Sociocultural III",
            "Estadistica Aplicada a la Educacion",
            "La Educacion en Mexico",
            "Diseño de Material Didactico",
            "Metodologia de la Didactica I",
            "Fisica",
            "Probabilidad y Estadistica",
            "Metodos y sistemas de trabajo I",
            "Distribucion de Planta",
            "Costos de Produccion",
            "Electricidad y Magnetismo"});
            this.cmbMateria.Location = new System.Drawing.Point(160, 87);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(173, 21);
            this.cmbMateria.TabIndex = 0;
            // 
            // cmbAlumno
            // 
            this.cmbAlumno.FormattingEnabled = true;
            this.cmbAlumno.Items.AddRange(new object[] {
            "",
            "Jorge Alberto Rubio Reyna",
            "Bryan Rolando De La Rosa Medrano",
            "Karen Sofia Alvarez Martinez",
            "Jose Reynaldo Sillas\tGuerrero",
            "Cesar Fabian Gonzalez Valdez",
            "Felipe de Jesús Bernal Gazca",
            "Jonathan\tMartinez Rivera",
            "Abril Galvan Rodriguez",
            "Karen Alvarez Martinez",
            "Alejandra\tLucio Zuñiga",
            "Gustavo Angel Borrego Ramirez",
            "Carlos Cortez Lopez",
            "Jonathan Cortez Perez",
            "Brandon Arturo Gonzalez Saravia",
            "Yaretzi Sandoval Vazquez",
            "Keyla Abigail Martinez Castillo",
            "Jose Manuel de la Fuente Irracheta",
            "Carlos Alberto Alvarez Montes",
            "Osiel Yado Flores",
            "Edgar Camarillo Alcocer",
            "Alberto Rubio Lazcano",
            "Arturo Martinez Rubio",
            "Ivan Yado Flores",
            "Javier Martinez Leal",
            "Irma Lazcano Martinez",
            "Enrique Flores Martinez",
            "Enedino Rubio Flores",
            "Checo Rubio Flores",
            "Mercedes\tCalderón López",
            "Karen López Reyes",
            "Jullio Gutiérrez Sandoval",
            "Marcos Callejón Garza",
            "Juan Garcia Garcia",
            "Cristian Reyna López",
            "Pablo Jaramillo Ibarra",
            "Mirna López Ibarreche",
            "Cecilia Montes Morelos",
            "Camila Guerrero Gutiérrez",
            "Ruth Reyes López",
            "Luis Ibarra\tChapa",
            "Cristina Montes Mata",
            "Ariana Lopéz Salas",
            "Zarahí Gutiérrez Reyes",
            "Julian Torres Zamora",
            "Milton Lira Garza",
            "Pedro Elizondo Mireles",
            "Rubén Reyes Salas",
            "Román Reyna Ibarra",
            "Talía Mireles Lópes",
            "Celia MijaresTorres",
            "Rosa Zendejas Ramírez",
            "Maria Torres Del Monte",
            "Yudith López Ortíz",
            "Sandra Cárdenas Mata",
            "Sebastian Villarreal Alvarado"});
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
            this.txtParcial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParcial_KeyPress);
            // 
            // txtCalificaciones
            // 
            this.txtCalificaciones.Location = new System.Drawing.Point(411, 194);
            this.txtCalificaciones.Name = "txtCalificaciones";
            this.txtCalificaciones.Size = new System.Drawing.Size(173, 20);
            this.txtCalificaciones.TabIndex = 3;
            this.txtCalificaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalificaciones_KeyPress);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Alumno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Parcial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Calificacion";
            // 
            // frmCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarCapCal);
            this.Controls.Add(this.btnGuardarCapCal);
            this.Controls.Add(this.txtCalificaciones);
            this.Controls.Add(this.txtParcial);
            this.Controls.Add(this.cmbAlumno);
            this.Controls.Add(this.cmbMateria);
            this.Name = "frmCalificaciones";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}