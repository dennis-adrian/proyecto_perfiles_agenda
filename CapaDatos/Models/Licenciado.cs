using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public  class Licenciado : Conexion
    {
        public Licenciado()
        {
            id = 0;
            nombre = "";
            apellido = "";
            descripcion = "";
            email = "";
            telefono = "";
            celular = "";
            docente = 0;
           
            id_institucion_representada = 0;
            id_carrera_licenciado = 0;

        }
        #region Atributos 
        private int id;
        private string nombre;
        private string apellido;
        private string descripcion;
        private string email;
        private string telefono;
        private string celular;
        private int docente;
        private int id_institucion_representada;
        private int id_carrera_licenciado;




        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Celular { get => celular; set => celular = value; }
        public int Docente { get => docente; set => docente = value; }
        public int Id_institucion_representada { get => id_institucion_representada; set => id_institucion_representada = value; }
        public int Id_carrera_licenciado { get => id_carrera_licenciado; set => id_carrera_licenciado = value; }


        #endregion
        #region Metodos 

        #endregion
    }
}
