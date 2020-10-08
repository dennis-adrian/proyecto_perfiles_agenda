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

  
        public DataTable Select(string carrera, string tipo = null, string estudiante = null)
        {
            string sql = "";
            if (estudiante == null && tipo == null)
            {
                sql = $" SELECT * FROM ViewDefensas where Carrera Like '%{carrera}%'  ; ";
            }
            else if (estudiante != null && tipo == null)
            {
                sql = $" SELECT * FROM ViewDefensas  WHERE Carrera = {carrera} and Estudiante LIKE '%{estudiante}%' ; ";
            }
            else if (estudiante == null && tipo != null)
            {
                sql = $" select * from ViewDefensas WHERE Carrera = {carrera} and Tipo = {tipo} ;";
            }
            else
            {
                sql = $" select * from ViewDefensas WHERE Carrera = {carrera} and Tipo = {tipo} and Estudiante LIKE '%{estudiante}%';";
            }

            return obj.SelectConexion(sql);
        }

        #endregion
    }
}
