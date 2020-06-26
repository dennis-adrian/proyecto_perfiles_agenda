using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class Carrera : Conexion, IMetodos
    {
        public Carrera()
        {
            id = 0;
            nombre = "";
            id_facultad = 0;
          
        }
        #region Atributos 
        private int id;
        private string nombre;
        private int id_facultad;


        #endregion
        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_facultad { get => id_facultad; set => id_facultad = value; }

        #endregion
        #region Metodos 
        public void Insert()
        {
            string insertSQL = " INSERT INTO carrera ( nombre, id_facultad ) VALUES ('" + Nombre + "', " + Id_facultad + " ); ";
            SQLiteConnection cnx = AbrirConexion(); 
            if (cnx != null)
            {
                SQLiteTransaction sqlTransaction = cnx.BeginTransaction();
                SQLiteCommand command = new SQLiteCommand(insertSQL, cnx);
                command.ExecuteNonQuery();
                sqlTransaction.Commit();
            }
            cerrarConexion();
          
            
        }
        public void Delete()
        {

        }
        public void Update()
        {

        }
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            return dt;

        }
        #endregion
    }
}
