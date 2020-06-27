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

            string sql = " select * from ViewDefensas where Carrera Like '%"+carrera+"%'; ";
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
            
            string sql = "  SELECT * FROM ViewPerfiles ; ";
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
           string sql = "  SELECT * FROM ViewPerfiles  where Carrera Like '%" + carrera + "%'; ; ";
            DataTable dt = new DataTable();

            if (AbrirConexion() != null)
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, AbrirConexion());
                da.Fill(dt);
                cerrarConexion();
            }
            return dt;

        }
        public DataTable ViewPerfilEstudiante(string estudiante)
        {
            string sql = "  SELECT * FROM ViewPerfiles  where Estudiante Like '%" + estudiante + "%'; ; ";
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
