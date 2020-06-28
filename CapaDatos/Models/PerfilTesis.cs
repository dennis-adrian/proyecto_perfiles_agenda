using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class PerfilTesis : Conexion, IMetodos
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
            id_tipo_licenciado = 0;
        }
        #region Atributos 
        private int id;
        private string tema;
        private string estado;
        private string fecha_aprobacion_jefe_carrera;
        private string fecha_recepcion_titulacion;
        private string estado_defensa;
        private double calificacion;
        private int id_estudiante;
        private int id_licenciado;
        private int id_tipo_licenciado;


        #endregion
        #region Propiedades 

        public int Id { get => id; set => id = value; }
        public string Tema { get => tema; set => tema = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Fecha_aprobacion_jefe_carrera { get => fecha_aprobacion_jefe_carrera; set => fecha_aprobacion_jefe_carrera = value; }
        public string Fecha_recepcion_titulacion { get => fecha_recepcion_titulacion; set => fecha_recepcion_titulacion = value; }
        public string Estado_defensa { get => estado_defensa; set => estado_defensa = value; }
        public double Calificacion { get => calificacion; set => calificacion = value; }
        public int Id_licenciado { get => id_licenciado; set => id_licenciado = value; }
        public int Id_tipo_licenciado { get => id_tipo_licenciado; set => id_tipo_licenciado = value; }
        public int Id_estudiante { get => id_estudiante; set => id_estudiante = value; }

        #endregion
        #region Metodos 
        //tema,estado,fecha_aprobacion_jefe_carrera,fecha_recepcion_titulacion,estado_defensa,calificacion,id_estudiante,id_licenciado,id_tipo_licenciado
        private static string TableName = "perfil_tesis";
        public void Insert()
        {
            string sql = "  INSERT INTO " + TableName + " (tema,estado,fecha_aprobacion_jefe_carrera,fecha_recepcion_titulacion,estado_defensa,calificacion,id_estudiante,id_licenciado,id_tipo_licenciado ) VALUES ( @parametro0, @parametro1, @parametro2 @parametro3, @parametro4, @parametro5, @parametro6,@parametro7,@parametro8); ";
            Object[] Parametros = new Object[] { Tema,Estado,Fecha_aprobacion_jefe_carrera,Fecha_recepcion_titulacion,Estado_defensa,Calificacion,Id_estudiante,Id_licenciado,Id_tipo_licenciado};
            QueryBuilder(sql, Parametros);

        }
        public void Delete(int id)
        {
            string sql = " DELETE FROM " + TableName + " WHERE id = @parametro0 ; ";
            Object[] Parametros = new Object[] { id };
            QueryBuilder(sql, Parametros);

        }
        public void Update(int id)
        {
            string sql = " UPDATE " + TableName + "  SET tema = @parametro0,estado=@parametro1,fecha_aprobacion_jefe_carrera=@parametro2,fecha_recepcion_titulacion=@parametro3,estado_defensa=@parametro4,calificacion=@parametro5,id_estudiante=@parametro6,id_licenciado=@parametro7,id_tipo_licenciado=@parametro8  WHERE id = @parametro9 ; ";

            Object[] Parametros = new Object[] { Tema, Estado, Fecha_aprobacion_jefe_carrera, Fecha_recepcion_titulacion, Estado_defensa, Calificacion, Id_estudiante, Id_licenciado, Id_tipo_licenciado, id };
            QueryBuilder(sql, Parametros);

        }

        public DataTable Select()
        {
            return SelectConexion(TableName);
        }
        public int LastId()
        {

            return LastIdConexion(TableName);
        }

        #endregion
    }
}
