using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;
using CapaDatos.View;
using CapaNegocio.src;

namespace CapaNegocio
{
    public class NegocioDefensaGeneral : ValidationInputUI
    {
        public NegocioDefensaGeneral()
        {

        }

        #region Instancias
        Carrera carrera = new Carrera();
        Estudiante estudiante = new Estudiante();
        DefensaExterna defensaExterna = new DefensaExterna();
        DetalleDefensa detalleDefensa = new DetalleDefensa();
        TitulacionOtros titulacionOtros = new TitulacionOtros();
        TipoTitulacionOtros tipoTitulacionOtros = new TipoTitulacionOtros();
        FuncionLicenciado funcionLicenciado = new FuncionLicenciado();
        DataTypes type = new DataTypes();


        #endregion

        #region Atributos

        Object[] parametros;

        #endregion

        public void MainUpdate(int operacion = 1)
        {
            try
            {
                switch (operacion)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }

            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }


        }
        public void ControlInput(Object[] Collection)
        {
            try
            {
                Validation(Collection);
                parametros = Collection;
            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }

        }
        public void UpdateDefensaTitulacionOtros(int idestudiante, int idtitulacion, int iddefensa, int lic1, int lic2, int lic3, int lic4, int lic5, int lic6, int lic7, Object[] Collection)
        {
            try
            {
                type.Registro = Convert.ToString(Collection[0]);
                estudiante.Registro = type.Registro;
                type.Texto2 = Convert.ToString(Collection[1]);
                estudiante.Nombre = type.Texto2;
                type.Texto2 = Convert.ToString(Collection[2]);
                estudiante.Apellido = type.Texto2;
                type.Email = Convert.ToString(Collection[3]);
                estudiante.Email = type.Email;
                string tel = Convert.ToString(Collection[4]);
                estudiante.Telefono = (tel == "") ? "" : tel;
                string cel = Convert.ToString(Collection[5]);
                estudiante.Celular = (cel == "") ? "" : cel;
                estudiante.Id_carrera = Convert.ToInt32(Collection[6]);

                titulacionOtros.Estado_defensa = "pendiente";
                titulacionOtros.Tema = Convert.ToString(Collection[7]);

                titulacionOtros.Calificacion = 0;


                estudiante.Update(idestudiante);

                titulacionOtros.Id_estudiante = idestudiante;

                titulacionOtros.Id_tipo_titulacion = tipoTitulacionOtros.FindIdBySearch(Convert.ToString(Collection[8]));
                titulacionOtros.Update(idtitulacion);



                type.Fecha = Convert.ToString(Collection[9]);
                defensaExterna.Fecha_presentacion = type.Fecha;
                string hr = Convert.ToString(Collection[10]);
                defensaExterna.Hora = hr;
                type.Aula = Convert.ToString(Collection[11]);
                defensaExterna.Aula = type.Aula;

                defensaExterna.Id_tesis = 0;
                defensaExterna.Id_titulacion_otro = idtitulacion;
                defensaExterna.Update(iddefensa);



                detalleDefensa.Id_defensa_externa = iddefensa;
                detalleDefensa.Id_licenciado = Convert.ToInt32(Collection[12]);
                detalleDefensa.Id_funcion_licenciado = funcionLicenciado.FindIdBySearch(Convert.ToString(Collection[13]));
                detalleDefensa.Update(lic1);

                detalleDefensa.Id_defensa_externa = iddefensa;
                detalleDefensa.Id_licenciado = Convert.ToInt32(Collection[14]);
                detalleDefensa.Id_funcion_licenciado = funcionLicenciado.FindIdBySearch(Convert.ToString(Collection[15]));
                detalleDefensa.Update(lic2);

                detalleDefensa.Id_defensa_externa = iddefensa;
                detalleDefensa.Id_licenciado = Convert.ToInt32(Collection[16]);
                detalleDefensa.Id_funcion_licenciado = funcionLicenciado.FindIdBySearch(Convert.ToString(Collection[17]));
                detalleDefensa.Update(lic3);

                detalleDefensa.Id_defensa_externa = iddefensa;
                detalleDefensa.Id_licenciado = Convert.ToInt32(Collection[18]);
                detalleDefensa.Id_funcion_licenciado = funcionLicenciado.FindIdBySearch(Convert.ToString(Collection[19]));
                detalleDefensa.Update(lic4);

                detalleDefensa.Id_defensa_externa = iddefensa;
                detalleDefensa.Id_licenciado = Convert.ToInt32(Collection[20]);
                detalleDefensa.Id_funcion_licenciado = funcionLicenciado.FindIdBySearch(Convert.ToString(Collection[21]));
                detalleDefensa.Update(lic5);

                detalleDefensa.Id_defensa_externa = iddefensa;
                detalleDefensa.Id_licenciado = Convert.ToInt32(Collection[22]);
                detalleDefensa.Id_funcion_licenciado = funcionLicenciado.FindIdBySearch(Convert.ToString(Collection[23]));
                detalleDefensa.Update(lic6);

                detalleDefensa.Id_defensa_externa = iddefensa;
                detalleDefensa.Id_licenciado = Convert.ToInt32(Collection[24]);
                detalleDefensa.Id_funcion_licenciado = funcionLicenciado.FindIdBySearch(Convert.ToString(Collection[25]));
                detalleDefensa.Update(lic7);







            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }

        }
        public Object[] InfoDefensaOtros(int iddefensa)
        {
            Object[] datos = new Object[] { };

            return datos;

        }


        ~NegocioDefensaGeneral()
        {

        }

    }
}
