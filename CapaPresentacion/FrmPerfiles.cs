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
{
    public partial class FrmPerfiles : Form
    {
       NegocioPerfiles obj = new NegocioPerfiles();
        string carrera = null;
        public FrmPerfiles(string criterio)
        {
            InitializeComponent();
            Inicializador(criterio);
            carrera = criterio;
        }
        public void Inicializador(string criterio)
        {
            if (carrera == null)
            {
                var list = obj.Perfiles();
                var bindingList = new BindingList<ViewPerfiles>(list);
                var source = new BindingSource(bindingList, null);
                dtgPerfilesTesis.DataSource = source;

            }
            else
            {
                var list2 = obj.PerfilesCarrera(carrera);
                var bindingList = new BindingList<ViewPerfilesCarrera>(list2);
                var source = new BindingSource(bindingList, null);
                dtgPerfilesTesis.DataSource = source;
            }
        }

        private void btnBuscarPerfil_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //esta variable debería corresponder a la cantidad de revisiones que tiene el perfil seleccionado
            int cantidadRevisiones = 1;
            FrmRevisiones frm = new FrmRevisiones(cantidadRevisiones);
            frm.Show();
        }
        
    }
}
