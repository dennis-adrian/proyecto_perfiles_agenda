using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;

namespace CapaNegocio.defensaExterna.defensaPerfil
{
    public class Index : src.Controller
    {
        public Estudiante estudiante = new Estudiante();
        public Carrera carrera;
        public DefensaExterna defensaExterna;
        public DetalleDefensa detalleDefensa;
        public TitulacionOtros titulacionOtros = new TitulacionOtros();
        public TipoTitulacionOtros tipoTitulacionOtros = new TipoTitulacionOtros();
        public FuncionLicenciado funcionLicenciado = new FuncionLicenciado();
        public src.DataTypes type = new src.DataTypes();


        public Index()
        {
            carrera = new Carrera();
            defensaExterna = new DefensaExterna();
            detalleDefensa = new DetalleDefensa();
        }




        public DataTable cargarCarreras()
        {
            return carrera.Select();
        }
    }
}
