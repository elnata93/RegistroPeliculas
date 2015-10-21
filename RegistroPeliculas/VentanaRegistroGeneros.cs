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
    public partial class VentanaRegistroGeneros : Form
    {
        public VentanaRegistroGeneros()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (GeneroIdtextBox.TextLength == 0)
            {
                Generos genero = new Generos();

                genero.Descripcion = DescripciontextBox.Text;
                if (genero.Insertar())
                {
                    MessageBox.Show("Genero no se guardo Correctamente");
                }
                else
                {
                    MessageBox.Show("Genero se guardo Correctamente");
                }
             }
             else
             {
                Generos genero = new Generos();

                genero.GeneroId = Convert.ToInt32(GeneroIdtextBox.Text);
                genero.Descripcion = DescripciontextBox.Text;
                if (genero.Editar()) 
                {
                    MessageBox.Show("Genero se edito Correctamente");
                }
                else
                { 
                    MessageBox.Show("Genero no se edito Correctamente");
                }
               
            }

        }
            

        private void eliminarbutton_Click(object sender, EventArgs e)
        {
            if (GeneroIdtextBox.TextLength > 0)
            {
                Generos genero = new Generos();

                genero.GeneroId = Convert.ToInt32(GeneroIdtextBox.Text);
                genero.Eliminar();
                MessageBox.Show("Genero se elimino Correctamente");
            }
            else
            {
                MessageBox.Show("Genero no se elimino correctamente");
            }
        }

        private void nuevobutton_Click(object sender, EventArgs e)
        {
           
            GeneroIdtextBox.Clear();
            DescripciontextBox.Clear();
        }

        private void VentanaRegistroGeneros_Load(object sender, EventArgs e)
        {

        }
    }
}
 