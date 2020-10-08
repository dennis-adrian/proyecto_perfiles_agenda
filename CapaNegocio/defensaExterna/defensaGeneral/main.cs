using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.defensaExterna.defensaGeneral
{
    public class Main : Index
    {
        public Main()
        {

        }


        public List<dynamic> defensas()
        {
            List<dynamic> lista_defensa = new List<dynamic>();
            var tabla = viewDefensas.Select();
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
                obj.Carrera = tabla.Rows[i][8].ToString();
                obj.Facultad = tabla.Rows[i][9].ToString();
                lista_defensa.Add(obj);
            }
            return lista_defensa;
        }
        public List<dynamic> defensasTipo()
        {
            List<dynamic> lista_defensa = new List<dynamic>();
            var tabla = viewDefensas.Select(Tipo);
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
                obj.Carrera = tabla.Rows[i][8].ToString();
                obj.Facultad = tabla.Rows[i][9].ToString();
                lista_defensa.Add(obj);
            }
            return lista_defensa;
        }
        public List<dynamic> defensasEstudiante()
        {
            List<dynamic> lista_defensa = new List<dynamic>();
            var tabla = viewDefensas.Select(estudiante:Estudiante);
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
                obj.Carrera = tabla.Rows[i][8].ToString();
                obj.Facultad = tabla.Rows[i][9].ToString();
                lista_defensa.Add(obj);
            }
            return lista_defensa;
        }
        public List<dynamic> defensasTipoEstudiante()
        {
            List<dynamic> lista_defensa = new List<dynamic>();
            var tabla = viewDefensas.Select(tipo:Tipo, estudiante: Estudiante);
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
                obj.Carrera = tabla.Rows[i][8].ToString();
                obj.Facultad = tabla.Rows[i][9].ToString();
                lista_defensa.Add(obj);
            }
            return lista_defensa;
        }
        #region Carrera

        public List<dynamic> defensasCarrera()
        {
            List<dynamic> lista_defensa = new List<dynamic>();
            var tabla = viewDefensasCarrera.Select(Carrera);
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
        public List<dynamic> defensasCarreraTipo()
        {
            List<dynamic> lista_defensa = new List<dynamic>();
            var tabla = viewDefensasCarrera.Select(carrera:Carrera,tipo:Tipo);
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

        public List<dynamic> defensasCarreraEstudiante()
        {
            List<dynamic> lista_defensa = new List<dynamic>();
            var tabla = viewDefensasCarrera.Select(carrera: Carrera, estudiante: Estudiante);
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
        public List<dynamic> defensasCarreraTipoEstudiante()
        {
            List<dynamic> lista_defensa = new List<dynamic>();
            var tabla = viewDefensasCarrera.Select(carrera: Carrera, estudiante: Estudiante,tipo:Tipo);
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

        #endregion
    }
}
