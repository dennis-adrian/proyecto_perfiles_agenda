using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.defensaExterna.defensaGeneral
{
    public class Main 
    {
        CapaDatos.View.DaoDefensas dao = new CapaDatos.View.DaoDefensas();
    


        private string tipo;
        private string estudiante;
        private string id_estudiante;
        private string carrera;


        public Main()
        {        
            tipo = "";
            estudiante = "";
            id_estudiante = "";
            carrera = null;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public string Estudiante { get => estudiante; set => estudiante = value; }
        public string Id_estudiante { get => id_estudiante; set => id_estudiante = value; }
        public string Carrera { get => carrera; set => carrera = value; }


        public List<dynamic> defensas()
        {
            List<dynamic> lista_defensa = new List<dynamic>();
            var tabla = dao.getDenfensas();
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
            var tabla = dao.getDenfensasTipo(Tipo);
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
            var tabla = dao.getDenfensaEstudiante(estudiante:Estudiante);
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
            var tabla = dao.getDenfensasTipoEstudiante(tipo:Tipo, estudiante: Estudiante);
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
            var tabla = dao.getDenfensasCarrera(carrera:Carrera);
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
            var tabla = dao.getDenfensasCarreraTipo(carrera:Carrera,tipo:Tipo);
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
            var tabla = dao.getDenfensasCarreraEstudiante(carrera: Carrera, estudiante: Estudiante);
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
            var tabla = dao.getDenfensasCarreraTipoEstudiante(carrera: Carrera, estudiante: Estudiante,tipo:Tipo);
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


        ~Main()
        {

        }
    }
}
