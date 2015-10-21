using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Actores : ClaseMaestra
    {
        public int ActorId { get; set; }
        public string Nombre { get; set; }

        public Actores()
        {
            this.ActorId = 0;
            this.Nombre = "";
        }
        public override bool Consultar(int IdBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            try
            {
                DataTable datatable;
                datatable = conexion.ObtenerDatos(String.Format("select * from Actores whele ActorId = {0}", ActorId));
                this.Nombre = datatable.Rows[0]["Nombre"].ToString();
                return true;
            }catch (Exception)
            {
                return false;
            }
        }

        public override bool Editar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(string.Format("update Actores set Nombre = '{0}' where ActorId = {1}", this.Nombre, this.ActorId));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(string.Format("delete from Actores where ActorId = {0}",this.ActorId));
            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(string.Format("Insert Into Actores (Nombre) values('{0}')", this.Nombre));
            return retorno;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            return conexion.ObtenerDatos(string.Format("select " + Campos + " from Actores where "  + Condicion +Orden));
        }
        
    }
}
