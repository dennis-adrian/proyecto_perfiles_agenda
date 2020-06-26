using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class TipoTitulacionOtros: Conexion, IMetodos
    {
        public TipoTitulacionOtros()
        {
            id = 0;
            tipo = "";
            descripcion = "";
        }
        #region Atributos 
        private int id;
        private string tipo;
        private string descripcion;

        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

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
