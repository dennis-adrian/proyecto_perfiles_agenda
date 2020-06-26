using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class TipoTitulacionOtros: Conexion, IMetodos
    {
        public TipoTitulacionOtros()
        {
            id = 0;
            tipo = "";
            descripcion = "";
        }
        #region Atributos 
        private int id;
        private string tipo;
        private string descripcion;

        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        #endregion
        #region Metodos 
        public void Insert()
        {
            string insertSQL = " INSERT INTO tipo_titulacion_otros ( tipo,descripcion ) VALUES ('" + Tipo + "', '" + Descripcion + "' ); ";
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
            string deleteSQL = " DELETE FROM tipo_titulacion_otros WHERE id = " + id + " ; ";
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
            string updateSQL = " UPDATE tipo_titulacion_otros " +
                         " SET tipo = '" + Tipo + "', descripcion = '" + Descripcion + "' " +
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
