using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class Notificacion
    {
        Conexion cnx = new Conexion();
        public Notificacion() : base()
        {

        }
        #region atributos
        private int id;
        private string titulo;
        private string mensaje;
        private string fecha;
        private string hora;
        private int leido;
        private string prioridad;
        private string tipo;
        private int id_perfil;
        string table_name = "notificacion";
        #endregion



        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Leido { get => leido; set => leido = value; }
        public string Prioridad { get => prioridad; set => prioridad = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Id_perfil { get => id_perfil; set => id_perfil = value; }

        #endregion

        #region Metodos
        protected DataTable getNotificaciones()
        {
            string sql = $"  select * from {table_name} ;";
            return cnx.SelectConexion(sql);
        }

        protected DataTable getPerfilTesis()
        {
            string sql = $"  select * from perfil_tesis ;";
            return cnx.SelectConexion(sql);

        }
        protected DataTable getRevisiones()
        {
            string sql = $"  select * from revision ;";
            return cnx.SelectConexion(sql);
        }
        protected void AllNotifications()
        {

        }

        protected void Insert()
        {

            string sql = $@"    INSERT INTO {table_name} 
                               ( 
                                    titulo,
                                    mensaje,
                                    fecha,
                                    hora,
                                    leido,
                                    prioridad,
                                    tipo,
                                    id_perfil  
                                )
                                VALUES 
                                ( 
                                    @parametro0,
                                    @parametro1,
                                    @parametro2,
                                    @parametro3,
                                    @parametro4,
                                    @parametro5,
                                    @parametro6,
                                    @parametro7
                                ); ";
            Object[] Parametros = new Object[] {
                                                    Titulo,
                                                    Mensaje,
                                                    Fecha,
                                                    Hora,
                                                    Leido,
                                                    Prioridad,
                                                    Tipo,
                                                    Id_perfil };
            cnx.QueryBuilder(sql, Parametros);
        }
        #endregion
        ~Notificacion()
        {

        }
    }
}
