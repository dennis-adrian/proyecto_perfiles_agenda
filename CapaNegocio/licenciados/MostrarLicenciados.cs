using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.licenciados
{
    public class MostrarLicenciados : Index
    {
        public MostrarLicenciados()
        {
        }
        
        //public List<ViewLicenciados> Licenciados()
        //{
        //    List<ViewLicenciados> ListaLicenciados = new List<ViewLicenciados>();
        //    DataTable tabla = viewlicenciados.Select();


        //    for (int i = 0; i < tabla.Rows.Count; i++)
        //    {
        //        ListaLicenciados.Add(new ViewLicenciados()
        //        {
        //            Id = Convert.ToInt32(tabla.Rows[i][0].ToString()),
        //            Nombre = tabla.Rows[i][1].ToString(),
        //            Apellido = tabla.Rows[i][2].ToString(),
        //            Tipo = tabla.Rows[i][3].ToString(),
        //            Telefono = tabla.Rows[i][4].ToString(),
        //            Celular = tabla.Rows[i][5].ToString(),
        //            Email = tabla.Rows[i][6].ToString()
        //        });

        //    }

        //    return ListaLicenciados;

        //}
    }
}
