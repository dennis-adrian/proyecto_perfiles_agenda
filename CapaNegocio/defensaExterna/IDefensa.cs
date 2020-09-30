using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.defensaExterna
{
    public interface IDefensa
    {
        List<dynamic> defensas(string tipo = null, string estudiante = null, string carrera=null);

    }
}
