using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class Estudiante : Conexion, IMetodos
    {
        public Estudiante()
        {
            id = 0;
            registro = "";
            nombre = "";
            apellido = "";
            email = "";
            telefono = "";
            celular = "";
            id_carrera = 0;
           
            


        }
        #region Atributos 
        private int id;
        private string registro;
        private string nombre;
        private string apellido;
        private string email;
        private string telefono;
        private string celular;
        private int id_carrera;
        private int id_tesis;
        private int id_titulacion_otro;

        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public string Registro { get => registro; set => registro = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Celular { get => celular; set => celular = value; }
        public int Id_carrera { get => id_carrera; set => id_carrera = value; }
        public int Id_tesis { get => id_tesis; set => id_tesis = value; }
        public int Id_titulacion_otro { get => id_titulacion_otro; set => id_titulacion_otro = value; }

        #endregion
        #region Metodos 

        public void Insert()
        {
            string insertSQL = " INSERT INTO estudiante (registro,nombre, apellido,email,telefono, celular,id_carrera,        id_tesis,id_titulacion_otro) VALUES ('" + Registro + "','" + Nombre + "','" + Apellido + "','" + Email + "','" + Telefono + "','" + Celular + "'," + Id_carrera + "  ); ";
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
            string deleteSQL = " DELETE FROM estudiante WHERE id = " + id + " ; ";
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
            string updateSQL = " UPDATE estudiante " +
                         " SET registro = '" + Registro + "', nombre = '" + Nombre + "', apellido = '" + Apellido + "', email = '" + Email + "', telefono = '" + Telefono + "', celular = '" + Celular + "',id_carrera = " + Id_carrera + "  " +
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
