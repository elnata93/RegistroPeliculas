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
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        private void regToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaRegistroPeliculas vr = new VentanaRegistroPeliculas();
            vr.Show();
        }

        private class RegistroForm
        {
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaConsultar vc = new VentanaConsultar();
            vc.Show();
        }

        private void generosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaRegistroGeneros vrg = new VentanaRegistroGeneros();
            vrg.Show();
        }

        private void actoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaRegistroActores vra = new VentanaRegistroActores();
            vra.Show();
        }

        private void estudiosCinematograficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaRegistroEstudioCinematografico vrec = new VentanaRegistroEstudioCinematografico();
            vrec.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaVisorReport vsp = new VentanaVisorReport();
            vsp.ShowDialog();
        }
    }
}
