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
        public int EstudioId { get; set; }
        public string Nombre { get; set; }

        public EstudiosCinematograficos()
        {
            this.EstudioId = 0;
            this.Nombre = "";
        }
        public override bool Consultar(int IdBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            try
            {
                DataTable datatable;
                datatable = conexion.ObtenerDatos(string.Format("select * from Estudios where EstudioId = {0}", EstudioId));
                this.Nombre = datatable.Rows[0]["Nombre"].ToString();
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
            conexion.Ejecutar(string.Format("update Estudios set Nombre = '{0}' where EstudioId = {1}", this.Nombre, this.EstudioId));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(string.Format("delete from Estudios where EstudioId = {0}", this.EstudioId));
            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(string.Format("Insert Into Estudios (Nombre) values('{0}')", this.Nombre));
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
