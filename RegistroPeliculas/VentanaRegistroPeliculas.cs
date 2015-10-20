
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
            
            if (TitulotextBox.TextLength > 0 && AnotextBox.TextLength > 0 && CalificaciontextBox.TextLength > 0 && IMDBtextBox.TextLength > 0 && CalificaciontextBox.TextLength > 0 /*&& GeneroscomboBox > 0 && ActorescomboBox > 0 && EstudiosCGcomboBox > 0*/ && DescripcionrichTextBox.TextLength > 0)
            {
                rp.Titulo = TitulotextBox.Text;
                rp.Ano = Convert.ToInt32(AnotextBox.Text);
                rp.Calificacion = Convert.ToInt32(CalificaciontextBox.Text);
                rp.IMDB = Convert.ToInt32(IMDBtextBox.Text);
                rp.CategoriaId = Convert.ToInt32(CategoriaIDtextBox.Text);
                rp.Genero = GeneroscomboBox.Text;
                rp.Actor = ActorescomboBox.Text;
                rp.Estudio = EstudiosCGcomboBox.Text;
                rp.Descripcion = DescripcionrichTextBox.Text; 
                if (rp.Insertar())
                {
                       
                    TitulotextBox.Clear();
                    AnotextBox.Clear();
                    CalificaciontextBox.Clear();
                    IMDBtextBox.Clear();
                    CategoriaIDtextBox.Clear();
                    DescripcionrichTextBox.Clear();
                    MessageBox.Show("Pelicula no se guardo Correctamente");
                }
                else
                {
                    MessageBox.Show("Pelicula se guardo Correctamente");
                }
            }
            else
            {
                MessageBox.Show("El campo no puede estar vacio");
            }
            
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GeneroscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // RegistroPeliculas rp = new RegistroPeliculas();
            // ListadodataGridViewDataSource = rp.Listado(GeneroscomboBox.Text,"","");
            //datos = GeneroscomboBox.SelectedValue.ToString();

        }

      private void ActorescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //RegistroPeliculas rp = new RegistroPeliculas();
            //ListadodataGridViewDataSource = rp.Listado(ActorescomboBox.Text,"","");
        }

        private void EstudiosCGcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           // RegistroPeliculas rp = new RegistroPeliculas();
           //ListadodataGridViewDataSource = rp.Listado(EstudiosCGcomboBox.Text,"","");
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
            
            for (int i = 0; i < actor.Listado("Nombre","1=1","").Rows.Count; i++)
            {
                ActorescomboBox.Items.Add(actor.Listado("Nombre", "1=1", "").Rows[i]["Nombre"]);
            }

            for (int i = 0; i < estudios.Listado("Nombre", "1=1", "").Rows.Count; i++)
            {
                EstudiosCGcomboBox.Items.Add(estudios.Listado("Nombre", "1=1", "").Rows[i]["Nombre"]);
            }

            for (int i = 0; i < genero.Listado("Descripcion", "1=1", "").Rows.Count; i++)
            {
                GeneroscomboBox1.Items.Add(genero.Listado("Descripcion", "1=1", "").Rows[i]["Descripcion"]);
            }
        }
         
        private void Agregarbutton1_Click(object sender, EventArgs e)
        {
              
        }
    }
         
}
