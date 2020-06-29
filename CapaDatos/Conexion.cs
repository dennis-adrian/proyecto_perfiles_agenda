using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace CapaDatos
{
    public class Conexion
    {
        #region Atributos

        private SQLiteConnection cnx;
        private string pathBd;

        #endregion
        #region Propiedades
        public string PathBd { get => pathBd; set => pathBd = value; }
        public SQLiteConnection Cnx { get => cnx; set => cnx = value; }

        #endregion

        public Conexion()
        {
            pathBd = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\"));
            cnx = new SQLiteConnection("data source=" + pathBd + @"\bd\perfiles.db");
        }

        #region Metodos

        public SQLiteConnection AbrirConexion()
        {
            if (cnx.State == ConnectionState.Closed)
            {
                cnx.Open();

            }
            return cnx;
        }
        public SQLiteConnection cerrarConexion()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();

            }
            return cnx;

        }

        public void QueryBuilder(string sql, Object[] Parametros)
        {
            try
            {
                SQLiteConnection cnx = AbrirConexion();
                SQLiteTransaction sqlTransaction = cnx.BeginTransaction();
                SQLiteCommand command = cnx.CreateCommand();
                command.CommandText = sql;

                for (int i = 0; i < Parametros.Length; i++)
                {
                    string parametro = "@parametro" + Convert.ToString(i);
                    command.Parameters.Add(new SQLiteParameter(parametro, Parametros[i]));
                }

                command.ExecuteNonQuery();
                sqlTransaction.Commit();
                cerrarConexion();
            }
            catch
            {
                throw new ArgumentException("Error");
            }

        }
        public DataTable SelectConexion(string tabla)
        {

            string sql = " SELECT * FROM "+tabla+" ; ";
            try
            {
                SQLiteConnection cnx = AbrirConexion();
                SQLiteCommand cmd = new SQLiteCommand(sql, cnx);
                DataTable items = new DataTable();
                items.Load(cmd.ExecuteReader());
                cerrarConexion();
                return items;

            }
            catch
            {
                throw new ArgumentException("Error");
            }
        }
        public DataTable SelectConexion(string sql, string estudiante)
        {
            try
            {
                SQLiteConnection cnx = AbrirConexion();
                SQLiteCommand command = cnx.CreateCommand();
                command.CommandText = sql;
                command.Parameters.Add(new SQLiteParameter("@parametro", estudiante));
                DataTable items = new DataTable();
                items.Load(command.ExecuteReader());

                cerrarConexion();
                return items;
            }
            catch
            {
                throw new ArgumentException("Error");
            }

        }


        public int LastIdConexion(string tabla)
        {

            
            string sql = "SELECT * FROM " + tabla + " WHERE ID = (SELECT MAX(ID) FROM " + tabla + ");";

            try
            {
                int last = 0;
                SQLiteConnection cnx = AbrirConexion();
                SQLiteCommand cmd = new SQLiteCommand(sql, cnx);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    last = reader.GetInt32(0);

                }
                cerrarConexion();
                return last;
            }
            catch
            {
                throw new ArgumentException("Error");
            }
        }
        #endregion



    }
}
