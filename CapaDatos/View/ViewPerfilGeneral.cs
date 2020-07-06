using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.View
{
    public class ViewPerfilGeneral
    {
        Conexion obj = new Conexion();
        #region Constructor
        public ViewPerfilGeneral()
        {
            id = 0;
            revisiones = 0;
            tema = "";
            estado_Proyecto = "";
            fecha_Aprobacion = "";
            fecha_Recepcion = "";
            estado_Defensa = "";
            calificacion = 0;
            registro = "";
            nombre = "";
            apellido = "";
            email = "";
            telefono = "";
            celular = "";
            carrera = "";
            facultad = "";
            tutor = "";
            tipo = "";
            funcion = "";
            institucion = "";
            carrera_Licenciado = "";

        }
        #endregion
        #region Atributos

        private int id;
        private int revisiones;
        private string tema;
        private string estado_Proyecto;
        private string fecha_Aprobacion;
        private string fecha_Recepcion;
        private string estado_Defensa;
        private double calificacion;
        private string registro;
        private string nombre;
        private string apellido;
        private string email;
        private string telefono;
        private string celular;
        private string carrera;
        private string facultad;
        private string tutor;
        private string tipo;
        private string funcion;
        private string institucion;
        private string carrera_Licenciado;



        #endregion


        #region Propiedades
        public int Id { get => id; set => id = value; }
        public int Revisiones { get => revisiones; set => revisiones = value; }
        public string Tema { get => tema; set => tema = value; }
        public string Estado_Proyecto { get => estado_Proyecto; set => estado_Proyecto = value; }
        public string Fecha_Aprobacion { get => fecha_Aprobacion; set => fecha_Aprobacion = value; }
        public string Fecha_Recepcion { get => fecha_Recepcion; set => fecha_Recepcion = value; }
        public string Estado_Defensa { get => estado_Defensa; set => estado_Defensa = value; }
        public double Calificacion { get => calificacion; set => calificacion = value; }
        public string Registro { get => registro; set => registro = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Facultad { get => facultad; set => facultad = value; }
        public string Tutor { get => tutor; set => tutor = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Funcion { get => funcion; set => funcion = value; }
        public string Institucion { get => institucion; set => institucion = value; }
        public string Carrera_Licenciado { get => carrera_Licenciado; set => carrera_Licenciado = value; }


        #endregion
        #region Metodos

        public DataTable Select(int i)
        {
            string sql = " SELECT * FROM ViewPerfilGeneral WHERE Id = "+i+" ; ";
            return obj.SelectConexion(sql);
        }

        #endregion
        #region Desctructor
        ~ViewPerfilGeneral()
        {

        }
        #endregion
    }
}
