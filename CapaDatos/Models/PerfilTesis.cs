using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class PerfilTesis : Conexion
    {
        public PerfilTesis()
        {
            id = 0;
            tema = "";
            estado = "";
            fecha_aprobacion_jefe_carrera = "";
            fecha_recepcion_titulacion = "";
            estado_defensa = "";
            calificacion = 0;
            id_estudiante = 0;
            id_licenciado = 0;
            id_funcion_licenciado = 0;
            fecha_limite = "";
        }
        #region Atributos
        private string fecha_limite;
        private int id;
        private string tema;
        private string estado;
        private string fecha_aprobacion_jefe_carrera;
        private string fecha_recepcion_titulacion;
        private string estado_defensa;
        private double calificacion;
        private int id_estudiante;
        private int id_licenciado;
        private int id_funcion_licenciado;
        private static string table_name = "perfil_tesis";
        #endregion
        #region Propiedades
        public string Fecha_limite { get => fecha_limite; set => fecha_limite = value; }
        public int Id { get => id; set => id = value; }
        public string Tema { get => tema; set => tema = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Fecha_aprobacion_jefe_carrera { get => fecha_aprobacion_jefe_carrera; set => fecha_aprobacion_jefe_carrera = value; }
        public string Fecha_recepcion_titulacion { get => fecha_recepcion_titulacion; set => fecha_recepcion_titulacion = value; }
        public string Estado_defensa { get => estado_defensa; set => estado_defensa = value; }
        public double Calificacion { get => calificacion; set => calificacion = value; }
        public int Id_licenciado { get => id_licenciado; set => id_licenciado = value; }
        public int Id_funcion_licenciado { get => id_funcion_licenciado; set => id_funcion_licenciado = value; }
        public int Id_estudiante { get => id_estudiante; set => id_estudiante = value; }

        #endregion
        #region Metodos
        public void Insert()
        {


            string sql = $@" INSERT INTO {table_name} ( 
                                tema,
                                estado,
                                fecha_aprobacion_jefe_carrera,
                                fecha_recepcion_titulacion,
                                estado_defensa,
                                calificacion,
                                id_estudiante,
                                id_licenciado,
                                id_funcion_licenciado,
                                fecha_limite
                            ) 
                            VALUES ( 
                                @parametro0,
                                @parametro1,
                                @parametro2,
                                @parametro3,
                                @parametro4, 
                                @parametro5, 
                                @parametro6,
                                @parametro7,
                                @parametro8,
                                @parametro9
                            ); ";
            Object[] Parametros = new Object[] { 
                Tema, 
                Estado, 
                Fecha_aprobacion_jefe_carrera, 
                Fecha_recepcion_titulacion,                
                Estado_defensa,
                
                Calificacion,
                Id_estudiante,                
                Id_licenciado, 
                Id_funcion_licenciado, 
                Fecha_limite 
            };
            QueryBuilder(sql, Parametros);

        }
        public void Delete(int id)
        {
            string sql = $" DELETE FROM {table_name} WHERE id = @parametro0 ; ";
            Object[] Parametros = new Object[] { id };
            QueryBuilder(sql, Parametros);

        }
        public void Update(int id)
        {
            string sql = $" UPDATE {table_name}  SET tema = @parametro0,estado=@parametro1,fecha_aprobacion_jefe_carrera=@parametro2,fecha_recepcion_titulacion=@parametro3,estado_defensa=@parametro4,calificacion=@parametro5,id_estudiante=@parametro6,id_licenciado=@parametro7,id_funcion_licenciado=@parametro8  WHERE id = @parametro9 ; ";

            Object[] Parametros = new Object[] { Tema, Estado, Fecha_aprobacion_jefe_carrera, Fecha_recepcion_titulacion, Estado_defensa, Calificacion, Id_estudiante, Id_licenciado, Id_funcion_licenciado, id };
            QueryBuilder(sql, Parametros);

        }

        public void updateStatus(int id,string estado)
        {
            string sql = $" UPDATE {table_name}  SET estado ='{estado}'  WHERE id = @parametro0 ; ";
            Object[] Parametros = new Object[] {  id };
            QueryBuilder(sql, Parametros);
        }
        public DataTable Select()
        {
            string sql = $" SELECT * FROM {table_name} ; ";
            return SelectConexion(sql);
        }

        public DataTable perfilesById(int i)
        {
            string sql = $" SELECT * FROM ViewPerfilGeneral WHERE Id = {i} ; ";
            return SelectConexion(sql);
        }

        public int LastId()
        {
            return LastIdConexion(table_name);
        }

        public DataTable perfilesAll()
        {
            string sql = " SELECT * FROM ViewPerfilGeneral ; ";
            return SelectConexion(sql);
        }
        public DataTable perfilesAllByEstudiante(string criterio)
        {

            string sql = $" SELECT * FROM ViewPerfilGeneral  WHERE Alumno LIKE '%{criterio}%' ; ";
            return SelectConexion(sql);

        }

        public DataTable perfilesAllByCarrera(string criterio)
        {

            string sql = $" SELECT * FROM ViewPerfilGeneral  WHERE Carrera LIKE '%{criterio}%' ; ";
            return SelectConexion(sql);

        }
        public DataTable perfilesAllByCarreraAndEstudiante(string criterio,string estudiante)
        {

            string sql = $" SELECT * FROM ViewPerfilGeneral  WHERE Carrera LIKE '%{criterio}%' and  (Alumno LIKE '%{estudiante}%') ;  ";
            return SelectConexion(sql);

        }
        public int perfilTotalRevision(int id)
        {
            string sql = $" SELECT * FROM ViewPerfilGeneral WHERE Id = {id} ; ";
            var table = SelectConexion(sql);
            int rev = 0;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                rev = Convert.ToInt32(table.Rows[i]["Revisiones"].ToString());

            }

                return rev;
        }
        #endregion
    }
}
