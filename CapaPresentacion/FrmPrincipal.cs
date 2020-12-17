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
using CapaPresentacion.FormsAgregar;
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

        #region Instancia frmHijo Unasolo vez

        public string title_home = "Inicio";
        public bool switchNuevoPerfil = false;
        public bool switchPerfiles = false;
        public bool switchNuevaDefensa = false;
        public bool switchDefensas = false;

        private FrmCarreraInterna CarInt = null;
        private FrmCarreraExterna CarExt = null;
        private FrmTutor Tutor = null;
        private FrmFacultad facu = null;
        private FrmInstitucion inst = null;


        private FrmFacultad FormInstance4
        {
            get
            {
                if (facu == null)
                {
                    facu = new FrmFacultad();
                    facu.Disposed += new EventHandler(form_Disposed4);
                }

                return facu;
            }
        }
        private FrmInstitucion FormInstance5
        {
            get
            {
                if (inst == null)
                {
                    inst = new FrmInstitucion();
                    inst.Disposed += new EventHandler(form_Disposed5);
                }

                return inst;
            }
        }

        void form_Disposed4(object sender, EventArgs e)
        {
            facu = null;

        }
        void form_Disposed5(object sender, EventArgs e)
        {
            inst = null;

        }

        private FrmCarreraInterna FormInstance1
        {
            get
            {
                if (CarInt== null)
                {
                    CarInt = new FrmCarreraInterna();
                    CarInt.Disposed += new EventHandler(form_Disposed1);
                }

                return CarInt;
            }
        }

        void form_Disposed1(object sender, EventArgs e)
        {
            CarInt = null;

        }

        private FrmCarreraExterna FormInstance2
        {
            get
            {
                if (CarExt == null)
                {
                    CarExt = new FrmCarreraExterna();
                    CarExt.Disposed += new EventHandler(form_Disposed2);
                }

                return CarExt;
            }
        }

        void form_Disposed2(object sender, EventArgs e)
        {
            CarExt = null;

        }

        private FrmTutor FormInstance3
        {
            get
            {
                if (Tutor == null)
                {
                    Tutor = new FrmTutor();
                    Tutor.Disposed += new EventHandler(form_Disposed3);
                }

                return Tutor;
            }
        }

        void form_Disposed3(object sender, EventArgs e)
        {
            Tutor = null;

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

        #region Metodos

       
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

        public void FirstButtonActive(IconButton btn)
        {
            btn.BackColor = Color.FromArgb(178, 8, 55);
            btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn.TextAlign = ContentAlignment.MiddleRight;
            btn.ImageAlign = ContentAlignment.MiddleRight;

        }
        public void FirstButtonDesactive(IconButton btn)
        {
            btn.BackColor = Color.FromArgb(102, 102, 102);
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.ImageAlign = ContentAlignment.MiddleLeft;

        }
        public void SecondButtonActive(IconButton btn)
        {
            btn.BackColor = Color.FromArgb(178, 8, 65);
            btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn.TextAlign = ContentAlignment.MiddleRight;
            btn.ImageAlign = ContentAlignment.MiddleRight;

        }
        public void SecondButtonDesactive(IconButton btn)
        {
            btn.BackColor = Color.FromArgb(64, 64, 64);
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.ImageAlign = ContentAlignment.MiddleLeft;
        }

        public void showSubMenus(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HidenMenus();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        public void HidenMenus()
        {
            if (pnlSubMenuPerfiles.Visible == true)
            {
                pnlSubMenuPerfiles.Visible = false;
                FirstButtonDesactive(btnPerfiles);
            }
            if (pnlSubMenuDefensa.Visible == true)
            {
               
                pnlSubMenuDefensa.Visible = false;
                FirstButtonDesactive(btnDefensaExterna);
            }
            if (pnlSubMenuNuevaDefensa.Visible == true)
            {

                pnlSubMenuNuevaDefensa.Visible = false;
                FirstButtonDesactive(btnNuevaDefensa);
            }

            if (pnlAgregar.Visible == true)
            {

                pnlAgregar.Visible = false;

            }


        }

        public void HiddenAgregar()
        {
            //  FirstButtonDesactive(btnAgregrNew);
            SecondButtonDesactive(btnNuevoLicen);
            SecondButtonDesactive(btnNuevaFacultad);
            SecondButtonDesactive(btnNuevaCarreraEx);
            SecondButtonDesactive(btnNuevaCareraIn);
            if (pnlAgregar.Visible == true)
                pnlAgregar.Visible = false;

        }
        public void HiddenNuevoperfil()
        {
            FirstButtonDesactive(btnNuevoPerfil);
        }
        public void ShowNuevoPerfil()
        {
            HidenMenus();
            HidenCarreras();
            FirstButtonActive(btnNuevoPerfil);
        }
        public void HiddenNuevaDefensa()
        {
            FirstButtonDesactive(btnNuevaDefensa);
            SecondButtonDesactive(btnExamendeGrado);
            SecondButtonDesactive(btnGraduacionExcelencia);
            if (pnlSubMenuNuevaDefensa.Visible == true)
                pnlSubMenuNuevaDefensa.Visible = false;

        }
        public void ShowNuevaDefensa()
        {
            HidenMenus();
            HidenCarreras();
            HiddenAgregar();
            FirstButtonActive(btnNuevaDefensa);
        }

        public void ShowMenus(IconButton iconbtn, Panel Submenu)
        {
            if (Submenu.Visible == false)
            {

                HiddenNuevoperfil();
                HiddenNuevaDefensa();
                HiddenAgregar();
                HidenCarreras();
                HidenMenus();
                Submenu.Visible = true;
                FirstButtonActive(iconbtn);
            }
            else
            {
                Submenu.Visible = false;
                FirstButtonDesactive(iconbtn);
                HidenCarreras();
            }


        }

        public void CustomizeDesing()
        {

            pnlAgregar.Visible = false;
            pnlSubMenuNuevaDefensa.Visible = false;
            FirstButtonDesactive(btnNuevaDefensa);
            pnlSubMenuPerfiles.Visible = false;
            FirstButtonDesactive(btnPerfiles);
            pnlSubMenuDefensa.Visible = false;
            FirstButtonDesactive(btnDefensaExterna);
            pnlCarrerasEmpresariales.Visible = false;
            SecondButtonDesactive(btnEmpresarialesPefiles);
            SecondButtonDesactive(btnEmpresarialesAgenda);
            pnlCarrerasTenologia.Visible = false;
            SecondButtonDesactive(btnTecnologiaPerfiles);
            SecondButtonDesactive(btnTecnologiaAgenda);
            pnlCarrerasJuridicas.Visible = false;
            SecondButtonDesactive(btnJuridicasPerfiles);
            SecondButtonDesactive(btnJuridicasAgenda);
            FirstButtonDesactive(btnNuevaDefensa);
            FirstButtonDesactive(btnNuevoPerfil);

        }

        public void HidenCarreras()
        {


            if (pnlCarrerasEmpresariales.Visible == true)
            {
                pnlCarrerasEmpresariales.Visible = false;
                SecondButtonDesactive(btnEmpresarialesPefiles); 
                SecondButtonDesactive(btnEmpresarialesAgenda);
            }
            if (pnlCarrerasTenologia.Visible == true)
            {
                pnlCarrerasTenologia.Visible = false;
                SecondButtonDesactive(btnTecnologiaPerfiles);
                SecondButtonDesactive(btnTecnologiaAgenda);

            }
            if (pnlCarrerasJuridicas.Visible == true)
            {
                pnlCarrerasJuridicas.Visible = false;
                SecondButtonDesactive(btnJuridicasPerfiles);
                SecondButtonDesactive(btnJuridicasAgenda);
            }


        }

        public void ShowCarreras(IconButton iconbtn, Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                HidenCarreras();
                Submenu.Visible = true;
                SecondButtonActive(iconbtn);
            }
            else
            {
                Submenu.Visible = false;
                SecondButtonDesactive(iconbtn);
            }


        }

        
        

        #endregion


        #region Buttons Primarios

        private void btnNuevoPerfil_Click(object sender, EventArgs e)
        {
            if (switchNuevoPerfil == false)
            {
                switchNuevoPerfil = true;
                HiddenNuevaDefensa();
                ShowNuevoPerfil();

                lblTitulo.Text = "NUEVO PERFIL";
                abrirFrmHijo(new FrmNuevoPerfil());
            }
            else
            {
                if (frmHijoActual != null)
                {
                    frmHijoActual.Close();

                    switchNuevoPerfil = false;
                }
                CustomizeDesing();
                lblTitulo.Text = title_home;

            }







            /*/////este codigo controla que no se abra dos veces el formulario
            Form frmNuevoPerfil = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmNuevoPerfil);

            if (frmNuevoPerfil != null)
            {
                //si la instancia existe la pongo en primer plano
                frmNuevoPerfil.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            
            frmNuevoPerfil = new FrmNuevoPerfil();
            abrirFrmHijo(frmNuevoPerfil);*/

        }
       
        
        
       
        private void btnNuevaDefensa_Click(object sender, EventArgs e)
        {
            if (switchNuevaDefensa == false)
            {
                switchNuevaDefensa = true;
                ShowMenus(btnNuevaDefensa, pnlSubMenuNuevaDefensa);
                
            }
            else
            {
                if (frmHijoActual != null)
                {
                    frmHijoActual.Close();

                    switchNuevaDefensa = false;
                }
                CustomizeDesing();
                lblTitulo.Text = title_home;

            }

           
           
            
        }

        private void btnPerfiles_Click(object sender, EventArgs e)
        {

            if (switchPerfiles == false)
            {
                switchPerfiles = true;
                btnActual = (IconButton)sender;
                string criterio = null;
                abrirFrmHijo(new FrmPerfiles(criterio));
                lblTitulo.Text = "Todos los Perfiles";
                ShowMenus(btnPerfiles, pnlSubMenuPerfiles);


            }
            else
            {
                if (frmHijoActual != null)
                {
                    frmHijoActual.Close();

                    switchPerfiles = false;
                }
                CustomizeDesing();
                lblTitulo.Text =title_home;

            }
            
        }
        private void btnDefensaExterna_Click(object sender, EventArgs e)
        {
            if (switchDefensas == false)
            {
                switchDefensas = true;
                btnActual = (IconButton)sender;
                string criterio = null;
                abrirFrmHijo(new FrmAgenda(criterio));
                lblTitulo.Text = "Todos las Defensas";
                ShowMenus(btnDefensaExterna, pnlSubMenuDefensa);


            }
            else
            {
                if (frmHijoActual != null)
                {
                    frmHijoActual.Close();

                    switchDefensas = false;
                }
                CustomizeDesing();
                lblTitulo.Text =title_home;

            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //TestNot();
            if (frmHijoActual != null)
            {
                frmHijoActual.Close();
            }
            CustomizeDesing();
            lblTitulo.Text = title_home;
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


        #region Buttons_Carreras

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            carrera = guardarCarreraClickeada(sender);

            lblTitulo.Text = carrera;
            string criterio = carrera;
            
            string actual = btnActual.Text;
            if (actual == "Defensa Externa")
            {
                abrirFrmHijo(new FrmAgenda(criterio));
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
                abrirFrmHijo(new FrmAgenda(criterio)); 
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
                abrirFrmHijo(new FrmAgenda(criterio));
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
                abrirFrmHijo(new FrmAgenda(criterio));
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
                abrirFrmHijo(new FrmAgenda(criterio));
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
                abrirFrmHijo(new FrmAgenda(criterio));
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
                abrirFrmHijo(new FrmAgenda(criterio));

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
                abrirFrmHijo(new FrmAgenda(criterio));
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
                abrirFrmHijo(new FrmAgenda(criterio));
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
                abrirFrmHijo(new FrmAgenda(criterio));
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
                abrirFrmHijo(new FrmAgenda(criterio));
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
                abrirFrmHijo(new FrmAgenda(criterio));
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
                abrirFrmHijo(new FrmAgenda(criterio));
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
                abrirFrmHijo(new FrmAgenda(criterio));
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
                abrirFrmHijo(new FrmAgenda(criterio));
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
                abrirFrmHijo(new FrmAgenda(criterio));
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
                abrirFrmHijo(new FrmAgenda(criterio));
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

        private void btnExamendeGrado_Click(object sender, EventArgs e)
        {
           
           
            SecondButtonDesactive(btnGraduacionExcelencia);
            lblTitulo.Text = btnExamendeGrado.Text;
            HidenCarreras();
            abrirFrmHijo(new FrmNuevaDefensaExterna(1));
            SecondButtonActive(btnExamendeGrado);
            pnlSubMenuNuevaDefensa.Visible = false;




        }

        private void btnGraduacionExcelencia_Click(object sender, EventArgs e)
        {

            SecondButtonDesactive(btnExamendeGrado);
            lblTitulo.Text = btnGraduacionExcelencia.Text;
            HidenCarreras();
            abrirFrmHijo(new FrmNuevaDefensaExterna(2));
            SecondButtonActive(btnGraduacionExcelencia);
            pnlSubMenuNuevaDefensa.Visible = false;
         
            
        }

        private void btnAgregrNew_Click(object sender, EventArgs e)
        {
            HidenCarreras();
            showSubMenus(pnlAgregar);
        }

        private void btnNuevoLicen_Click(object sender, EventArgs e)
        {
            HiddenAgregar();
            FrmTutor frm = this.FormInstance3;
            frm.btnSeleccionarLicenciado.Visible = false;
            frm.Show();
            frm.BringToFront();
        }

        private void btnNuevaFacultad_Click(object sender, EventArgs e)
        {
            HiddenAgregar();
            FrmFacultad frm = this.FormInstance4;
            frm.btnSelecFacu.Visible = false;
            frm.Show();
            frm.BringToFront();
        }

        private void btnNuevaCarreraEx_Click(object sender, EventArgs e)
        {
            HiddenAgregar();
            FrmCarreraExterna frm = this.FormInstance2;
            HidenCarreras();
            frm.btnSelecCarreraExt.Visible = false;
            frm.Show();
            frm.BringToFront();
            pnlAgregar.Visible = false;
        }

        private void btnNuevaCareraIn_Click(object sender, EventArgs e)
        {
            HiddenAgregar();
            FrmCarreraInterna frm = this.FormInstance1;
           // HiddenAgregar();
            HidenCarreras();
            frm.btnSelecCarrera.Visible = false;
            frm.Show();
            frm.BringToFront();
            pnlAgregar.Visible = false;
        }

        private void pnlFrmHijo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregrNew_MouseHover(object sender, EventArgs e)
        {

        }
        
        
        //Trabajando las notificaciones
        public void obtenerNotificaciones()
        {
            CapaNegocio.notificaciones.Index obj = new CapaNegocio.notificaciones.Index();
            //COMENTADO TEMPORALMENTE
            obj.main();
            var notificaciones = obj.notificaciones();
            foreach (var item in notificaciones)
            {
                FrmNotificaciones frmNotif = new FrmNotificaciones();
                frmNotif.mostrarNotificaciones(item.Id, item.Titulo, item.Mensaje, item.Prioridad, item.Tipo, item.Hora, item.Fecha, item.Id_perfil);
            }
        }
        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            obtenerNotificaciones();
            btnNotificaciones.Enabled = false;
            timer1.Interval = 10000;
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnNotificaciones.Enabled = true;
            timer1.Stop();
        }

        private void btnInstituciones_Click(object sender, EventArgs e)
        {
            HiddenAgregar();
            FrmInstitucion frm = this.FormInstance5;
            frm.btnSelecInstitu.Visible = false;
            frm.Show();
            frm.BringToFront();
        }
    }
}
