using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class DetalleRevision : Conexion
    {
        public DetalleRevision()
        {
            id = 0;
            id_revision = 0;
            id_licenciado = 0;
            id_tipo_licenciado = 0;

        }

        #region Atributos 

        private int id;
        private int id_revision;
        private int id_licenciado;
        private int id_tipo_licenciado;



        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public int Id_revision { get => id_revision; set => id_revision = value; }
        public int Id_licenciado { get => id_licenciado; set => id_licenciado = value; }
        public int Id_tipo_licenciado { get => id_tipo_licenciado; set => id_tipo_licenciado = value; }


        #endregion
        #region Metodos 

        #endregion
    }
}
