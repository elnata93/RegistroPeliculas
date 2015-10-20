namespace MoviesOrganizer
{
    partial class Interfaz
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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiosCinematograficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.generosToolStripMenuItem,
            this.actoresToolStripMenuItem,
            this.estudiosCinematograficosToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // regToolStripMenuItem
            // 
            this.regToolStripMenuItem.Name = "regToolStripMenuItem";
            this.regToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.regToolStripMenuItem.Text = "Registrar";
            this.regToolStripMenuItem.Click += new System.EventHandler(this.regToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // generosToolStripMenuItem
            // 
            this.generosToolStripMenuItem.Name = "generosToolStripMenuItem";
            this.generosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.generosToolStripMenuItem.Text = "Generos";
            this.generosToolStripMenuItem.Click += new System.EventHandler(this.generosToolStripMenuItem_Click);
            // 
            // actoresToolStripMenuItem
            // 
            this.actoresToolStripMenuItem.Name = "actoresToolStripMenuItem";
            this.actoresToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.actoresToolStripMenuItem.Text = "Actores";
            this.actoresToolStripMenuItem.Click += new System.EventHandler(this.actoresToolStripMenuItem_Click);
            // 
            // estudiosCinematograficosToolStripMenuItem
            // 
            this.estudiosCinematograficosToolStripMenuItem.Name = "estudiosCinematograficosToolStripMenuItem";
            this.estudiosCinematograficosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.estudiosCinematograficosToolStripMenuItem.Text = "Estudios Cinematograficos";
            this.estudiosCinematograficosToolStripMenuItem.Click += new System.EventHandler(this.estudiosCinematograficosToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MoviesOrganizer.Properties.Resources.diez_alternativas_a_peliculas_yonkis_01;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(633, 331);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Interfaz";
            this.Text = "Registro de Peliculas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiosCinematograficosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

