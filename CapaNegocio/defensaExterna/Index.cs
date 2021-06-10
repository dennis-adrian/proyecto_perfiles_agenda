using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.defensaExterna
{
    public class Index
    {

        CapaDatos.View.DaoDefensas dao = new CapaDatos.View.DaoDefensas();
        public struct DefensaStruct
        {

            int id;
            string fecha_Defensa;
            string hora;
            string aula;
            string tipo;
            string tema;
            string registro;
            string estudiante;
            string carrera;
            string facultad;

            public DefensaStruct(int id, string fecha_Defensa, string hora, string aula, string tipo, string tema, string registro, string estudiante, string carrera, string facultad)
            {
                this.id = id;
                this.fecha_Defensa = fecha_Defensa;
                this.hora = hora;
                this.aula = aula;
                this.tipo = tipo;
                this.tema = tema;
                this.registro = registro;
                this.estudiante = estudiante;
                this.carrera = carrera;
                this.facultad = facultad;
            }

            public int Id { get => id; set => id = value; }
            public string Fecha_Defensa { get => fecha_Defensa; set => fecha_Defensa = value; }
            public string Hora { get => hora; set => hora = value; }
            public string Aula { get => aula; set => aula = value; }
            public string Tipo { get => tipo; set => tipo = value; }
            public string Tema { get => tema; set => tema = value; }
            public string Registro { get => registro; set => registro = value; }
            public string Estudiante { get => estudiante; set => estudiante = value; }
            public string Carrera { get => carrera; set => carrera = value; }
            public string Facultad { get => facultad; set => facultad = value; }
        }

        Dictionary<string, string> tiposConsulta = new Dictionary<string, string>();
        public List<DefensaStruct> getDefensas(CapaDatos.View.DaoDefensas dao)
        {

            List<DefensaStruct> defensas = new List<DefensaStruct>();
            var tabla = dao.getDenfensas(dao.Key);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DefensaStruct obj = new DefensaStruct();
                obj.Id = Convert.ToInt32(tabla.Rows[i][0].ToString());
                obj.Fecha_Defensa = tabla.Rows[i][1].ToString();
                obj.Hora = tabla.Rows[i][2].ToString();
                obj.Aula = tabla.Rows[i][3].ToString();
                obj.Tipo = tabla.Rows[i][4].ToString();
                obj.Tema = tabla.Rows[i][5].ToString();
                obj.Registro = tabla.Rows[i][6].ToString();
                obj.Estudiante = tabla.Rows[i][7].ToString();
                obj.Carrera = tabla.Rows[i][8].ToString();
                obj.Facultad = tabla.Rows[i][9].ToString();
                defensas.Add(obj);
            }
            return defensas;

        }
    }
}
