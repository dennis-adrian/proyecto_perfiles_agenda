using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.licenciados
{
    public class InfoLicenciado : Index
    {
        int id;
        public InfoLicenciado(int id)
        {
            this.id = id;
        }
        public Object[] main()
        {
            int Id = 0, Docente = 0, Id_institucion_representada = 0, Id_carrera_licenciado = 0;
            string Nombre = "", Apellido = "", Descripcion = "", Email = "", Telefono = "",Celular="",Tipo="";



            var dt = licenciado.FindById(id);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Id = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                Nombre = dt.Rows[i]["nombre"].ToString();
                Apellido = dt.Rows[i]["apellido"].ToString();
                Descripcion = dt.Rows[i]["descripcion"].ToString();
                Email = dt.Rows[i]["email"].ToString();
                Telefono = dt.Rows[i]["telefono"].ToString();
                Celular = dt.Rows[i]["celular"].ToString();
                Tipo = dt.Rows[i]["tipo"].ToString();
                Docente = Convert.ToInt32(dt.Rows[i]["docente"].ToString());
                Id_institucion_representada = Convert.ToInt32(dt.Rows[i]["id_institucion_representada"].ToString());
                Id_carrera_licenciado = Convert.ToInt32(dt.Rows[i]["id_carrera_licenciado"].ToString());


            }

            Object[] datos = new Object[] { 
                Id, 
                Nombre, 
                Apellido, 
                Descripcion, 
                Email, 
                Telefono, 
                Celular, 
                Tipo, 
                Docente, 
                Id_institucion_representada, 
                Id_carrera_licenciado 
            };

            return datos;



        }

    }
}
