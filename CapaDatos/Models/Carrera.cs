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
            string sql = $@" INSERT INTO {table_name} (nombre, id_facultad ) VALUES ('{Nombre}',{Id_facultad}); ";
            execQuery(sql);

        }
        public void Delete(int id)
        {
            string sql = $" DELETE FROM {table_name}  WHERE id = {id} ; ";
            execQuery(sql);

        }
        public void Update(int id)
        {
            string sql = $@" UPDATE {table_name}  
                            SET nombre = '{Nombre}' , id_facultad = {Id_facultad} 
                            WHERE id = {id} ; ";
            execQuery(sql);
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
