using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;
using CapaNegocio.src;



namespace CapaNegocio
{
    public class NegocioNuevaDefensa : ValidationInputUI
    {
        #region  Construct
        public NegocioNuevaDefensa(){

        }

        #endregion


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

        #region  Metodos
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
        public void Main(int operacion = 1)
        {
            try
            {
                switch (operacion)
                {
                    case 1:
                        NuevaDefensaOtro(parametros);
                        break;
                    case 2:
                        NuevaDefensaTesis(parametros);
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
        public void NuevaDefensaOtro(Object[] Collection)
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


                estudiante.Insert();
                int idestudiante = estudiante.LastId();
                titulacionOtros.Id_estudiante = idestudiante;

                titulacionOtros.Id_tipo_titulacion = tipoTitulacionOtros.FindIdBySearch(Convert.ToString(Collection[8]));

                type.Fecha =  Convert.ToString(Collection[9]);
                defensaExterna.Fecha_presentacion = type.Fecha;
                string hr = Convert.ToString(Collection[10]);
                defensaExterna.Hora = hr;
                type.Aula = Convert.ToString(Collection[11]);
                defensaExterna.Aula = type.Aula;
                
                defensaExterna.Id_tesis = 0;
                defensaExterna.Id_titulacion_otro = idestudiante;
                defensaExterna.Insert();

                int iddefensa = defensaExterna.LastId();


                detalleDefensa.Id_defensa_externa = iddefensa;
                detalleDefensa.Id_licenciado = Convert.ToInt32(Collection[12]);
                detalleDefensa.Id_funcion_licenciado = funcionLicenciado.FindIdBySearch(Convert.ToString(Collection[13]));
                detalleDefensa.Insert();

                detalleDefensa.Id_defensa_externa = iddefensa;
                detalleDefensa.Id_licenciado = Convert.ToInt32(Collection[14]);
                detalleDefensa.Id_funcion_licenciado = funcionLicenciado.FindIdBySearch(Convert.ToString(Collection[15]));
                detalleDefensa.Insert();

                detalleDefensa.Id_defensa_externa = iddefensa;
                detalleDefensa.Id_licenciado = Convert.ToInt32(Collection[16]);
                detalleDefensa.Id_funcion_licenciado = funcionLicenciado.FindIdBySearch(Convert.ToString(Collection[17]));
                detalleDefensa.Insert();

                detalleDefensa.Id_defensa_externa = iddefensa;
                detalleDefensa.Id_licenciado = Convert.ToInt32(Collection[18]);
                detalleDefensa.Id_funcion_licenciado = funcionLicenciado.FindIdBySearch(Convert.ToString(Collection[19]));
                detalleDefensa.Insert();

                detalleDefensa.Id_defensa_externa = iddefensa;
                detalleDefensa.Id_licenciado = Convert.ToInt32(Collection[20]);
                detalleDefensa.Id_funcion_licenciado = funcionLicenciado.FindIdBySearch(Convert.ToString(Collection[21]));
                detalleDefensa.Insert();

                detalleDefensa.Id_defensa_externa = iddefensa;
                detalleDefensa.Id_licenciado = Convert.ToInt32(Collection[22]);
                detalleDefensa.Id_funcion_licenciado = funcionLicenciado.FindIdBySearch(Convert.ToString(Collection[23]));
                detalleDefensa.Insert();

                detalleDefensa.Id_defensa_externa = iddefensa;
                detalleDefensa.Id_licenciado = Convert.ToInt32(Collection[24]);
                detalleDefensa.Id_funcion_licenciado = funcionLicenciado.FindIdBySearch(Convert.ToString(Collection[25]));
                detalleDefensa.Insert();


                




            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }
        }

        public void NuevaDefensaTesis(Object[] Collection)
        {
            try
            {
                type.Fecha = Convert.ToString(Collection[0]);
                defensaExterna.Fecha_presentacion = type.Fecha;

                string hr = Convert.ToString(Collection[1]);
                defensaExterna.Hora = hr;

                type.Aula = Convert.ToString(Collection[2]);
                defensaExterna.Aula = type.Aula;

                int idtesis = Convert.ToInt32(Collection[3]);
                defensaExterna.Id_tesis = idtesis;

                defensaExterna.Id_titulacion_otro = 0;
                defensaExterna.Insert();

            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }
        }

        public DataTable cargarCarreras()
        {
            DataTable dt1 = carrera.Select();

            return dt1;
        }
        #endregion



        #region Destruct

        ~NegocioNuevaDefensa(){

        }
        #endregion
    }
}
