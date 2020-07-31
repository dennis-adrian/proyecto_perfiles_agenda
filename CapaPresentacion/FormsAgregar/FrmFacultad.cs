using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.FormsAgregar
{
    public partial class FrmFacultad : Form
    {
        //BORDE SOMBREADO FORMULAR
        private const int CS_DROPSHADOW = 0x20000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        public FrmFacultad()
        {
            InitializeComponent();
        }

        int posY = 0;
        int posX = 0;
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void FrmFacultad_Load(object sender, EventArgs e)
        {

        }
    }
}
