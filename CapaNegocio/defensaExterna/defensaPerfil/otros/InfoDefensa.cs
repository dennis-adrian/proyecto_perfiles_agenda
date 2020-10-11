using CapaNegocio.nuevoPerfil;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.defensaExterna.defensaPerfil.otros
{
    public class InfoDefensa:defensaPerfil.Index
    {

        public InfoDefensa() : base()
        {

        }


        public dynamic getInfoDefensaOtros(int iddefensa)
        {
            dynamic obj = new ExpandoObject();           

            var dt = defensaExterna.infoDefensaOtros(iddefensa);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                obj.Id = Convert.ToInt32(dt.Rows[i]["Id"].ToString());
                obj.Fecha_presentacion = dt.Rows[i]["Fecha_presentacion"].ToString();
                obj.Hora = dt.Rows[i]["Hora"].ToString();
                obj.Aula = dt.Rows[i]["Aula"].ToString();
                obj.Id_titulacion_otro = Convert.ToInt32(dt.Rows[i]["Id_titulacion_otro"].ToString());
                obj.Estado_defensa = dt.Rows[i]["Estado_defensa"].ToString();
                obj.Tema = dt.Rows[i]["Tema"].ToString();
                obj.Calificacion = Convert.ToDouble(dt.Rows[i]["Calificacion"].ToString());
                obj.Id_tipo_titulacion = Convert.ToInt32(dt.Rows[i]["Id_tipo_titulacion"].ToString());
                obj.Id_estudiante = Convert.ToInt32(dt.Rows[i]["Id_estudiante"].ToString());
                obj.Registro = dt.Rows[i]["Registro"].ToString();
                obj.Nombre = dt.Rows[i]["Nombre"].ToString();
                obj.Apellido = dt.Rows[i]["Apellido"].ToString();
                obj.Email = dt.Rows[i]["Email"].ToString();
                obj.Telefono = dt.Rows[i]["Telefono"].ToString();
                obj.Celular = dt.Rows[i]["Celular"].ToString();
                obj.Id_carrera = Convert.ToInt32(dt.Rows[i]["Id_carrera"].ToString());
                obj.Carrera = dt.Rows[i]["Carrera"].ToString();
            }
            
            return obj;
        }
        public dynamic getInfoDefensaTesis(int iddefensa)
        {

            dynamic obj = new ExpandoObject();
            var dt = defensaExterna.infoDefensaTesis(iddefensa);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                obj.Id = Convert.ToInt32(dt.Rows[i]["Id"].ToString());
                obj.Fecha_presentacion = dt.Rows[i]["Fecha_presentacion"].ToString();
                obj.Hora = dt.Rows[i]["Hora"].ToString();
                obj.Aula = dt.Rows[i]["Aula"].ToString();
                obj.Id_tesis = Convert.ToInt32(dt.Rows[i]["Id_tesis"].ToString());
                obj.Estado_defensa = dt.Rows[i]["Estado_defensa"].ToString();
                obj.Tema = dt.Rows[i]["Tema"].ToString();
                obj.Calificacion = Convert.ToDouble(dt.Rows[i]["Calificacion"].ToString());
                obj.Id_estudiante = Convert.ToInt32(dt.Rows[i]["Id_estudiante"].ToString());
                obj.Registro = dt.Rows[i]["Registro"].ToString();
                obj.Nombre = dt.Rows[i]["Nombre"].ToString();
                obj.Apellido = dt.Rows[i]["Apellido"].ToString();
                obj.Email = dt.Rows[i]["Email"].ToString();
                obj.Telefono = dt.Rows[i]["Telefono"].ToString();
                obj.Celular = dt.Rows[i]["Celular"].ToString();
                obj.Id_carrera = Convert.ToInt32(dt.Rows[i]["Id_carrera"].ToString());
                obj.Carrera = dt.Rows[i]["Carrera"].ToString();
            }

            return obj;
        }
        public List<dynamic> getLicenciadosDefensa(int id_defensa)
        {
            List<dynamic> licenciados = new List<dynamic>();
            var cursor = detalleDefensa.getLicenciadosDefensa(id_defensa);
            for (int i = 0; i < cursor.Rows.Count; i++)
            {
                dynamic obj = new ExpandoObject();
                obj.Id_detalle_defensa = Convert.ToInt32(cursor.Rows[i][0].ToString());
                obj.Id_defensa_externa = Convert.ToInt32(cursor.Rows[i][1].ToString());
                obj.Id_licenciado = Convert.ToInt32(cursor.Rows[i][2].ToString());
                obj.Nombre = cursor.Rows[i][3].ToString();
                obj.Apellido = cursor.Rows[i][4].ToString();
                obj.Id_funcion_licenciado = cursor.Rows[i][5].ToString();
                obj.Funcion = cursor.Rows[i][6].ToString();
                licenciados.Add(obj);
            }
            return licenciados;
        }


    }
}
