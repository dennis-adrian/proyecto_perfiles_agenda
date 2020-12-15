using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class Carrera : Conexion, IMetodos
    {
        public Carrera()
        {
            id = 0;
            nombre = "";
            id_facultad = 0;
        }

        #region Atributos
        private int id;
        private string nombre;
        private int id_facultad;
        private static string table_name = "carrera";
        #endregion
        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_facultad { get => id_facultad; set => id_facultad = value; }
        #endregion
        #region Metodos
        public void Insert()
        {
            string sql = $" INSERT INTO {table_name} (nombre, id_facultad ) VALUES(@parametro0,@parametro1); ";
            Object[] Parametros = new Object[] { Nombre, Id_facultad };
            QueryBuilder(sql, Parametros);

        }
        public void Delete(int id)
        {
            string sql = $" DELETE FROM {table_name}  WHERE id = @parametro0 ; ";
            Object[] Parametros = new Object[] { id };
            QueryBuilder(sql, Parametros);

        }
        public void Update(int id)
        {
            string sql = $" UPDATE {table_name}  SET nombre = @parametro0 , id_facultad = @parametro1 WHERE id = @parametro2 ; ";
            Object[] Parametros = new Object[] {Nombre,Id_facultad, id };
            QueryBuilder(sql, Parametros);

        }
        public DataTable Select()
        {
            string sql = $" SELECT C.id as id,C.nombre as nombre,C.id_facultad as id_facultad, F.nombre as facultad FROM  {table_name} as C INNER JOIN facultad as F on C.id_facultad = F.id; ";
            return SelectConexion(sql);
        }
        public DataTable Select(string criterio)
        {
            string search = criterio.Trim();
            string sql = $" SELECT C.id as id,C.nombre as nombre,C.id_facultad as id_facultad, F.nombre as facultad FROM  {table_name} as C INNER JOIN facultad as F on C.id_facultad = F.id WHERE C.nombre LIKE '%{search}%' ; ";
            return SelectConexion(sql);
        }
        public DataTable loadFacultades()
        {
            string sql = $" SELECT * FROM facultad ; ";
            return SelectConexion(sql);
        }
        public int LastId()
        {
            return LastIdConexion(table_name);
        }



        #endregion
    }
}
