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
        Carrera carrera = new Carrera();
        Estudiante estudiante = new Estudiante();
        DefensaExterna defensaExterna = new DefensaExterna();
        DetalleDefensa detalleDefensa = new DetalleDefensa();
        TitulacionOtros titulacionOtros = new TitulacionOtros();
        TipoTitulacionOtros tipoTitulacionOtros = new TipoTitulacionOtros();
        FuncionLicenciado funcionLicenciado = new FuncionLicenciado();
        src.DataTypes type = new src.DataTypes();


        public Index()
        {

        }




        public DataTable cargarCarreras()
        {
            return carrera.Select();
        }
    }
}
