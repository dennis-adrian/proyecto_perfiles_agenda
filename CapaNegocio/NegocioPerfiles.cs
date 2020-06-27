using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class NegocioPerfiles
    {
        Vistas Vista = new Vistas();
        CapaDatos.Models.Licenciado licenciados = new CapaDatos.Models.Licenciado();
        public NegocioPerfiles()
        {

        }
        #region FrmPerfiles

        public DataTable mostarPerfiles()
        {
            return Vista.ViewPerfiles();
        }
        public DataTable mostrarPerfileCarrera(string carrera)
        {
            return Vista.ViewPerfilesCarrera(carrera);
        }
        public DataTable mostrarPerfilEstudiante(string criterio)
        {
            return Vista.ViewPerfilEstudiante(criterio);
        }
        #endregion

        #region NuevoPerfil

        public  DataTable Licenciados()
        {

            return licenciados.Select();
        }
        #endregion


    }
}
