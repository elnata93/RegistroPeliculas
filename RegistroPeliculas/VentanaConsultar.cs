using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace MoviesOrganizer
{
    public partial class VentanaConsultar : Form
    {
        public VentanaConsultar()
        {
            InitializeComponent();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            RegistroPeliculas cs = new RegistroPeliculas();
            ConsultardataGridView.DataSource=cs.Consultar(BuscarcomboBox.Text , ConsultartextBox.Text);

        }
    }
}
