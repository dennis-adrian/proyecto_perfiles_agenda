using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class TipoLicenciado: Conexion, IMetodos
    {
        public TipoLicenciado()
        {
            id = 0;
            tipo = "";
            funcion_licenciado = "";
            descripcion = "";

        }
        #region Atributos 
        private int id;
        private string tipo;
        private string funcion_licenciado;
        private string descripcion;



        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Funcion_licenciado { get => funcion_licenciado; set => funcion_licenciado = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }


        #endregion
        #region Metodos 
        public void Insert()
        {
            string insertSQL = " INSERT INTO tipo_licenciado ( tipo, funcion_licenciado,descripcion ) VALUES ('" + Tipo + "','" + Funcion_licenciado + "','"+Descripcion+"' ); ";
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
            string deleteSQL = " DELETE FROM tipo_licenciado WHERE id = " + id + " ; ";
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
            string updateSQL = " UPDATE tipo_licenciado " +
                         " SET tipo = '" + tipo + "', funcion_licenciado = '" + Funcion_licenciado + "',descripcion='"+Descripcion+"' " +
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
