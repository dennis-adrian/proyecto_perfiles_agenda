using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.licenciados
{
    public class AgregarLicenciado : Index
    {
        public AgregarLicenciado() : base()
        {
        }

        public void main(Object[] Collection)
        {

            try
            {
                type.Texto2 = Convert.ToString(Collection[0]);
                licenciado.Nombre = type.Texto2;

                type.Texto2 = Convert.ToString(Collection[1]);
                licenciado.Apellido = type.Texto2;


                string des = Convert.ToString(Collection[2]);
                licenciado.Descripcion = (des == "") ? "" : des;


                type.Email = Convert.ToString(Collection[3]);
                licenciado.Email = type.Email;

                string tel = Convert.ToString(Collection[4]);
                licenciado.Telefono = (tel == "") ? "" : tel;

                string cel = Convert.ToString(Collection[5]);
                licenciado.Celular = (cel == "") ? "" : cel;

                type.Texto1 = Convert.ToString(Collection[6]);
                licenciado.Tipo = type.Texto1;


                licenciado.Docente = Convert.ToInt32(Collection[7]);

                licenciado.Id_institucion_representada = Convert.ToInt32(Collection[8]);

                licenciado.Id_carrera_licenciado = Convert.ToInt32(Collection[9]);

                licenciado.Insert();


            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e.Message);
            }
        }
        ~AgregarLicenciado()
        {

        }


    }
}
