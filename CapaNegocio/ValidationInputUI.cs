using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ValidationInputUI
    {
        public ValidationInputUI()
        {

        }

        //
        public void ValidateInput(Object[] collection)
        {


            foreach (var item in collection)
            {

                Type doubleType = typeof(double);
                Type intType = typeof(int);
                Type stringType = typeof(string);
                Type charType = typeof(char);
                Type boolType = typeof(bool);

                if (item.GetType() == doubleType)
                {

                    Console.WriteLine(item.GetType());
                }
                else if(item.GetType() == intType)
                {

                    Console.WriteLine(item.GetType());
                }
                else if(item.GetType() == stringType)
                {
                    Console.WriteLine(item.GetType());
                }
                else if (item.GetType() == charType)
                {
                    Console.WriteLine(item.GetType());
                }
                else if (item.GetType() == boolType)
                {
                    Console.WriteLine(item.GetType());
                }
                else
                {
                    throw new ArgumentException("sin tipo de dato registrado");
                }


                
            }
        }

      
    }
}
