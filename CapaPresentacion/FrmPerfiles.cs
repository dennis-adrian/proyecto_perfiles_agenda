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

            if(criterio == null)
            {
                dtgPerfilesTesis.DataSource= obj.mostarPerfiles();
            }
            else
            {
                dtgPerfilesTesis.DataSource = obj.mostrarPerfileCarrera(criterio);
            }
        }

        private void btnBuscarPerfil_Click(object sender, EventArgs e)
        {
            string estudiante = txtBuscarPerfil.Text;
            if(carrera == null)
            {
                Inicializador(carrera);

            }
            else
            {
                dtgPerfilesTesis.DataSource = obj.mostrarPerfilEstudiante(estudiante);
            }
           
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
