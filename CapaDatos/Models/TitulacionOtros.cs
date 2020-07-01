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

       
             private static string TableName = "titulacion_otros";
        public void Insert()
        {
            string sql = "  INSERT INTO " + TableName + " (  estado_defensa,calificacion,id_estudiante,id_tipo_titulacion  ) VALUES ( @parametro0); ";
            Object[] Parametros = new Object[] { Estado_defensa,Calificacion,Id_estudiante,id_tipo_titulacion };
            QueryBuilder(sql, Parametros);

        }
        public void Delete(int id)
        {
            string sql = " DELETE FROM " + TableName + " WHERE id = @parametro0 ; ";
            Object[] Parametros = new Object[] { id };
            QueryBuilder(sql, Parametros);

        }
        public void Update(int id)
        {
            string sql = " UPDATE " + TableName + "  SET estado_defensa = @parametro0 ,calificacion=@parametro1,id_estudiante=@parmetro2,id_tipo_titulacion=@parametro3  WHERE id = @parametro4 ; ";

            Object[] Parametros = new Object[] { Estado_defensa, Calificacion, Id_estudiante, id_tipo_titulacion, id };
            QueryBuilder(sql, Parametros);

        }

        public DataTable Select()
        {
            string sql = " SELECT * FROM " + TableName + " ; ";
            return SelectConexion(sql);
        }
        public int LastId()
        {

            return LastIdConexion(TableName);
        }


        #endregion
    }
}
