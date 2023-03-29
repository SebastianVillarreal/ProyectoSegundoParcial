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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtBuscarGrupo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClaveGrupo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGrupos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGrupos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Location = new System.Drawing.Point(30, 606);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.Size = new System.Drawing.Size(1856, 420);
            this.dgvGrupos.TabIndex = 0;
            // 
            // lblUsuarioGrupo
            // 
            this.lblUsuarioGrupo.AutoSize = true;
            this.lblUsuarioGrupo.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioGrupo.Location = new System.Drawing.Point(50, 69);
            this.lblUsuarioGrupo.Name = "lblUsuarioGrupo";
            this.lblUsuarioGrupo.Size = new System.Drawing.Size(137, 45);
            this.lblUsuarioGrupo.TabIndex = 1;
            this.lblUsuarioGrupo.Text = "Usuario";
            this.lblUsuarioGrupo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblClaveGrupos
            // 
            this.lblClaveGrupos.AutoSize = true;
            this.lblClaveGrupos.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveGrupos.Location = new System.Drawing.Point(50, 135);
            this.lblClaveGrupos.Name = "lblClaveGrupos";
            this.lblClaveGrupos.Size = new System.Drawing.Size(104, 45);
            this.lblClaveGrupos.TabIndex = 2;
            this.lblClaveGrupos.Text = "Clave";
            // 
            // lblDescripcionGrupos
            // 
            this.lblDescripcionGrupos.AutoSize = true;
            this.lblDescripcionGrupos.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionGrupos.Location = new System.Drawing.Point(50, 297);
            this.lblDescripcionGrupos.Name = "lblDescripcionGrupos";
            this.lblDescripcionGrupos.Size = new System.Drawing.Size(202, 45);
            this.lblDescripcionGrupos.TabIndex = 3;
            this.lblDescripcionGrupos.Text = "Descripcion";
            // 
            // btnGuardarGrupos
            // 
            this.btnGuardarGrupos.BackColor = System.Drawing.Color.White;
            this.btnGuardarGrupos.BackgroundImage = global::PSPSDO.Properties.Resources.Guardar_icon;
            this.btnGuardarGrupos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarGrupos.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarGrupos.Location = new System.Drawing.Point(50, 378);
            this.btnGuardarGrupos.Name = "btnGuardarGrupos";
            this.btnGuardarGrupos.Size = new System.Drawing.Size(104, 83);
            this.btnGuardarGrupos.TabIndex = 4;
            this.btnGuardarGrupos.UseVisualStyleBackColor = false;
            this.btnGuardarGrupos.Click += new System.EventHandler(this.btnGuardarGrupos_Click);
            // 
            // btnActualizarGrupos
            // 
            this.btnActualizarGrupos.BackColor = System.Drawing.Color.White;
            this.btnActualizarGrupos.BackgroundImage = global::PSPSDO.Properties.Resources.Update_icon;
            this.btnActualizarGrupos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnActualizarGrupos.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarGrupos.Location = new System.Drawing.Point(42, 513);
            this.btnActualizarGrupos.Name = "btnActualizarGrupos";
            this.btnActualizarGrupos.Size = new System.Drawing.Size(120, 83);
            this.btnActualizarGrupos.TabIndex = 6;
            this.btnActualizarGrupos.UseVisualStyleBackColor = false;
            this.btnActualizarGrupos.Click += new System.EventHandler(this.btnActualizarGrupos_Click);
            // 
            // txtUsuarioGrupo
            // 
            this.txtUsuarioGrupo.Location = new System.Drawing.Point(287, 73);
            this.txtUsuarioGrupo.Name = "txtUsuarioGrupo";
            this.txtUsuarioGrupo.Size = new System.Drawing.Size(514, 56);
            this.txtUsuarioGrupo.TabIndex = 7;
            this.txtUsuarioGrupo.TextChanged += new System.EventHandler(this.txtUsuarioGrupo_TextChanged);
            // 
            // txtClaveGrupos
            // 
            this.txtClaveGrupos.Location = new System.Drawing.Point(287, 135);
            this.txtClaveGrupos.Multiline = true;
            this.txtClaveGrupos.Name = "txtClaveGrupos";
            this.txtClaveGrupos.Size = new System.Drawing.Size(469, 56);
            this.txtClaveGrupos.TabIndex = 8;
            // 
            // txtDescripcionGrupos
            // 
            this.txtDescripcionGrupos.Location = new System.Drawing.Point(287, 286);
            this.txtDescripcionGrupos.Multiline = true;
            this.txtDescripcionGrupos.Name = "txtDescripcionGrupos";
            this.txtDescripcionGrupos.Size = new System.Drawing.Size(399, 56);
            this.txtDescripcionGrupos.TabIndex = 9;
            // 
            // btnEliminarGrupos
            // 
            this.btnEliminarGrupos.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnEliminarGrupos.BackColor = System.Drawing.Color.White;
            this.btnEliminarGrupos.BackgroundImage = global::PSPSDO.Properties.Resources.Borrar_icon;
            this.btnEliminarGrupos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarGrupos.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGrupos.Location = new System.Drawing.Point(184, 513);
            this.btnEliminarGrupos.Name = "btnEliminarGrupos";
            this.btnEliminarGrupos.Size = new System.Drawing.Size(164, 83);
            this.btnEliminarGrupos.TabIndex = 10;
            this.btnEliminarGrupos.UseVisualStyleBackColor = false;
            this.btnEliminarGrupos.Click += new System.EventHandler(this.btnElimiarGrupos_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(609, 551);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(171, 45);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Buscador:";
            // 
            // txtBuscarGrupo
            // 
            this.txtBuscarGrupo.Location = new System.Drawing.Point(794, 545);
            this.txtBuscarGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarGrupo.Name = "txtBuscarGrupo";
            this.txtBuscarGrupo.Size = new System.Drawing.Size(458, 56);
            this.txtBuscarGrupo.TabIndex = 13;
            this.txtBuscarGrupo.TextChanged += new System.EventHandler(this.txtBuscarGrupo_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::PSPSDO.Properties.Resources._1098321945g;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtClaveGrupo);
            this.groupBox1.Controls.Add(this.dgvGrupos);
            this.groupBox1.Controls.Add(this.txtBuscarGrupo);
            this.groupBox1.Controls.Add(this.lblUsuarioGrupo);
            this.groupBox1.Controls.Add(this.lblSearch);
            this.groupBox1.Controls.Add(this.lblClaveGrupos);
            this.groupBox1.Controls.Add(this.btnEliminarGrupos);
            this.groupBox1.Controls.Add(this.lblDescripcionGrupos);
            this.groupBox1.Controls.Add(this.txtDescripcionGrupos);
            this.groupBox1.Controls.Add(this.btnGuardarGrupos);
            this.groupBox1.Controls.Add(this.txtClaveGrupos);
            this.groupBox1.Controls.Add(this.btnActualizarGrupos);
            this.groupBox1.Controls.Add(this.txtUsuarioGrupo);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-8, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1937, 1077);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GRUPOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 45);
            this.label1.TabIndex = 14;
            this.label1.Text = "Clave Grupo";
            // 
            // txtClaveGrupo
            // 
            this.txtClaveGrupo.Location = new System.Drawing.Point(287, 211);
            this.txtClaveGrupo.Multiline = true;
            this.txtClaveGrupo.Name = "txtClaveGrupo";
            this.txtClaveGrupo.Size = new System.Drawing.Size(469, 56);
            this.txtClaveGrupo.TabIndex = 15;
            // 
            // frmGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PSPSDO.Properties.Resources._1098321945g;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGrupos";
            this.Text = "frmGrupos";
            this.Load += new System.EventHandler(this.frmGrupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtBuscarGrupo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClaveGrupo;
    }
}