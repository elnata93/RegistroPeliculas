namespace MoviesOrganizer
{
    partial class VentanaRegistroGeneros
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
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.Descripcionlabel = new System.Windows.Forms.Label();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.nuevobutton = new System.Windows.Forms.Button();
            this.eliminarbutton = new System.Windows.Forms.Button();
            this.generoIdlabel = new System.Windows.Forms.Label();
            this.GeneroIdtextBox = new System.Windows.Forms.TextBox();
            this.RegGenlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(91, 113);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(157, 20);
            this.DescripciontextBox.TabIndex = 2;
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.Location = new System.Drawing.Point(9, 116);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(63, 13);
            this.Descripcionlabel.TabIndex = 4;
            this.Descripcionlabel.Text = "Descripcion";
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(93, 161);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 4;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // nuevobutton
            // 
            this.nuevobutton.Location = new System.Drawing.Point(12, 161);
            this.nuevobutton.Name = "nuevobutton";
            this.nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.nuevobutton.TabIndex = 3;
            this.nuevobutton.Text = "Nuevo";
            this.nuevobutton.UseVisualStyleBackColor = true;
            this.nuevobutton.Click += new System.EventHandler(this.nuevobutton_Click);
            // 
            // eliminarbutton
            // 
            this.eliminarbutton.Location = new System.Drawing.Point(173, 161);
            this.eliminarbutton.Name = "eliminarbutton";
            this.eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.eliminarbutton.TabIndex = 5;
            this.eliminarbutton.Text = "Eliminar";
            this.eliminarbutton.UseVisualStyleBackColor = true;
            this.eliminarbutton.Click += new System.EventHandler(this.eliminarbutton_Click);
            // 
            // generoIdlabel
            // 
            this.generoIdlabel.AutoSize = true;
            this.generoIdlabel.Location = new System.Drawing.Point(12, 74);
            this.generoIdlabel.Name = "generoIdlabel";
            this.generoIdlabel.Size = new System.Drawing.Size(51, 13);
            this.generoIdlabel.TabIndex = 8;
            this.generoIdlabel.Text = "GeneroId";
            // 
            // GeneroIdtextBox
            // 
            this.GeneroIdtextBox.Location = new System.Drawing.Point(93, 71);
            this.GeneroIdtextBox.Name = "GeneroIdtextBox";
            this.GeneroIdtextBox.Size = new System.Drawing.Size(155, 20);
            this.GeneroIdtextBox.TabIndex = 1;
            // 
            // RegGenlabel
            // 
            this.RegGenlabel.AutoSize = true;
            this.RegGenlabel.Location = new System.Drawing.Point(73, 24);
            this.RegGenlabel.Name = "RegGenlabel";
            this.RegGenlabel.Size = new System.Drawing.Size(104, 13);
            this.RegGenlabel.TabIndex = 9;
            this.RegGenlabel.Text = "Registro de Generos";
            // 
            // VentanaRegGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 196);
            this.Controls.Add(this.RegGenlabel);
            this.Controls.Add(this.GeneroIdtextBox);
            this.Controls.Add(this.generoIdlabel);
            this.Controls.Add(this.eliminarbutton);
            this.Controls.Add(this.nuevobutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Descripcionlabel);
            this.Controls.Add(this.DescripciontextBox);
            this.Name = "VentanaRegGeneros";
            this.Text = "VentanaRegGeneros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Label Descripcionlabel;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button nuevobutton;
        private System.Windows.Forms.Button eliminarbutton;
        private System.Windows.Forms.Label generoIdlabel;
        private System.Windows.Forms.TextBox GeneroIdtextBox;
        private System.Windows.Forms.Label RegGenlabel;
    }
}