using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class Notificacion: CapaDatos.Conexion
    {
        public Notificacion()
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
        public DataTable findUnread()
        {
            string sql = $"  select * from {table_name} where leido = 0 limit 10;";
            return SelectConexion(sql);
        }
        public DataTable findRead()
        {
            string sql = $"  select * from {table_name} where leido = 1 ;";
            return SelectConexion(sql);
        }
        public DataTable find()
        {
            string sql = $"  select * from {table_name} ;";
            return SelectConexion(sql);
        }
 
        public DataTable findById(int id)
        {
            string sql = $"  select * from {table_name} WHERE id = {id} ; ";
            return SelectConexion(sql);
        }

        public DataTable getData(string table)
        {

            string sql = $"  select * from {table} ;";
            return SelectConexion(sql);
        }

        public void updateLeido(int id)
        {
            string sql = $" update notificacion set leido = 1 where id = @parametro0 ; ";
            Object[] Parametros = new Object[] { id };
            QueryBuilder(sql,Parametros);
        }
        public void Insert()
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
            QueryBuilder(sql, Parametros);
        }
        #endregion
        ~Notificacion()
        {

        }
    }
}
