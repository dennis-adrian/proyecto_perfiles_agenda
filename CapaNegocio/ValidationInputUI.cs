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
                    if(item > 0)
                    {

                    }
                    else
                    {
                        throw new ArgumentException("el campo debe ser mayor a 0.0");
                    }

                    Console.WriteLine(item.GetType());
                }
                else if(item.GetType() == intType)
                {
                    if(item > 0)
                    {

                    }
                    else
                    {
                        throw new ArgumentException("el campo debe ser mayor a 0");
                    }

                    Console.WriteLine(item.GetType());
                }
                else if(item.GetType() == stringType)
                {
                    bool x = string.IsNullOrEmpty(item);
                    if(!x)
                    {


                    }
                    else
                    {
                        throw new ArgumentException("el campo esta vacio ");
                    }
                    //Console.WriteLine(item.GetType());
                }
                else if (item.GetType() == charType)
                {
                    //Console.WriteLine(item.GetType());
                }
                else if (item.GetType() == boolType)
                {
                    if(item)
                    {

                    }
                    else
                    {

                    }
                    //Console.WriteLine(item.GetType());
                }
                else
                {
                    throw new ArgumentException("sin tipo de dato registrado");
                }


                
            }
        }

      
    }
}
