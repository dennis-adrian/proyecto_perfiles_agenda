using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class PerfilTesis : Conexion, IMetodos
    {
        public PerfilTesis()
        {
            id = 0;
            tema = "";
            estado = "";
            fecha_aprobacion_jefe_carrera = "";
            fecha_recepcion_titulacion = "";
            estado_defensa = "";
            calificacion = 0;
            id_liceniado = 0;
            id_tipo_licenciado = 0;
        }
        #region Atributos 
        private int id;
        private string tema;
        private string estado;
        private string fecha_aprobacion_jefe_carrera;
        private string fecha_recepcion_titulacion;
        private string estado_defensa;
        private double calificacion;
        private int id_liceniado;
        private int id_tipo_licenciado;


        #endregion
        #region Propiedades 

        public int Id { get => id; set => id = value; }
        public string Tema { get => tema; set => tema = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Fecha_aprobacion_jefe_carrera { get => fecha_aprobacion_jefe_carrera; set => fecha_aprobacion_jefe_carrera = value; }
        public string Fecha_recepcion_titulacion { get => fecha_recepcion_titulacion; set => fecha_recepcion_titulacion = value; }
        public string Estado_defensa { get => estado_defensa; set => estado_defensa = value; }
        public double Calificacion { get => calificacion; set => calificacion = value; }
        public int Id_liceniado { get => id_liceniado; set => id_liceniado = value; }
        public int Id_tipo_licenciado { get => id_tipo_licenciado; set => id_tipo_licenciado = value; }

        #endregion
        #region Metodos 
        public void Insert()
        {

        }
        public void Delete()
        {

        }
        public void Update()
        {

        }
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            return dt;

        }
        #endregion
    }
}
