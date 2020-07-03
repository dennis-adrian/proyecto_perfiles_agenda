using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cargar();
        }

        private void cmbtest1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void cargar()
        {
            CapaNegocio.NegocioNuevoPerfil obj = new CapaNegocio.NegocioNuevoPerfil();




            DataTable dtcarrera = obj.cargarCarreras();
            cmbtest1.DataSource = dtcarrera;
            cmbtest1.ValueMember = "id";
            cmbtest1.DisplayMember = "nombre";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string  x = cmbtest1.SelectedValue.ToString();
            MessageBox.Show(x);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);

            cmbtest1.SelectedValue = x;
        }
    }
}
