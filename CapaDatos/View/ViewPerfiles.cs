using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.View
{
    public class ViewPerfiles
    {
        Conexion obj = new Conexion();
        public ViewPerfiles()
        {
            id = 0;
            estado_Proyecto = "";
            registro = "";
            estudiante = "";
            carrera = "";
            facultad = "";
            tema = "";
            tutor = "";
            email = "";
            telefono = "";
            fecha_Recepcion = "";

        }
        #region Atributos
        private int id;
        private string estado_Proyecto;
        private string registro;
        private string estudiante;
        private string carrera;
        private string facultad;
        private string tema;
        private string tutor;
        private string email;
        private string telefono;
        private string fecha_Recepcion;



        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Estado_Proyecto { get => estado_Proyecto; set => estado_Proyecto = value; }
        public string Registro { get => registro; set => registro = value; }
        public string Estudiante { get => estudiante; set => estudiante = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Facultad { get => facultad; set => facultad = value; }
        public string Tema { get => tema; set => tema = value; }
        public string Tutor { get => tutor; set => tutor = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Fecha_Recepcion { get => fecha_Recepcion; set => fecha_Recepcion = value; }
        #endregion

        #region Metodos
        public DataTable Select()
        {
            return obj.SelectConexion("ViewPerfiles") ;
        }
        public DataTable Select(string estudiante)
        {

            string sql = " SELECT * FROM ViewPerfiles  WHERE estudiante LIKE '%@parametro%' ; ";
            return obj.SelectConexion(sql, estudiante);
           
        }

        #endregion
    }
}
