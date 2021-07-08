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
        private static string table_name = "carrera_licenciado";

        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }


        #endregion

        #region Metodos
        public void Insert()
        {
            string sql = $"  INSERT INTO {table_name} ( nombre) VALUES ('{Nombre}'); ";
            execQuery(sql);

        }
        public void Delete(int id)
        {
            string sql = $" DELETE FROM {table_name}  WHERE id = {id} ; ";
            execQuery(sql);

        }
        public void Update(int id)
        {
            string sql = $" UPDATE {table_name}  SET nombre = '{Nombre}'  WHERE id = {id} ; ";
            execQuery(sql);

        }

        public DataTable Select()
        {
            string sql = $" SELECT * FROM {table_name} ; ";
            return SelectConexion(sql);
        }
        public DataTable Select(string criterio)
        {
            string search = criterio.Trim();
            string sql = $" SELECT * FROM {table_name} WHERE nombre LIKE '%{search}%' ; ";
            return SelectConexion(sql);
        }
        public int LastId()
        {
            return LastIdConexion(table_name);
        }


        #endregion

    }
}
