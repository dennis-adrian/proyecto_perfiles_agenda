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
    public partial class FrmEditarDefensaExterna : Form
    {
        string carrera;
        int estudiante;
        string tipo;


        public FrmEditarDefensaExterna(int ES = 0,string CA = "",string TI = "")
        {
            InitializeComponent();
            
            this.carrera = CA;
            this.estudiante = ES;
            this.tipo = TI;
            Inicializar();



        }

        public void Inicializar()
        {
            lblTituloDefensa.Text = tipo;
        }

        private void FrmEditarDefensaExterna_Load(object sender, EventArgs e)
        {




        }

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            
                if (e.Button == MouseButtons.Left && e.Clicks >= 2)
                {
                    if (FormWindowState.Normal == WindowState)
                    {
                        Rectangle workingArea = new Rectangle();
                        workingArea = Screen.GetWorkingArea(pnlBarraTitulo);
                        MaximumSize = workingArea.Size;
                        WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        MaximumSize = new Size(0, 0);
                        WindowState = FormWindowState.Normal;
                    }
                    pnlBarraTitulo.Select();
                    return;
                }
                ArrastrarForm.ReleaseCapture();
                ArrastrarForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
            }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnCancelarNuevaDefensa_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
