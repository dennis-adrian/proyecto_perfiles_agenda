using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.defensaExterna
{
    public abstract class DefensaFactory
    {
        public abstract IDefensa GetDefensas(string type);
    }
}
