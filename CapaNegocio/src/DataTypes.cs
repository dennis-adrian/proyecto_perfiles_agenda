using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaNegocio.src
{
    public class DataTypes
    {
       
        #region Atributos
        private string email;
        private string telefono;
        private string celular;

        private string registro;

        private string aula;

        private string fecha;

        private string texto;



        #endregion


        #region Propiedades
        public string Email
        {
            get { return email; }

            set
            {
                if (Regex.IsMatch(value, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$"))
                {

                    this.email = value;

                }
                else
                {
                    throw new ArgumentException("la direccion de correo es invalida ");
                }
            }
        }

        public string Telefono 
        {
            get { return telefono; }
            set
            {
                if (Regex.IsMatch(value, @"^[0-9]{6,11}$"))
                {
                    this.telefono = value;
                }
                else
                {
                    throw new ArgumentException("ingrese un numero valido de telefono");
                }
            }
               
        }

        public string Celular
        {
            get { return celular; }
            set
            {


                if (Regex.IsMatch(value, @"^[0-9]{6,11}$"))
                {
                    this.celular = value;
                }
                else
                {
                    throw new ArgumentException("ingrese un número valido de Celular");
                }


            }
        }

        public string Registro 
        {
            get { return registro; }

            set
            {


                if (Regex.IsMatch(value, @"^[0-9a-zA-Z]{6,10}$"))
                {
                    this.registro = value;
                }
                else
                {
                    throw new ArgumentException("ingrese un número válido de Registro");
                }


            } 
        }

        public string Aula 
        {
            get { return aula; }

            set
            {


                if (Regex.IsMatch(value, @"^[NES][0-9]{1,4}$"))
                {
                    this.aula = value;
                }
                else
                {
                    throw new ArgumentException("ingrese un numero válido de Registro");
                }


            } 
        }

        public string Fecha
        {
            get { return fecha; }
            set
            {
                if(Regex.IsMatch(value, @"^([0 - 2][0 - 9] | 3[0 - 1])(\/| -)(0[1 - 9] | 1[0 - 2])\2(\d{ 4})$"))
                {
                    this.fecha = value;
                }
                else
                {
                    throw new ArgumentException("datos de fecha invalidos o tiene el formato incorrecto");
                }
            }
        }

        public string Texto
        {
            get { return texto; }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z ]*$"))
                {
                    this.texto = value;
                }
                else
                {
                    throw new ArgumentException("datos invalidos solo aceptan letras");
                }
            }
        }

        #endregion

    }
}
