using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class Facultad: Conexion, IMetodos
    {
        public Facultad()
        {
            id = 0;
            nombre = "";
        }
        #region Atributos 
        private int id;
        private string nombre;


        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }


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
        public  DataTable Select()
        {
            DataTable dt = new DataTable();
            return dt;

        }


        #endregion

    }
}
