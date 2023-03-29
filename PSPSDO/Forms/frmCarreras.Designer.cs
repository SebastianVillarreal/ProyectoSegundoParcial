namespace PSPSDO.Forms
{
    partial class frmCarreras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarreras));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dgvListaCarreras = new System.Windows.Forms.DataGridView();
            this.btnCarreraAñadir = new System.Windows.Forms.Button();
            this.btnBuscarCarrera = new System.Windows.Forms.Button();
            this.btnCarreraBorrar = new System.Windows.Forms.Button();
            this.txtBusquedaCarreras = new System.Windows.Forms.TextBox();
            this.btnCarreraEditar = new System.Windows.Forms.Button();
            this.btnCarreraMostrar = new System.Windows.Forms.Button();
            this.txtClaveCarrera = new System.Windows.Forms.TextBox();
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.txtDescripcionCarrera = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCarreras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.dgvListaCarreras);
            this.groupBox1.Controls.Add(this.btnCarreraAñadir);
            this.groupBox1.Controls.Add(this.btnBuscarCarrera);
            this.groupBox1.Controls.Add(this.btnCarreraBorrar);
            this.groupBox1.Controls.Add(this.txtBusquedaCarreras);
            this.groupBox1.Controls.Add(this.btnCarreraEditar);
            this.groupBox1.Controls.Add(this.btnCarreraMostrar);
            this.groupBox1.Controls.Add(this.txtClaveCarrera);
            this.groupBox1.Controls.Add(this.txtNombreCarrera);
            this.groupBox1.Controls.Add(this.txtDescripcionCarrera);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1928, 1047);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carreras";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;

            this.pictureBox5.Location = new System.Drawing.Point(59, 260);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(279, 52);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;

            this.pictureBox4.Location = new System.Drawing.Point(59, 125);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(279, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // dgvListaCarreras
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListaCarreras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaCarreras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaCarreras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaCarreras.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaCarreras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaCarreras.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaCarreras.GridColor = System.Drawing.Color.Black;
            this.dgvListaCarreras.Location = new System.Drawing.Point(59, 501);
            this.dgvListaCarreras.Name = "dgvListaCarreras";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaCarreras.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaCarreras.Size = new System.Drawing.Size(1473, 433);
            this.dgvListaCarreras.TabIndex = 4;
            // 
            // btnCarreraAñadir
            // 
            this.btnCarreraAñadir.BackColor = System.Drawing.Color.White;
            this.btnCarreraAñadir.BackgroundImage = global::PSPSDO.Properties.Resources.Agregar_icon;
            this.btnCarreraAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarreraAñadir.Location = new System.Drawing.Point(59, 390);
            this.btnCarreraAñadir.Name = "btnCarreraAñadir";
            this.btnCarreraAñadir.Size = new System.Drawing.Size(51, 46);
            this.btnCarreraAñadir.TabIndex = 0;
            this.btnCarreraAñadir.UseVisualStyleBackColor = false;
            this.btnCarreraAñadir.Click += new System.EventHandler(this.btnCarreraAñadir_Click);
            // 
            // btnBuscarCarrera
            // 
            this.btnBuscarCarrera.BackColor = System.Drawing.Color.White;
            this.btnBuscarCarrera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarCarrera.BackgroundImage")));
            this.btnBuscarCarrera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarCarrera.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCarrera.Location = new System.Drawing.Point(1477, 454);
            this.btnBuscarCarrera.Name = "btnBuscarCarrera";
            this.btnBuscarCarrera.Size = new System.Drawing.Size(55, 53);
            this.btnBuscarCarrera.TabIndex = 12;
            this.btnBuscarCarrera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCarrera.UseVisualStyleBackColor = false;
            this.btnBuscarCarrera.Click += new System.EventHandler(this.btnBuscarCarrera_Click);
            // 
            // btnCarreraBorrar
            // 
            this.btnCarreraBorrar.BackColor = System.Drawing.Color.White;
            this.btnCarreraBorrar.BackgroundImage = global::PSPSDO.Properties.Resources.Borrar_icon;
            this.btnCarreraBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCarreraBorrar.Location = new System.Drawing.Point(275, 391);
            this.btnCarreraBorrar.Name = "btnCarreraBorrar";
            this.btnCarreraBorrar.Size = new System.Drawing.Size(50, 46);
            this.btnCarreraBorrar.TabIndex = 1;
            this.btnCarreraBorrar.UseVisualStyleBackColor = false;
            this.btnCarreraBorrar.Click += new System.EventHandler(this.btnCarreraBorrar_Click);
            // 
            // txtBusquedaCarreras
            // 
            this.txtBusquedaCarreras.Location = new System.Drawing.Point(59, 455);
            this.txtBusquedaCarreras.Name = "txtBusquedaCarreras";
            this.txtBusquedaCarreras.Size = new System.Drawing.Size(1421, 53);
            this.txtBusquedaCarreras.TabIndex = 11;
            // 
            // btnCarreraEditar
            // 
            this.btnCarreraEditar.BackColor = System.Drawing.Color.White;
            this.btnCarreraEditar.BackgroundImage = global::PSPSDO.Properties.Resources.edit_icon;
            this.btnCarreraEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCarreraEditar.Location = new System.Drawing.Point(170, 390);
            this.btnCarreraEditar.Name = "btnCarreraEditar";
            this.btnCarreraEditar.Size = new System.Drawing.Size(50, 49);
            this.btnCarreraEditar.TabIndex = 2;
            this.btnCarreraEditar.UseVisualStyleBackColor = false;
            this.btnCarreraEditar.Click += new System.EventHandler(this.btnCarreraEditar_Click);
            // 
            // btnCarreraMostrar
            // 
            this.btnCarreraMostrar.BackColor = System.Drawing.Color.White;
            this.btnCarreraMostrar.Location = new System.Drawing.Point(1331, 940);
            this.btnCarreraMostrar.Name = "btnCarreraMostrar";
            this.btnCarreraMostrar.Size = new System.Drawing.Size(201, 57);
            this.btnCarreraMostrar.TabIndex = 3;
            this.btnCarreraMostrar.Text = "Mostrar Todo";
            this.btnCarreraMostrar.UseVisualStyleBackColor = false;
            this.btnCarreraMostrar.Click += new System.EventHandler(this.btnCarreraMostrar_Click);
            // 
            // txtClaveCarrera
            // 
            this.txtClaveCarrera.Location = new System.Drawing.Point(59, 183);
            this.txtClaveCarrera.Name = "txtClaveCarrera";
            this.txtClaveCarrera.Size = new System.Drawing.Size(448, 53);
            this.txtClaveCarrera.TabIndex = 5;
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.Location = new System.Drawing.Point(59, 318);
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.Size = new System.Drawing.Size(448, 53);
            this.txtNombreCarrera.TabIndex = 6;
            // 
            // txtDescripcionCarrera
            // 
            this.txtDescripcionCarrera.Location = new System.Drawing.Point(513, 183);
            this.txtDescripcionCarrera.Multiline = true;
            this.txtDescripcionCarrera.Name = "txtDescripcionCarrera";
            this.txtDescripcionCarrera.Size = new System.Drawing.Size(1019, 256);
            this.txtDescripcionCarrera.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PSPSDO.Properties.Resources.ut_menu2;
            this.pictureBox1.Location = new System.Drawing.Point(856, -56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(1486, 293);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(493, 530);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(513, 128);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(279, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1924, 1051);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCarreras";
            this.Text = "Carreras";
            this.Load += new System.EventHandler(this.frmCarreras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCarreras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarreraAñadir;
        private System.Windows.Forms.Button btnCarreraBorrar;
        private System.Windows.Forms.Button btnCarreraEditar;
        private System.Windows.Forms.Button btnCarreraMostrar;
        private System.Windows.Forms.DataGridView dgvListaCarreras;
        private System.Windows.Forms.TextBox txtClaveCarrera;
        private System.Windows.Forms.TextBox txtNombreCarrera;
        private System.Windows.Forms.TextBox txtDescripcionCarrera;
        private System.Windows.Forms.TextBox txtBusquedaCarreras;
        private System.Windows.Forms.Button btnBuscarCarrera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}