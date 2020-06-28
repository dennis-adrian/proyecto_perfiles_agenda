using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaNegocio.src
{
   public  class Email
    {

        private string direccion;
        public string Direccion
        {
            get { return direccion; }

            set
            {
                if (Regex.IsMatch(value, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$"))
                {

                    this.direccion = value;

                }
                else
                {
                    throw new ArgumentException("la direccion de correo es invalida ");
                }
            }
        }
    }
}

