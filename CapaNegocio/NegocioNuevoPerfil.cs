﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;
using CapaNegocio.src;

namespace CapaNegocio
{
    public class NegocioNuevoPerfil : ValidationInputUI
    {

        #region Construct

        public NegocioNuevoPerfil()
        {

        }
        #endregion

        #region Instancias
        PerfilTesis perfilTesis = new PerfilTesis();
        Estudiante estudiante = new Estudiante();
        Carrera carrera = new Carrera();
        FuncionLicenciado funcionLicenciado = new FuncionLicenciado();
        DataTypes type = new DataTypes();
        #endregion

        #region Atributos

        Object[] parametros;
        #endregion

        #region Metodos
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
                NuevoPerfil(parametros);
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

                type.Celular = Convert.ToString(Collection[5]);
                estudiante.Celular = type.Celular;

                estudiante.Id_carrera = Convert.ToInt32(Collection[6]);

                type.Texto2 = Convert.ToString(Collection[7]);//input
                perfilTesis.Tema = type.Texto2;

                perfilTesis.Estado = "En Recepcion";

                type.Fecha = Convert.ToString(Collection[8]);//input
                perfilTesis.Fecha_aprobacion_jefe_carrera = type.Fecha;

                type.Fecha = Convert.ToString(Collection[9]);//input
                perfilTesis.Fecha_recepcion_titulacion = type.Fecha;

                perfilTesis.Estado_defensa = "Sin Asignar";
                perfilTesis.Calificacion = 0;
                

                perfilTesis.Id_licenciado = Convert.ToInt32(Collection[10]);//input

                estudiante.Insert();
                int id = estudiante.LastId();
                perfilTesis.Id_estudiante = id;
                int id_funcion = funcionLicenciado.FindIdBySearch("Tutor");//Convert.ToInt32(funcionLicenciado.Select("Tutor").Rows[1][1].ToString());
                perfilTesis.Id_funcion_licenciado = id_funcion;
                perfilTesis.Insert();
                
                                                          
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

        public Object[] InitialForms()
        {
             Object[] collection = new Object[] { 1 };
            return collection;
        }
        
        #endregion

        #region Destruct

        ~NegocioNuevoPerfil()
        {

        }


        #endregion


    }
}
