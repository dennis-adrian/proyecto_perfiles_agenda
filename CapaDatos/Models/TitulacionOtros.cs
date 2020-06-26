using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class TitulacionOtros : Conexion, IMetodos
    {
        public TitulacionOtros()
        {
            id = 0;
            estado_defensa = "";
            calificacion = 0;
            id_estudiante = 0;
            id_tipo_titulacion = 0;
        }
        #region Atributos 
        private int id;
        private string estado_defensa;
        private double calificacion;
        private int id_estudiante;
        private int id_tipo_titulacion;


        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public string Estado_defensa { get => estado_defensa; set => estado_defensa = value; }
        public double Calificacion { get => calificacion; set => calificacion = value; }
        public int Id_estudiante { get => id_estudiante; set => id_estudiante = value; }
        public int Id_tipo_titulacion { get => id_tipo_titulacion; set => id_tipo_titulacion = value; }

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
