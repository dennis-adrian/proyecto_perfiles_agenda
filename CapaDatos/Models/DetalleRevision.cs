using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class DetalleRevision : Conexion, IMetodos
    {
        public DetalleRevision()
        {
            id = 0;
            id_revision = 0;
            id_licenciado = 0;
            id_funcion_licenciado = 0;

        }

        #region Atributos 

        private int id;
        private int id_revision;
        private int id_licenciado;
        private int id_funcion_licenciado;




        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public int Id_revision { get => id_revision; set => id_revision = value; }
        public int Id_licenciado { get => id_licenciado; set => id_licenciado = value; }
        public int Id_funcion_licenciado { get => id_funcion_licenciado; set => id_funcion_licenciado = value; }


        #endregion
        #region Metodos 
         
        private static string TableName = "detalle_revision";
        public void Insert()
        {
            string sql = "  INSERT INTO " + TableName + " (  id_revision, id_licenciado,id_funcion_licenciado  ) VALUES ( @parametro0,@parametro1,@parametro2); ";
            Object[] Parametros = new Object[] { Id_revision, Id_licenciado, Id_funcion_licenciado };
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
            string sql = " UPDATE " + TableName + "  SET  id_revision = @parametro0, id_licenciado = @parametro1 ,id_funcion_licenciado  = @parametro2  WHERE id = @parametro3 ; ";

            Object[] Parametros = new Object[] { Id_revision, Id_licenciado, Id_funcion_licenciado, id };
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
