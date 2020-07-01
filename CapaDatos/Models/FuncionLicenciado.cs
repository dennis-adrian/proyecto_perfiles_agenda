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
            
            funcion_licenciado = "";
            descripcion = "";

        }
        #region Atributos 
        private int id;
        private string funcion_licenciado;
        private string descripcion;



        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        
        public string Funcion_licenciado { get => funcion_licenciado; set => funcion_licenciado = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }


        #endregion
        #region Metodos 
       
           private static string TableName = "funcion_licenciado";
        public void Insert()
        {
            string sql = "  INSERT INTO " + TableName + " (   funcion_licenciado,descripcion  ) VALUES ( @parametro0,@paramtros1); ";
            Object[] Parametros = new Object[] { Funcion_licenciado,Descripcion };
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
            string sql = " UPDATE " + TableName + "  SET    funcion_licenciado=@parametro0,descripcion  = @parametro1  WHERE id = @parametro2 ; ";

            Object[] Parametros = new Object[] {  Funcion_licenciado, Descripcion, id };
            QueryBuilder(sql, Parametros);

        }

        public DataTable Select()
        {
            string sql = " SELECT * FROM " + TableName + " ; ";
            return SelectConexion(sql);
        }
        public int FindIdBySearch(string criterio)
        {
            string sql = " SELECT id FROM " + TableName + "  WHERE funcion_licenciado  like '%@parametro0%'  limit 1 ; ";
            return FindIdBySearchConexion(sql, criterio);
        }
        public int LastId()
        {

            return LastIdConexion(TableName);
        }

        #endregion
    }
}
