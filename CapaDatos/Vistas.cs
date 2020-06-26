using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Vistas : Conexion
    {

        public Vistas()
        {

        }

        public DataTable ViewDefensas()
        {
            /* string sql = " select * from ( "+
             " select DE.id as Id,DE.fecha_presentacion as Fecha_Defensa ,DE.hora as Hora,DE.aula as Aula,\"Tesis\" as Tipo, PF.tema as Tema, ES.registro as Registro ,ES.nombre as Nombre,ES.apellido as Apellido,CA.nombre as Carrera,FA.nombre as Facultad  from defensa_externa as DE inner join perfil_tesis as PF on DE.id_tesis = PF.id  inner join estudiante as ES on PF.id_estudiante = ES.id inner join carrera as CA on ES.id_carrera = CA.id inner join facultad as FA on CA.id_facultad = FA.id  where DE.id_tesis > 0 and DE.id_tesis != null " +
             " UNION " + 
 " select DE.id as Id,DE.fecha_presentacion as Fecha_Defensa ,DE.hora as Hora,DE.aula as Aula,TTO.tipo as Tipo, \"descripcion de tema\" as Tema, ES.registro as Registro ,ES.nombre as Nombre,ES.apellido as Apellido, CA.nombre as Carrera, FA.nombre as Facultad  from defensa_externa as DE inner join titulacion_otros as TOS on DE.id_titulacion_otro = TOS.id  inner join tipo_titulacion_otros as TTO on TOS.id_tipo_titulacion = TTO.id    inner join estudiante as ES on TOS.id_estudiante = ES.id inner join carrera as CA on ES.id_carrera = CA.id inner join facultad as FA on CA.id_facultad = FA.id  where DE.id_titulacion_otro > 0 and DE.id_titulacion_otro != null  ); ";*/

            string sql = "  SELECT * FROM ViewDefensas ; ";



        
            DataTable dt = new DataTable();

            if (AbrirConexion() != null)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, AbrirConexion());
                da.Fill(dt);
                cerrarConexion();
            }
            return dt;

        }
        public DataTable ViewDefensasCarrera(string carrera)
        {
            /*string sql = " select AG.id as idagenda, AG.fecha_presentacion as fecha ,AG.hora as Hora,AG.aula as Aula,PF.tema as Tema, EG.fecha_aprobacion as Fechaaprobacion, ES.registro as Registro, ES.nombre as Nombres, ES.apellido as Apellidos, CA.nombre as Carreras,FA.nombre as Facultad " +
                           " from agenda AG inner join perfil_tesis PF on AG.id_tesis = PF.id inner join examen_grado as EG on AG.id_examen_grado = EG.id inner join estudiante as ES on EG.id_estudiante = ES.id inner join carrera as CA on ES.id_carrera = CA.id inner join facultad as FA on CA.id_facultad = FA.id ";*/

            string sql = "  SELECT * FROM defensa_externa ; ";
            DataTable dt = new DataTable();

            if (AbrirConexion() != null)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, AbrirConexion());
                da.Fill(dt);
                cerrarConexion();
            }
            return dt;

        }
        public DataTable ViewPerfiles()
        {
            /*string sql = " select AG.id as idagenda, AG.fecha_presentacion as fecha ,AG.hora as Hora,AG.aula as Aula,PF.tema as Tema, EG.fecha_aprobacion as Fechaaprobacion, ES.registro as Registro, ES.nombre as Nombres, ES.apellido as Apellidos, CA.nombre as Carreras,FA.nombre as Facultad " +
                           " from agenda AG inner join perfil_tesis PF on AG.id_tesis = PF.id inner join examen_grado as EG on AG.id_examen_grado = EG.id inner join estudiante as ES on EG.id_estudiante = ES.id inner join carrera as CA on ES.id_carrera = CA.id inner join facultad as FA on CA.id_facultad = FA.id ";*/

            string sql = "  SELECT * FROM defensa_externa ; ";
            DataTable dt = new DataTable();

            if (AbrirConexion() != null)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, AbrirConexion());
                da.Fill(dt);
                cerrarConexion();
            }
            return dt;

        }
        public DataTable ViewPerfilesCarrera(string carrera)
        {
            /*string sql = " select AG.id as idagenda, AG.fecha_presentacion as fecha ,AG.hora as Hora,AG.aula as Aula,PF.tema as Tema, EG.fecha_aprobacion as Fechaaprobacion, ES.registro as Registro, ES.nombre as Nombres, ES.apellido as Apellidos, CA.nombre as Carreras,FA.nombre as Facultad " +
                           " from agenda AG inner join perfil_tesis PF on AG.id_tesis = PF.id inner join examen_grado as EG on AG.id_examen_grado = EG.id inner join estudiante as ES on EG.id_estudiante = ES.id inner join carrera as CA on ES.id_carrera = CA.id inner join facultad as FA on CA.id_facultad = FA.id ";*/

            string sql = "  SELECT * FROM defensa_externa ; ";
            DataTable dt = new DataTable();

            if (AbrirConexion() != null)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, AbrirConexion());
                da.Fill(dt);
                cerrarConexion();
            }
            return dt;

        }
    }
}
