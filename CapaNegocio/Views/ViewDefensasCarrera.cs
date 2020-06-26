using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Views
{
    public class ViewDefensasCarrera
    {
        public ViewDefensasCarrera()
        {
            id = 0;
            fecha_Defensa = "";
            hora = "";
            aula = "";
            tipo = "";
            tema = "";
            registro = "";
            nombre = "";
            apellido = "";
            carrera = "";
            facultad = "";
        }

        private int id;
        private string fecha_Defensa;
        private string hora;
        private string aula;
        private string tipo;
        private string tema;
        private string registro;
        private string nombre;
        private string apellido;
        private string carrera;
        private string facultad;

        public int Id { get => id; set => id = value; }
        public string Fecha_Defensa { get => fecha_Defensa; set => fecha_Defensa = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Aula { get => aula; set => aula = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Tema { get => tema; set => tema = value; }
        public string Registro { get => registro; set => registro = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Facultad { get => facultad; set => facultad = value; }
    }

}
