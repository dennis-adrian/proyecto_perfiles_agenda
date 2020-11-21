using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;

namespace CapaNegocio.notificaciones
{

    /*
    P1	Critical 5 days
    P2	Important 10 days
    P3	Normal 15 days
    P4	Low	25 days
    */
    public class Index                                     
    {
        #region Atributos
        protected Notificacion notificacion;


        #endregion

        #region Constructor

        public Index()
        {
            notificacion = new Notificacion();
        }

        #endregion

        #region Metodos



        protected string getDateNow()
        {
            return DateTime.Now.ToString("dd-MM-yyyy");
        }
        protected string getHourNow()
        {
            return DateTime.Now.ToString("HH:mm");
        }
        protected bool createNotification(string titulo, string mensaje, string fecha, string hora, int leido, string prioridad, string tipo, int idp)
        {
            try
            {
                notificacion.Titulo = titulo;
                notificacion.Mensaje = mensaje;
                notificacion.Fecha = fecha;
                notificacion.Hora = hora;
                notificacion.Leido = leido;
                notificacion.Prioridad = prioridad;
                notificacion.Tipo = tipo;
                notificacion.Id_perfil = idp;
                notificacion.Insert();
                return true;

            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
                return false;
            }
        }

        public string determinarPrioridad(string inicio, string final)
        {

            string format = "dd-MM-yyyy";
            DateTime fecha_inicio = DateTime.ParseExact(inicio, format, CultureInfo.InvariantCulture);

            DateTime fecha_final = DateTime.ParseExact(final, format, CultureInfo.InvariantCulture);

            DateTime fecha_actual = DateTime.Now;

            TimeSpan rango_inicial =  fecha_final - fecha_inicio;

            TimeSpan rango_actual =  fecha_actual - fecha_inicio;

            int diff = rango_inicial.Days - rango_actual.Days; 


            //Console.WriteLine(fecha_inicio);
            //Console.WriteLine(fecha_final);
            //Console.WriteLine(fecha_actual);
            //Console.WriteLine(rango_actual.Days);
            //Console.WriteLine(rango_inicial.Days);
            //Console.WriteLine(diff);

            if (diff > 25)
            {
                return "nothing";

            }else if(diff <= 25 && diff > 15)
            {

                return "low";
            }
            else if(diff <=15 && diff > 10)
            {

                return "normal";
            }
            else if(diff <= 10 && diff > 5)
            {
                return "important";
            }
            else if (diff <= 5 && diff > 0)
            {
                return "critical";
            }
            else
            {
                return "time out";
            }


        }

        public List<Notificacion> notificaciones(string tipo="unread")
        {
            List<Notificacion> list = new List<Notificacion>();
            var nt = tipo == "read"? notificacion.findRead()
                    : tipo == "all"? notificacion.find() 
                    : notificacion.findUnread();

            for (int i = 0; i < nt.Rows.Count; i++)
            {
                Notificacion obj = new Notificacion();
                obj.Id = Convert.ToInt32(nt.Rows[i]["id"]);
                obj.Titulo = Convert.ToString(nt.Rows[i]["titulo"]);
                obj.Mensaje = Convert.ToString(nt.Rows[i]["mensaje"]);
                obj.Fecha = Convert.ToString(nt.Rows[i]["fecha"]);
                obj.Hora = Convert.ToString(nt.Rows[i]["hora"]);
                obj.Leido = Convert.ToInt32(nt.Rows[i]["leido"]);
                obj.Prioridad = Convert.ToString(nt.Rows[i]["prioridad"]);
                obj.Tipo = Convert.ToString(nt.Rows[i]["tipo"]);
                obj.Id_perfil = Convert.ToInt32(nt.Rows[i]["id_perfil"]);

                list.Add(obj);
            }
            return list;
        }

        public bool markAsRead(int id)
        {
            try
            {
                notificacion.updateLeido(id);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }


        #endregion
    }
}
