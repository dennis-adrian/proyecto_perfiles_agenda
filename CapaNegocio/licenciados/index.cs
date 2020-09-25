using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.View;
using CapaDatos.Models;
using System.Data;

namespace CapaNegocio.licenciados
{
    public class Index : src.Controller
    {
        #region Instancias

        public Licenciado licenciado;
        public ViewLicenciados viewlicenciados;
        public Institucion institucion;
        public CarreraLicenciado carreraLicenciado;
        public src.DataTypes type;
        #endregion

        public Index()
        {
            viewlicenciados = new ViewLicenciados();
            licenciado = new Licenciado();
            institucion = new Institucion();
            carreraLicenciado = new CarreraLicenciado();
            type = new src.DataTypes();
        }
        public DataTable cargarCarrerasLicenciados()
        {
            return carreraLicenciado.Select();
        }
        public DataTable cargarInstitucion()
        {
            return institucion.Select();
        }
    }
}
