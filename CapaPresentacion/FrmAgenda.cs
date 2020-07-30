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
            personalizarDiseño();
            carrera = criterio;
        }

        FrmPrincipal frp = new FrmPrincipal();

        private void personalizarDiseño()
        {
            pnlFiltroDefensa.Visible = false;
        }
        private void ocultarPaneles()
        {
            if (pnlFiltroDefensa.Visible == true)
                pnlFiltroDefensa.Visible = false;
            if (frp.pnlAgregar.Visible == true)
                frp.pnlAgregar.Visible = false;
        }
        private void mostrarPaneles(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarPaneles();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
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
        private void btnEditarAgenda_Click(object sender, EventArgs e)
        {
            FrmEditarDefensaExterna frm = new FrmEditarDefensaExterna();
            frm.Show();

        }

        private void dtgDefensaExterna_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            mostrarPaneles(pnlFiltroDefensa);
        }

        private void btnExamenGrado_Click(object sender, EventArgs e)
        {
            //..
            //..
            ocultarPaneles();
        }

        private void btnTesis_Click(object sender, EventArgs e)
        {
            //..
            //..
            ocultarPaneles();
        }

        private void btnPorExecencia_Click(object sender, EventArgs e)
        {
            //..
            //..
            ocultarPaneles();
        }
    }
}
