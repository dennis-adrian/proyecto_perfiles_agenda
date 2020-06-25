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

        }

        #region Atributos 

        private int id;
        private int id_revision;
        private int id_licenciado;



        #endregion
        #region Propiedades 
        public int Id { get => id; set => id = value; }
        public int Id_revision { get => id_revision; set => id_revision = value; }
        public int Id_licenciado { get => id_licenciado; set => id_licenciado = value; }


        #endregion
        #region Metodos 

        #endregion
    }
}
