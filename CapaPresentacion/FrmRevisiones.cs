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
        private const int CS_DROPSHADOW = 0x20000;

        #region Instancias

        NegocioPerfilGeneral obj = new NegocioPerfilGeneral();


        #endregion

        #region Constructores
        public FrmRevisiones()
        {
            InitializeComponent();
        }
        public FrmRevisiones(int cantRevisiones, int idperfil)
        {
            InitializeComponent();
            this.cantRevisiones = cantRevisiones;
            this.idperfil = idperfil;
            ShowPerfilGeneral(idperfil);
            //HiddenRevision();
            pnlSubMenus.Visible = false;
            DesactiveColors();
        }
        #endregion

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }
        public void HiddenRevision()
        {
            if(pnlContainerPrimera.Visible == true)
            {
                pnlContainerPrimera.Visible = false;

            }
            if (pnlContainerSegunda.Visible == true)
            {
                pnlContainerSegunda.Visible = false;

            }
            if (pnlContainerTercera.Visible == true)
            {
                pnlContainerTercera.Visible = false;

            }
            if (pnlContainerCuarta.Visible == true)
            {
                pnlContainerCuarta.Visible = false;

            }
            if (pnlAdd1.Visible == true)
            {
                pnlAdd1.Visible = false;

            }
            if (pnlAdd2.Visible == true)
            {
                pnlAdd2.Visible = false;

            }
            if (pnlAdd3.Visible == true)
            {
                pnlAdd3.Visible = false;

            }
            if (pnlAdd4.Visible == true)
            {
                pnlAdd4.Visible = false;

            }



        }
       

        public void DesactiveColors()
        {
            pnlGeneral.BackColor = Color.FromArgb(64, 64, 64);
            pnlRevisiones.BackColor = Color.FromArgb(64, 64, 64);
            pnlPrimeraRev.BackColor = Color.FromArgb(64, 64, 64);
            pnlSegundaRev.BackColor = Color.FromArgb(64, 64, 64);
            pnlTerceraRev.BackColor = Color.FromArgb(64, 64, 64);
            pnlCuartaRev.BackColor = Color.FromArgb(64, 64, 64);
        }

        



        private void FrmRevisiones2_Load(object sender, EventArgs e)
        {
            pnlContenedorGralBackup = pnlContenedorGral;
            btnGeneralRev_Click(null, e);
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
            pnlGeneral.BackColor = Color.Crimson;

            //reiniciarResaltado();
            pnlGeneral.Visible = true;
            cerrarFormEnPanel();
            pnlContenedorRev.Controls.Add(pnlContenedorGral);
            pnlContenedorGral.Visible = true;
            ShowPerfilGeneral(this.idperfil);
        }



        private void btnPrimeraRev_Click(object sender, EventArgs e)
        {
            pnlContenedorGral.Visible = false;
            DesactiveColors();
            pnlPrimeraRev.Visible = true;
            pnlPrimeraRev.BackColor = Color.Crimson;
            abrirFormEnPanel(new FrmRevisionIndividual(this.idperfil,1));
        }

        private void btnSegundaRev_Click(object sender, EventArgs e)
        {
            pnlContenedorGral.Visible = false;
            DesactiveColors();
            pnlSegundaRev.Visible = true;
            pnlSegundaRev.BackColor = Color.Crimson;
            abrirFormEnPanel(new FrmRevisionIndividual(this.idperfil,2));
        }
        private void btnTerceraRev_Click(object sender, EventArgs e)
        {
            pnlContenedorGral.Visible = false;
            DesactiveColors();
            pnlTerceraRev.Visible = true;
            pnlTerceraRev.BackColor = Color.Crimson;
            abrirFormEnPanel(new FrmRevisionIndividual(this.idperfil,3));
        }
        private void btnCuartaRev_Click(object sender, EventArgs e)
        {
            pnlContenedorGral.Visible = false;
            DesactiveColors();
            pnlCuartaRev.Visible = true;
            pnlCuartaRev.BackColor = Color.Crimson;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRevisiones_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumeroRevisiones.Text);
            pnlSubMenus.Visible = true;
            ShowRevisiones(num);
        }

       

        public void ShowRevisiones(int num)
        {
            
            switch (num)
            {
                case 1:

                    pnlContainerRevisiones.Visible = false;
                    HiddenRevision();
                    pnlAdd2.Visible = true;
                    pnlContainerPrimera.Visible = true;
                    break;
                case 2:

                    pnlContainerRevisiones.Visible = false;
                    HiddenRevision();
                    pnlAdd3.Visible = true;
                    pnlContainerSegunda.Visible = true;
                    pnlContainerPrimera.Visible = true;
                    break;
                case 3:

                    pnlContainerRevisiones.Visible = false;
                    HiddenRevision();
                    pnlAdd4.Visible = true;
                    pnlContainerTercera.Visible = true;
                    pnlContainerSegunda.Visible = true;
                    pnlContainerPrimera.Visible = true;
                    break;
                case 4:

                    pnlContainerRevisiones.Visible = false;
                    HiddenRevision();
                    pnlContainerCuarta.Visible = true;
                    pnlContainerTercera.Visible = true;
                    pnlContainerSegunda.Visible = true;
                    pnlContainerPrimera.Visible = true;

                    break;
                case 0:
                    HiddenRevision();
                    pnlAdd1.Visible = true;
                    pnlContainerRevisiones.Visible = false;
                    break;
                default:
                    break;

            }
        }
        

        private void btnAddNewRev1_Click(object sender, EventArgs e)
        {

            ShowRevisiones(1);

        }

        private void btnAddNewRev2_Click(object sender, EventArgs e)
        {

            ShowRevisiones(2);

        }

        private void btnAddNewRev3_Click_1(object sender, EventArgs e)
        {
            ShowRevisiones(3);

        }
        private void btnAddNewRev4_Click(object sender, EventArgs e)
        {
            ShowRevisiones(4);
        }
    }
}
