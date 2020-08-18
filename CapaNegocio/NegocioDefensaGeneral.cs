using System;
using System.Collections.Generic;
using System.Data;
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iddefensa">id de la defensa externa </param>
        /// <returns>un Array tipo Object con los datos de la consulta</returns>
        public Object[] InfoDefensaOtros(int iddefensa)
        {
            double Calificacion = 0 ;
            int Id = 0;
            int Id_titulacion_otro = 0;
            int Id_estudiante = 0; 
            int Id_carrera = 0;
            int Id_tipo_titulacion = 0;
            string Fecha_presentacion = "";
            string Hora = ""; 
            string Aula = "";
            string Estado_defensa = "";
            string Tema = "";
            string Registro = "";
            string Nombre = "";
            string Apellido = "";
            string Email = "";
            string Telefono = "";
            string Celular = "";
            string Carrera = "" ;
            
            var dt = defensaExterna.InfoDefensaOtros(iddefensa);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Id = Convert.ToInt32(dt.Rows[i]["Id"].ToString());
                Fecha_presentacion  = dt.Rows[i]["Fecha_presentacion"].ToString();
                Hora = dt.Rows[i]["Hora"].ToString();
                Aula = dt.Rows[i]["Aula"].ToString();
                Id_titulacion_otro = Convert.ToInt32(dt.Rows[i]["Id_titulacion_otro"].ToString());
                Estado_defensa = dt.Rows[i]["Estado_defensa"].ToString();
                Tema = dt.Rows[i]["Tema"].ToString();
                Calificacion = Convert.ToDouble(dt.Rows[i]["Calificacion"].ToString());
                Id_tipo_titulacion = Convert.ToInt32(dt.Rows[i]["Id_tipo_titulacion"].ToString());
                Id_estudiante = Convert.ToInt32(dt.Rows[i]["Id_estudiante"].ToString());
                Registro = dt.Rows[i]["Registro"].ToString();
                Nombre = dt.Rows[i]["Nombre"].ToString();
                Apellido = dt.Rows[i]["Apellido"].ToString();
                Email = dt.Rows[i]["Email"].ToString();
                Telefono = dt.Rows[i]["Telefono"].ToString();
                Celular = dt.Rows[i]["Celular"].ToString();
                Id_carrera = Convert.ToInt32(dt.Rows[i]["Id_carrera"].ToString());
                Carrera = dt.Rows[i]["Carrera"].ToString();
             
            }

            Object[] datos = new Object[]
            {
                Id,
                Fecha_presentacion,
                Hora,
                Aula,
                Id_titulacion_otro,
                Estado_defensa,
                Tema,
                Calificacion,
                Id_tipo_titulacion,
                Id_estudiante,
                Registro,
                Nombre,
                Apellido,
                Email,
                Telefono,
                Celular,
                Id_carrera,
                Carrera
            };

            return datos;
        }
        public DataTable cargarCarreras()
        {
            DataTable dt1 = carrera.Select();

            return dt1;
        }

        ~NegocioDefensaGeneral()
        {

        }

    }
}
