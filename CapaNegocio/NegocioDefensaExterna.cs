using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;

namespace CapaNegocio
{
    public class NegocioDefensaExterna
    {
        DefensaExterna defensaExterna = new DefensaExterna();
        public NegocioDefensaExterna()
        {

        }
        #region FrmDefensaExterna

        public DataTable Defensas()
        {
            return defensaExterna.MostrarAgendas();
        }

        #endregion
    }
}
