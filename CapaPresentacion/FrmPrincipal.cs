using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace CapaPresentacion
{

    public partial class FrmPrincipal : Form
    {

        #region Constructor

        public FrmPrincipal()
        {
            InitializeComponent();
            CustomizeDesing();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        #endregion


        #region Atributos

      
        private IconButton btnFacultadActual;//guarda la facultad actual seleccionada
        private IconButton btnCarreraActual;//guarda la carrera actual seleccionada
        private IconButton btnActual;//valor entre los buttons perfiles y defensa externa
        private string facultad;//guarda la facultad actual seleccionada
        private string carrera;//guarda la carrera actual seleccionado
        private Form frmHijoActual;//var frm hijo

        #endregion


        #region Propiedades y Estructuras
        private struct ColoresRgb
        {
            public static Color color1 = Color.FromArgb(43, 228, 240);
            public static Color rojoUtepsa = Color.FromArgb(178, 8, 55);
        }

        #endregion



        #region Metodos

        private void activarBoton(object btnRemitente, Color color)
        {
            if (btnRemitente != null)
            {
                deshabilitarResaltado();

                btnFacultadActual = (IconButton)btnRemitente;
                btnFacultadActual.BackColor = Color.FromArgb(178, 8, 55);
                //btnActual.ForeColor = color;
                btnFacultadActual.TextAlign = ContentAlignment.MiddleCenter;
                //btnActual.IconColor = color;
                btnFacultadActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnFacultadActual.ImageAlign = ContentAlignment.MiddleCenter;
                //btnActual.Padding = new Padding(40, 0, 0, 0);
            }
        }

        private void deshabilitarResaltado()
        {
            if (btnFacultadActual != null)
            {
                //btnActual.Padding = new Padding(40, 0, 0, 0);
                btnFacultadActual.BackColor = Color.FromArgb(102, 102, 102);
                btnFacultadActual.ForeColor = Color.White;
                //btnActual.TextAlign = ContentAlignment.MiddleLeft;
                btnFacultadActual.IconColor = Color.White;
                btnFacultadActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                //btnActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private string guardarFacultadClickeada(object btnRemitente)
        {
            btnFacultadActual = (IconButton)btnRemitente;
            return btnFacultadActual.Text;
        }

        private string guardarCarreraClickeada(object btnRemitente)
        {
            btnCarreraActual = (IconButton)btnRemitente;
            return btnCarreraActual.Text;

        }

        private void abrirFrmHijo(Form frmHijo)
        {
            if (frmHijoActual != null)
            {
                frmHijoActual.Close();
            }
            frmHijoActual = frmHijo;
            frmHijo.TopLevel = false;
            frmHijo.FormBorderStyle = FormBorderStyle.None;
            frmHijo.Dock = DockStyle.Fill;
            pnlFrmHijo.Controls.Add(frmHijo);
            pnlFrmHijo.Tag = frmHijo;
            //frmHijo.BringToFront();
            frmHijo.Show();
        }

        private void revisarEstadoVentana()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                btnRestaurar.Visible = true;
                btnMaximizar.Visible = false;
            }
            if (this.WindowState == FormWindowState.Normal)
            {
                btnMaximizar.Visible = true;
                btnRestaurar.Visible = false;
            }
        }

        public void HidenMenus()
        {
            if (pnlSubMenuPerfiles.Visible == true)
            {
                pnlSubMenuPerfiles.Visible = false;
                btnPerfiles.BackColor = Color.FromArgb(102, 102, 102);
                btnPerfiles.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnPerfiles.TextAlign = ContentAlignment.MiddleLeft;
                btnPerfiles.ImageAlign = ContentAlignment.MiddleLeft;
            }

            if (pnlSubMenuDefensa.Visible == true)
            {
                pnlSubMenuDefensa.Visible = false;
                btnDefensaExterna.BackColor = Color.FromArgb(102, 102, 102);
                btnDefensaExterna.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnDefensaExterna.TextAlign = ContentAlignment.MiddleLeft;
                btnDefensaExterna.ImageAlign = ContentAlignment.MiddleLeft;
            }


        }

        public void ShowMenus(IconButton iconbtn, Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                HidenCarreras();
                HidenMenus();
                Submenu.Visible = true;
                iconbtn.BackColor = Color.FromArgb(178, 8, 55);
                iconbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                iconbtn.TextAlign = ContentAlignment.MiddleRight;
                iconbtn.ImageAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                Submenu.Visible = false;
                iconbtn.BackColor = Color.FromArgb(102, 102, 102);
                iconbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                iconbtn.TextAlign = ContentAlignment.MiddleLeft;
                iconbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }


        }

        public void CustomizeDesing()
        {
            pnlSubMenuPerfiles.Visible = false;
            btnPerfiles.BackColor = Color.FromArgb(102, 102, 102);
            btnPerfiles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPerfiles.TextAlign = ContentAlignment.MiddleLeft;
            btnPerfiles.ImageAlign = ContentAlignment.MiddleLeft;
            pnlSubMenuDefensa.Visible = false;
            btnDefensaExterna.BackColor = Color.FromArgb(102, 102, 102);
            btnDefensaExterna.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDefensaExterna.TextAlign = ContentAlignment.MiddleLeft;
            btnDefensaExterna.ImageAlign = ContentAlignment.MiddleLeft;
            pnlCarrerasEmpresariales.Visible = false;
            btnEmpresarialesPefiles.BackColor = Color.FromArgb(64, 64, 64);
            btnEmpresarialesPefiles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmpresarialesPefiles.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpresarialesPefiles.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpresarialesAgenda.BackColor = Color.FromArgb(64, 64, 64);
            btnEmpresarialesAgenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmpresarialesAgenda.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpresarialesAgenda.ImageAlign = ContentAlignment.MiddleLeft;
            pnlCarrerasTenologia.Visible = false;
            btnTecnologiaPerfiles.BackColor = Color.FromArgb(64, 64, 64);
            btnTecnologiaPerfiles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTecnologiaPerfiles.TextAlign = ContentAlignment.MiddleLeft;
            btnTecnologiaPerfiles.ImageAlign = ContentAlignment.MiddleLeft;
            btnTecnologiaAgenda.BackColor = Color.FromArgb(64, 64, 64);
            btnTecnologiaAgenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTecnologiaAgenda.TextAlign = ContentAlignment.MiddleLeft;
            btnTecnologiaAgenda.ImageAlign = ContentAlignment.MiddleLeft;
            pnlCarrerasJuridicas.Visible = false;
            btnJuridicasPerfiles.BackColor = Color.FromArgb(64, 64, 64);
            btnJuridicasPerfiles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnJuridicasPerfiles.TextAlign = ContentAlignment.MiddleLeft;
            btnJuridicasPerfiles.ImageAlign = ContentAlignment.MiddleLeft;
            btnJuridicasAgenda.BackColor = Color.FromArgb(64, 64, 64);
            btnJuridicasAgenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnJuridicasAgenda.TextAlign = ContentAlignment.MiddleLeft;
            btnJuridicasAgenda.ImageAlign = ContentAlignment.MiddleLeft;
        }

        public void HidenCarreras()
        {


            if (pnlCarrerasEmpresariales.Visible == true)
            {
                pnlCarrerasEmpresariales.Visible = false;
                btnEmpresarialesPefiles.BackColor = Color.FromArgb(64, 64, 64);
                btnEmpresarialesPefiles.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnEmpresarialesPefiles.TextAlign = ContentAlignment.MiddleLeft;
                btnEmpresarialesPefiles.ImageAlign = ContentAlignment.MiddleLeft;
                btnEmpresarialesAgenda.BackColor = Color.FromArgb(64, 64, 64);
                btnEmpresarialesAgenda.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnEmpresarialesAgenda.TextAlign = ContentAlignment.MiddleLeft;
                btnEmpresarialesAgenda.ImageAlign = ContentAlignment.MiddleLeft;
            }
            if (pnlCarrerasTenologia.Visible == true)
            {
                pnlCarrerasTenologia.Visible = false;
                btnTecnologiaPerfiles.BackColor = Color.FromArgb(64, 64, 64);
                btnTecnologiaPerfiles.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnTecnologiaPerfiles.TextAlign = ContentAlignment.MiddleLeft;
                btnTecnologiaPerfiles.ImageAlign = ContentAlignment.MiddleLeft;
                btnTecnologiaAgenda.BackColor = Color.FromArgb(64, 64, 64);
                btnTecnologiaAgenda.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnTecnologiaAgenda.TextAlign = ContentAlignment.MiddleLeft;
                btnTecnologiaAgenda.ImageAlign = ContentAlignment.MiddleLeft;

            }
            if (pnlCarrerasJuridicas.Visible == true)
            {
                pnlCarrerasJuridicas.Visible = false;
                btnJuridicasPerfiles.BackColor = Color.FromArgb(64, 64, 64);
                btnJuridicasPerfiles.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnJuridicasPerfiles.TextAlign = ContentAlignment.MiddleLeft;
                btnJuridicasPerfiles.ImageAlign = ContentAlignment.MiddleLeft;
                btnJuridicasAgenda.BackColor = Color.FromArgb(64, 64, 64);
                btnJuridicasAgenda.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnJuridicasAgenda.TextAlign = ContentAlignment.MiddleLeft;
                btnJuridicasAgenda.ImageAlign = ContentAlignment.MiddleLeft;
            }


        }

        public void ShowCarreras(IconButton iconbtn, Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                HidenCarreras();
                Submenu.Visible = true;
                iconbtn.BackColor = Color.FromArgb(178, 8, 60);
                iconbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                iconbtn.TextAlign = ContentAlignment.MiddleRight;
                iconbtn.ImageAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                Submenu.Visible = false;
                iconbtn.BackColor = Color.FromArgb(64, 64, 64);
                iconbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                iconbtn.TextAlign = ContentAlignment.MiddleLeft;
                iconbtn.ImageAlign = ContentAlignment.MiddleLeft;

            }


        }

        #endregion


        #region Buttons Primarios

        private void btnNuevoPerfil_Click(object sender, EventArgs e)
        {
            activarBoton(sender, ColoresRgb.rojoUtepsa);
            /////este codigo controla que no se abra dos veces el formulario
            Form frmNuevoPerfil = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmNuevoPerfil);

            if (frmNuevoPerfil != null)
            {
                //si la instancia existe la pongo en primer plano
                frmNuevoPerfil.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            lblTitulo.Text = "NUEVO PERFIL";
            frmNuevoPerfil = new FrmNuevoPerfil();
            abrirFrmHijo(frmNuevoPerfil);
        }

        private void btnNuevaDefensa_Click(object sender, EventArgs e)
        {
            activarBoton(sender, ColoresRgb.rojoUtepsa);
            Form frmNuevaDefensaExterna = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmNuevaDefensaExterna);

            if (frmNuevaDefensaExterna != null)
            {
                frmNuevaDefensaExterna.BringToFront();
                return;
            }

            lblTitulo.Text = "NUEVA DEFENSA";
            frmNuevaDefensaExterna = new FrmNuevaDefensaExterna();
            abrirFrmHijo(frmNuevaDefensaExterna);
        }

        private void btnPerfiles_Click(object sender, EventArgs e)
        {
            btnActual = (IconButton)sender;
            string criterio = null;
            abrirFrmHijo(new FrmPerfiles(criterio));
            lblTitulo.Text = "Todos los Perfiles";
            ShowMenus(btnPerfiles, pnlSubMenuPerfiles);
        }
        private void btnDefensaExterna_Click(object sender, EventArgs e)
        {
            btnActual = (IconButton)sender;
            string criterio = null;
            abrirFrmHijo(new FrmAgenda(criterio));
            lblTitulo.Text = "Todos las Defensas";
            ShowMenus(btnDefensaExterna, pnlSubMenuDefensa);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (frmHijoActual != null)
            {
                frmHijoActual.Close();
            }
            CustomizeDesing();
            lblTitulo.Text = "Titulo";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Quiere Cerrar la Aplicación?", "Mensaje de Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }


        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }


       


        #endregion


        #region Buttons Secundarios

        private void btnEmpresarialesPerfiles_Click(object sender, EventArgs e)
        {
            string facultad = guardarFacultadClickeada(sender);

            ShowCarreras(btnEmpresarialesPefiles, pnlCarrerasEmpresariales);

        }
        private void btnTecnologiaPerfiles_Click(object sender, EventArgs e)
        {
            string facultad = guardarFacultadClickeada(sender);

            ShowCarreras(btnTecnologiaPerfiles, pnlCarrerasTenologia);
        }
        private void btnJuridicasPerfiles_Click(object sender, EventArgs e)
        {
            facultad = guardarFacultadClickeada(sender);
            ShowCarreras(btnJuridicasPerfiles, pnlCarrerasJuridicas);
        }              
        private void btnEmpresarialesAgenda_Click(object sender, EventArgs e)
        {
            facultad = guardarFacultadClickeada(sender);
            ShowCarreras(btnEmpresarialesAgenda, pnlCarrerasEmpresariales);


        }
        private void btnTecnologiaAgenda_Click(object sender, EventArgs e)
        {
            facultad = guardarFacultadClickeada(sender);
            ShowCarreras(btnTecnologiaAgenda, pnlCarrerasTenologia);
        }
        private void btnJuridicasAgenda_Click(object sender, EventArgs e)
        {
            facultad = guardarFacultadClickeada(sender);
            ShowCarreras(btnJuridicasAgenda, pnlCarrerasJuridicas);
        }

        #endregion



        #region Botones_Carreras

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            carrera = guardarCarreraClickeada(sender);
            lblTitulo.Text = carrera;
            string criterio = carrera;
            string actual = btnActual.Text;
            if (actual == "Defensa Externa")
            {
                //abrirFrmHijo(new FrmAgenda(criterio));
                HidenCarreras();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                HidenCarreras();
            }


        }

        private void btnTurismo_Click(object sender, EventArgs e)
        {
            carrera = guardarCarreraClickeada(sender);
            lblTitulo.Text = carrera;
            string criterio = carrera;
            string actual = btnActual.Text;
            if (actual == "Defensa Externa")
            {
                //abrirFrmHijo(new FrmAgenda(criterio)); 
                HidenCarreras();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                HidenCarreras();
            }

        }

        private void btnComercial_Click(object sender, EventArgs e)
        {
            carrera = guardarCarreraClickeada(sender);
            lblTitulo.Text = carrera;
            string criterio = carrera;
            string actual = btnActual.Text;
            if (actual == "Defensa Externa")
            {
                //abrirFrmHijo(new FrmAgenda(criterio));
                HidenCarreras();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                HidenCarreras();
            }

        }

        private void btnComInternacional_Click(object sender, EventArgs e)
        {
            carrera = guardarCarreraClickeada(sender);
            lblTitulo.Text = carrera;
            string criterio = carrera;
            string actual = btnActual.Text;
            if (actual == "Defensa Externa")
            {
                //abrirFrmHijo(new FrmAgenda(criterio));
                HidenCarreras();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                HidenCarreras();
            }

        }

        private void btnMarketing_Click(object sender, EventArgs e)
        {
            carrera = guardarCarreraClickeada(sender);
            lblTitulo.Text = carrera;
            string criterio = carrera;
            string actual = btnActual.Text;
            if (actual == "Defensa Externa")
            {
                //abrirFrmHijo(new FrmAgenda(criterio));
                HidenCarreras();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                HidenCarreras();
            }

        }

        private void btnContaduria_Click(object sender, EventArgs e)
        {
            carrera = guardarCarreraClickeada(sender);
            lblTitulo.Text = carrera;
            string criterio = carrera;
            string actual = btnActual.Text;
            if (actual == "Defensa Externa")
            {
                //abrirFrmHijo(new FrmAgenda(criterio));

                HidenCarreras();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                HidenCarreras();
            }

        }

        private void btnFinanciera_Click(object sender, EventArgs e)
        {
            carrera = guardarCarreraClickeada(sender);
            lblTitulo.Text = carrera;
            string criterio = carrera;
            string actual = btnActual.Text;
            if (actual == "Defensa Externa")
            {
                //abrirFrmHijo(new FrmAgenda(criterio));

                HidenCarreras();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                HidenCarreras();
            }

        }

        private void btnComunicacion_Click(object sender, EventArgs e)
        {
            carrera = guardarCarreraClickeada(sender);
            lblTitulo.Text = carrera;
            string criterio = carrera;
            string actual = btnActual.Text;
            if (actual == "Defensa Externa")
            {
                //abrirFrmHijo(new FrmAgenda(criterio));
                HidenCarreras();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                HidenCarreras();
            }

        }
        private void btnIndustrial_Click(object sender, EventArgs e)
        {
            carrera = guardarCarreraClickeada(sender);
            lblTitulo.Text = carrera;
            string criterio = carrera;
            string actual = btnActual.Text;
            if (actual == "Defensa Externa")
            {
                //abrirFrmHijo(new FrmAgenda(criterio));
                HidenCarreras();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                HidenCarreras();
            }

        }

        private void btnPetrolera_Click(object sender, EventArgs e)
        {
            carrera = guardarCarreraClickeada(sender);
            lblTitulo.Text = carrera;
            string criterio = carrera;
            string actual = btnActual.Text;
            if (actual == "Defensa Externa")
            {
                //abrirFrmHijo(new FrmAgenda(criterio));
                HidenCarreras();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                HidenCarreras();
            }

        }

        private void btnElectronica_Click(object sender, EventArgs e)
        {
            carrera = guardarCarreraClickeada(sender);
            lblTitulo.Text = carrera;
            string criterio = carrera;
            string actual = btnActual.Text;
            if (actual == "Defensa Externa")
            {
                //abrirFrmHijo(new FrmAgenda(criterio));
                HidenCarreras();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                HidenCarreras();
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            carrera = guardarCarreraClickeada(sender);
            lblTitulo.Text = carrera;
            string criterio = carrera;
            string actual = btnActual.Text;
            if (actual == "Defensa Externa")
            {
                //abrirFrmHijo(new FrmAgenda(criterio));
                HidenCarreras();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                HidenCarreras();
            }
        }

        private void btnMecanica_Click(object sender, EventArgs e)
        {
            carrera = guardarCarreraClickeada(sender);
            lblTitulo.Text = carrera;
            string criterio = carrera;
            string actual = btnActual.Text;
            if (actual == "Defensa Externa")
            {
                //abrirFrmHijo(new FrmAgenda(criterio));
                HidenCarreras();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                HidenCarreras();
            }
        }

        private void btnRedes_Click(object sender, EventArgs e)
        {
            carrera = guardarCarreraClickeada(sender);
            lblTitulo.Text = carrera;
            string criterio = carrera;
            string actual = btnActual.Text;
            if (actual == "Defensa Externa")
            {
                //abrirFrmHijo(new FrmAgenda(criterio));
                HidenCarreras();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                HidenCarreras();
            }
        }

        private void btnElectrica_Click(object sender, EventArgs e)
        {
            carrera = guardarCarreraClickeada(sender);
            lblTitulo.Text = carrera;
            string criterio = carrera;
            string actual = btnActual.Text;
            if (actual == "Defensa Externa")
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                HidenCarreras();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                HidenCarreras();
            }
        }

        private void btnDerecho_Click(object sender, EventArgs e)
        {
            carrera = guardarCarreraClickeada(sender);
            lblTitulo.Text = carrera;
            string criterio = carrera;
            string actual = btnActual.Text;
            if (actual == "Defensa Externa")
            {
                ///abrirFrmHijo(new FrmAgenda(criterio));
                HidenCarreras();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                HidenCarreras();
            }
        }

        private void btnRelInter_Click(object sender, EventArgs e)
        {
            carrera = guardarCarreraClickeada(sender);
            lblTitulo.Text = carrera;
            string criterio = carrera;
            string actual = btnActual.Text;
            if (actual == "Defensa Externa")
            {
                //abrirFrmHijo(new FrmAgenda(criterio));
                HidenCarreras();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                HidenCarreras();
            }
        }

        private void btnPsicologia_Click(object sender, EventArgs e)
        {
            carrera = guardarCarreraClickeada(sender);
            lblTitulo.Text = carrera;
            string criterio = carrera;
            string actual = btnActual.Text;
            if (actual == "Defensa Externa")
            {
                //abrirFrmHijo(new FrmAgenda(criterio));
                HidenCarreras();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                HidenCarreras();
            }
        }



        #endregion



        #region Eventos 

        private void FrmPrincipal_Resize(object sender, EventArgs e)
        {
            revisarEstadoVentana();
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

        #endregion



    }
}
