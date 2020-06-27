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

namespace CapaPresentacion.FormsAgregar
{
    public partial class NuevaInstitucion : Form
    {
        Helpers obj = new Helpers();
        public NuevaInstitucion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarInstitucion_Click(object sender, EventArgs e)
        {
            string nombre = txtInstitucion.Text;
            obj.InsertInstitucion(nombre);
            txtInstitucion.Clear();
            this.Close();
        }

        private void btnCancelarNuevaInstitucion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
