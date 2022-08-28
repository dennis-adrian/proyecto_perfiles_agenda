using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Structures
{
    public struct ByPassDefensa
    {
        private int id_defensa;
        private int id_tesis;
        public ByPassDefensa(int id_defensa, int id_tesis)
        {
            this.id_defensa = id_defensa;
            this.id_tesis = id_tesis;
        }

        public int Id_defensa { get => id_defensa; set => id_defensa = value; }
        public int Id_tesis { get => id_tesis; set => id_tesis = value; }
    }
}
