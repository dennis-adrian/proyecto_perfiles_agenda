using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaNegocio.src
{
    public class Numero
    {
        private string telefono;

        private string celular;
        public string Telefono
        {
            get { return telefono; }
            set
            {
                    

                    if(Regex.IsMatch(value, @"^[0-9]{6,11}$"))
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

    }
}
