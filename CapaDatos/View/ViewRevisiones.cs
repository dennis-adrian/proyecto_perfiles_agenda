using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.View
{
    public class ViewRevisiones
    {
        Conexion obj = new Conexion();
        public ViewRevisiones()
        {

            id = 0;
            id_tesis = 0;
            estado = "";
            fecha_entrega_alumno = "";
            fecha_entrega_tribunal = "";
            fecha_limite_devolucion = "";
            fecha_devolucion_tribunal = "";
            fecha_devolucion_alumno = "";
            observacion = "";
            nro_tribunal = 0;
            nro_revision = 0;           
            fecha_empaste = "";
            id_Licenciado = 0;
            licenciado = "";
            tipo = "";
            funcion = "";


        }
        #region Atributos

        private int id;
        private int id_tesis;
        private string estado;
        private string fecha_entrega_alumno;
        private string fecha_entrega_tribunal;
        private string fecha_limite_devolucion;
        private string fecha_devolucion_tribunal;
        private string fecha_devolucion_alumno;
        private string observacion;
        private int nro_tribunal;
        private int nro_revision;
        private string fecha_empaste;
        private int id_Licenciado;
        private string licenciado;
        private string tipo;
        private string funcion;



        #endregion
        #region Propiedades
        public int Id { get => id; set => id = value; }
        public int Id_tesis { get => id_tesis; set => id_tesis = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Fecha_entrega_alumno { get => fecha_entrega_alumno; set => fecha_entrega_alumno = value; }
        public string Fecha_entrega_tribunal { get => fecha_entrega_tribunal; set => fecha_entrega_tribunal = value; }
        public string Fecha_limite_devolucion { get => fecha_limite_devolucion; set => fecha_limite_devolucion = value; }
        public string Fecha_devolucion_tribunal { get => fecha_devolucion_tribunal; set => fecha_devolucion_tribunal = value; }
        public string Fecha_devolucion_alumno { get => fecha_devolucion_alumno; set => fecha_devolucion_alumno = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Nro_tribunal { get => nro_tribunal; set => nro_tribunal = value; }
        public int Nro_revision { get => nro_revision; set => nro_revision = value; }
        public string Fecha_empaste { get => fecha_empaste; set => fecha_empaste = value; }
        public string Licenciado { get => licenciado; set => licenciado = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Funcion { get => funcion; set => funcion = value; }
        public int Id_Licenciado { get => id_Licenciado; set => id_Licenciado = value; }

        #endregion

        #region Metodos

        public DataTable Select(int i)
        {
            string sql = " SELECT * FROM ViewRevisiones WHERE Id_tesis = " + i + " ; ";
            return obj.SelectConexion(sql);
        }
        public DataTable RevisionByTribunal(int idp, int nro, int tri)
        {
            string sql = " SELECT * FROM ViewRevisiones WHERE Id_tesis = " + idp + " AND Nro_revision = " + nro + " AND Nro_tribunal = " + tri + " ; ";
            return obj.SelectConexion(sql);
        }


        #endregion
    }
}
