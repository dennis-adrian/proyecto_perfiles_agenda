using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class PerfilTesis : Conexion, IMetodos
    {
        public PerfilTesis()
        {
            id = 0;
            tema = "";
            estado = "Aprobado";
            fecha_aprobacion_jefe_carrera = "";
            fecha_recepcion_titulacion = "";
            estado_defensa = "";
            calificacion = 0;
            id_estudiante = 0;
            id_licenciado = 0;
            id_tipo_licenciado = 0;
        }
        #region Atributos 
        private int id;
        private string tema;
        private string estado;
        private string fecha_aprobacion_jefe_carrera;
        private string fecha_recepcion_titulacion;
        private string estado_defensa;
        private double calificacion;
        private int id_estudiante;
        private int id_licenciado;
        private int id_tipo_licenciado;


        #endregion
        #region Propiedades 

        public int Id { get => id; set => id = value; }
        public string Tema { get => tema; set => tema = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Fecha_aprobacion_jefe_carrera { get => fecha_aprobacion_jefe_carrera; set => fecha_aprobacion_jefe_carrera = value; }
        public string Fecha_recepcion_titulacion { get => fecha_recepcion_titulacion; set => fecha_recepcion_titulacion = value; }
        public string Estado_defensa { get => estado_defensa; set => estado_defensa = value; }
        public double Calificacion { get => calificacion; set => calificacion = value; }
        public int Id_licenciado { get => id_licenciado; set => id_licenciado = value; }
        public int Id_tipo_licenciado { get => id_tipo_licenciado; set => id_tipo_licenciado = value; }
        public int Id_estudiante { get => id_estudiante; set => id_estudiante = value; }

        #endregion
        #region Metodos 
        public void Insert()
        {
            string insertSQL = " INSERT INTO perfil_tesis (tema,estado,fecha_aprobacion_jefe_carrera,fecha_recepcion_titulacion,estado_defensa,calificacion,id_estudiante,id_licenciado,id_tipo_licenciado) VALUES ('" + Tema + "', '" + Estado + "', '" + Fecha_aprobacion_jefe_carrera + "','" + Fecha_recepcion_titulacion + "','"+Estado_defensa+"',"+Calificacion+","+Id_estudiante+",  " + Id_licenciado + ", "+Id_tipo_licenciado+" ); ";
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
            string deleteSQL = " DELETE FROM perfil_tesis WHERE id = " + id + " ; ";
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
            string updateSQL = " UPDATE perfil_tesis " +
                         " SET  tema = '"+Tema+"',estado,fecha_aprobacion_jefe_carrera ='"+Fecha_aprobacion_jefe_carrera+"',fecha_recepcion_titulacion = '"+Fecha_recepcion_titulacion+"',estado_defensa = '"+Estado_defensa+"',calificacion="+Calificacion+",id_estudiante="+Id_estudiante+",id_licenciado="+Id_licenciado+",id_tipo_licenciado = "+Id_tipo_licenciado+" " +
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
