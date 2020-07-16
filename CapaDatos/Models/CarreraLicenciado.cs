using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class CarreraLicenciado : Conexion, IMetodos
    {
        public CarreraLicenciado()
        {
            id = 0;
            nombre = "";
        }
        #region Atributos 
        private int id;
        private string nombre;
        private static string TableName = "carrera_licenciado";

        #endregion
        #region Propiedades 
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }


        #endregion


        #region Metodos 
        public void Insert()
        {
            string sql = "  INSERT INTO "+TableName+" ( nombre) VALUES (@parametro0); ";
            Object[] Parametros = new Object[] { Nombre };
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
            string sql = " UPDATE " + TableName + "  SET nombre = @parametro0  WHERE id = @parametro1 ; ";

            Object[] Parametros = new Object[] { Nombre,  id };
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
