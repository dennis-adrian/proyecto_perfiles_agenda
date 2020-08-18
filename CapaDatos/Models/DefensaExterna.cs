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
            if(Id_tesis == 0)
            {
                string sql = "  INSERT INTO " + TableName + " ( fecha_presentacion, hora,aula, id_titulacion_otro ) VALUES ( @parametro0, @parametro1, @parametro2, @parametro3 ); ";
                Object[] Parametros = new Object[] { Fecha_presentacion, Hora, Aula, Id_titulacion_otro };
                QueryBuilder(sql, Parametros);
            }
            else if (Id_titulacion_otro == 0)
            {
                 string sql = "  INSERT INTO " + TableName + " ( fecha_presentacion, hora,aula,id_tesis ) VALUES ( @parametro0, @parametro1, @parametro2, @parametro3 ); ";
                Object[] Parametros = new Object[] { Fecha_presentacion, Hora, Aula, Id_tesis };
                QueryBuilder(sql, Parametros);
            }
            else
            {

            }


        }
        public void Delete(int id)
        {
            string sql = " DELETE FROM " + TableName + " WHERE id = @parametro0 ; ";
            Object[] Parametros = new Object[] { id };
            QueryBuilder(sql, Parametros);

        }
        public void Update(int id)
        {
            if (Id_tesis == 0)
            {
                string sql = " UPDATE " + TableName + "  SET fecha_presentacion= @parametro0, hora = @parametro1, aula = @parametro2,  id_titulacion_otro= @parametro3 WHERE id = @parametro4 ; ";

                Object[] Parametros = new Object[] { Fecha_presentacion, Hora, Aula, Id_titulacion_otro, id };
                QueryBuilder(sql, Parametros);

            }
            else if (Id_titulacion_otro == 0)
            {
                string sql = " UPDATE " + TableName + " SET fecha_presentacion= @parametro0, hora = @parametro1, aula = @parametro2, id_tesis = @parametro3 WHERE id = @parametro4 ; ";

                Object[] Parametros = new Object[] { Fecha_presentacion, Hora, Aula, Id_tesis, id };
                QueryBuilder(sql, Parametros);
            }
           
          

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

        public DataTable InfoDefensaOtros(int iddefensa)
        {
            string sql = " select DE.id as Id, DE.fecha_presentacion as Fecha_presentacion, DE.hora as Hora, DE.aula as Aula,  DE.id_titulacion_otro as Id_titulacion_otro, TOS.estado_defensa as Estado_defensa, TOS.tema as Tema, TOS.calificacion as Calificacion, TOS.id_tipo_titulacion as Id_tipo_titulacion, TOS.id_estudiante as Id_estudiante, ES.registro as Registro, ES.nombre as Nombre , ES.apellido as Apellido, ES.email as Email, ES.telefono as Telefono, ES.celular as Celular, ES.id_carrera as Id_carrera, CA.nombre as Carrera from defensa_externa as DE inner join titulacion_otros AS TOS on  TOS.id = DE.id_titulacion_otro inner join estudiante as ES on ES.id = TOS.id_estudiante inner join carrera as CA on ES.id_carrera = CA.id where DE.id = "+ iddefensa + " ;";

            return SelectConexion(sql);

        }
        public DataTable InfoDetalleDenfensa()
        {
            string sql = "";

            return SelectConexion(sql);

        }

        #endregion
    }
}
