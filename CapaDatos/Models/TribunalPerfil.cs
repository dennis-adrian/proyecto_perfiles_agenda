using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class TribunalPerfil:Conexion, IMetodos
    {
        #region Constructor
        public TribunalPerfil()
        {
            this.id_perfil = 0;
            this.id_licenciado = 0;
            this.nro_tribunal = 0;

        }
        #endregion

        #region Atributos
        private int id_perfil;

        private int id_licenciado;

        private int nro_tribunal;

        private string table_name = "tribunal_perfil";


        #endregion

        #region Propiedades
        public int Id_perfil { get => id_perfil; set => id_perfil = value; }
        public int Id_licenciado { get => id_licenciado; set => id_licenciado = value; }
        public int Nro_tribunal { get => nro_tribunal; set => nro_tribunal = value; }



        #endregion


        #region Metodos



        #endregion

        #region Destructor
        ~TribunalPerfil()
        {

        }

        public void Insert()
        {
            string sql = $" INSERT INTO {table_name} (id_perfil, id_licenciado, nro_tribunal ) VALUES(@parametro0,@parametro1,@parametro2); ";
            Object[] Parametros = new Object[] { Id_perfil, Id_licenciado,Nro_tribunal};
            QueryBuilder(sql, Parametros);
        }

        public void Delete(int id)
        {
            //string sql = $" DELETE FROM {table_name}  WHERE id = @parametro0 ; ";
            //Object[] Parametros = new Object[] { id };
            //QueryBuilder(sql, Parametros);

        }
        public void Update(int id)
        {
            //string sql = $" UPDATE {table_name}  SET id_perfil = @parametro0 , id_licenciado = @parametro1 WHERE id = @parametro2 ; ";
            //Object[] Parametros = new Object[] { Nombre, Id_facultad, id };
            //QueryBuilder(sql, Parametros);

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
       
        public int LastId()
        {
            return LastIdConexion(table_name);
        }



        #endregion
    }
}
