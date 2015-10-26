using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoviesOrganizer
{
    public partial class VentanaVisorReport : Form
    {
        public VentanaVisorReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisorGenerosReport vgr = new VisorGenerosReport();
            GenerosReport gr = new GenerosReport();
            vgr.VisorcrystalReportViewer.ReportSource = gr;
            vgr.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            VisorActoresReport var = new VisorActoresReport();
            ActoresReport ar = new ActoresReport();
            var.VisorActorcrystalReportViewer.ReportSource = ar;
            var.ShowDialog();
        }
    }
}
