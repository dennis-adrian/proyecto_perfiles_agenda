using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class TribunalPerfil : Conexion, IMetodos
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

        public void Insert()
        {
            string sql = $@" INSERT INTO {table_name} (id_perfil, id_licenciado, nro_tribunal ) 
                            VALUES( {Id_perfil}, {Id_licenciado}, {Nro_tribunal}); ";
            execQuery(sql);
        }

        public void Delete(int id)
        {
        }
        public void Update(int id)
        {
            string sql = $@" UPDATE {table_name}  
                            SET  id_licenciado = {Id_licenciado} 
                            WHERE id_perfil = {id} AND nro_tribunal = {Nro_tribunal} ; ";
            execQuery(sql);

        }

        public DataTable Select(int idperfil)
        {
            string sql = $@" SELECT 
                            TP.id_perfil as Id_perfil,
                            TP.id_licenciado as Id_licenciado,
                            TP.nro_tribunal as Nro_tribunal,
                            L.nombre||' '||L.apellido as  Licenciado 
                        FROM tribunal_perfil as TP 
                        INNER JOIN licenciado as L 
                        ON TP.id_licenciado = L.id 
                        HWERE id_perfil= {idperfil} ; ";
            return SelectConexion(sql);
        }

        public int LastId()
        {
            return LastIdConexion(table_name);
        }


        #endregion

        #region Destructor
        ~TribunalPerfil()
        {

        }




        #endregion
    }
}
