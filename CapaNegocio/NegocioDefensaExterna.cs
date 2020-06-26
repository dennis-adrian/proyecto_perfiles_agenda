using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;
using CapaDatos;

namespace CapaNegocio
{
    public class NegocioDefensaExterna
    {
        DefensaExterna defensaExterna = new DefensaExterna();
        Vistas vistas = new Vistas();
        public NegocioDefensaExterna()
        {

        }
        #region FrmDefensaExterna

        public DataTable Defensas()
        {
            return vistas.ViewDefensas();

        }



        #endregion
    }
}
