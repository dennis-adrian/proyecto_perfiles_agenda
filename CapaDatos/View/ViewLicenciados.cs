using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.View
{
    public  class ViewLicenciados
    {
        Conexion obj = new Conexion();
        public ViewLicenciados()
        {
            id = 0;
            nombre = "";
            apellido = "";
            tipo = "";
            celular = "";
            email = "";

        }
        #region Atributos
        private int id;
        private string nombre;
        private string apellido;
        private string tipo;
        private string telefono;
        private string celular;
        private string email;
        #region Propiedades

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Email { get => email; set => email = value; }


        #endregion



        #endregion
        #region Metodos

        public DataTable Select()
        {
            string sql = " SELECT * FROM ViewLicenciados ; ";
            return obj.SelectConexion(sql);
        }
        #endregion
    }

}
