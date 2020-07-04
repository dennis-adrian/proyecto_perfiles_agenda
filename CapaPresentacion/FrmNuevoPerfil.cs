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
    public partial class FrmNuevoPerfil : Form
    {
        #region Instancias

        NegocioNuevoPerfil obj = new NegocioNuevoPerfil();

        #endregion


        #region Constructor
        public FrmNuevoPerfil()
        {
            InitializeComponent();
            FormsControls();
        }

        #endregion


        #region Buttons

        private void btnElegirTutor_Click(object sender, EventArgs e)
        {
            FrmTutor frm = new FrmTutor();
            frm.Show();
        }
        private void btnCancelarNuevop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGuardarNuevoP_Click(object sender, EventArgs e)
        {

        }


        #endregion


        #region Arrastrar_Form

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarForm.ReleaseCapture();
            ArrastrarForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


        

        #region Metodos

        public void FormsControls()
        {
            cmbCarrera.Items.Clear();
            cmbCarrera.DataSource = obj.cargarCarreras();
            cmbCarrera.ValueMember = "id";
            cmbCarrera.DisplayMember = "nombre";

        }
        public void ClearForms()
        {
            txtRegistroAlum.Clear();//input
            txtNombreAlum.Clear();//input
            txtApellidoAlum.Clear();//input
            txtEmailAlum.Clear();//input
            txtTelefonoAlum.Clear();//input
            txtCelularAlum.Clear();//input
            txtTemaTesis.Clear();//input
           

        }




        #endregion


    }
}
