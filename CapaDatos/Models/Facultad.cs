using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class Facultad: Conexion
    {
        public Facultad()
        {
            id = 0;
            nombre = "";
        }
        #region Atributos 
        private int id;
        private string nombre;


        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }


        #endregion
        #region Metodos 

        #endregion

    }
}
