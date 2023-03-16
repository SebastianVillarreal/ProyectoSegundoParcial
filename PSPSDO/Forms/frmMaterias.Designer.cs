namespace PSPSDO.Forms
{
    partial class frmMaterias
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
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.txtClaveMateria = new System.Windows.Forms.TextBox();
            this.txtUsuarioMateria = new System.Windows.Forms.TextBox();
            this.btnInsertarMateria = new System.Windows.Forms.Button();
            this.btnEditarMateria = new System.Windows.Forms.Button();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.dtpFechaMateria = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Location = new System.Drawing.Point(25, 16);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(82, 13);
            this.lblNombreMateria.TabIndex = 0;
            this.lblNombreMateria.Text = "Nombre Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(19, 37);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(232, 20);
            this.txtNombreMateria.TabIndex = 4;
            // 
            // txtClaveMateria
            // 
            this.txtClaveMateria.Location = new System.Drawing.Point(308, 37);
            this.txtClaveMateria.Name = "txtClaveMateria";
            this.txtClaveMateria.Size = new System.Drawing.Size(232, 20);
            this.txtClaveMateria.TabIndex = 5;
            // 
            // txtUsuarioMateria
            // 
            this.txtUsuarioMateria.Location = new System.Drawing.Point(19, 97);
            this.txtUsuarioMateria.Name = "txtUsuarioMateria";
            this.txtUsuarioMateria.Size = new System.Drawing.Size(232, 20);
            this.txtUsuarioMateria.TabIndex = 6;
            // 
            // btnInsertarMateria
            // 
            this.btnInsertarMateria.Location = new System.Drawing.Point(783, 147);
            this.btnInsertarMateria.Name = "btnInsertarMateria";
            this.btnInsertarMateria.Size = new System.Drawing.Size(219, 47);
            this.btnInsertarMateria.TabIndex = 9;
            this.btnInsertarMateria.Text = "Insertar";
            this.btnInsertarMateria.UseVisualStyleBackColor = true;
            this.btnInsertarMateria.Click += new System.EventHandler(this.btnInsertarMateria_Click);
            // 
            // btnEditarMateria
            // 
            this.btnEditarMateria.Location = new System.Drawing.Point(783, 215);
            this.btnEditarMateria.Name = "btnEditarMateria";
            this.btnEditarMateria.Size = new System.Drawing.Size(219, 47);
            this.btnEditarMateria.TabIndex = 10;
            this.btnEditarMateria.Text = "Editar";
            this.btnEditarMateria.UseVisualStyleBackColor = true;
            this.btnEditarMateria.Click += new System.EventHandler(this.btnEditarMateria_Click);
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Location = new System.Drawing.Point(783, 287);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(219, 47);
            this.btnEliminarMateria.TabIndex = 11;
            this.btnEliminarMateria.Text = "Eliminar";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            this.btnEliminarMateria.Click += new System.EventHandler(this.btnEliminarMateria_Click);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(19, 147);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.Size = new System.Drawing.Size(758, 390);
            this.dgvMaterias.TabIndex = 12;
            // 
            // dtpFechaMateria
            // 
            this.dtpFechaMateria.Location = new System.Drawing.Point(308, 97);
            this.dtpFechaMateria.Name = "dtpFechaMateria";
            this.dtpFechaMateria.Size = new System.Drawing.Size(229, 20);
            this.dtpFechaMateria.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(589, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Buscador";
            // 
            // frmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 577);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtpFechaMateria);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.btnEliminarMateria);
            this.Controls.Add(this.btnEditarMateria);
            this.Controls.Add(this.btnInsertarMateria);
            this.Controls.Add(this.txtUsuarioMateria);
            this.Controls.Add(this.txtClaveMateria);
            this.Controls.Add(this.txtNombreMateria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombreMateria);
            this.Name = "frmMaterias";
            this.Text = "Materias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.TextBox txtClaveMateria;
        private System.Windows.Forms.TextBox txtUsuarioMateria;
        private System.Windows.Forms.Button btnInsertarMateria;
        private System.Windows.Forms.Button btnEditarMateria;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.DateTimePicker dtpFechaMateria;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}