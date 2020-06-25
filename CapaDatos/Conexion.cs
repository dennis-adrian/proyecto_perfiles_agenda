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

        #endregion



    }
}
