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
        public void Insert()
        {
            string insertSQL = " INSERT INTO revision  ( fecha_entrega_alumno,fecha_entrega_tribunal,fecha_limite_devolucion,fecha_devolucion_tribunal,fecha_devolucion_alumno,nro_tribunal,nro_revision,fecha_empaste, id_tesis ) VALUES ('"+Fecha_entrega_alumno+"','"+Fecha_entrega_tribunal+"','"+Fecha_limite_devolucion+"','"+Fecha_devolucion_tribunal+"','"+Fecha_devolucion_alumno+"',"+Nro_tribunal+" ,"+Nro_revision+" ,'"+Fecha_empaste+"',"+Id_tesis+" ); ";
            SQLiteConnection cnx = AbrirConexion();
            if (cnx != null)
            {
                SQLiteTransaction sqlTransaction = cnx.BeginTransaction();
                SQLiteCommand command = new SQLiteCommand(insertSQL, cnx);
                command.ExecuteNonQuery();
                sqlTransaction.Commit();

                cerrarConexion();
            }




        }
        public void Delete(int id)
        {
            string deleteSQL = " DELETE FROM revision WHERE id = " + id + " ; ";
            SQLiteConnection cnx = AbrirConexion();
            if (cnx != null)
            {
                SQLiteTransaction sqlTransaction = cnx.BeginTransaction();
                SQLiteCommand command = new SQLiteCommand(deleteSQL, cnx);
                command.ExecuteNonQuery();
                sqlTransaction.Commit();

                cerrarConexion();
            }



        }
        public void Update(int id)
        {
            string updateSQL = " UPDATE revision  " +
                         " SET fecha_entrega_alumno = '"+Fecha_entrega_alumno+"',fecha_entrega_tribunal= '"+Fecha_entrega_tribunal+"',fecha_limite_devolucion = '"+Fecha_limite_devolucion+"',fecha_devolucion_tribunal = '"+Fecha_devolucion_tribunal+"',fecha_devolucion_alumno = '"+Fecha_devolucion_alumno+"',nro_tribunal="+Nro_tribunal+",nro_revision="+Nro_revision+",fecha_empaste='"+Fecha_empaste+"',id_tesis="+Id_tesis+" " +
                         " WHERE id = " + id + " ; ";

            SQLiteConnection cnx = AbrirConexion();
            if (cnx != null)
            {
                SQLiteTransaction sqlTransaction = cnx.BeginTransaction();
                SQLiteCommand command = new SQLiteCommand(updateSQL, cnx);
                command.ExecuteNonQuery();
                sqlTransaction.Commit();

                cerrarConexion();
            }

        }
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            return dt;

        }
        #endregion
    }
}
