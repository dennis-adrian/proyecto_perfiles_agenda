using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class Carrera : Conexion
    {
        public Carrera()
        {
            id = 0;
            nombre = "";
            id_facultad = 0;
          
        }
        #region Atributos 
        private int id;
        private string nombre;
        private int id_facultad;


        #endregion
        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_facultad { get => id_facultad; set => id_facultad = value; }

        #endregion
        #region Metodos 

        #endregion
    }
}
