using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.View;

namespace CapaNegocio.defensaExterna
{
    /// <summary>
    /// funcionalidad:
    /// 1:ver todas las defensas(general)
    /// 2:ver defensas por carrera(carrera)
    /// 3:filtro de tipo (general)
    /// 4:filtro de tipo (carrera)
    /// 5:filtro de estudiante(general)
    /// 6:filro de estudiante (carrera)
    /// 7:filro de tipo y estudiante(general)
    /// 8:filtro de tipo y estudiante (carrera)
    /// </summary>
    public class Index
    {
        public ViewDefensas viewDefensas;
        public ViewDefensasCarrera viewDefensasCarrera;
        public Index()
        {
            viewDefensas = new ViewDefensas();
            viewDefensasCarrera = new ViewDefensasCarrera();
        }
             

        ~Index(){ }
    }
}
