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
            tema = "";
            calificacion = 0;
            id_estudiante = 0;
            id_tipo_titulacion = 0;
        }
        #region Atributos
        private int id;
        private string estado_defensa;
        private string tema;
        private double calificacion;
        private int id_estudiante;
        private int id_tipo_titulacion;
        private static string table_name = "titulacion_otros";
        #endregion
        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Estado_defensa { get => estado_defensa; set => estado_defensa = value; }
        public double Calificacion { get => calificacion; set => calificacion = value; }
        public int Id_estudiante { get => id_estudiante; set => id_estudiante = value; }
        public int Id_tipo_titulacion { get => id_tipo_titulacion; set => id_tipo_titulacion = value; }
        public string Tema { get => tema; set => tema = value; }

        #endregion
        #region Metodos
        public void Insert()
        {
            string sql = $"  INSERT INTO {table_name} (  estado_defensa,tema,calificacion,id_estudiante,id_tipo_titulacion  ) VALUES ( @parametro0,@parametro1,@parametro2,@parametro3,@parametro4); ";
            Object[] Parametros = new Object[] { Estado_defensa,Tema,Calificacion,Id_estudiante,id_tipo_titulacion };
            QueryBuilder(sql, Parametros);

        }
        public void Delete(int id)
        {
            string sql = $" DELETE FROM {table_name} WHERE id = @parametro0 ; ";
            Object[] Parametros = new Object[] { id };
            QueryBuilder(sql, Parametros);

        }
        public void Update(int id)
        {
            string sql = $" UPDATE  {table_name}  SET estado_defensa = @parametro0 , tema = @parametro1 ,calificacion= @parametro2 ,id_estudiante=@parametro3,id_tipo_titulacion=@parametro4  WHERE id = @parametro5 ; ";
            Object[] Parametros = new Object[] { Estado_defensa,Tema, Calificacion, Id_estudiante, id_tipo_titulacion, id };
            QueryBuilder(sql, Parametros);

        }

        public DataTable Select()
        {
            string sql = $" SELECT * FROM " + table_name + " ; ";
            return SelectConexion(sql);
        }
        public int LastId()
        {
            return LastIdConexion(table_name);
        }
        public DataTable FindById(int Id)
        {
            string sql = $" SELECT * FROM {table_name} WHERE id = {Id}  ;";
            return SelectConexion(sql);

        }



        #endregion
    }
}
