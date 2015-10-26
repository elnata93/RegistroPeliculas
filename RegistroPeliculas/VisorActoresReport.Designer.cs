namespace MoviesOrganizer
{
    partial class VisorActoresReport
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
            this.VisorActorcrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // VisorActorcrystalReportViewer
            // 
            this.VisorActorcrystalReportViewer.ActiveViewIndex = -1;
            this.VisorActorcrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VisorActorcrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.VisorActorcrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisorActorcrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.VisorActorcrystalReportViewer.Name = "VisorActorcrystalReportViewer";
            this.VisorActorcrystalReportViewer.Size = new System.Drawing.Size(492, 437);
            this.VisorActorcrystalReportViewer.TabIndex = 0;
            // 
            // VisorActoresReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 437);
            this.Controls.Add(this.VisorActorcrystalReportViewer);
            this.Name = "VisorActoresReport";
            this.Text = "VisorActoresReport";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer VisorActorcrystalReportViewer;
    }
}