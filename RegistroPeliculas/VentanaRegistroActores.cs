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
    public partial class VentanaRegistroActores : Form
    {
        public VentanaRegistroActores()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (ActorIdtextBox.TextLength == 0)
            {
                Actores actor = new Actores();
                actor.Nombre = NomActortextBox.Text;
                if (actor.Insertar())
                {
                    MessageBox.Show("Actor no se guardo Correctamente");
                }
                else
                {
                    MessageBox.Show("Actor se guardo Correctamente");
                }

            }
            else
            {
                Actores actor = new Actores();
                actor.ActorId = Convert.ToInt32(ActorIdtextBox.Text);
                actor.Nombre = NomActortextBox.Text;
                if (actor.Editar())
                {
                    MessageBox.Show("Actor se guardo Correctamente");
                }
                else
                {
                    MessageBox.Show("Actor no se guardo Correctamente");
                }

            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if(ActorIdtextBox.TextLength > 0)
            {
                Actores actor = new Actores();
                actor.ActorId = Convert.ToInt32(ActorIdtextBox.Text);
                actor.Eliminar();
                MessageBox.Show("Actor se elimino Correctamente");
            }else
            {
                MessageBox.Show("Actor no de elimino Correctamente");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            ActorIdtextBox.Clear();
            NomActortextBox.Clear();
        }
    }
}
