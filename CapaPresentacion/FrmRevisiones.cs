using CapaPresentacion.Revisiones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.ContractForms;

namespace CapaPresentacion
{
    public partial class FrmRevisiones : Form
    {
        int cantRevisiones;
        int idperfil;
        #region Constructores
        public FrmRevisiones()
        {
            InitializeComponent();
        }
        public FrmRevisiones(int cantRevisiones,int idperfil)
        {
            InitializeComponent();
            this.cantRevisiones = cantRevisiones;
            this.idperfil = idperfil;
        }
        #endregion
        private void FrmRevisiones2_Load(object sender, EventArgs e)
        {
            btnGeneralRev_Click(null, e);
            inicializarComponentes();
            validarCantRevisiones();
        }
        public void inicializarComponentes()
        {
            pnlPrimeraRev.Visible = false;
            btnSegundaRev.Visible = false;
            pnlSegundaRev.Visible = false;
            btnTerceraRev.Visible = false;
            pnlTerceraRev.Visible = false;
            btnCuartaRev.Visible = false;
            pnlCuartaRev.Visible = false;
            btnAddNewRev3.Visible = false;
            btnAddNewRev4.Visible = false;
        }
        public void reiniciarResaltado()
        {
            pnlGeneral.Visible = false;
            pnlPrimeraRev.Visible = false;
            pnlSegundaRev.Visible = false;
            pnlTerceraRev.Visible = false;
            pnlCuartaRev.Visible = false;
        }
        #region validarRevisiones
        public void validarCantRevisiones()
        {
            int cantidad = this.cantRevisiones;
            switch (cantidad)
            {
                case 1:
                    btnPrimeraRev.Visible = true;
                    btnSegundaRev.Visible = false;
                    btnTerceraRev.Visible = false;
                    btnCuartaRev.Visible = false;
                    break;
                case 2:
                    btnPrimeraRev.Visible = true;
                    validarRevision2();
                    break;
                case 3:
                    btnPrimeraRev.Visible = true;
                    validarRevision2();
                    validarRevision3();
                    break;
                case 4:
                    btnPrimeraRev.Visible = true;
                    validarRevision2();
                    validarRevision3();
                    validarRevision4();
                    break;
                default:
                    break;
            }
        }
        public void validarRevision2()
        {
            if (btnSegundaRev.Visible == false && pnlSegundaRev.Visible == false)
            {
                btnSegundaRev.Visible = true;
                pnlSegundaRev.Visible = true;
                btnAddNewRev.Visible = false;
                btnAddNewRev3.Visible = true;
            }
        }
        public void validarRevision3()
        {
            if (btnTerceraRev.Visible == false && pnlTerceraRev.Visible == false)
            {
                btnTerceraRev.Visible = true;
                pnlTerceraRev.Visible = true;
                btnAddNewRev3.Visible = false;
                btnAddNewRev4.Visible = true;
            }
        }
        public void validarRevision4()
        {
            if (btnCuartaRev.Visible == false && pnlCuartaRev.Visible == false)
            {
                btnCuartaRev.Visible = true;
                pnlCuartaRev.Visible = true;
                btnAddNewRev4.Visible = false;

            }
        }
        #endregion
        private void btnCancelRev_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.pnlContenedorRev.Controls.Count > 0)
                this.pnlContenedorRev.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedorRev.Controls.Add(fh);
            this.pnlContenedorRev.Tag = fh;
            fh.Show();

        }

        private void btnGeneralRev_Click(object sender, EventArgs e)
        {
            reiniciarResaltado();
            pnlGeneral.Visible = true;
            AbrirFormEnPanel(new FrmGeneral(this.idperfil));
        }

        private void btnPrimeraRev_Click(object sender, EventArgs e)
        {
            reiniciarResaltado();
            pnlPrimeraRev.Visible = true;
            AbrirFormEnPanel(new FrmRevisionIndividual());
        }

        private void btnSegundaRev_Click(object sender, EventArgs e)
        {
            reiniciarResaltado();
            pnlSegundaRev.Visible = true;
            AbrirFormEnPanel(new FrmRevisionIndividual());
        }
        private void btnTerceraRev_Click(object sender, EventArgs e)
        {
            reiniciarResaltado();
            pnlTerceraRev.Visible = true;
            AbrirFormEnPanel(new FrmRevisionIndividual());
        }
        private void btnCuartaRev_Click(object sender, EventArgs e)
        {
            reiniciarResaltado();
            pnlCuartaRev.Visible = true;
            AbrirFormEnPanel(new FrmRevisionIndividual());
        }
        private void btnAddNewRev_Click(object sender, EventArgs e)
        {
            reiniciarResaltado();
            validarRevision2();
            AbrirFormEnPanel(new FrmRevisionIndividual());
        }

        private void btnAddNewRev3_Click(object sender, EventArgs e)
        {
            reiniciarResaltado();
            validarRevision3();
            AbrirFormEnPanel(new FrmRevisionIndividual());
        }

        private void btnAddNewRev4_Click(object sender, EventArgs e)
        {
            reiniciarResaltado();
            validarRevision4();
            AbrirFormEnPanel(new FrmRevisionIndividual());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Arrastrar Forms
        private void pnlBarraNuevoLicenciado_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarForm.ReleaseCapture();
            ArrastrarForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
