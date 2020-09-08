using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class FuncionLicenciado: Conexion, IMetodos
    {
        public FuncionLicenciado()
        {
            id = 0;
            funcion = "";
            descripcion = "";
        }
        #region Atributos
        private int id;
        private string funcion;
        private string descripcion;
        private static string table_name = "funcion_licenciado";
        #endregion
        #region Propiedades
        public int Id { get => id; set => id = value; }

        public string Funcion { get => funcion; set => funcion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }


        #endregion
        #region Metodos
        public void Insert()
        {
            string sql = $"  INSERT INTO {table_name} (   funcion,descripcion  ) VALUES ( @parametro0,@paramtro1); ";
            Object[] Parametros = new Object[] { Funcion,Descripcion };
            QueryBuilder(sql, Parametros);

        }
        public void Delete(int id)
        {
            string sql = $" DELETE FROM  {table_name} WHERE id = @parametro0 ; ";
            Object[] Parametros = new Object[] { id };
            QueryBuilder(sql, Parametros);

        }
        public void Update(int id)
        {
            string sql = $" UPDATE   {table_name}  SET    funcion=@parametro0,descripcion  = @parametro1  WHERE id = @parametro2 ; ";
            Object[] Parametros = new Object[] {  Funcion, Descripcion, id };
            QueryBuilder(sql, Parametros);

        }

        public DataTable Select()
        {
            string sql = $" SELECT * FROM {table_name} ; ";
            return SelectConexion(sql);
        }
        public int FindIdBySearch(string criterio)
        {
            string sql = $" SELECT id FROM {table_name}  WHERE funcion  LIKE '%"+criterio+"%'   ; ";
            return FindIdBySearchConexion(sql);
        }
        public int LastId()
        {

            return LastIdConexion(table_name);
        }

        #endregion
    }
}
