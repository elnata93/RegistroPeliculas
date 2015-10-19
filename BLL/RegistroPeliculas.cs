using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BLL
{
    public class RegistroPeliculas : ClaseMaestra
    {
        public int PeliculasId { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public int Calificacion { get; set; }
        public int IMDB { get; set; }
        public int CategoriaId { get; set; }
        public string Genero { get; set; }  
        public string Actor { get; set; }  
        public string Estudio { get; set; }
        public string Descripcion { get; set; }

        public RegistroPeliculas()
        {
            this.PeliculasId = 0;
            this.Titulo = "";
            this.Ano = 0;
            this.Calificacion = 0;
            this.IMDB = 0;
            this.CategoriaId = 0;
            this.Genero = "";
            this.Actor = "";
            this.Estudio = "";
            this.Descripcion = "";
        }

        public RegistroPeliculas(int peliculasid,string titulo,int ano,int calificacion,int imdb,int categoriaid, string genero,string actor,string estudio,string descripcion)
        {
            this.PeliculasId = peliculasid;
            this.Titulo = titulo;
            this.Ano = ano;
            this.Calificacion = calificacion;
            this.IMDB = imdb;
            this.CategoriaId = categoriaid;
            this.Genero = genero;
            this.Actor = actor;
            this.Estudio = estudio;
            this.Descripcion = descripcion;
        }


        public override bool Insertar()
        {
            bool retorno = false;

            ConexionDb conexion = new ConexionDb();

            conexion.Ejecutar(String.Format("Insert Into Peliculas (Titulo,Ano,Calificacion,IMDB,CategoriaId,Genero,Actor,Estudio,Descripcion) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", this.Titulo,this.Ano,this.Calificacion,this.IMDB,this.CategoriaId,this.Genero,this.Actor,this.Estudio,this.Descripcion));

            return retorno;

        }

        public DataTable Consultar(string campo,string consulta)
        {
            ConexionDb conexion = new ConexionDb();

            return conexion.ObtenerDatos("select * from Peliculas where "+campo+ " = "+consulta);
            
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();

                return conexion.ObtenerDatos("select " +Campos +" from where "+Condicion +Orden);
        }

        public override bool Editar()
        {
            throw new NotImplementedException();
        }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public override bool Consultar(int IdBuscado)
        {
            throw new NotImplementedException();
        }
    }
}
