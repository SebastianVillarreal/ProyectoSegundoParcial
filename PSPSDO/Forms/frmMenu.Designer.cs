namespace PSPSDO.Forms
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capturaCalificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.carrerasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::PSPSDO.Properties.Resources.green;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1370, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiasToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.gruposToolStripMenuItem,
            this.carrerasToolStripMenuItem});
            this.configuraciónToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(215, 43);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(209, 44);
            this.materiasToolStripMenuItem.Text = "Materias";
            this.materiasToolStripMenuItem.Click += new System.EventHandler(this.materiasToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(209, 44);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // gruposToolStripMenuItem
            // 
            this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            this.gruposToolStripMenuItem.Size = new System.Drawing.Size(209, 44);
            this.gruposToolStripMenuItem.Text = "Grupos";
            this.gruposToolStripMenuItem.Click += new System.EventHandler(this.gruposToolStripMenuItem_Click);
            // 
            // carrerasToolStripMenuItem
            // 
            this.carrerasToolStripMenuItem.Name = "carrerasToolStripMenuItem";
            this.carrerasToolStripMenuItem.Size = new System.Drawing.Size(209, 44);
            this.carrerasToolStripMenuItem.Text = "Carreras";
            this.carrerasToolStripMenuItem.Click += new System.EventHandler(this.carrerasToolStripMenuItem_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capturaCalificacionesToolStripMenuItem});
            this.profesoresToolStripMenuItem.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profesoresToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(170, 43);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            // 
            // capturaCalificacionesToolStripMenuItem
            // 
            this.capturaCalificacionesToolStripMenuItem.Name = "capturaCalificacionesToolStripMenuItem";
            this.capturaCalificacionesToolStripMenuItem.Size = new System.Drawing.Size(392, 44);
            this.capturaCalificacionesToolStripMenuItem.Text = "Captura Calificaciones";
            this.capturaCalificacionesToolStripMenuItem.Click += new System.EventHandler(this.capturaCalificacionesToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiasToolStripMenuItem1,
            this.alumnosToolStripMenuItem1,
            this.gruposToolStripMenuItem1,
            this.carrerasToolStripMenuItem1});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(148, 43);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // materiasToolStripMenuItem1
            // 
            this.materiasToolStripMenuItem1.Name = "materiasToolStripMenuItem1";
            this.materiasToolStripMenuItem1.Size = new System.Drawing.Size(209, 44);
            this.materiasToolStripMenuItem1.Text = "Materias";
            this.materiasToolStripMenuItem1.Click += new System.EventHandler(this.materiasToolStripMenuItem1_Click);
            // 
            // alumnosToolStripMenuItem1
            // 
            this.alumnosToolStripMenuItem1.Name = "alumnosToolStripMenuItem1";
            this.alumnosToolStripMenuItem1.Size = new System.Drawing.Size(209, 44);
            this.alumnosToolStripMenuItem1.Text = "Alumnos";
            this.alumnosToolStripMenuItem1.Click += new System.EventHandler(this.alumnosToolStripMenuItem1_Click);
            // 
            // gruposToolStripMenuItem1
            // 
            this.gruposToolStripMenuItem1.Name = "gruposToolStripMenuItem1";
            this.gruposToolStripMenuItem1.Size = new System.Drawing.Size(209, 44);
            this.gruposToolStripMenuItem1.Text = "Grupos";
            this.gruposToolStripMenuItem1.Click += new System.EventHandler(this.gruposToolStripMenuItem1_Click);
            // 
            // carrerasToolStripMenuItem1
            // 
            this.carrerasToolStripMenuItem1.Name = "carrerasToolStripMenuItem1";
            this.carrerasToolStripMenuItem1.Size = new System.Drawing.Size(209, 44);
            this.carrerasToolStripMenuItem1.Text = "Carreras";
            this.carrerasToolStripMenuItem1.Click += new System.EventHandler(this.carrerasToolStripMenuItem1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::PSPSDO.Properties.Resources.ut_VERDE;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::PSPSDO.Properties.Resources.giphy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1370, 697);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capturaCalificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gruposToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem carrerasToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}