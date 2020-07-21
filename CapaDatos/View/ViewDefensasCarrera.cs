using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.View
{
    public class ViewDefensasCarrera
    {
        Conexion obj = new Conexion();
        public ViewDefensasCarrera()
        {
            id = 0;
            fecha_Defensa = "";
            hora = "";
            aula = "";
            tipo = "";
            tema = "";
            registro = "";
            estudiante = "";
        }

        private int id;
        private string fecha_Defensa;
        private string hora;
        private string aula;
        private string tipo;
        private string tema;
        private string registro;
        private string estudiante;

        public int Id { get => id; set => id = value; }
        public string Fecha_Defensa { get => fecha_Defensa; set => fecha_Defensa = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Aula { get => aula; set => aula = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Tema { get => tema; set => tema = value; }
        public string Registro { get => registro; set => registro = value; }
        public string Estudiante { get => estudiante; set => estudiante = value; }





        #region Metodos

        public DataTable Select(string carrera)
        {
            string sql = " SELECT * FROM ViewDefensasCarrera where Carrera = @parametro0 ; ";
            return obj.SelectConexion(sql, carrera);
        }
        public DataTable Select(string carrera, string estudiante)
        {

            string sql = " SELECT * FROM ViewDefensasCarrera  where Carrera LIKE '%@parametro0%' and Estudiante LIKE '%@parametro1%' ; ";
            return obj.SelectConexion(sql, carrera, estudiante);

        }



        #endregion
    }
}
