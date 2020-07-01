using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;
using CapaNegocio.src;

namespace CapaNegocio
{
    public class NegocioNuevoPerfil : ValidationInputUI
    {
        PerfilTesis perfilTesis = new PerfilTesis();
        Estudiante estudiante = new Estudiante();
        FuncionLicenciado funcionLicenciado = new FuncionLicenciado();
        DataTypes type = new DataTypes();

        Object[] parametros; 
        
        public NegocioNuevoPerfil()
        {

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
        public void Main()
        {
            try
            {
                NuevoEstudiante(parametros);
                NuevoPerfil(parametros);
            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }
           

        }
        public void NuevoEstudiante(Object[] Collection)
        {
            try
            {
                type.Registro = Convert.ToString(Collection[0]);
                estudiante.Registro = type.Registro;

                type.Texto = Convert.ToString(Collection[1]);
                estudiante.Nombre = type.Texto;

                type.Texto = Convert.ToString(Collection[2]);
                estudiante.Apellido = type.Texto;

                type.Email = Convert.ToString(Collection[3]);
                estudiante.Email = type.Email;

                type.Telefono = Convert.ToString(Collection[4]);
                estudiante.Telefono = type.Telefono;

                type.Celular = Convert.ToString(Collection[5]);
                estudiante.Celular = type.Celular;

                estudiante.Id_carrera = Convert.ToInt32(Collection[6]);


                estudiante.Insert();
                                                          
            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }
        }
        public void NuevoPerfil(Object[] Collection)
        {
            try
            {

                int id = estudiante.LastId();

                int id_funcion = 2;//Convert.ToInt32(funcionLicenciado.Select("Tutor").Rows[1][1].ToString());



                
                type.Texto = Convert.ToString(Collection[7]);//input
                perfilTesis.Tema = type.Texto;

                perfilTesis.Estado = "En Recepcion";

                type.Fecha = Convert.ToString(Collection[8]);//input
                perfilTesis.Fecha_aprobacion_jefe_carrera = type.Fecha;

                type.Fecha = Convert.ToString(Collection[9]);//input
                perfilTesis.Fecha_recepcion_titulacion = type.Fecha;

                perfilTesis.Estado_defensa = "Sin Asignar";
                perfilTesis.Calificacion = 0;
                perfilTesis.Id_estudiante = id;

                perfilTesis.Id_licenciado = Convert.ToInt32(Collection[10]);//input
                perfilTesis.Id_funcion_licenciado = id_funcion;

                perfilTesis.Insert();
                                                                                 

            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }

        }


    }
}
