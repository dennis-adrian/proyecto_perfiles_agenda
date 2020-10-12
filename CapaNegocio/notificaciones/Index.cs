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
    public class Index : CapaDatos.Models.Notificacion
    {

        public Index()
        {
        }
        /*
            P1	Critical 5 days
            P2	Important 10 days
            P3	Normal 15 days
            P4	Low	25 days

             */

        List<Dictionary<int, string>> list_fecha_recepecion = new List<Dictionary<int, string>>();
        List<int> id_perfil_notificaciones = new List<int>();


        private void dataPerfilTesis()
        {
            var pf = getPerfilTesis();

            for (int i = 0; i < pf.Rows.Count; i++)
            {
                Dictionary<int, string> perfil = new Dictionary<int, string>();
                int key = Convert.ToInt32(pf.Rows[i]["id"].ToString());
                string value = pf.Rows[i]["fecha_recepcion_titulacion"].ToString();


                perfil.Add(key, value);
                list_fecha_recepecion.Add(perfil);

            }


        }

        private void setIdPerfilNotificaciones()
        {
            var cursor = getNotificaciones();
            for (int i = 0; i < cursor.Rows.Count; i++)
            {
                int id = Convert.ToInt32(cursor.Rows[i]["id_perfil"].ToString());
                id_perfil_notificaciones.Add(id);
            }

        }


        private string determinarPrioridad(string input_fec)
        {
            
            string dateString = input_fec;
            string format = "dd-MM-yyyy";
            DateTime oldDate = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);
            DateTime newDate = DateTime.Now;
            TimeSpan ts = newDate - oldDate;
            int diff = 364 - (ts.Days);
            if (diff <= 5)
            {
                return "critical";
            }
            else if (diff <= 10)
            {

                return "important";
            }

            else if (diff <= 15)
            {
                return "normal";

            }
            else if (diff <= 25)
            {

                return "low";
            }
            else
            {
                return "nothing";
            }

        }




        public void main()
        {
            dataPerfilTesis();
            setIdPerfilNotificaciones();

            revisar();
        }
        
        private void revisar()
        {
            foreach (var dic in list_fecha_recepecion)
            {
                foreach (var item in dic)
                {
                    int key = item.Key;
                    if (id_perfil_notificaciones.Contains(key))
                    {

                    }
                    else
                    {
                        string prioridad = determinarPrioridad(item.Value);
                        if(prioridad == "nothing")
                        {

                        }
                        else
                        {
                            CreateNewNotificacion
                            (
                                perfil_titulo[prioridad],
                                perfil_msg[prioridad],
                                getDateNow(), 
                                getHourNow(), 
                                0, 
                                prioridad, 
                                "perfil", 
                                key
                            );
                        }
                        
                    }
                }
            }
        }

        

        Dictionary<string, string> perfil_titulo = new Dictionary<string, string>()
        {
            ["critical"] = "titulo de estado critico o alerta",
            ["important"] = "titulo de estado importante",
            ["normal"] = "normal",
            ["low"] = "titulo de prioridad baja"
        };
        Dictionary<string, string> perfil_msg = new Dictionary<string, string>()
        {
            ["critical"] = "msg 1",
            ["important"] = "msg 2 ",
            ["normal"] = "msg 3",
            ["low"] = "msg de prioridad baja"
        };

        string getDateNow()
        {
            return DateTime.Now.ToString("dd-MM-yyyy");
        }
        string getHourNow()
        {

            return DateTime.Now.ToString("HH:mm");
        }
        public void CreateNewNotificacion(string tit,string msg,string fec,string hor,int lei, string pri,string tip,int idp)
        {
            Titulo = tit;
            Mensaje = msg;
            Fecha = fec;
            Hora = hor;
            Leido = lei;
            Prioridad = pri;
            Tipo = tip;
            Id_perfil = idp;
            Insert();
        }




        public List<Notificacion> notificaciones()
        {
            List<Notificacion> list = new List<Notificacion>();

            var nt = getNotificaciones();
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



    }
}
