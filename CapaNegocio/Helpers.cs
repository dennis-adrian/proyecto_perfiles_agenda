using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;


namespace CapaNegocio
{

    public class Helpers
    {

        Institucion institucion = new Institucion();
        public Helpers()
        {


        }
        public void InsertInstitucion(string nombre)
        {
            institucion.Nombre = nombre;
            institucion.Insert();

        }
       
    }
}
