using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class CarreraLicenciado : Conexion, IMetodos
    {
        public CarreraLicenciado()
        {
            id = 0;
            nombre = "";
        }
        #region Atributos 
        private int id;
        private string nombre;


        #endregion
        #region Propiedades 
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }


        #endregion
        #region Metodos 
        public void Insert()
        {
            string insertSQL = " INSERT INTO carrera_licenciado ( nombre) VALUES ('" + Nombre + "'  ); ";
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
            string deleteSQL = " DELETE FROM carrera_licenciado WHERE id = " + id + " ; ";
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
            string updateSQL = " UPDATE carrera_licenciado " +
                         " SET nombre = '" + Nombre + "'  " +
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
