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
        private SQLiteConnection cnx;
        private string pathBd;

        public string PathBd { get => pathBd; set => pathBd = value; }
        public SQLiteConnection Cnx { get => cnx; set => cnx = value; }

        public Conexion()
        {
            //cnx = new SQLiteConnection("data source=" + pathBd + @"\bd\perfiles.db");
            pathBd = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\"));
        }
        
        public void abrirConexion()
        {
            cnx = new SQLiteConnection("data source=" + pathBd + @"\bd\perfiles.db");
            cnx.Open();
        }
        public void insertarDatos(string sql)
        {
            abrirConexion();
            string insertSQL = sql;
            SQLiteTransaction sqlTransaction = cnx.BeginTransaction();
            SQLiteCommand command = new SQLiteCommand(insertSQL, cnx);
            command.ExecuteNonQuery();
            sqlTransaction.Commit();

        }

        public DataTable mostrarDatos(string sql)
        {
            abrirConexion();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, cnx);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cnx.Close();
            return ds;
        }
        public DataTable cargarCombo(string sql)
        {
            abrirConexion();
            SQLiteCommand cmd = new SQLiteCommand(sql, cnx);
            DataTable items = new DataTable();
            items.Load(cmd.ExecuteReader());
            return items;


        }
        public DataTable cargarperfilaprobado(string sql)
        {
            abrirConexion();
            SQLiteCommand cmd = new SQLiteCommand(sql, cnx);
            DataTable items = new DataTable();
            items.Load(cmd.ExecuteReader());
            return items;

        }
    }
}
