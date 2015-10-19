using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class EstudiosCinematograficos : ClaseMaestra
    {
        public int estudioId { get; set; }
        public string nombre { get; set; }

        public EstudiosCinematograficos()
        {
            this.estudioId = 0;
            this.nombre = "";
        }
        public override bool Consultar(int IdBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            try
            {
                DataTable datatable;
                datatable = conexion.ObtenerDatos(string.Format("select * from Estudios where EstudioId = {0}", estudioId));
                this.nombre = datatable.Rows[0]["Nombre"].ToString();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Editar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(string.Format("update Estudios set Nombre = '{0}' where EstudioId = {1}", this.nombre, this.estudioId));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(string.Format("delete from Estudios where EstudioId = {0}", this.estudioId));
            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(string.Format("Insert Into Estudios (Nombre) values('{0}')", this.nombre));
            return retorno;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            return conexion.ObtenerDatos(String.Format("select " + Campos + " from Estudios where " + Condicion));
        }
        
        /*public DataTable ObtenerEstudiosCG(string campo)
        {
            ConexionDb conexion = new ConexionDb();

            return conexion.ObtenerDatos("select * from Estudios where" + campo);
        }*/
    }
}
