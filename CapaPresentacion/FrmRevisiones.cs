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
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class FrmRevisiones : Form
    {
        int cantRevisiones = 0;
        int idperfil;
        Panel pnlContenedorGralBackup;

        #region Instancias

        NegocioPerfilGeneral obj = new NegocioPerfilGeneral();


        #endregion

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
            ShowPerfilGeneral(idperfil);
        }
        #endregion


        //-------------
        private void FrmRevisiones2_Load(object sender, EventArgs e)
        {
            pnlContenedorGralBackup = pnlContenedorGral;
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
        public void ShowPerfilGeneral(int id)
        {
            var Collection = obj.PerfilGeneral(id);
            foreach (var item in Collection)
            {
                txtNumeroRevisiones.Text = item.Revisiones.ToString();
                txtTemaGral.Text = item.Tema.ToString();
                txtEstadoProyectoGral.Text = item.Estado_Proyecto.ToString();
                txtRegistroGral.Text = item.Registro.ToString();
                txtNombreGral.Text = item.Nombre.ToString();
                txtApellidoGral.Text = item.Apellido.ToString();
                txtEmailGral.Text = item.Email.ToString();
                txtTelefonoGral.Text = item.Telefono.ToString();
                txtCelularGral.Text = item.Celular.ToString();
                txtCarreraGral.Text = item.Carrera.ToString();
                txtTutorGral.Text = item.Tutor.ToString();

                var fecha_aprobacion = item.Fecha_Aprobacion.ToString();
                var array_apr = fecha_aprobacion.Split('-');
                int d = Convert.ToInt32(array_apr[0]);
                int m = Convert.ToInt32(array_apr[1]);
                int y = Convert.ToInt32(array_apr[2]);
                dttFechaAprobacionGral.Value = new DateTime(y, m, d);

                var fecha_recepcion = item.Fecha_Aprobacion.ToString();
                var array_rec = fecha_aprobacion.Split('-');
                int dd = Convert.ToInt32(array_rec[0]);
                int mm = Convert.ToInt32(array_rec[1]);
                int yy = Convert.ToInt32(array_rec[2]);
                dttFechaAprobacionGral.Value = new DateTime(yy, mm, dd);
            }
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

        private void abrirFormEnPanel(object formhija)
        {
            if (this.pnlContenedorRev.Controls.Count > 0)
                this.pnlContenedorRev.Controls.Clear();
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedorRev.Controls.Add(fh);
            this.pnlContenedorRev.Tag = fh;
            fh.Show();
        }
        private void cerrarFormEnPanel()
        {
            if (this.pnlContenedorRev.Controls.Count > 0)
                this.pnlContenedorRev.Controls.Clear();
        }
        private void btnGeneralRev_Click(object sender, EventArgs e)
        {
            Panel pnlContenedorGral = pnlContenedorGralBackup;
            reiniciarResaltado();
            pnlGeneral.Visible = true;
            cerrarFormEnPanel();
            pnlContenedorRev.Controls.Add(pnlContenedorGral);
            pnlContenedorGral.Visible = true;
            ShowPerfilGeneral(this.idperfil);
        }

        private void btnPrimeraRev_Click(object sender, EventArgs e)
        {
            pnlContenedorGral.Visible = false;
            reiniciarResaltado();
            pnlPrimeraRev.Visible = true;
            abrirFormEnPanel(new FrmRevisionIndividual(this.idperfil,1));
        }

        private void btnSegundaRev_Click(object sender, EventArgs e)
        {
            reiniciarResaltado();
            pnlSegundaRev.Visible = true;
            abrirFormEnPanel(new FrmRevisionIndividual(this.idperfil,2));
        }
        private void btnTerceraRev_Click(object sender, EventArgs e)
        {
            pnlContenedorGral.Visible = false;
            reiniciarResaltado();
            pnlTerceraRev.Visible = true;
            abrirFormEnPanel(new FrmRevisionIndividual(this.idperfil,3));
        }
        private void btnCuartaRev_Click(object sender, EventArgs e)
        {
            pnlContenedorGral.Visible = false;
            reiniciarResaltado();
            pnlCuartaRev.Visible = true;
            abrirFormEnPanel(new FrmRevisionIndividual(this.idperfil,4));
        }





        private void btnAddNewRev_Click(object sender, EventArgs e)
        {
            pnlContenedorGral.Visible = false;
            reiniciarResaltado();
            validarRevision2();
            abrirFormEnPanel(new FrmRevisionIndividual(this.idperfil,2));
        }

        private void btnAddNewRev3_Click(object sender, EventArgs e)
        {
            reiniciarResaltado();
            validarRevision3();
            abrirFormEnPanel(new FrmRevisionIndividual(this.idperfil,3));
        }

        private void btnAddNewRev4_Click(object sender, EventArgs e)
        {
            reiniciarResaltado();
            validarRevision4();
            abrirFormEnPanel(new FrmRevisionIndividual(this.idperfil,4));
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
