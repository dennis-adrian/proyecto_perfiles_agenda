using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos.View;

namespace CapaPresentacion
{//comentario

    public partial class FrmAgenda : Form
    {
        NegocioDefensaExterna obj = new NegocioDefensaExterna();

        string carrera = null;
       
        public FrmAgenda(string criterio)
        {
            InitializeComponent();
            Inicializador(criterio);
            carrera = criterio;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        public void Inicializador(string criterio)
        {
            if(criterio == null)
            {
                var list = obj.Defensas();

                var bindingList = new BindingList<ViewDefensas>(list);
                var source = new BindingSource(bindingList, null);
                dtgDefensaExterna.DataSource = source;

            }
            else
            {
                var list2 = obj.DefensasCarrera(criterio);

                var bindingList = new BindingList<ViewDefensasCarrera>(list2);
                var source = new BindingSource(bindingList, null);
                dtgDefensaExterna.DataSource = source;
            }

           

        }

        private void btnBuscarDefensa_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarRevisiones_Click(object sender, EventArgs e)
        {

            FrmNuevaDefensaExterna frm = new FrmNuevaDefensaExterna();
            frm.Show();
        }
    }
}
