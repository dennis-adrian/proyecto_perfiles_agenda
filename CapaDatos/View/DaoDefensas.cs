using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.View
{
    public class DaoDefensas
    {
        public DaoDefensas()
        {

        }

        Conexion obj = new Conexion();
        
        public DataTable getDenfensasCarrera(string carrera)
        {
            string sql = $" SELECT * FROM ViewDefensas WHERE Carrera LIKE '%{carrera}%'  ; ";        
            return obj.SelectConexion(sql);
        }
        public DataTable getDenfensasCarreraTipo(string carrera, string tipo)
        {
            string sql = $" SELECT * FROM ViewDefensas WHERE Carrera LIKE '%{carrera}%' AND Tipo LIKE '%{tipo}%'  ; ";
            return obj.SelectConexion(sql);
        }
        public DataTable getDenfensasCarreraEstudiante(string carrera, string estudiante)
        {
            string sql = $" SELECT * FROM ViewDefensas WHERE Carrera LIKE '%{carrera}%' AND Estudiante LIKE '%{estudiante}%'  ; ";
            return obj.SelectConexion(sql);
        }

        public DataTable getDenfensasCarreraTipoEstudiante(string carrera, string tipo,string estudiante)
        {
            string sql = $" SELECT * FROM ViewDefensas WHERE Carrera LIKE '%{carrera}%' AND Tipo LIKE '%{tipo}%' AND Estudiante LIKE '%{estudiante}%'   ; ";
            return obj.SelectConexion(sql);
        }
        /********/
        public DataTable getDenfensas()
        {
            string sql = $" SELECT * FROM ViewDefensas ; ";
            return obj.SelectConexion(sql);
        }
        public DataTable getDenfensasTipo( string tipo)
        {
            string sql = $" SELECT * FROM ViewDefensas WHERE Tipo LIKE '%{tipo}%'  ; ";
            return obj.SelectConexion(sql);
        }
        public DataTable getDenfensaEstudiante(string estudiante)
        {
            string sql = $" SELECT * FROM ViewDefensas WHERE Estudiante LIKE '%{estudiante}%'  ; ";
            return obj.SelectConexion(sql);
        }

        public DataTable getDenfensasTipoEstudiante(string tipo, string estudiante)
        {
            string sql = $" SELECT * FROM ViewDefensas WHERE Tipo LIKE '%{tipo}%' AND Estudiante LIKE '%{estudiante}%'   ; ";
            return obj.SelectConexion(sql);
        }
    }
}
