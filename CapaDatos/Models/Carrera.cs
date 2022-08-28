using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    /// <summary>
    /// Clase Carrera
    /// </summary>
    public class Carrera : Conexion, IMetodos
    {
        public Carrera()
        {
            id = 0;
            nombre = "";
            id_facultad = 0;
        }

        #region Atributos

        /// <summary>
        /// Id Carrera
        /// </summary>
        private int id;

        /// <summary>
        /// Nombre de la Carrera
        /// </summary>
        private string nombre;

        /// <summary>
        /// Codigo de facultad a la que pertenece
        /// </summary>
        private int id_facultad;

        /// <summary>
        /// Nombre del esquema en la base de datos
        /// </summary>
        private static string table_name = "carrera";
        #endregion
        #region Propiedades

        /// <summary>
        /// </summary>
        /// <value>Propiedad <c>Id</c> representa el id de la carrera<</value>
        public int Id { get => id; set => id = value; }

        /// <summary>
        ///
        /// </summary>
        /// <value>Propiedad <c>Nombre</c> representa el nombre de la carrera</value>
        public string Nombre { get => nombre; set => nombre = value; }

        /// <summary>
        ///
        /// </summary>
        /// <value>Propiedad<c>Id_Facultad</c> representa el codigo de la facultad</value>
        public int Id_facultad { get => id_facultad; set => id_facultad = value; }
        #endregion
        #region Metodos

        /// <summary>
        /// Crea una nueva Carrera
        /// </summary>
        public void Insert()
        {
            string sql = $@" INSERT INTO {table_name} (nombre, id_facultad ) VALUES ('{Nombre}',{Id_facultad}); ";
            execQuery(sql);

        }

        /// <summary>
        /// Elimina una Carrera
        /// </summary>
        /// <param name="id">id o codigo de la carrera</param>
        public void Delete(int id)
        {
            string sql = $" DELETE FROM {table_name}  WHERE id = {id} ; ";
            execQuery(sql);

        }

        /// <summary>
        /// Actualiza una Carrera
        /// </summary>
        /// <param name="id">id o codigo de la carrera</param>
        public void Update(int id)
        {
            string sql = $@" UPDATE {table_name}
                            SET nombre = '{Nombre}' , id_facultad = {Id_facultad}
                            WHERE id = {id} ; ";
            execQuery(sql);
        }

        /// <summary>
        /// Obtiene los datos de las carreras con su respectiva facultad
        /// </summary>
        /// <returns>retorna los datos de la carrera en formato de tabla</returns>
        public DataTable Select()
        {
            string sql = $" SELECT C.id as id,C.nombre as nombre,C.id_facultad as id_facultad, F.nombre as facultad FROM  {table_name} as C INNER JOIN facultad as F on C.id_facultad = F.id; ";
            return SelectConexion(sql);
        }

        /// <summary>
        /// Busca una Carrera por su nombre
        /// </summary>
        /// <param name="criterio">parametro criterio de busqueda por nombre</param>
        /// <returns>retorna las carreras  que coincidan con el criterio de busqueda en formato de tabla</returns>
        public DataTable Select(string criterio)
        {
            string search = criterio.Trim();
            string sql = $" SELECT C.id as id,C.nombre as nombre,C.id_facultad as id_facultad, F.nombre as facultad FROM  {table_name} as C INNER JOIN facultad as F on C.id_facultad = F.id WHERE C.nombre LIKE '%{search}%' ; ";
            return SelectConexion(sql);
        }


        /// <summary>
        /// Obtiene todas las carreras
        /// </summary>
        /// <returns>retorna todas las carreras en formato tabla</returns>
        public DataTable loadFacultades()
        {
            string sql = $" SELECT * FROM facultad ; ";
            return SelectConexion(sql);
        }

        /// <summary>
        /// Obtiene el id o codigo de la ultima carrera
        /// </summary>
        /// <returns>retorna un entero que es el numero del id de la carrera</returns>
        public int LastId()
        {
            return LastIdConexion(table_name);
        }



        #endregion
    }
}
