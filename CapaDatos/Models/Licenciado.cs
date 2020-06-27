using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public  class Licenciado : Conexion, IMetodos
    {
        public Licenciado()
        {
            id = 0;
            nombre = "";
            apellido = "";
            descripcion = "";
            email = "";
            telefono = "";
            celular = "";
            docente = 0;
           
            id_institucion_representada = 0;
            id_carrera_licenciado = 0;

        }
        #region Atributos 
        private int id;
        private string nombre;
        private string apellido;
        private string descripcion;
        private string email;
        private string telefono;
        private string celular;
        private int docente;
        private int id_institucion_representada;
        private int id_carrera_licenciado;




        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Celular { get => celular; set => celular = value; }
        public int Docente { get => docente; set => docente = value; }
        public int Id_institucion_representada { get => id_institucion_representada; set => id_institucion_representada = value; }
        public int Id_carrera_licenciado { get => id_carrera_licenciado; set => id_carrera_licenciado = value; }


        #endregion
        #region Metodos 
        public void Insert()
        {

            string insertSQL = " INSERT INTO licenciado (nombre,apellido,descripcion,email,telefono,celular,docente ) VALUES ('" + Nombre + "', '" + Apellido + "','" + Descripcion + "','" + Email + "', '" + Telefono + "','" + Celular + "', " + Docente +", "+ Id_institucion_representada + "," + Id_carrera_licenciado + " ); ";
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
            string deleteSQL = " DELETE FROM licenciado WHERE id = " + id + " ; ";
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
            string updateSQL = " UPDATE licenciado " +
                         " SET nombre = '" + Nombre + "', apellido = '" + Apellido + "', descripcion = '" + Descripcion + "', email = '" + Email + "', telefono = '" + Telefono + "', celular = '" + Celular + "', docente = "+Docente+", id_institucion_representada = " + Id_institucion_representada + ", id_carrera_licenciado = " + Id_carrera_licenciado + "  " +
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
            string sql = "  select LI.id as id, (LI.nombre+' '+LI.apellido) as Licenciado,LI.telefono as Telefono ,I.nombre as Institucion, CL.nombre as Carrera from licenciado as LI inner join institucion as I on I.id = LI.id_institucion_representada inner join carrera_licenciado as CL on CL.id = LI.id_carrera_licenciado;   ";
            SQLiteConnection cnx = AbrirConexion();
            DataTable ds = new DataTable();
            if (cnx != null)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, cnx);
                
                da.Fill(ds);
                Cnx.Close();
                
            }
            return ds;
        }
       

        
        #endregion
    }
}
