using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.View
{
    /// <summary>
    /// clase creada para la obtener las consultas de defensas exitentes
    /// </summary>
    public class DaoDefensas
    {
        string carrera;
        string tipo;
        string estudiante;
        string key;

        /// <summary>
        /// se crea el constructor de la clase
        /// </summary>
        public DaoDefensas()
        {
            carrera = null;
            tipo = null;
            estudiante = null;
            key = null;
            fillDic();


        }

        /// <summary>
        /// Generamos la clase para el almacenamiento de consultas
        /// </summary>
        Dictionary<string, string> defensasTipos = new Dictionary<string, string>();
       
        /// <summary>
        /// Instanciamos la Conexion
        /// </summary>
        Conexion obj = new Conexion();

        public string Carrera { get => carrera; set => carrera = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Estudiante { get => estudiante; set => estudiante = value; }
        public string Key { get => key; set => key = value; }

        /// <summary>
        /// Agregamos diferentes tipos de consultas con los requerimientos del usuario
        /// </summary>
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

        /// <summary>
        /// filtramos la vista viewDefensas con los requerimientos del usuario
        /// </summary>
        /// <param name="carrera"></param>
        /// <returns></returns>
        public DataTable getDenfensasCarrera(string carrera)
        {
            string sql = $" SELECT * FROM ViewDefensas WHERE Carrera LIKE '%{carrera}%'  ; ";        
            return obj.SelectConexion(sql);
        }
        /// <summary>
        /// filtramos viewDefensas entre carrera y tipo elegido por el usuario
        /// </summary>
        /// <param name="carrera"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public DataTable getDenfensasCarreraTipo(string carrera, string tipo)
        {
            string sql = $" SELECT * FROM ViewDefensas WHERE Carrera LIKE '%{carrera}%' AND Tipo LIKE '%{tipo}%'  ; ";
            return obj.SelectConexion(sql);
        }
        /// <summary>
        /// filtramos viewDefensas entre carrera y estudiante elegido por el usuario
        /// </summary>
        /// <param name="carrera"></param>
        /// <param name="estudiante"></param>
        /// <returns></returns>
        public DataTable getDenfensasCarreraEstudiante(string carrera, string estudiante)
        {
            string sql = $" SELECT * FROM ViewDefensas WHERE Carrera LIKE '%{carrera}%' AND Estudiante LIKE '%{estudiante}%'  ; ";
            return obj.SelectConexion(sql);
        }
        /// <summary>
        /// filtramos viewDefensas entre carrera, tipo y estudiante elegido por el usuario
        /// </summary>
        /// <param name="carrera"></param>
        /// <param name="tipo"></param>
        /// <param name="estudiante"></param>
        /// <returns></returns>
        public DataTable getDenfensasCarreraTipoEstudiante(string carrera, string tipo,string estudiante)
        {
            string sql = $" SELECT * FROM ViewDefensas WHERE Carrera LIKE '%{carrera}%' AND Tipo LIKE '%{tipo}%' AND Estudiante LIKE '%{estudiante}%'   ; ";
            return obj.SelectConexion(sql);
        }
        /********/

        /// <summary>
        /// obtenemos todas las defensas
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public DataTable getDenfensas(string tipo = "DEFENSAS")
        {
            fillDic();
            string sql = defensasTipos[tipo];
            return obj.SelectConexion(sql);
        }/// <summary>
         /// filtramos viewDefensas entre tipo elegido por el usuario
         /// </summary>
         /// <param name="tipo"></param>
         /// <returns></returns>
        public DataTable getDenfensasTipo( string tipo)
        {
            string sql = $" SELECT * FROM ViewDefensas WHERE Tipo LIKE '%{tipo}%'  ; ";
            return obj.SelectConexion(sql);
        }
        /// <summary>
        /// filtramos viewDefensas entre estudiante elegido por el usuario
        /// </summary>
        /// <param name="estudiante"></param>
        /// <returns></returns>
        public DataTable getDenfensaEstudiante(string estudiante)
        {
            string sql = $" SELECT * FROM ViewDefensas WHERE Estudiante LIKE '%{estudiante}%'  ; ";
            return obj.SelectConexion(sql);
        }
        /// <summary>
        /// filtramos viewDefensas entre tipo y estudiante elegido por el usuario
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="estudiante"></param>
        /// <returns></returns>
        public DataTable getDenfensasTipoEstudiante(string tipo, string estudiante)
        {
            string sql = $" SELECT * FROM ViewDefensas WHERE Tipo LIKE '%{tipo}%' AND Estudiante LIKE '%{estudiante}%'   ; ";
            return obj.SelectConexion(sql);
        }
    }
}
