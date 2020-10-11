using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.defensaExterna.defensaPerfil.otros
{
    public class ActualizarDefensa : defensaPerfil.Index
    {
        public ActualizarDefensa() : base()
        {

        }
        
        public void updateOtros( dynamic estudiante_obj, dynamic titulcion_otros_obj, dynamic defensa_externa_obj,List<dynamic> lista_detalle_defensa_obj)
        {
            try
            {
                /*
                defensa externa-----------------
                id
                fecha_presentacion
                hora
                aula
                id_titulacion_otro

                estudiante-----------------------
                id
                registro
                nombre
                apellido
                email
                telefono
                celular
                id_carrera 

                titulacion_otros---------------
                id
                estado_defensa
                tema
                calificacion
                id_estudiante
                id_tipo_titulacion

                detalle_defensa----------------*7
                id
                id_defensa_externa
                id_licenciado
                id_funcion_licenciado


                 
                 */
                estudiante.Id = Convert.ToInt32(estudiante_obj.Id);
                estudiante.Registro = Convert.ToString(estudiante_obj.Registro);
                estudiante.Apellido = Convert.ToString(estudiante_obj.Apellido);
                estudiante.Nombre = Convert.ToString(estudiante_obj.Nombre);
                estudiante.Email = Convert.ToString(estudiante_obj.Email);

                estudiante.Telefono = Convert.ToString(estudiante_obj.Telefono);

                estudiante.Celular = Convert.ToString(estudiante_obj.Celular);
                estudiante.Id_carrera = Convert.ToInt32(estudiante_obj.Id_carrera);

                estudiante.Update(estudiante.Id);


                titulacionOtros.Id = Convert.ToInt32(titulcion_otros_obj.Id);
                titulacionOtros.Estado_defensa = Convert.ToString(titulcion_otros_obj.Estado_defensa);
                titulacionOtros.Tema = Convert.ToString(titulcion_otros_obj.Tema);
                titulacionOtros.Calificacion = Convert.ToDouble(titulcion_otros_obj.Calificacion);
                titulacionOtros.Id_estudiante = Convert.ToInt32(titulcion_otros_obj.Id_estudiante);
                titulacionOtros.Id_tipo_titulacion = Convert.ToInt32(titulcion_otros_obj.Id_tipo_titulacion);

                titulacionOtros.Update(titulacionOtros.Id);

                defensaExterna.Id = Convert.ToInt32(defensa_externa_obj.Id);
                defensaExterna.Fecha_presentacion = Convert.ToString(defensa_externa_obj.Fecha_presentacion);
                defensaExterna.Hora = Convert.ToString(defensa_externa_obj.Hora);

                defensaExterna.Aula = Convert.ToString(defensa_externa_obj.Aula);
                defensaExterna.Id_titulacion_otro = Convert.ToInt32(defensa_externa_obj.Id_titulacion_otro);

                defensaExterna.Update(defensaExterna.Id);


                foreach(var item in lista_detalle_defensa_obj)
                {
                    detalleDefensa.Id = Convert.ToInt32(item.Id);
                    detalleDefensa.Id_defensa_externa = Convert.ToInt32(item.Id_defensa_externa);
                    detalleDefensa.Id_funcion_licenciado = Convert.ToInt32(item.Id_funcion_licenciado);
                    detalleDefensa.Id_licenciado = Convert.ToInt32(item.Id_licenciado);
                    detalleDefensa.Update(detalleDefensa.Id);
                }

            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }

        }




        /// <summary>
        /// PENDIENTE
        /// </summary>
        /// <param name="estudiante_obj"></param>
        /// <param name="titulcion_otros_obj"></param>
        /// <param name="defensa_externa_obj"></param>

        public void updateTesis(dynamic estudiante_obj, dynamic titulcion_otros_obj, dynamic defensa_externa_obj)
        {
            try
            {
                /*
                defensa externa-----------------
                id
                fecha_presentacion
                hora
                aula
                id_titulacion_otro

                estudiante-----------------------
                id
                registro
                nombre
                apellido
                email
                telefono
                celular
                id_carrera 

                titulacion_otros---------------
                id
                estado_defensa
                tema
                calificacion
                id_estudiante
                id_tipo_titulacion

                detalle_defensa----------------*7
                id
                id_defensa_externa
                id_licenciado
                id_funcion_licenciado


                 
                 */
                estudiante.Id = Convert.ToInt32(estudiante_obj.Id);
                estudiante.Registro = Convert.ToString(estudiante_obj.Registro);
                estudiante.Apellido = Convert.ToString(estudiante_obj.Apellido);
                estudiante.Nombre = Convert.ToString(estudiante_obj.Nombre);
                estudiante.Email = Convert.ToString(estudiante_obj.Email);

                estudiante.Telefono = Convert.ToString(estudiante_obj.Telefono);

                estudiante.Celular = Convert.ToString(estudiante_obj.Celular);
                estudiante.Id_carrera = Convert.ToInt32(estudiante_obj.Id_carrera);

                estudiante.Update(estudiante.Id);


                titulacionOtros.Id = Convert.ToInt32(titulcion_otros_obj.Id);
                titulacionOtros.Estado_defensa = Convert.ToString(titulcion_otros_obj.Estado_defensa);
                titulacionOtros.Tema = Convert.ToString(titulcion_otros_obj.Tema);
                titulacionOtros.Calificacion = Convert.ToDouble(titulcion_otros_obj.Calificacion);
                titulacionOtros.Id_estudiante = Convert.ToInt32(titulcion_otros_obj.Id_estudiante);
                titulacionOtros.Id_tipo_titulacion = Convert.ToInt32(titulcion_otros_obj.Id_tipo_titulacion);

                titulacionOtros.Update(titulacionOtros.Id);

                defensaExterna.Id = Convert.ToInt32(defensa_externa_obj.Id);
                defensaExterna.Fecha_presentacion = Convert.ToString(defensa_externa_obj.Fecha_presentacion);
                defensaExterna.Hora = Convert.ToString(defensa_externa_obj.Hora);

                defensaExterna.Aula = Convert.ToString(defensa_externa_obj.Aula);
                defensaExterna.Id_titulacion_otro = Convert.ToInt32(defensa_externa_obj.Id_titulacion_otro);

                defensaExterna.Update(defensaExterna.Id);




            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }

        }


    }
}
