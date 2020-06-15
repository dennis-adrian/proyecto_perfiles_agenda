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
    public partial class FrmNuevoPerfil : Form
    {
        public FrmNuevoPerfil()
        {
            InitializeComponent();
        }

        private void btnCancelarNuevop_Click(object sender, EventArgs e)
        {
            FrmPrincipal.frmNuevoPerfilCerrado = true;
            this.Close();
        }
        #region Arrastrar_Form

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarForm.ReleaseCapture();
            ArrastrarForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
