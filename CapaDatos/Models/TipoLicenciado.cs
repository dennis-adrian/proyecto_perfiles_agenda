using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class TipoLicenciado: Conexion, IMetodos
    {
        public TipoLicenciado()
        {
            id = 0;
            tipo = "";
            funcion_licenciado = "";
            descripcion = "";

        }
        #region Atributos 
        private int id;
        private string tipo;
        private string funcion_licenciado;
        private string descripcion;



        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Funcion_licenciado { get => funcion_licenciado; set => funcion_licenciado = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }


        #endregion
        #region Metodos 
       
           private static string TableName = "tipo_licenciado";
        public void Insert()
        {
            string sql = "  INSERT INTO " + TableName + " (  tipo, funcion_licenciado,descripcion  ) VALUES ( @parametro0,@paramtros1,@parametros2); ";
            Object[] Parametros = new Object[] { Tipo,Funcion_licenciado,Descripcion };
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
            string sql = " UPDATE " + TableName + "  SET   tipo = @parametro0, funcion_licenciado=@parametro1,descripcion  = @parametro2  WHERE id = @parametro3 ; ";

            Object[] Parametros = new Object[] { Tipo, Funcion_licenciado, Descripcion, id };
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
