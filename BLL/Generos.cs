using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Generos : ClaseMaestra
    {
        public int GeneroId { get; set; }
        public string Descripcion { get; set; }

        public Generos()
        {
            this.GeneroId = 0;
            this.Descripcion = "";
        }

        public override bool Consultar(int IdBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            try
            {
                DataTable datatable;
                datatable = conexion.ObtenerDatos(String.Format("select *  from Generos where GeneroId = {0}",this.GeneroId));
                this.Descripcion = datatable.Rows[0]["Descripcion"].ToString();
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
            conexion.Ejecutar(string.Format("update Generos set Descripcion ='{0}' where GeneroId = {1}",this.Descripcion,this.GeneroId));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;

            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(string.Format("delete from Generos where GeneroId = {0}", this.GeneroId));
            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno = false;

            ConexionDb conexion = new ConexionDb();
            conexion.Ejecutar(string.Format("Insert Into Generos (Descripcion) values('{0}')", this.Descripcion));
            return retorno;
        }


        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            return conexion.ObtenerDatos(string.Format("select " + Campos + " from Generos where " + Condicion));
        }
    }
}