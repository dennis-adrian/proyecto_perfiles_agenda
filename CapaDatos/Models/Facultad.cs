using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class Facultad: Conexion, IMetodos
    {
        public Facultad()
        {
            id = 0;
            nombre = "";
        }
        #region Atributos 
        private int id;
        private string nombre;


        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }


        #endregion
        #region Metodos 

        public void Insert()
        {
            string insertSQL = " INSERT INTO facultad ( nombre) VALUES ('" + Nombre + "' ); ";
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
            string deleteSQL = " DELETE FROM facultad WHERE id = " + id + " ; ";
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
            string updateSQL = " UPDATE facultad " +
                         " SET nombre = '" + Nombre + "' " +
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
