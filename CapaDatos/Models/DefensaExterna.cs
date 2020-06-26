using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class DefensaExterna : Conexion, IMetodos
    {
        public DefensaExterna()
        {
            id = 0;
            fecha_presentacion = "";
            hora = "";
            aula = "";
            id_tesis = 0;
            id_titulacion_otro = 0;
        }
        #region Atributos 
        private int id;
        private string fecha_presentacion;
        private string hora;
        private string aula;
        private int id_tesis;
        private int id_titulacion_otro;

        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public string Fecha_presentacion { get => fecha_presentacion; set => fecha_presentacion = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Aula { get => aula; set => aula = value; }
        public int Id_tesis { get => id_tesis; set => id_tesis = value; }
        public int Id_titulacion_otro { get => id_titulacion_otro; set => id_titulacion_otro = value; }

        #endregion
        #region Metodos 


        public void Insert()
        {
            string insertSQL = " INSERT INTO defensa_externa ( fecha_presentacion, hora,aula,id_tesis,id_titulacion_otro ) VALUES ( '"+ Fecha_presentacion + "','" + Hora + "','" + Aula + "', " + Id_tesis + ", " +Id_titulacion_otro+" ); ";
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
            string deleteSQL = " DELETE FROM defensa_externa WHERE id = " + id + " ; ";
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
            string updateSQL = " UPDATE defensa_externa " +
                        " SET fecha_presentacion = '" + Fecha_presentacion + "', hora = '" + Hora + "', aula = '" + Aula + "', id_tesis = " + Id_tesis + ", id_titulacion_otro = " + Id_titulacion_otro + " " +
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
        public DataTable SelectId(int id)
        {
            DataTable dt = new DataTable();
            return dt;

        }
        public DataTable LastId()
        {
            DataTable dt = new DataTable();
            return dt;

        }



        #endregion
    }
}
