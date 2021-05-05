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

        private string texto1;//sin  acentos y ñ

        private string texto2;//con acentos y ñ



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
                if (Regex.IsMatch(value, @"^[0-9a-zA-Z]{5,10}$"))
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
                //N400
                //E500
                //S521
                //N-E-S->512
                //



                if (Regex.IsMatch(value, @"^[NESO][0-9]{1,4}$"))
                {
                    this.aula = value;
                }
                else
                {
                    throw new ArgumentException("ingrese un numero válido de aula sin guinoes eje. 'N500' ");
                }


            }
        }

        public string Fecha
        {
            get { return fecha; }
            set
            {
                if (Regex.IsMatch(value, @"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$"))
                {
                    this.fecha = value;
                }
                else
                {
                    throw new ArgumentException("datos de fecha invalidos o tiene el formato incorrecto");
                }
            }
        }

        public string Texto1
        {
            get { return texto1; }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z ]*$"))
                {
                    this.texto1 = value;
                }
                else
                {
                    throw new ArgumentException("datos invalidos solo aceptan letras");
                }
            }
        }
        public string Texto2
        {
            get { return texto2; }
            set
            {
                //if (Regex.IsMatch(value, @"^[a-zA-ZÀ-ÿ\u00f1\u00d1\u00E0-\u00FC ]*$"))
                //{
                //    this.texto2 = value;
                //}
                //else
                //{
                //    throw new ArgumentException("datos invalidos solo aceptan letras");
                //}
                this.texto2 = value;
            }
        }

        #endregion

    }
}
