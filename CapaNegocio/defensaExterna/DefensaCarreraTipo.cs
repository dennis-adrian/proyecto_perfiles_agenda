using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.defensaExterna
{
    public class DefensaCarreraTipo : Index, IDefensa
    {
        public List<dynamic> defensas(string tipo = null, string estudiante = null, string carrera = null)
        {
            List<dynamic> lista_defensa = new List<dynamic>();
            var tabla = viewDefensasCarrera.Select(carrera,tipo);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dynamic obj = new ExpandoObject();
                obj.Id = tabla.Rows[i][0].ToString();
                obj.Fecha_Defensa = tabla.Rows[i][1].ToString();
                obj.Hora = tabla.Rows[i][2].ToString();
                obj.Aula = tabla.Rows[i][3].ToString();
                obj.Tipo = tabla.Rows[i][4].ToString();
                obj.Tema = tabla.Rows[i][5].ToString();
                obj.Registro = tabla.Rows[i][6].ToString();
                obj.Estudiante = tabla.Rows[i][7].ToString();
                lista_defensa.Add(obj);
            }
            return lista_defensa;
        }
    }
}
