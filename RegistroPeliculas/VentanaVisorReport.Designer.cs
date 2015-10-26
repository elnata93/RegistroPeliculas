namespace MoviesOrganizer
{
    partial class VentanaVisorReport
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
            this.VisorGenerosbutton = new System.Windows.Forms.Button();
            this.VisorActoresbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VisorGenerosbutton
            // 
            this.VisorGenerosbutton.Location = new System.Drawing.Point(89, 71);
            this.VisorGenerosbutton.Name = "VisorGenerosbutton";
            this.VisorGenerosbutton.Size = new System.Drawing.Size(104, 23);
            this.VisorGenerosbutton.TabIndex = 0;
            this.VisorGenerosbutton.Text = "Visor de Generos";
            this.VisorGenerosbutton.UseVisualStyleBackColor = true;
            this.VisorGenerosbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // VisorActoresbutton
            // 
            this.VisorActoresbutton.Location = new System.Drawing.Point(89, 123);
            this.VisorActoresbutton.Name = "VisorActoresbutton";
            this.VisorActoresbutton.Size = new System.Drawing.Size(104, 23);
            this.VisorActoresbutton.TabIndex = 1;
            this.VisorActoresbutton.Text = "Visor de Actores";
            this.VisorActoresbutton.UseVisualStyleBackColor = true;
            this.VisorActoresbutton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // VentanaVisorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 213);
            this.Controls.Add(this.VisorActoresbutton);
            this.Controls.Add(this.VisorGenerosbutton);
            this.Name = "VentanaVisorReport";
            this.Text = "VentanaVisorReport";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VisorGenerosbutton;
        private System.Windows.Forms.Button VisorActoresbutton;
    }
}