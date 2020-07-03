using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class FrmNuevoPerfil : Form
    {
        public FrmNuevoPerfil()
        {
            InitializeComponent();
            cargarcarreratest();
        }

        private void btnCancelarNuevop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Arrastrar_Form

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarForm.ReleaseCapture();
            ArrastrarForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnElegirTutor_Click(object sender, EventArgs e)
        {
            FrmLicenciado obj = new FrmLicenciado();
            obj.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnElegirTutor_Click_1(object sender, EventArgs e)
        {
            FrmTutor frm = new FrmTutor();
            frm.Show();
        }

        private void pnlBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }


        #region CARGARCOMBOBOX
        public void cargarcarreratest()
        {
            CapaDatos.Models.Carrera obj = new CapaDatos.Models.Carrera();

            cmbCarrera.DataSource = obj.Select();
            cmbCarrera.DisplayMember = "nombre";
            //cmbCarrera.ValueMember = "id";
        }



        #endregion

        private void btnCancelarNuevop_Click_1(object sender, EventArgs e)
        {
            
        }

        private void grbAlumno_Enter(object sender, EventArgs e)
        {

        }
    }
}
