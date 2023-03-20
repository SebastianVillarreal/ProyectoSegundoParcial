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
            this.lblClaveMateria = new System.Windows.Forms.Label();
            this.lblUsuarioMateria = new System.Windows.Forms.Label();
            this.lblFechaMateria = new System.Windows.Forms.Label();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.txtClaveMateria = new System.Windows.Forms.TextBox();
            this.txtUsuarioMateria = new System.Windows.Forms.TextBox();
            this.btnInsertarMateria = new System.Windows.Forms.Button();
            this.btnEditarMateria = new System.Windows.Forms.Button();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.dtpFechaMateria = new System.Windows.Forms.DateTimePicker();
            this.txtBuscarMateria = new System.Windows.Forms.TextBox();
            this.lblBuscadorMateria = new System.Windows.Forms.Label();
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
            // lblClaveMateria
            // 
            this.lblClaveMateria.AutoSize = true;
            this.lblClaveMateria.Location = new System.Drawing.Point(305, 16);
            this.lblClaveMateria.Name = "lblClaveMateria";
            this.lblClaveMateria.Size = new System.Drawing.Size(72, 13);
            this.lblClaveMateria.TabIndex = 1;
            this.lblClaveMateria.Text = "Clave Materia";
            // 
            // lblUsuarioMateria
            // 
            this.lblUsuarioMateria.AutoSize = true;
            this.lblUsuarioMateria.Location = new System.Drawing.Point(25, 60);
            this.lblUsuarioMateria.Name = "lblUsuarioMateria";
            this.lblUsuarioMateria.Size = new System.Drawing.Size(79, 13);
            this.lblUsuarioMateria.TabIndex = 2;
            this.lblUsuarioMateria.Text = "Codigo Usuario";
            // 
            // lblFechaMateria
            // 
            this.lblFechaMateria.AutoSize = true;
            this.lblFechaMateria.Location = new System.Drawing.Point(305, 60);
            this.lblFechaMateria.Name = "lblFechaMateria";
            this.lblFechaMateria.Size = new System.Drawing.Size(37, 13);
            this.lblFechaMateria.TabIndex = 3;
            this.lblFechaMateria.Text = "Fecha";
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
            this.txtUsuarioMateria.Location = new System.Drawing.Point(19, 76);
            this.txtUsuarioMateria.Name = "txtUsuarioMateria";
            this.txtUsuarioMateria.Size = new System.Drawing.Size(232, 20);
            this.txtUsuarioMateria.TabIndex = 6;
            // 
            // btnInsertarMateria
            // 
            this.btnInsertarMateria.Location = new System.Drawing.Point(659, 10);
            this.btnInsertarMateria.Name = "btnInsertarMateria";
            this.btnInsertarMateria.Size = new System.Drawing.Size(202, 47);
            this.btnInsertarMateria.TabIndex = 9;
            this.btnInsertarMateria.Text = "Insertar";
            this.btnInsertarMateria.UseVisualStyleBackColor = true;
            this.btnInsertarMateria.Click += new System.EventHandler(this.btnInsertarMateria_Click);
            // 
            // btnEditarMateria
            // 
            this.btnEditarMateria.Location = new System.Drawing.Point(659, 113);
            this.btnEditarMateria.Name = "btnEditarMateria";
            this.btnEditarMateria.Size = new System.Drawing.Size(203, 47);
            this.btnEditarMateria.TabIndex = 10;
            this.btnEditarMateria.Text = "Editar";
            this.btnEditarMateria.UseVisualStyleBackColor = true;
            this.btnEditarMateria.Click += new System.EventHandler(this.btnEditarMateria_Click);
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Location = new System.Drawing.Point(659, 60);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(202, 47);
            this.btnEliminarMateria.TabIndex = 11;
            this.btnEliminarMateria.Text = "Eliminar";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            this.btnEliminarMateria.Click += new System.EventHandler(this.btnEliminarMateria_Click);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(12, 169);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.Size = new System.Drawing.Size(983, 396);
            this.dgvMaterias.TabIndex = 12;
            this.dgvMaterias.SelectionChanged += new System.EventHandler(this.dgvMaterias_SelectionChanged);
            // 
            // dtpFechaMateria
            // 
            this.dtpFechaMateria.Location = new System.Drawing.Point(308, 76);
            this.dtpFechaMateria.Name = "dtpFechaMateria";
            this.dtpFechaMateria.Size = new System.Drawing.Size(229, 20);
            this.dtpFechaMateria.TabIndex = 13;
            // 
            // txtBuscarMateria
            // 
            this.txtBuscarMateria.Location = new System.Drawing.Point(19, 121);
            this.txtBuscarMateria.Name = "txtBuscarMateria";
            this.txtBuscarMateria.Size = new System.Drawing.Size(380, 20);
            this.txtBuscarMateria.TabIndex = 14;
            this.txtBuscarMateria.TextChanged += new System.EventHandler(this.txtBuscarMateria_TextChanged);
            // 
            // lblBuscadorMateria
            // 
            this.lblBuscadorMateria.AutoSize = true;
            this.lblBuscadorMateria.Location = new System.Drawing.Point(16, 105);
            this.lblBuscadorMateria.Name = "lblBuscadorMateria";
            this.lblBuscadorMateria.Size = new System.Drawing.Size(52, 13);
            this.lblBuscadorMateria.TabIndex = 15;
            this.lblBuscadorMateria.Text = "Buscador";
            // 
            // frmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 577);
            this.Controls.Add(this.lblBuscadorMateria);
            this.Controls.Add(this.txtBuscarMateria);
            this.Controls.Add(this.dtpFechaMateria);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.btnEliminarMateria);
            this.Controls.Add(this.btnEditarMateria);
            this.Controls.Add(this.btnInsertarMateria);
            this.Controls.Add(this.txtUsuarioMateria);
            this.Controls.Add(this.txtClaveMateria);
            this.Controls.Add(this.txtNombreMateria);
            this.Controls.Add(this.lblFechaMateria);
            this.Controls.Add(this.lblUsuarioMateria);
            this.Controls.Add(this.lblClaveMateria);
            this.Controls.Add(this.lblNombreMateria);
            this.Name = "frmMaterias";
            this.Text = "Materias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.Label lblClaveMateria;
        private System.Windows.Forms.Label lblUsuarioMateria;
        private System.Windows.Forms.Label lblFechaMateria;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.TextBox txtClaveMateria;
        private System.Windows.Forms.TextBox txtUsuarioMateria;
        private System.Windows.Forms.Button btnInsertarMateria;
        private System.Windows.Forms.Button btnEditarMateria;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.DateTimePicker dtpFechaMateria;
        private System.Windows.Forms.TextBox txtBuscarMateria;
        private System.Windows.Forms.Label lblBuscadorMateria;
    }
}