using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class Revision : Conexion, IMetodos
    {
        public Revision()
        {
            id = 0;
            fecha_entrega_alumno = "";
            fecha_entrega_tribunal = "";
            fecha_limite_devolucion = "";
            fecha_devolucion_tribunal = "";
            fecha_devolucion_alumno = "";
            nro_tribunal = 0;
            nro_revision = 0;
            fecha_empaste = "";
            id_tesis = 0;


        }
        #region Atributos 

        private int id;
        private string fecha_entrega_alumno;
        private string fecha_entrega_tribunal;
        private string fecha_limite_devolucion;
        private string fecha_devolucion_tribunal;
        private string fecha_devolucion_alumno;
        private int nro_tribunal;
        private int nro_revision;
        private string fecha_empaste;
        private int id_tesis;


        #endregion
        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Fecha_entrega_alumno { get => fecha_entrega_alumno; set => fecha_entrega_alumno = value; }
        public string Fecha_entrega_tribunal { get => fecha_entrega_tribunal; set => fecha_entrega_tribunal = value; }
        public string Fecha_limite_devolucion { get => fecha_limite_devolucion; set => fecha_limite_devolucion = value; }
        public string Fecha_devolucion_tribunal { get => fecha_devolucion_tribunal; set => fecha_devolucion_tribunal = value; }
        public string Fecha_devolucion_alumno { get => fecha_devolucion_alumno; set => fecha_devolucion_alumno = value; }
        public int Nro_tribunal { get => nro_tribunal; set => nro_tribunal = value; }
        public int Nro_revision { get => nro_revision; set => nro_revision = value; }
        public string Fecha_empaste { get => fecha_empaste; set => fecha_empaste = value; }
        public int Id_tesis { get => id_tesis; set => id_tesis = value; }


        #endregion
        #region Metodos 

             private static string TableName = "revision";
        public void Insert()
        {
            string sql = "  INSERT INTO " + TableName + " (  fecha_entrega_alumno,fecha_entrega_tribunal,fecha_limite_devolucion,fecha_devolucion_tribunal,fecha_devolucion_alumno,nro_tribunal,nro_revision,fecha_empaste, id_tesis  ) VALUES ( @parametro0,@parametro1,@parametro2,@parametro3,@parametro4,@parametro5,@parametro6,@parametro7,@parametro8); ";
            Object[] Parametros = new Object[] { Fecha_entrega_alumno, Fecha_entrega_tribunal, Fecha_limite_devolucion, Fecha_devolucion_tribunal, Fecha_devolucion_alumno, Nro_tribunal, Nro_revision, Fecha_empaste, Id_tesis };
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
            string sql = " UPDATE " + TableName + "  SET fecha_entrega_alumno=@parametro0,fecha_entrega_tribunal=@parametro1,fecha_limite_devolucion=@parametro2,fecha_devolucion_tribunal@parametro3,fecha_devolucion_alumno=@parametro4,nro_tribunal@parametro=5,nro_revision=@parametro6,fecha_empaste=@parametro7, id_tesis=@parametro8   WHERE id = @parametro9 ; ";

            Object[] Parametros = new Object[] { Fecha_entrega_alumno, Fecha_entrega_tribunal, Fecha_limite_devolucion, Fecha_devolucion_tribunal, Fecha_devolucion_alumno, Nro_tribunal, Nro_revision, Fecha_empaste, Id, id };
            QueryBuilder(sql, Parametros);

        }

        public DataTable Select()
        {
            string sql = " SELECT * FROM " + TableName + " ; ";
            return SelectConexion(sql);
        }
        public int LastId()
        {

            return LastIdConexion(TableName);
        }

        #endregion
    }
}
