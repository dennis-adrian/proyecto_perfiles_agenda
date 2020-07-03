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
    public partial class FrmRevisionIndividual : Form
    {
        string nroTribunal = "1";
        public FrmRevisionIndividual()
        {
            InitializeComponent();
        }
        public void reiniciarValores()
        {
            txtTribunal.Text = "";
            txtObservaciones.Text = "";
            dttDevolucionAlumno.Value = DateTime.Parse("12/12/2000");
            dttDevolucionTribunal.Value = DateTime.Parse("12/12/2000");
            dttEmpaste.Value = DateTime.Parse("12/12/2000");
            dttEntregaAlumno.Value = DateTime.Parse("12/12/2000");
            dttEntregaTribunal.Value = DateTime.Parse("12/12/2000");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnElegirTribunal_Click(object sender, EventArgs e)
        {
            Form frmElegirTribunal = new FrmLicenciado();
            frmElegirTribunal.Show();
        }

        private void btnCancelarNuevop_Click(object sender, EventArgs e)
        {
            FrmRevisiones frm = new FrmRevisiones();
            frm.Close();
        }

        private void rbTribunal2_CheckedChanged(object sender, EventArgs e)
        {
            this.nroTribunal = "2";
            reiniciarValores();
            txtTribunal.Text = nroTribunal;
        }

        private void rbTribunal1_CheckedChanged(object sender, EventArgs e)
        {
            this.nroTribunal = "1";
            reiniciarValores();
            txtTribunal.Text = nroTribunal;
        }
    }
}
