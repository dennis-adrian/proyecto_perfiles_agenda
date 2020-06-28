using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class TipoTitulacionOtros: Conexion, IMetodos
    {
        public TipoTitulacionOtros()
        {
            id = 0;
            tipo = "";
            descripcion = "";
        }
        #region Atributos 
        private int id;
        private string tipo;
        private string descripcion;

        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        #endregion
        #region Metodos 
        
             private static string TableName = "tipo_licenciado";
        public void Insert()
        {
            string sql = "  INSERT INTO " + TableName + " (  tipo,descripcion  ) VALUES ( @parametro0,@parametro1); ";
            Object[] Parametros = new Object[] {Tipo,Descripcion };
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
            string sql = " UPDATE " + TableName + "  SET  tipo = @parametro0,descripcion=@parametro1   WHERE id = @parametro1 ; ";

            Object[] Parametros = new Object[] { Tipo, Descripcion, id };
            QueryBuilder(sql, Parametros);

        }

        public DataTable Select()
        {
            return SelectConexion(TableName);
        }
        public int LastId()
        {

            return LastIdConexion(TableName);
        }

        #endregion
    }
}
