namespace MoviesOrganizer
{
    partial class VentanaConsultar
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
            this.ConsultartextBox = new System.Windows.Forms.TextBox();
            this.Consultarbutton = new System.Windows.Forms.Button();
            this.ConsultardataGridView = new System.Windows.Forms.DataGridView();
            this.Consultarlabel = new System.Windows.Forms.Label();
            this.BuscarcomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultardataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultartextBox
            // 
            this.ConsultartextBox.Location = new System.Drawing.Point(139, 49);
            this.ConsultartextBox.Name = "ConsultartextBox";
            this.ConsultartextBox.Size = new System.Drawing.Size(552, 20);
            this.ConsultartextBox.TabIndex = 1;
            // 
            // Consultarbutton
            // 
            this.Consultarbutton.Location = new System.Drawing.Point(697, 47);
            this.Consultarbutton.Name = "Consultarbutton";
            this.Consultarbutton.Size = new System.Drawing.Size(75, 23);
            this.Consultarbutton.TabIndex = 2;
            this.Consultarbutton.Text = "Consultar";
            this.Consultarbutton.UseVisualStyleBackColor = true;
            this.Consultarbutton.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // ConsultardataGridView
            // 
            this.ConsultardataGridView.AllowUserToAddRows = false;
            this.ConsultardataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultardataGridView.Location = new System.Drawing.Point(12, 91);
            this.ConsultardataGridView.Name = "ConsultardataGridView";
            this.ConsultardataGridView.Size = new System.Drawing.Size(760, 171);
            this.ConsultardataGridView.TabIndex = 3;
            // 
            // Consultarlabel
            // 
            this.Consultarlabel.AutoSize = true;
            this.Consultarlabel.Location = new System.Drawing.Point(353, 9);
            this.Consultarlabel.Name = "Consultarlabel";
            this.Consultarlabel.Size = new System.Drawing.Size(103, 13);
            this.Consultarlabel.TabIndex = 4;
            this.Consultarlabel.Text = "Consulta de Pelicula";
            // 
            // BuscarcomboBox
            // 
            this.BuscarcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuscarcomboBox.FormattingEnabled = true;
            this.BuscarcomboBox.Items.AddRange(new object[] {
            "Todos",
            "PeliculaId",
            "Titulo ",
            "Ano",
            "Calificacion",
            "IMDB",
            "Categoria"});
            this.BuscarcomboBox.Location = new System.Drawing.Point(12, 48);
            this.BuscarcomboBox.Name = "BuscarcomboBox";
            this.BuscarcomboBox.Size = new System.Drawing.Size(121, 21);
            this.BuscarcomboBox.TabIndex = 6;
            // 
            // VentanaConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(784, 316);
            this.Controls.Add(this.BuscarcomboBox);
            this.Controls.Add(this.Consultarlabel);
            this.Controls.Add(this.ConsultardataGridView);
            this.Controls.Add(this.Consultarbutton);
            this.Controls.Add(this.ConsultartextBox);
            this.Name = "VentanaConsultar";
            this.Text = "VentanaConsultar";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultardataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ConsultartextBox;
        private System.Windows.Forms.Button Consultarbutton;
        private System.Windows.Forms.DataGridView ConsultardataGridView;
        private System.Windows.Forms.Label Consultarlabel;
        private System.Windows.Forms.ComboBox BuscarcomboBox;
    }
}