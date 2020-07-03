using CapaPresentacion.FormsAgregar;
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
    public partial class FrmTutor : Form
    {
        public FrmTutor()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCarrera frm = new FrmCarrera();
            frm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
            FrmCarrera frm = new FrmCarrera();
            frm.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmInstitucion frm1 = new FrmInstitucion();
            frm1.ShowDialog();
        }
    }
}
