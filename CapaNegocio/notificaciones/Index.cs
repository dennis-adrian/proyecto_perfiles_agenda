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
        #region Structs
        public struct perfil
        {
            #region Atributos
            private int id;
            private string fecha_recepcion;
            private string fecha_aprobacion;
            private string fecha_limite;


            #endregion

            #region Propiedades

            public int Id { get => id; set => id = value; }
            public string Fecha_recepcion { get => fecha_recepcion; set => fecha_recepcion = value; }
            public string Fecha_aprobacion { get => fecha_aprobacion; set => fecha_aprobacion = value; }
            public string Fecha_limite { get => fecha_limite; set => fecha_limite = value; }

            #endregion

            #region Constructor
            public perfil(int id, string fecha_recepcion, string fecha_aprobacion, string fecha_limite)
            {
                this.id = id;
                this.fecha_recepcion = fecha_recepcion;
                this.fecha_aprobacion = fecha_aprobacion;
                this.fecha_limite = fecha_limite;

            }
            #endregion
        }
        public struct revision
        {
            #region Atributos


            #endregion

            #region Propiedades


            #endregion

            #region Constructor
            #endregion
        }


        #endregion


        #region Atributos
        protected Notificacion notificacion;


        Dictionary<string, string> title_perfil = new Dictionary<string, string>()
        {
            ["critical"] = "titulo de estado critico o alerta",
            ["important"] = "titulo de estado importante",
            ["normal"] = "normal",
            ["low"] = "titulo de prioridad baja",
            ["time-out"]="tiempo muerto"
        };
        Dictionary<string, string> message_perfil = new Dictionary<string, string>()
        {
            ["critical"] = "msg 1",
            ["important"] = "msg 2 ",
            ["normal"] = "msg 3",
            ["low"] = "msg de prioridad baja",

            ["time-out"] = "tiempo muerto"
        };
        Dictionary<string, string> title_revision = new Dictionary<string, string>()
        {
            ["critical"] = "titulo de estado critico o alerta",
            ["important"] = "titulo de estado importante",
            ["normal"] = "normal",
            ["low"] = "titulo de prioridad baja"
        };
        Dictionary<string, string> message_revision = new Dictionary<string, string>()
        {
            ["critical"] = "msg 1",
            ["important"] = "msg 2 ",
            ["normal"] = "msg 3",
            ["low"] = "msg de prioridad baja"
        };
        List<perfil> list_perfil = new List<perfil>();
        List<revision> list_revision = new List<revision>();


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

            TimeSpan rango_inicial = fecha_final - fecha_inicio;

            TimeSpan rango_actual = fecha_actual - fecha_inicio;

            int diff = rango_inicial.Days - rango_actual.Days;

            if (diff > 25)
            {
                return "nothing";

            } else if (diff <= 25 && diff > 15)
            {

                return "low";
            }
            else if (diff <= 15 && diff > 10)
            {

                return "normal";
            }
            else if (diff <= 10 && diff > 5)
            {
                return "important";
            }
            else if (diff <= 5 && diff > 0)
            {
                return "critical";
            }
            else
            {
                return "time-out";
            }


        }

        public List<Notificacion> notificaciones(string tipo = "unread")
        {
            List<Notificacion> list = new List<Notificacion>();
            var nt = tipo == "read" ? notificacion.findRead()
                    : tipo == "all" ? notificacion.find()
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

        public bool markAsRead(int id_notificacion)
        {
            try
            {
                notificacion.updateLeido(id_notificacion);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public void dataPerfil()
        {
            var dt = notificacion.getData("perfil_tesis");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = Convert.ToInt32(dt.Rows[i]["id"]);
                string fec_recepcion = Convert.ToString(dt.Rows[i]["fecha_recepcion_titulacion"]);
                string fec_aprobacion = Convert.ToString(dt.Rows[i]["fecha_aprobacion_jefe_carrera"]);
                string fec_limite = Convert.ToString(dt.Rows[i]["fecha_limite"]);

                perfil obj = new perfil(id: id, fecha_recepcion: fec_recepcion, fecha_aprobacion: fec_aprobacion, fecha_limite: fec_limite);

                list_perfil.Add(obj);
            }


        }
        public async Task dataRevision()
        {
            await Task.Run(() => {

                var dt = notificacion.getData("revision");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //int id = Convert.ToInt32(dt.Rows[i]["id"]);
                    //string fec_recepcion = Convert.ToString(dt.Rows[i]["fecha_recepcion_titulacion"]);
                    //string fec_aprobacion = Convert.ToString(dt.Rows[i]["fecha_aprobacion_jefe_carrera"]);
                    //string fec_limite = Convert.ToString(dt.Rows[i]["fecha_limite"]);

                    //revision obj = new revision(id: id, fecha_recepcion: fec_recepcion, fecha_aprobacion: fec_aprobacion, fecha_limite: fec_limite);

                    //list_revision.Add(obj);
                }
            });


        }

        public void setDataFromListPerfil()
        {
            var all_notificaciones = notificaciones("all");

            if (all_notificaciones.Count == 0)
            {
                foreach (var pf in list_perfil)
                {

                    string prioridad = determinarPrioridad(pf.Fecha_recepcion, pf.Fecha_limite);
                    if (prioridad != "nothing")
                    {

                        createNotification(title_perfil[prioridad], message_perfil[prioridad], getDateNow(), getHourNow(), 0, prioridad, "perfil", pf.Id);
                       
                    }

                }

            }
            else
            {
                foreach (var pf in list_perfil)
                {

                    string prioridad = determinarPrioridad(pf.Fecha_recepcion, pf.Fecha_limite);
                    if (prioridad != "nothing")
                    {
                        bool exist = notificacion.ifExistsNotificacion(prioridad, pf.Id, "perfil");
                        if (exist)
                        {
                            //do nothing
                        }
                        else
                        {

                            createNotification(title_perfil[prioridad], message_perfil[prioridad], getDateNow(), getHourNow(), 0, prioridad, "perfil", pf.Id);
                        }

                    }

                }
            }


        }
        public async Task setDataFromListRevision()
        {
            await Task.Run(() => {
                foreach (var rv in list_revision)
                {
                    //string prioridad = determinarPrioridad(pf.Fecha_recepcion, pf.Fecha_limite);
                    //if (prioridad != "nothing")
                    //{
                    //    createNotification(titulo[prioridad], msg[prioridad], getDateNow(), getHourNow(), 0, prioridad, "perfil", pf.Id);
                    //}

                }
            });
        }

        public void main()
        {
            dataPerfil();
            //await dataRevision();
            setDataFromListPerfil();
            //await setDataFromListRevision();
        }
        #endregion

        #region Destructor
        ~Index() { }
        #endregion
    }
}
