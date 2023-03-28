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
            this.btnCarreraAñadir = new System.Windows.Forms.Button();
            this.btnCarreraBorrar = new System.Windows.Forms.Button();
            this.btnCarreraEditar = new System.Windows.Forms.Button();
            this.btnCarreraMostrar = new System.Windows.Forms.Button();
            this.dgvListaCarreras = new System.Windows.Forms.DataGridView();
            this.txtClaveCarrera = new System.Windows.Forms.TextBox();
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.txtDescripcionCarrera = new System.Windows.Forms.TextBox();
            this.lbCarreraClave = new System.Windows.Forms.Label();
            this.lbCarreraNombre = new System.Windows.Forms.Label();
            this.lbCarreraDescripcion = new System.Windows.Forms.Label();
            this.txtBusquedaCarreras = new System.Windows.Forms.TextBox();
            this.btnBuscarCarrera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarreraAñadir
            // 
            this.btnCarreraAñadir.Location = new System.Drawing.Point(37, 103);
            this.btnCarreraAñadir.Name = "btnCarreraAñadir";
            this.btnCarreraAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnCarreraAñadir.TabIndex = 0;
            this.btnCarreraAñadir.Text = "Agregar";
            this.btnCarreraAñadir.UseVisualStyleBackColor = true;
            this.btnCarreraAñadir.Click += new System.EventHandler(this.btnCarreraAñadir_Click);
            // 
            // btnCarreraBorrar
            // 
            this.btnCarreraBorrar.Location = new System.Drawing.Point(118, 103);
            this.btnCarreraBorrar.Name = "btnCarreraBorrar";
            this.btnCarreraBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnCarreraBorrar.TabIndex = 1;
            this.btnCarreraBorrar.Text = "Borrar";
            this.btnCarreraBorrar.UseVisualStyleBackColor = true;
            this.btnCarreraBorrar.Click += new System.EventHandler(this.btnCarreraBorrar_Click);
            // 
            // btnCarreraEditar
            // 
            this.btnCarreraEditar.Location = new System.Drawing.Point(702, 106);
            this.btnCarreraEditar.Name = "btnCarreraEditar";
            this.btnCarreraEditar.Size = new System.Drawing.Size(75, 23);
            this.btnCarreraEditar.TabIndex = 2;
            this.btnCarreraEditar.Text = "Editar";
            this.btnCarreraEditar.UseVisualStyleBackColor = true;
            this.btnCarreraEditar.Click += new System.EventHandler(this.btnCarreraEditar_Click);
            // 
            // btnCarreraMostrar
            // 
            this.btnCarreraMostrar.Location = new System.Drawing.Point(563, 106);
            this.btnCarreraMostrar.Name = "btnCarreraMostrar";
            this.btnCarreraMostrar.Size = new System.Drawing.Size(113, 23);
            this.btnCarreraMostrar.TabIndex = 3;
            this.btnCarreraMostrar.Text = "Mostrar Todo";
            this.btnCarreraMostrar.UseVisualStyleBackColor = true;
            this.btnCarreraMostrar.Click += new System.EventHandler(this.btnCarreraMostrar_Click);
            // 
            // dgvListaCarreras
            // 
            this.dgvListaCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCarreras.Location = new System.Drawing.Point(12, 132);
            this.dgvListaCarreras.Name = "dgvListaCarreras";
            this.dgvListaCarreras.Size = new System.Drawing.Size(776, 253);
            this.dgvListaCarreras.TabIndex = 4;
            // 
            // txtClaveCarrera
            // 
            this.txtClaveCarrera.Location = new System.Drawing.Point(12, 30);
            this.txtClaveCarrera.Name = "txtClaveCarrera";
            this.txtClaveCarrera.Size = new System.Drawing.Size(134, 20);
            this.txtClaveCarrera.TabIndex = 5;
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.Location = new System.Drawing.Point(12, 77);
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.Size = new System.Drawing.Size(134, 20);
            this.txtNombreCarrera.TabIndex = 6;
            // 
            // txtDescripcionCarrera
            // 
            this.txtDescripcionCarrera.Location = new System.Drawing.Point(152, 30);
            this.txtDescripcionCarrera.Multiline = true;
            this.txtDescripcionCarrera.Name = "txtDescripcionCarrera";
            this.txtDescripcionCarrera.Size = new System.Drawing.Size(524, 67);
            this.txtDescripcionCarrera.TabIndex = 7;
            // 
            // lbCarreraClave
            // 
            this.lbCarreraClave.AutoSize = true;
            this.lbCarreraClave.Location = new System.Drawing.Point(12, 9);
            this.lbCarreraClave.Name = "lbCarreraClave";
            this.lbCarreraClave.Size = new System.Drawing.Size(34, 13);
            this.lbCarreraClave.TabIndex = 8;
            this.lbCarreraClave.Text = "Clave";
            // 
            // lbCarreraNombre
            // 
            this.lbCarreraNombre.AutoSize = true;
            this.lbCarreraNombre.Location = new System.Drawing.Point(12, 61);
            this.lbCarreraNombre.Name = "lbCarreraNombre";
            this.lbCarreraNombre.Size = new System.Drawing.Size(44, 13);
            this.lbCarreraNombre.TabIndex = 9;
            this.lbCarreraNombre.Text = "Nombre";
            // 
            // lbCarreraDescripcion
            // 
            this.lbCarreraDescripcion.AutoSize = true;
            this.lbCarreraDescripcion.Location = new System.Drawing.Point(152, 9);
            this.lbCarreraDescripcion.Name = "lbCarreraDescripcion";
            this.lbCarreraDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbCarreraDescripcion.TabIndex = 10;
            this.lbCarreraDescripcion.Text = "Descripcion";
            // 
            // txtBusquedaCarreras
            // 
            this.txtBusquedaCarreras.Location = new System.Drawing.Point(199, 106);
            this.txtBusquedaCarreras.Name = "txtBusquedaCarreras";
            this.txtBusquedaCarreras.Size = new System.Drawing.Size(257, 20);
            this.txtBusquedaCarreras.TabIndex = 11;
            // 
            // btnBuscarCarrera
            // 
            this.btnBuscarCarrera.Location = new System.Drawing.Point(462, 106);
            this.btnBuscarCarrera.Name = "btnBuscarCarrera";
            this.btnBuscarCarrera.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCarrera.TabIndex = 12;
            this.btnBuscarCarrera.Text = "Buscar";
            this.btnBuscarCarrera.UseVisualStyleBackColor = true;
            this.btnBuscarCarrera.Click += new System.EventHandler(this.btnBuscarCarrera_Click);
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarCarrera);
            this.Controls.Add(this.txtBusquedaCarreras);
            this.Controls.Add(this.lbCarreraDescripcion);
            this.Controls.Add(this.lbCarreraNombre);
            this.Controls.Add(this.lbCarreraClave);
            this.Controls.Add(this.txtDescripcionCarrera);
            this.Controls.Add(this.txtNombreCarrera);
            this.Controls.Add(this.txtClaveCarrera);
            this.Controls.Add(this.dgvListaCarreras);
            this.Controls.Add(this.btnCarreraMostrar);
            this.Controls.Add(this.btnCarreraEditar);
            this.Controls.Add(this.btnCarreraBorrar);
            this.Controls.Add(this.btnCarreraAñadir);
            this.Name = "frmCarreras";
            this.Text = "Carreras";
            this.Load += new System.EventHandler(this.frmCarreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCarreras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lbCarreraClave;
        private System.Windows.Forms.Label lbCarreraNombre;
        private System.Windows.Forms.Label lbCarreraDescripcion;
        private System.Windows.Forms.TextBox txtBusquedaCarreras;
        private System.Windows.Forms.Button btnBuscarCarrera;
    }
}