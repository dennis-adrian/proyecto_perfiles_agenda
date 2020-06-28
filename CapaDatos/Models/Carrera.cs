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

        private static string TableName = "carrera";


        #endregion
        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_facultad { get => id_facultad; set => id_facultad = value; }

        #endregion
        #region Metodos 
        public void Insert()
        {
            string sql = " INSERT INTO "+TableName+" (nombre, id_facultad ) VALUES(@parametro0,@parametro1); ";
            Object[] Parametros = new Object[] { Nombre, Id_facultad };
            QueryBuilder(sql, Parametros);
                                          
        }
        public void Delete(int id)
        {
            string sql = " DELETE FROM " + TableName + "  WHERE id = @parametro0 ; ";
            Object[] Parametros = new Object[] { id };
            QueryBuilder(sql, Parametros);

        }
        public void Update(int id)
        {
            string sql = " UPDATE " + TableName + "  SET nombre = @parametro0 , id_facultad = @parametro1 WHERE id = @parametro2 ; ";
            Object[] Parametros = new Object[] {Nombre,Id_facultad, id };
            QueryBuilder(sql, Parametros);

        }
        public DataTable Select()
        {
            return SelectConexion(TableName);
        }
        public int LastId()
        {

            string tabla = "carrera";
            return LastIdConexion(TableName);
        }



        #endregion
    }
}
