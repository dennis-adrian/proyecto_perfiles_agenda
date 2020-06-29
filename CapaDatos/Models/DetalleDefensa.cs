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

       
       
       
        /////
        private static string  TableName = "detalle_defensa";
        public void Insert()
        {
            string sql = "  INSERT INTO " + TableName + " (  id_defensa_externa, id_licenciado,id_tipo_licenciado  ) VALUES ( @parametro0,@parametro1,@parametro2); ";
            Object[] Parametros = new Object[] { Id_defensa_externa, Id_licenciado, Id_tipo_licenciado };
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
            string sql = " UPDATE " + TableName + "  SET  id_defensa_externa = @parametro0, id_licenciado = @parametro1 ,id_tipo_licenciado = @parametro2  WHERE id = @parametro3 ; ";

            Object[] Parametros = new Object[] { Id_defensa_externa, Id_licenciado, Id_tipo_licenciado, id };
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
