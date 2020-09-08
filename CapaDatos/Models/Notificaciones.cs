using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class Notificaciones : Conexion
    {
        public Notificaciones()
        {

        }
        #region Atributos
        private int id;
        private string tipo_notificacion;
        private string fecha;
        private string hora;
        private string titulo;
        private string texto;
        private string estado; //unread or read


        #endregion
        #region Metodos
        public void getNewNotifications()
        {


        }
        public void loadNotifications()
        {

        }
        public void AllNotifications()
        {

        }
        #endregion

    }
}
