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
            this.cmbCarreraMat = new System.Windows.Forms.ComboBox();
            this.lblCarreraMat = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreMateria.Location = new System.Drawing.Point(88, 39);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(206, 36);
            this.lblNombreMateria.TabIndex = 0;
            this.lblNombreMateria.Text = "Nombre Materia";
            // 
            // lblClaveMateria
            // 
            this.lblClaveMateria.AutoSize = true;
            this.lblClaveMateria.BackColor = System.Drawing.Color.Transparent;
            this.lblClaveMateria.Location = new System.Drawing.Point(396, 38);
            this.lblClaveMateria.Name = "lblClaveMateria";
            this.lblClaveMateria.Size = new System.Drawing.Size(179, 36);
            this.lblClaveMateria.TabIndex = 1;
            this.lblClaveMateria.Text = "Clave Materia";
            // 
            // lblUsuarioMateria
            // 
            this.lblUsuarioMateria.AutoSize = true;
            this.lblUsuarioMateria.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioMateria.Location = new System.Drawing.Point(52, 138);
            this.lblUsuarioMateria.Name = "lblUsuarioMateria";
            this.lblUsuarioMateria.Size = new System.Drawing.Size(197, 36);
            this.lblUsuarioMateria.TabIndex = 2;
            this.lblUsuarioMateria.Text = "Codigo Usuario";
            // 
            // lblFechaMateria
            // 
            this.lblFechaMateria.AutoSize = true;
            this.lblFechaMateria.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaMateria.Location = new System.Drawing.Point(505, 138);
            this.lblFechaMateria.Name = "lblFechaMateria";
            this.lblFechaMateria.Size = new System.Drawing.Size(86, 36);
            this.lblFechaMateria.TabIndex = 3;
            this.lblFechaMateria.Text = "Fecha";
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(33, 80);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(312, 43);
            this.txtNombreMateria.TabIndex = 4;
            // 
            // txtClaveMateria
            // 
            this.txtClaveMateria.Location = new System.Drawing.Point(368, 79);
            this.txtClaveMateria.Name = "txtClaveMateria";
            this.txtClaveMateria.Size = new System.Drawing.Size(232, 43);
            this.txtClaveMateria.TabIndex = 5;
            // 
            // txtUsuarioMateria
            // 
            this.txtUsuarioMateria.Location = new System.Drawing.Point(33, 177);
            this.txtUsuarioMateria.Name = "txtUsuarioMateria";
            this.txtUsuarioMateria.Size = new System.Drawing.Size(232, 43);
            this.txtUsuarioMateria.TabIndex = 6;
            // 
            // btnInsertarMateria
            // 
            this.btnInsertarMateria.BackgroundImage = global::PSPSDO.Properties.Resources.Agregar_icon;
            this.btnInsertarMateria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsertarMateria.Location = new System.Drawing.Point(873, 50);
            this.btnInsertarMateria.Name = "btnInsertarMateria";
            this.btnInsertarMateria.Size = new System.Drawing.Size(67, 47);
            this.btnInsertarMateria.TabIndex = 9;
            this.btnInsertarMateria.UseVisualStyleBackColor = true;
            this.btnInsertarMateria.Click += new System.EventHandler(this.btnInsertarMateria_Click);
            // 
            // btnEditarMateria
            // 
            this.btnEditarMateria.BackgroundImage = global::PSPSDO.Properties.Resources.edit_icon;
            this.btnEditarMateria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditarMateria.Location = new System.Drawing.Point(873, 156);
            this.btnEditarMateria.Name = "btnEditarMateria";
            this.btnEditarMateria.Size = new System.Drawing.Size(67, 47);
            this.btnEditarMateria.TabIndex = 10;
            this.btnEditarMateria.UseVisualStyleBackColor = true;
            this.btnEditarMateria.Click += new System.EventHandler(this.btnEditarMateria_Click);
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.BackgroundImage = global::PSPSDO.Properties.Resources.Borrar_icon;
            this.btnEliminarMateria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarMateria.Location = new System.Drawing.Point(873, 103);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(67, 47);
            this.btnEliminarMateria.TabIndex = 11;
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            this.btnEliminarMateria.Click += new System.EventHandler(this.btnEliminarMateria_Click);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMaterias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(33, 344);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.Size = new System.Drawing.Size(983, 396);
            this.dgvMaterias.TabIndex = 12;
            this.dgvMaterias.SelectionChanged += new System.EventHandler(this.dgvMaterias_SelectionChanged);
            // 
            // dtpFechaMateria
            // 
            this.dtpFechaMateria.Location = new System.Drawing.Point(305, 177);
            this.dtpFechaMateria.Name = "dtpFechaMateria";
            this.dtpFechaMateria.Size = new System.Drawing.Size(484, 43);
            this.dtpFechaMateria.TabIndex = 13;
            // 
            // txtBuscarMateria
            // 
            this.txtBuscarMateria.Location = new System.Drawing.Point(195, 249);
            this.txtBuscarMateria.Name = "txtBuscarMateria";
            this.txtBuscarMateria.Size = new System.Drawing.Size(380, 43);
            this.txtBuscarMateria.TabIndex = 14;
            this.txtBuscarMateria.TextChanged += new System.EventHandler(this.txtBuscarMateria_TextChanged);
            // 
            // lblBuscadorMateria
            // 
            this.lblBuscadorMateria.AutoSize = true;
            this.lblBuscadorMateria.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscadorMateria.Location = new System.Drawing.Point(52, 256);
            this.lblBuscadorMateria.Name = "lblBuscadorMateria";
            this.lblBuscadorMateria.Size = new System.Drawing.Size(129, 36);
            this.lblBuscadorMateria.TabIndex = 15;
            this.lblBuscadorMateria.Text = "Buscador";
            // 
            // cmbCarreraMat
            // 
            this.cmbCarreraMat.FormattingEnabled = true;
            this.cmbCarreraMat.Location = new System.Drawing.Point(648, 79);
            this.cmbCarreraMat.Name = "cmbCarreraMat";
            this.cmbCarreraMat.Size = new System.Drawing.Size(102, 44);
            this.cmbCarreraMat.TabIndex = 16;
            // 
            // lblCarreraMat
            // 
            this.lblCarreraMat.AutoSize = true;
            this.lblCarreraMat.BackColor = System.Drawing.Color.Transparent;
            this.lblCarreraMat.Location = new System.Drawing.Point(644, 39);
            this.lblCarreraMat.Name = "lblCarreraMat";
            this.lblCarreraMat.Size = new System.Drawing.Size(106, 36);
            this.lblCarreraMat.TabIndex = 17;
            this.lblCarreraMat.Text = "Carrera";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::PSPSDO.Properties.Resources._1098321945g;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblNombreMateria);
            this.groupBox1.Controls.Add(this.lblCarreraMat);
            this.groupBox1.Controls.Add(this.lblClaveMateria);
            this.groupBox1.Controls.Add(this.cmbCarreraMat);
            this.groupBox1.Controls.Add(this.lblUsuarioMateria);
            this.groupBox1.Controls.Add(this.lblBuscadorMateria);
            this.groupBox1.Controls.Add(this.lblFechaMateria);
            this.groupBox1.Controls.Add(this.txtBuscarMateria);
            this.groupBox1.Controls.Add(this.txtNombreMateria);
            this.groupBox1.Controls.Add(this.dtpFechaMateria);
            this.groupBox1.Controls.Add(this.txtClaveMateria);
            this.groupBox1.Controls.Add(this.dgvMaterias);
            this.groupBox1.Controls.Add(this.txtUsuarioMateria);
            this.groupBox1.Controls.Add(this.btnEliminarMateria);
            this.groupBox1.Controls.Add(this.btnInsertarMateria);
            this.groupBox1.Controls.Add(this.btnEditarMateria);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1829, 1133);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materias";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PSPSDO.Properties.Resources.ut_menu2;
            this.pictureBox1.Location = new System.Drawing.Point(1022, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMaterias";
            this.Text = "Materias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox cmbCarreraMat;
        private System.Windows.Forms.Label lblCarreraMat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}