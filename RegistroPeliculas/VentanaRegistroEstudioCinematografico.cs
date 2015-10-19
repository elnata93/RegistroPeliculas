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
    public partial class VentanaRegistroEstudioCinematografico : Form
    {
        public VentanaRegistroEstudioCinematografico()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (EstudioIdtextBox.TextLength == 0)
            {
                EstudiosCinematograficos  estudio = new EstudiosCinematograficos();

                estudio.nombre = NombreEstudiotextBox.Text;
                if (estudio.Insertar())
                {
                    MessageBox.Show("Estudio Cinematografico no se guardo Correctamente");
                }
                else
                {
                    MessageBox.Show("Estudio Cinematografico se  guardo Correctamente");
                }
            }
            else
            {
                EstudiosCinematograficos estudio = new EstudiosCinematograficos();

                estudio.estudioId = Convert.ToInt32(EstudioIdtextBox.Text);
                estudio.nombre = NombreEstudiotextBox.Text;
                if (estudio.Editar())
                {
                    MessageBox.Show("Estudio Cinematografico no se edito Correctamente");
                }
                else
                {
                    MessageBox.Show("Estudio Cinematografico se edito Correctamente");
                }

            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if(EstudioIdtextBox.TextLength > 0)
            {
                EstudiosCinematograficos estudio = new EstudiosCinematograficos();
                estudio.estudioId = Convert.ToInt32(EstudioIdtextBox.Text);
                estudio.Eliminar();
                MessageBox.Show("Estudio Cinematografico se elimino Correctamente");
            }
            else
            {
                MessageBox.Show("Estudio Cinematografico no se elimino Correctamente");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            EstudioIdtextBox.Clear();
            NombreEstudiotextBox.Clear();
        }
    }
}
