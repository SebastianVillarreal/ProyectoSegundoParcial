namespace PSPSDO.Forms
{
    partial class frmGrupos
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
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.lblUsuarioGrupo = new System.Windows.Forms.Label();
            this.lblClaveGrupos = new System.Windows.Forms.Label();
            this.lblDescripcionGrupos = new System.Windows.Forms.Label();
            this.btnGuardarGrupos = new System.Windows.Forms.Button();
            this.btnActualizarGrupos = new System.Windows.Forms.Button();
            this.txtUsuarioGrupo = new System.Windows.Forms.TextBox();
            this.txtClaveGrupos = new System.Windows.Forms.TextBox();
            this.txtDescripcionGrupos = new System.Windows.Forms.TextBox();
            this.btnEliminarGrupos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Location = new System.Drawing.Point(12, 250);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.Size = new System.Drawing.Size(536, 312);
            this.dgvGrupos.TabIndex = 0;
            // 
            // lblUsuarioGrupo
            // 
            this.lblUsuarioGrupo.AutoSize = true;
            this.lblUsuarioGrupo.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioGrupo.Location = new System.Drawing.Point(28, 13);
            this.lblUsuarioGrupo.Name = "lblUsuarioGrupo";
            this.lblUsuarioGrupo.Size = new System.Drawing.Size(57, 19);
            this.lblUsuarioGrupo.TabIndex = 1;
            this.lblUsuarioGrupo.Text = "Usuario";
            this.lblUsuarioGrupo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblClaveGrupos
            // 
            this.lblClaveGrupos.AutoSize = true;
            this.lblClaveGrupos.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveGrupos.Location = new System.Drawing.Point(31, 62);
            this.lblClaveGrupos.Name = "lblClaveGrupos";
            this.lblClaveGrupos.Size = new System.Drawing.Size(44, 19);
            this.lblClaveGrupos.TabIndex = 2;
            this.lblClaveGrupos.Text = "Clave";
            // 
            // lblDescripcionGrupos
            // 
            this.lblDescripcionGrupos.AutoSize = true;
            this.lblDescripcionGrupos.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionGrupos.Location = new System.Drawing.Point(12, 115);
            this.lblDescripcionGrupos.Name = "lblDescripcionGrupos";
            this.lblDescripcionGrupos.Size = new System.Drawing.Size(83, 19);
            this.lblDescripcionGrupos.TabIndex = 3;
            this.lblDescripcionGrupos.Text = "Descripcion";
            // 
            // btnGuardarGrupos
            // 
            this.btnGuardarGrupos.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarGrupos.Location = new System.Drawing.Point(35, 205);
            this.btnGuardarGrupos.Name = "btnGuardarGrupos";
            this.btnGuardarGrupos.Size = new System.Drawing.Size(75, 33);
            this.btnGuardarGrupos.TabIndex = 4;
            this.btnGuardarGrupos.Text = "Guardar";
            this.btnGuardarGrupos.UseVisualStyleBackColor = true;
            this.btnGuardarGrupos.Click += new System.EventHandler(this.btnGuardarGrupos_Click);
            // 
            // btnActualizarGrupos
            // 
            this.btnActualizarGrupos.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarGrupos.Location = new System.Drawing.Point(156, 205);
            this.btnActualizarGrupos.Name = "btnActualizarGrupos";
            this.btnActualizarGrupos.Size = new System.Drawing.Size(82, 33);
            this.btnActualizarGrupos.TabIndex = 6;
            this.btnActualizarGrupos.Text = "Actualizar";
            this.btnActualizarGrupos.UseVisualStyleBackColor = true;
            this.btnActualizarGrupos.Click += new System.EventHandler(this.btnActualizarGrupos_Click);
            // 
            // txtUsuarioGrupo
            // 
            this.txtUsuarioGrupo.Location = new System.Drawing.Point(119, 13);
            this.txtUsuarioGrupo.Name = "txtUsuarioGrupo";
            this.txtUsuarioGrupo.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioGrupo.TabIndex = 7;
            // 
            // txtClaveGrupos
            // 
            this.txtClaveGrupos.Location = new System.Drawing.Point(119, 62);
            this.txtClaveGrupos.Name = "txtClaveGrupos";
            this.txtClaveGrupos.Size = new System.Drawing.Size(100, 20);
            this.txtClaveGrupos.TabIndex = 8;
            // 
            // txtDescripcionGrupos
            // 
            this.txtDescripcionGrupos.Location = new System.Drawing.Point(119, 117);
            this.txtDescripcionGrupos.Multiline = true;
            this.txtDescripcionGrupos.Name = "txtDescripcionGrupos";
            this.txtDescripcionGrupos.Size = new System.Drawing.Size(199, 74);
            this.txtDescripcionGrupos.TabIndex = 9;
            // 
            // btnEliminarGrupos
            // 
            this.btnEliminarGrupos.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnEliminarGrupos.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGrupos.Location = new System.Drawing.Point(289, 207);
            this.btnEliminarGrupos.Name = "btnEliminarGrupos";
            this.btnEliminarGrupos.Size = new System.Drawing.Size(75, 31);
            this.btnEliminarGrupos.TabIndex = 10;
            this.btnEliminarGrupos.Text = "Eliminar";
            this.btnEliminarGrupos.UseVisualStyleBackColor = true;
            this.btnEliminarGrupos.Click += new System.EventHandler(this.btnElimiarGrupos_Click);
            // 
            // frmGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 576);
            this.Controls.Add(this.btnEliminarGrupos);
            this.Controls.Add(this.txtDescripcionGrupos);
            this.Controls.Add(this.txtClaveGrupos);
            this.Controls.Add(this.txtUsuarioGrupo);
            this.Controls.Add(this.btnActualizarGrupos);
            this.Controls.Add(this.btnGuardarGrupos);
            this.Controls.Add(this.lblDescripcionGrupos);
            this.Controls.Add(this.lblClaveGrupos);
            this.Controls.Add(this.lblUsuarioGrupo);
            this.Controls.Add(this.dgvGrupos);
            this.Name = "frmGrupos";
            this.Text = "frmGrupos";
            this.Load += new System.EventHandler(this.frmGrupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.Label lblUsuarioGrupo;
        private System.Windows.Forms.Label lblClaveGrupos;
        private System.Windows.Forms.Label lblDescripcionGrupos;
        private System.Windows.Forms.Button btnGuardarGrupos;
        private System.Windows.Forms.Button btnActualizarGrupos;
        private System.Windows.Forms.TextBox txtUsuarioGrupo;
        private System.Windows.Forms.TextBox txtClaveGrupos;
        private System.Windows.Forms.TextBox txtDescripcionGrupos;
        private System.Windows.Forms.Button btnEliminarGrupos;
    }
}