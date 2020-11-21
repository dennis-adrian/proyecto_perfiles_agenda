using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.notificaciones
{
    public class revisionNotificacion
    {
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
    }
}
