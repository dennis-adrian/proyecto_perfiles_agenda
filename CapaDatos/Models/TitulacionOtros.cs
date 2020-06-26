using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class TitulacionOtros : Conexion, IMetodos
    {
        public TitulacionOtros()
        {
            id = 0;
            estado_defensa = "";
            calificacion = 0;
            id_estudiante = 0;
            id_tipo_titulacion = 0;
        }
        #region Atributos 
        private int id;
        private string estado_defensa;
        private double calificacion;
        private int id_estudiante;
        private int id_tipo_titulacion;


        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public string Estado_defensa { get => estado_defensa; set => estado_defensa = value; }
        public double Calificacion { get => calificacion; set => calificacion = value; }
        public int Id_estudiante { get => id_estudiante; set => id_estudiante = value; }
        public int Id_tipo_titulacion { get => id_tipo_titulacion; set => id_tipo_titulacion = value; }

        #endregion
        #region Metodos 

        public void Insert()
        {
            string insertSQL = " INSERT INTO titulacion_otros ( estado_defensa,calificacion,id_estudiante,id_tipo_titulacion  ) VALUES ('" + Estado_defensa + "', " + Calificacion + ", "+Id_estudiante+","+Id_tipo_titulacion+" ); ";
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
            string deleteSQL = " DELETE FROM titulacion_otros WHERE id = " + id + " ; ";
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
            string updateSQL = " UPDATE titulacion_otros " +
                         " SET estado_defensa='"+Estado_defensa+"', calificacion = "+Calificacion+",id_estudiante = "+Id_estudiante+",id_tipo_titulacion="+Id_tipo_titulacion+" " +
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
