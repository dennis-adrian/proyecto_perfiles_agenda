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
using CapaPresentacion.ContractForms;

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

        #region propiedades



        #endregion
        public void Inicializador(string criterio)
        {
            if (criterio == null)
            {
               
                var list = obj.Perfiles();
                var bindingList = new BindingList<ViewPerfiles>(list);
                var source = new BindingSource(bindingList, null);
                dtgPerfilesTesis.DataSource = source;

            }
            else
            {
              
                var list2 = obj.PerfilesCarrera(criterio);
                var bindingList = new BindingList<ViewPerfilesCarrera>(list2);
                var source = new BindingSource(bindingList, null);
                dtgPerfilesTesis.DataSource = source;
            }
        }

        private void btnBuscarPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarPerfil.Text;
            if (carrera == null)
            {
                
                var list = obj.Perfiles(nombre);
                var bindingList = new BindingList<ViewPerfiles>(list);
                var source = new BindingSource(bindingList, null);
                dtgPerfilesTesis.DataSource = source;

            }
            else
            {
                var list2 = obj.PerfilesCarrera(carrera,nombre);
                var bindingList = new BindingList<ViewPerfilesCarrera>(list2);
                var source = new BindingSource(bindingList, null);
                dtgPerfilesTesis.DataSource = source;
            }

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtgPerfilesTesis.CurrentRow != null)
            {
                int id_seleccionado = Convert.ToInt32(dtgPerfilesTesis.CurrentRow.Cells[0].Value.ToString());
                int cantidadRevisiones = 1;
                FrmRevisiones frm = new FrmRevisiones(cantidadRevisiones, id_seleccionado);
                frm.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna revisión");
            }
        }

        private void txtBuscarPerfil_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
