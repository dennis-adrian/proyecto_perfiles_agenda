using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.notificaciones
{
    public class perfilNotificacion:Index
    {
        public perfilNotificacion()
        {

        }
        public struct perfil
        {
            #region Atributos


            private int id;
            private string fecha_recepcion;
            private string fecha_aprobacion;
            private string fecha_vencimiento;

            #endregion

            #region Propiedades

            public int Id { get => id; set => id = value; }
            public string Fecha_recepcion { get => fecha_recepcion; set => fecha_recepcion = value; }
            public string Fecha_aprobacion { get => fecha_aprobacion; set => fecha_aprobacion = value; }
            public string Fecha_vencimiento { get => fecha_vencimiento; set => fecha_vencimiento = value; }

            #endregion

            #region Constructor
            public perfil(int id,string fecha_recepcion,  string fecha_aprobacion, string fecha_vencimiento)
            {
                this.id = id;
                this.fecha_recepcion = fecha_recepcion;
                this.fecha_aprobacion = fecha_aprobacion;
                this.fecha_vencimiento = fecha_vencimiento;

            }
            #endregion
        }

        Dictionary<string, string> titulo = new Dictionary<string, string>()
        {
            ["critical"] = "titulo de estado critico o alerta",
            ["important"] = "titulo de estado importante",
            ["normal"] = "normal",
            ["low"] = "titulo de prioridad baja"
        };
        Dictionary<string, string> msg = new Dictionary<string, string>()
        {
            ["critical"] = "msg 1",
            ["important"] = "msg 2 ",
            ["normal"] = "msg 3",
            ["low"] = "msg de prioridad baja"
        };
        List<perfil> list_perfil = new List<perfil>();

        public void dataPerfil(string tabla)
        {

            var dt = notificacion.getData(tabla);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                int id = Convert.ToInt32(dt.Rows[i]["id"]);

                string fec_recepcion= Convert.ToString(dt.Rows[i]["fecha_recepcion_titulacion"]);


                string fec_aprobacion = Convert.ToString(dt.Rows[i]["fecha_aprobacion_jefe_carrera"]);

                string fec_vencimiento = "";


                perfil obj = new perfil(id:id,fecha_recepcion:fec_recepcion,fecha_aprobacion:fec_aprobacion,fecha_vencimiento:fec_vencimiento);

                list_perfil.Add(obj);
            }

            
        }

        public void dataNotificaciones()
        {

        }

        public void main()
        {
            foreach(var pf in list_perfil)
            {
                string prioridad = determinarPrioridad(pf.Fecha_recepcion,pf.Fecha_vencimiento);
                if(prioridad == "nothing")
                {
                    createNotification(titulo[prioridad], msg[prioridad], getDateNow(), getHourNow(), 0, prioridad, "perfil", pf.Id);

                }

            }
        }
        
    }
    
}
