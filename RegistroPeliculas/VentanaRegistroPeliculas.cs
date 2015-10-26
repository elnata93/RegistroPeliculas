
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
    public partial class VentanaRegistroPeliculas : Form
    {
        
        public VentanaRegistroPeliculas()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            RegistroPeliculas rp = new RegistroPeliculas();

            if (TitulotextBox.TextLength > 0 && AnotextBox.TextLength > 0)
            {
                rp.Titulo = TitulotextBox.Text;
                rp.Ano = Convert.ToInt32(AnotextBox.Text);
                rp.Calificacion = Convert.ToInt32(CalificaciontextBox.Text);
                rp.IMDB = Convert.ToInt32(IMDBtextBox.Text);
                rp.CategoriaId = Convert.ToInt32(CategoriaIDtextBox.Text);
                //rp.Genero = GeneroscomboBox.Text;
                for (int i = 0; i < GenerolistBox.Items.Count; i++)
                {
                    rp.Genero += GenerolistBox.Items[i].ToString();
                }
                //rp.Actor = ActorescomboBox.Text;
                for (int i = 0; i < ActorlistBox.Items.Count; i++)
                {
                    rp.Actor += ActorlistBox.Items[i].ToString();
                }
                rp.Estudio = EstudiosCGcomboBox.Text;
                rp.Descripcion = DescripcionrichTextBox.Text;
                if (rp.Insertar())
                {
                    MessageBox.Show("Pelicula no se guardo Correctamente");
                }
                else
                {
                    MessageBox.Show("Pelicula se guardo Correctamente");
                }
            }
            else
            {
                rp.PeliculaId = Convert.ToInt32(PeliculaIdtextBox.Text);
                rp.Titulo = TitulotextBox.Text;
                rp.Ano = Convert.ToInt32(AnotextBox.Text);
                rp.Calificacion = Convert.ToInt32(CalificaciontextBox.Text);
                rp.IMDB = Convert.ToInt32(IMDBtextBox.Text);
                rp.CategoriaId = Convert.ToInt32(CategoriaIDtextBox.Text);
                //rp.Genero = GeneroscomboBox.Text;
                rp.Genero = GenerolistBox.Text;
                //rp.Actor = ActorescomboBox.Text;
                rp.Actor = ActorlistBox.Text;
                rp.Estudio = EstudiosCGcomboBox.Text;
                rp.Descripcion = DescripcionrichTextBox.Text;
                if (rp.Editar())
                {
                    MessageBox.Show("Pelicula no se guardo Correctamente");
                }
                else
                {
                    MessageBox.Show("Pelicula se guardo Correctamente");
                }
                    
            }
            
        }
        
        private void VentanaRegistroPeliculas_Load(object sender, EventArgs e)
        {
            Generos genero = new Generos();
            Actores actor = new Actores();
            EstudiosCinematograficos estudios = new EstudiosCinematograficos();

            for (int i = 0; i < genero.Listado("Descripcion", "1=1", "").Rows.Count; i++)
            {
                GeneroscomboBox.Items.Add(genero.Listado("Descripcion", "1=1", "").Rows[i]["Descripcion"]);
            }

            for (int i = 0; i < actor.Listado("Nombre", "1=1", "").Rows.Count; i++)
            {
                ActorescomboBox.Items.Add(actor.Listado("Nombre", "1=1", "").Rows[i]["Nombre"]);
            }

            for (int i = 0; i < estudios.Listado("Nombre", "1=1", "").Rows.Count; i++)
            {
                EstudiosCGcomboBox.Items.Add(estudios.Listado("Nombre", "1=1", "").Rows[i]["Nombre"]);
            }

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            PeliculaIdtextBox.Clear();
            TitulotextBox.Clear();
            AnotextBox.Clear();
            CalificaciontextBox.Clear();
            IMDBtextBox.Clear();
            CategoriaIDtextBox.Clear();
            GeneroscomboBox.SelectedIndex = 0;
            ActorescomboBox.SelectedIndex=0;
            EstudiosCGcomboBox.SelectedIndex=0;
            DescripcionrichTextBox.Clear();
            GenerolistBox.Items.Clear();
            ActorlistBox.Items.Clear();
            
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (PeliculaIdtextBox.TextLength > 0)
            {
                RegistroPeliculas rp = new RegistroPeliculas();

                rp.PeliculaId = Convert.ToInt32(PeliculaIdtextBox.Text);
                rp.Eliminar();
                MessageBox.Show("Pelicula se elimino Correctamente");
            }
            else
            {
                MessageBox.Show("Pelicula no se elimino correctamente");
            }
        }

        private void Agregarbutton1_Click(object sender, EventArgs e)
        {
            GenerolistBox.Items.Add(GeneroscomboBox.Text);
                                
        }

        private void Agregarbutton2_Click(object sender, EventArgs e)
        {
            ActorlistBox.Items.Add(ActorescomboBox.Text);
            
        }

    }
         
}
