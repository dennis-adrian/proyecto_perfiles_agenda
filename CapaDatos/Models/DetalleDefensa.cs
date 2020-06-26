using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class DetalleDefensa : Conexion, IMetodos
    {
        public DetalleDefensa()
        {
            id = 0;
            id_defensa_externa = 0;
            id_licenciado = 0;
            id_tipo_licenciado = 0;


        }
        #region Atributos 
        private int id;
        private int id_defensa_externa;
        private int id_licenciado;
        private int id_tipo_licenciado;

        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public int Id_defensa_externa { get => id_defensa_externa; set => id_defensa_externa = value; }
        public int Id_licenciado { get => id_licenciado; set => id_licenciado = value; }
        public int Id_tipo_licenciado { get => id_tipo_licenciado; set => id_tipo_licenciado = value; }

        #endregion
        #region Metodos 

        public void Insert()
        {
            string insertSQL = " INSERT INTO detalle_defensa ( id_defensa_externa, id_licenciado,id_tipo_licenciado ) VALUES (" + Id_defensa_externa + ", " + Id_licenciado + ","+ id_tipo_licenciado + " ); ";
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
            string deleteSQL = " DELETE FROM detalle_defensa WHERE id = " + id + " ; ";
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
            string updateSQL = " UPDATE detalle_defensa " +
                         " SET id_defensa_externa = '" + Id_defensa_externa + "', id_licenciado = " + Id_licenciado + ", id_tipo_licenciado = "+Id_tipo_licenciado+" " +
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
