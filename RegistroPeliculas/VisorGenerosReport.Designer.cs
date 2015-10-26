namespace MoviesOrganizer
{
    partial class VisorGenerosReport
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
            this.VisorcrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // VisorcrystalReportViewer
            // 
            this.VisorcrystalReportViewer.ActiveViewIndex = -1;
            this.VisorcrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VisorcrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.VisorcrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisorcrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.VisorcrystalReportViewer.Name = "VisorcrystalReportViewer";
            this.VisorcrystalReportViewer.Size = new System.Drawing.Size(428, 359);
            this.VisorcrystalReportViewer.TabIndex = 0;
            // 
            // VisorGenerosReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 359);
            this.Controls.Add(this.VisorcrystalReportViewer);
            this.Name = "VisorGenerosReport";
            this.Text = "VisorGenerosReport";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer VisorcrystalReportViewer;
    }
}