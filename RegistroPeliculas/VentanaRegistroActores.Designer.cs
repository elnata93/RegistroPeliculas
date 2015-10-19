namespace MoviesOrganizer
{
    partial class VentanaRegistroActores
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
            this.regActorlabel = new System.Windows.Forms.Label();
            this.actorIdlabel = new System.Windows.Forms.Label();
            this.ActorIdtextBox = new System.Windows.Forms.TextBox();
            this.NomActortextBox = new System.Windows.Forms.TextBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regActorlabel
            // 
            this.regActorlabel.AutoSize = true;
            this.regActorlabel.Location = new System.Drawing.Point(102, 26);
            this.regActorlabel.Name = "regActorlabel";
            this.regActorlabel.Size = new System.Drawing.Size(100, 13);
            this.regActorlabel.TabIndex = 0;
            this.regActorlabel.Text = "Registro de Actores";
            // 
            // actorIdlabel
            // 
            this.actorIdlabel.AutoSize = true;
            this.actorIdlabel.Location = new System.Drawing.Point(12, 76);
            this.actorIdlabel.Name = "actorIdlabel";
            this.actorIdlabel.Size = new System.Drawing.Size(41, 13);
            this.actorIdlabel.TabIndex = 1;
            this.actorIdlabel.Text = "ActorId";
            // 
            // ActorIdtextBox
            // 
            this.ActorIdtextBox.Location = new System.Drawing.Point(90, 73);
            this.ActorIdtextBox.Name = "ActorIdtextBox";
            this.ActorIdtextBox.Size = new System.Drawing.Size(182, 20);
            this.ActorIdtextBox.TabIndex = 2;
            // 
            // NomActortextBox
            // 
            this.NomActortextBox.Location = new System.Drawing.Point(90, 121);
            this.NomActortextBox.Name = "NomActortextBox";
            this.NomActortextBox.Size = new System.Drawing.Size(182, 20);
            this.NomActortextBox.TabIndex = 3;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(12, 169);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 4;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(105, 169);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 5;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(197, 169);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 6;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre Actor";
            // 
            // VentanaRegActores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 207);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.NomActortextBox);
            this.Controls.Add(this.ActorIdtextBox);
            this.Controls.Add(this.actorIdlabel);
            this.Controls.Add(this.regActorlabel);
            this.Name = "VentanaRegActores";
            this.Text = "VentanaRegActores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label regActorlabel;
        private System.Windows.Forms.Label actorIdlabel;
        private System.Windows.Forms.TextBox ActorIdtextBox;
        private System.Windows.Forms.TextBox NomActortextBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Label label3;
    }
}