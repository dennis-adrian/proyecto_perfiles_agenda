using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class DefensaExterna : Conexion, IMetodos
    {
        public DefensaExterna()
        {
            id = 0;
            fecha_presentacion = "";
            hora = "";
            aula = "";
            id_tesis = 0;
            id_titulacion_otro = 0;
        }
        #region Atributos 
        private int id;
        private string fecha_presentacion;
        private string hora;
        private string aula;
        private int id_tesis;
        private int id_titulacion_otro;

        private static string TableName = "defensa_externa";

        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public string Fecha_presentacion { get => fecha_presentacion; set => fecha_presentacion = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Aula { get => aula; set => aula = value; }
        public int Id_tesis { get => id_tesis; set => id_tesis = value; }
        public int Id_titulacion_otro { get => id_titulacion_otro; set => id_titulacion_otro = value; }

        #endregion
        #region Metodos 



        public void Insert()
        {
            string sql = "  INSERT INTO " + TableName + " ( fecha_presentacion, hora,aula,id_tesis,id_titulacion_otro ) VALUES ( @parametro0, @parametro1, @parametro2, @parametro3, @parametro4); ";
            Object[] Parametros = new Object[] { Fecha_presentacion,Hora,Aula,Id_tesis,Id_titulacion_otro };
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
            string sql = " UPDATE " + TableName + "  SET fecha_presentacion=@parametro0, hora=@parametro1, aula=@parametro2, id_tesis=@parametro3,  id_titulacion_otro=@parametro4 WHERE id = @parametro5 ; ";

            Object[] Parametros = new Object[] { Fecha_presentacion, Hora, Aula, Id_tesis, Id_titulacion_otro, id };
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
