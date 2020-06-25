using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class DefensaExterna : Conexion
    {
        public DefensaExterna()
        {
            id = 0;
            fecha_presentacion = "";
            hora = "";
            aula = "";
            id_tesis = 0;
            id_titulacion_otro = 0;
        }
        #region Atributos 
        private int id;
        private string fecha_presentacion;
        private string hora;
        private string aula;
        private int id_tesis;
        private int id_titulacion_otro;

        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public string Fecha_presentacion { get => fecha_presentacion; set => fecha_presentacion = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Aula { get => aula; set => aula = value; }
        public int Id_tesis { get => id_tesis; set => id_tesis = value; }
        public int Id_titulacion_otro { get => id_titulacion_otro; set => id_titulacion_otro = value; }

        #endregion
        #region Metodos 


        #endregion
    }
}
