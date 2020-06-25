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

        private SQLiteConnection cnx = ;
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
            //cnx = new SQLiteConnection("data source=" + pathBd + @"\bd\perfiles.db");
           
                if(cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();ffff
                    return cnx;
                }       
        }
        public void cerrarConexion()
        {asdasdasd
            
            
               /* if (Conexion.State == ConnectionState.Open)
                    Conexion.Close();
                return Conexion;*/
            
            *//*dfdf
        }



        #endregion



    }
}
