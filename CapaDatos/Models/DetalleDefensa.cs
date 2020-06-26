using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class DetalleDefensa : Conexion, IMetodos
    {
        public DetalleDefensa()
        {
            id = 0;
            id_defensa_externa = 0;
            id_licenciado = 0;
            id_tipo_licenciado = 0;


        }
        #region Atributos 
        private int id;
        private int id_defensa_externa;
        private int id_licenciado;
        private int id_tipo_licenciado;

        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public int Id_defensa_externa { get => id_defensa_externa; set => id_defensa_externa = value; }
        public int Id_licenciado { get => id_licenciado; set => id_licenciado = value; }
        public int Id_tipo_licenciado { get => id_tipo_licenciado; set => id_tipo_licenciado = value; }

        #endregion
        #region Metodos 

        public void Insert()
        {

        }
        public void Delete()
        {

        }
        public void Update()
        {

        }
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            return dt;

        }

        #endregion
    }
}
