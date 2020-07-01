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
        public void Validation(Object[] collection)
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
                     double x = Convert.ToDouble(item);
                     if(x > 0)
                     {

                     }
                     else
                     {
                         throw new ArgumentException("el campo debe ser mayor a 0.0");
                     }


                 }
                 else if(item.GetType() == intType)
                 {
                     int x = Convert.ToInt32(item);
                     if (x > 0)
                     {

                     }
                     else
                     {
                         throw new ArgumentException("el campo debe ser mayor a 0");
                     }


                 }
                 else if(item.GetType() == stringType)
                 {
                     string s = Convert.ToString(item);
                     bool x = string.IsNullOrEmpty(s);
                     if(!x)
                     {


                     }
                     else
                     {
                         throw new ArgumentException("el campo esta vacio ");
                     }

                 }
                 else if (item.GetType() == charType)
                 {

                 }
                 else if (item.GetType() == boolType)
                 {


                 }
                 else
                 {
                     throw new ArgumentException("sin tipo de dato registrado");
                 }


                
            }

        }

      
    }
}
