using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class DetalleRevision : Conexion
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

        private static string table_name = "detalle_revision";
        public void Insert()
        {
            string sql = "  INSERT INTO " + table_name + " (  id_revision, id_licenciado,id_funcion_licenciado  ) VALUES ( @parametro0,@parametro1,@parametro2); ";
            Object[] Parametros = new Object[] { Id_revision, Id_licenciado, Id_funcion_licenciado };
            QueryBuilder(sql, Parametros);

        }
        public void Delete(int id)
        {
            string sql = " DELETE FROM " + table_name + " WHERE id = @parametro0 ; ";
            Object[] Parametros = new Object[] { id };
            QueryBuilder(sql, Parametros);

        }
        public void Update(int id)
        {
            string sql = " UPDATE " + table_name + "  SET  id_revision = @parametro0, id_licenciado = @parametro1 ,id_funcion_licenciado  = @parametro2  WHERE id = @parametro3 ; ";

            Object[] Parametros = new Object[] { Id_revision, Id_licenciado, Id_funcion_licenciado, id };
            QueryBuilder(sql, Parametros);

        }
        
        public List<int> RevisionesPerfilTribunal(int idtesis, int nrotribunal)
        {
            try
            {
                List<int> list = new List<int>();
                string sql = $" select * from revision where id_tesis = {idtesis} and nro_tribunal = {nrotribunal} ";
                var cursor = SelectConexion(sql);
                for (int i = 0; i < cursor.Rows.Count; i++)
                {
                    list.Add(Convert.ToInt32(cursor.Rows[i]["id"].ToString()));
                }
                return list;
            }
            catch(Exception ex)
            {
                throw new ArgumentException(ex+"");
            }
        }
        public void updateTribunales(int idtesis,int nrotribunal,int idlicenciado)
        {
            try
            {
                var list = RevisionesPerfilTribunal(idtesis, nrotribunal);
                foreach (var idrevision in list)
                {
                    string sql = $" UPDATE {table_name} SET id_licenciado = {idlicenciado} WHERE id_revision = {idrevision} ; ";
                    execQuery(sql);

                }

            }
            catch(Exception ex)
            {
                throw new ArgumentException(ex + "");
            }

        }

        public DataTable Select()
        {
            string sql = " SELECT * FROM " + table_name + " ; ";
            return SelectConexion(sql);
        }
        public int LastId()
        {

            return LastIdConexion(table_name);
        }
        #endregion
    }
}
