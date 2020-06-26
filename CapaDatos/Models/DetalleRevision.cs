using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class DetalleRevision : Conexion, IMetodos
    {
        public DetalleRevision()
        {
            id = 0;
            id_revision = 0;
            id_licenciado = 0;
            id_tipo_licenciado = 0;

        }

        #region Atributos 

        private int id;
        private int id_revision;
        private int id_licenciado;
        private int id_tipo_licenciado;



        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public int Id_revision { get => id_revision; set => id_revision = value; }
        public int Id_licenciado { get => id_licenciado; set => id_licenciado = value; }
        public int Id_tipo_licenciado { get => id_tipo_licenciado; set => id_tipo_licenciado = value; }


        #endregion
        #region Metodos 
        public void Insert()
        {
            string insertSQL = " INSERT INTO detalle_revision (id_revision, id_licenciado,id_tipo_licenciado ) VALUES ( "+Id_revision+","+Id_licenciado+","+Id_tipo_licenciado+" ); ";
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
            string deleteSQL = " DELETE FROM detalle_revision WHERE id = " + id + " ; ";
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
            string updateSQL = " UPDATE detalle_revision " +
                         " SET id_revision = "+Id_revision+", id_licenciado="+Id_licenciado+" ,id_tipo_licenciado = "+Id_tipo_licenciado+"  " +
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
