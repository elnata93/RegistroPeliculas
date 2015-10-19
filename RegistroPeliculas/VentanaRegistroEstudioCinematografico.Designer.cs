namespace MoviesOrganizer
{
    partial class VentanaRegistroEstudioCinematografico
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
            this.Estudiolabel = new System.Windows.Forms.Label();
            this.EstudioIdlabel = new System.Windows.Forms.Label();
            this.NombreEstudiolabel = new System.Windows.Forms.Label();
            this.EstudioIdtextBox = new System.Windows.Forms.TextBox();
            this.NombreEstudiotextBox = new System.Windows.Forms.TextBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Estudiolabel
            // 
            this.Estudiolabel.AutoSize = true;
            this.Estudiolabel.Location = new System.Drawing.Point(73, 36);
            this.Estudiolabel.Name = "Estudiolabel";
            this.Estudiolabel.Size = new System.Drawing.Size(188, 13);
            this.Estudiolabel.TabIndex = 0;
            this.Estudiolabel.Text = "Registro de Estudios Cinematograficos";
            // 
            // EstudioIdlabel
            // 
            this.EstudioIdlabel.AutoSize = true;
            this.EstudioIdlabel.Location = new System.Drawing.Point(12, 102);
            this.EstudioIdlabel.Name = "EstudioIdlabel";
            this.EstudioIdlabel.Size = new System.Drawing.Size(51, 13);
            this.EstudioIdlabel.TabIndex = 1;
            this.EstudioIdlabel.Text = "EstudioId";
            // 
            // NombreEstudiolabel
            // 
            this.NombreEstudiolabel.AutoSize = true;
            this.NombreEstudiolabel.Location = new System.Drawing.Point(12, 158);
            this.NombreEstudiolabel.Name = "NombreEstudiolabel";
            this.NombreEstudiolabel.Size = new System.Drawing.Size(97, 13);
            this.NombreEstudiolabel.TabIndex = 2;
            this.NombreEstudiolabel.Text = "Nombre de Estudio";
            // 
            // EstudioIdtextBox
            // 
            this.EstudioIdtextBox.Location = new System.Drawing.Point(115, 99);
            this.EstudioIdtextBox.Name = "EstudioIdtextBox";
            this.EstudioIdtextBox.Size = new System.Drawing.Size(209, 20);
            this.EstudioIdtextBox.TabIndex = 3;
            // 
            // NombreEstudiotextBox
            // 
            this.NombreEstudiotextBox.Location = new System.Drawing.Point(115, 151);
            this.NombreEstudiotextBox.Name = "NombreEstudiotextBox";
            this.NombreEstudiotextBox.Size = new System.Drawing.Size(209, 20);
            this.NombreEstudiotextBox.TabIndex = 4;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(15, 227);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 5;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(130, 227);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 6;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(249, 227);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 7;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // VentanaRegistroEstudioCinematografico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.NombreEstudiotextBox);
            this.Controls.Add(this.EstudioIdtextBox);
            this.Controls.Add(this.NombreEstudiolabel);
            this.Controls.Add(this.EstudioIdlabel);
            this.Controls.Add(this.Estudiolabel);
            this.Name = "VentanaRegistroEstudioCinematografico";
            this.Text = "VentanaRegistroEstudioCinematografico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Estudiolabel;
        private System.Windows.Forms.Label EstudioIdlabel;
        private System.Windows.Forms.Label NombreEstudiolabel;
        private System.Windows.Forms.TextBox EstudioIdtextBox;
        private System.Windows.Forms.TextBox NombreEstudiotextBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
    }
}