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
                    throw new ArgumentException("ingrese un numero valido de Celular");
                }


            }
        }



        #endregion

    }
}
