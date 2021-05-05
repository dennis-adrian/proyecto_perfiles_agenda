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
        
        public bool updateOtros( dynamic estudiante_obj, dynamic titulcion_otros_obj, dynamic defensa_externa_obj,List<dynamic> lista_detalle_defensa_obj)
        {
            try
            {
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
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
                //throw new ArgumentException("" + e);
            }

        }
        public void updateTesis(dynamic estudiante_obj, dynamic perfil_tesis_obj, dynamic defensa_externa_obj)
        {
            try
            {
                
                estudiante.Id = Convert.ToInt32(estudiante_obj.Id);
                estudiante.Registro = Convert.ToString(estudiante_obj.Registro);
                estudiante.Apellido = Convert.ToString(estudiante_obj.Apellido);
                estudiante.Nombre = Convert.ToString(estudiante_obj.Nombre);
                estudiante.Email = Convert.ToString(estudiante_obj.Email);

                estudiante.Telefono = Convert.ToString(estudiante_obj.Telefono);

                estudiante.Celular = Convert.ToString(estudiante_obj.Celular);
                estudiante.Id_carrera = Convert.ToInt32(estudiante_obj.Id_carrera);

                estudiante.Update(estudiante.Id);


                perfilTesis.Id = Convert.ToInt32(perfil_tesis_obj.Id);

                perfilTesis.Calificacion = Convert.ToDouble(perfil_tesis_obj.Calificacion);
                perfilTesis.Estado_defensa = perfilTesis.Calificacion > 0 ? "Defendido" : Convert.ToString(perfil_tesis_obj.Estado_defensa);
                perfilTesis.Estado = perfilTesis.Calificacion > 0 ? "Defendido" : Convert.ToString(perfil_tesis_obj.Estado);
                perfilTesis.Tema = Convert.ToString(perfil_tesis_obj.Tema);
                perfilTesis.Id_estudiante = Convert.ToInt32(perfil_tesis_obj.Id_estudiante);

                perfilTesis.Id_licenciado = Convert.ToInt32(perfil_tesis_obj.Id_licenciado);

                perfilTesis.Id_funcion_licenciado = Convert.ToInt32(perfil_tesis_obj.Id_funcion_licenciado);
                perfilTesis.Fecha_aprobacion_jefe_carrera = Convert.ToString(perfil_tesis_obj.Fecha_aprobacion_jefe_carrera);
                perfilTesis.Fecha_recepcion_titulacion = Convert.ToString(perfil_tesis_obj.Fecha_recepcion_titulacion);

                perfilTesis.Update(perfilTesis.Id);

               

                defensaExterna.Id = Convert.ToInt32(defensa_externa_obj.Id);
                defensaExterna.Fecha_presentacion = Convert.ToString(defensa_externa_obj.Fecha_presentacion);
                defensaExterna.Hora = Convert.ToString(defensa_externa_obj.Hora);

                defensaExterna.Aula = Convert.ToString(defensa_externa_obj.Aula);
                defensaExterna.Id_tesis = Convert.ToInt32(defensa_externa_obj.Id_tesis);

                defensaExterna.Update(defensaExterna.Id);


              



            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }

        }
        public void updateTesis(dynamic estudiante_obj, dynamic perfil_tesis_obj, dynamic defensa_externa_obj, List<dynamic> lista_detalle_defensa_obj)
        {
            try
            {
                
                estudiante.Id = Convert.ToInt32(estudiante_obj.Id);
                estudiante.Registro = Convert.ToString(estudiante_obj.Registro);
                estudiante.Apellido = Convert.ToString(estudiante_obj.Apellido);
                estudiante.Nombre = Convert.ToString(estudiante_obj.Nombre);
                estudiante.Email = Convert.ToString(estudiante_obj.Email);

                estudiante.Telefono = Convert.ToString(estudiante_obj.Telefono);

                estudiante.Celular = Convert.ToString(estudiante_obj.Celular);
                estudiante.Id_carrera = Convert.ToInt32(estudiante_obj.Id_carrera);

                estudiante.Update(estudiante.Id);


                perfilTesis.Id = Convert.ToInt32(perfil_tesis_obj.Id);

                perfilTesis.Calificacion = Convert.ToDouble(perfil_tesis_obj.Calificacion);
                perfilTesis.Estado_defensa = perfilTesis.Calificacion > 0 ? "Defendido" : Convert.ToString(perfil_tesis_obj.Estado_defensa);
                perfilTesis.Estado = perfilTesis.Calificacion > 0 ? "Defendido" : Convert.ToString(perfil_tesis_obj.Estado);
                perfilTesis.Tema = Convert.ToString(perfil_tesis_obj.Tema);
                perfilTesis.Id_estudiante = Convert.ToInt32(perfil_tesis_obj.Id_estudiante);

                perfilTesis.Id_licenciado= Convert.ToInt32(perfil_tesis_obj.Id_licenciado);

                perfilTesis.Id_funcion_licenciado = Convert.ToInt32(perfil_tesis_obj.Id_funcion_licenciado);
                perfilTesis.Fecha_aprobacion_jefe_carrera = Convert.ToString(perfil_tesis_obj.Fecha_aprobacion_jefe_carrera);
                perfilTesis.Fecha_recepcion_titulacion = Convert.ToString(perfil_tesis_obj.Fecha_recepcion_titulacion);

                perfilTesis.Update(perfilTesis.Id);

                defensaExterna.Id = Convert.ToInt32(defensa_externa_obj.Id);
                defensaExterna.Fecha_presentacion = Convert.ToString(defensa_externa_obj.Fecha_presentacion);
                defensaExterna.Hora = Convert.ToString(defensa_externa_obj.Hora);

                defensaExterna.Aula = Convert.ToString(defensa_externa_obj.Aula);
                defensaExterna.Id_tesis = Convert.ToInt32(defensa_externa_obj.Id_tesis);

                defensaExterna.Update(defensaExterna.Id);


                foreach (var item in lista_detalle_defensa_obj)
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
                throw new ArgumentException(e.Message);
            }

        }


    }
}
