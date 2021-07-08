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
        string carrera;
        string tipo;
        string estudiante;
        string key;

        public DaoDefensas()
        {
            carrera = null;
            tipo = null;
            estudiante = null;
            key = null;
            fillDic();


        }

        Dictionary<string, string> defensasTipos = new Dictionary<string, string>();
       

        Conexion obj = new Conexion();

        public string Carrera { get => carrera; set => carrera = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Estudiante { get => estudiante; set => estudiante = value; }
        public string Key { get => key; set => key = value; }

        public void fillDic()
        {
            defensasTipos.Clear();
            defensasTipos.Add("DEFENSAS", $" SELECT * FROM ViewDefensas ");

            defensasTipos.Add("CARRERA", $" SELECT * FROM ViewDefensas WHERE Carrera LIKE '%{this.Carrera}%' ");

            defensasTipos.Add("CARRERA_TIPO", $" SELECT * FROM ViewDefensas WHERE Carrera LIKE '%{this.Carrera}%' AND Tipo LIKE '%{this.Tipo}%'  ; ");

            defensasTipos.Add("CARRERA_ESTUDIANTE", $" SELECT * FROM ViewDefensas WHERE Carrera LIKE '%{this.Carrera}%' AND Estudiante LIKE '%{this.Estudiante}%'  ; ");

            defensasTipos.Add("CARRERA_TIPO_ESTUDIANTE", $" SELECT * FROM ViewDefensas WHERE Carrera LIKE '%{this.Carrera}%' AND Tipo LIKE '%{this.Tipo}%' AND Estudiante LIKE '%{this.Estudiante}%'   ; ");
            
            defensasTipos.Add("TIPO", $" SELECT * FROM ViewDefensas WHERE Tipo LIKE '%{this.Tipo}%'  ; ");

            defensasTipos.Add("ESTUDIANTE", $" SELECT * FROM ViewDefensas WHERE Estudiante LIKE '%{this.Estudiante}%'  ; ");

            defensasTipos.Add("TIPO_ESTUDIANTE", $" SELECT * FROM ViewDefensas WHERE Tipo LIKE '%{this.Tipo}%' AND Estudiante LIKE '%{this.Estudiante}%'   ; ");
        }
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
        public DataTable getDenfensas(string tipo = "DEFENSAS")
        {
            fillDic();
            string sql = defensasTipos[tipo];
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
