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
            //pnlPerfiles.Size = MinimumSize;
            //pnlDefensaExterna.Size = MinimumSize;

            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        #endregion


        #region Atributos

        private bool facultadJuridicasClickeada;//booleano para validar el estado
        private bool facultadTecnologiaClickeada;//booleano para validar el estado
        private bool facultadEmpresarialesClickeada;//booleano para validar el estado
        private IconButton btnFacultadActual;//guarda la facultad actual seleccionada
        private IconButton btnCarreraActual;//guarda la carrera actual seleccionada
        private IconButton btnActual;//valor entre los buttons perfiles y defensa externa
        private string facultad;//guarda la facultad actual seleccionada
        private string carrera;//guarda la carrera actual seleccionada

        private Form frmHijoActual;//var frm hijo

        #endregion


        #region Propiedades y Estructuras
        private struct ColoresRgb
        {
            public static Color color1 = Color.FromArgb(43, 228, 240);
            public static Color rojoUtepsa = Color.FromArgb(178, 8, 55);
        }

        #endregion


        //BUTTONS PRIMARIOS DE INICIO 
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
            btnActual = (IconButton)sender;/*
             string criterio = null;
             abrirFrmHijo(new FrmPerfiles(criterio));
             lblTitulo.Text = "Todos los Perfiles";

             if (pnlPerfiles.Size != pnlPerfiles.MaximumSize)
             {
                 mostrarFacultades(pnlPerfiles);
             }
             else
             {
                 ocultarFacultades(pnlPerfiles);
             }
             if (pnlDefensaExterna.Size == pnlDefensaExterna.MaximumSize)
             {
                 ocultarFacultades(pnlDefensaExterna);
             }
             activarBoton(sender, ColoresRgb.rojoUtepsa);*/
            ShowMenus(pnlSubMenuPerfiles);
        }

        

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (frmHijoActual != null)
            {
                frmHijoActual.Close();
            }
            CustomizeDesing();
            //ReiniciarForm();
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


        private void btnDefensaExterna_Click(object sender, EventArgs e)
        {
            btnActual = (IconButton)sender;
            /*btnActual = (IconButton)sender;

            string criterio = null;
            abrirFrmHijo(new FrmAgenda(criterio));
            lblTitulo.Text = "Todos las Defensas";

            if (pnlDefensaExterna.Size != pnlDefensaExterna.MaximumSize)
            {
                mostrarFacultades(pnlDefensaExterna);
            }
            else
            {
                ocultarFacultades(pnlDefensaExterna);
            }
            if (pnlPerfiles.Size == pnlPerfiles.MaximumSize)
            {
                ocultarFacultades(pnlPerfiles);
            }
            activarBoton(sender, ColoresRgb.rojoUtepsa);*/

            ShowMenus(pnlSubMenuDefensa);

        }


        #endregion


        #region Buttons Secundarios

        private void btnEmpresarialesPerfiles_Click(object sender, EventArgs e)
        {
            string facultad = guardarFacultadClickeada(sender);

            KeepSelecction(btnEmpresarialesPefiles, pnlCarrerasEmpresariales);
            DisolveSelecction(btnTecnologiaPerfiles, pnlCarrerasTenologia);
            DisolveSelecction(btnJuridicasPerfiles, pnlCarrerasJuridicas);

        }

        private void btnTecnologiaPerfiles_Click(object sender, EventArgs e)
        {
            string facultad = guardarFacultadClickeada(sender);

            DisolveSelecction(btnEmpresarialesPefiles, pnlCarrerasEmpresariales);
            KeepSelecction(btnTecnologiaPerfiles, pnlCarrerasTenologia);
            DisolveSelecction(btnJuridicasPerfiles, pnlCarrerasJuridicas);

        }

        private void btnJuridicasPerfiles_Click(object sender, EventArgs e)
        {
            facultad = guardarFacultadClickeada(sender);
            DisolveSelecction(btnEmpresarialesPefiles, pnlCarrerasEmpresariales);
            DisolveSelecction(btnTecnologiaPerfiles, pnlCarrerasTenologia);
            KeepSelecction(btnJuridicasPerfiles, pnlCarrerasJuridicas);
        }

       
        private void btnEmpresarialesAgenda_Click(object sender, EventArgs e)
        {
            facultad = guardarFacultadClickeada(sender);
            KeepSelecction(btnEmpresarialesAgenda, pnlCarrerasEmpresariales);
            DisolveSelecction(btnTecnologiaAgenda, pnlCarrerasTenologia);
            DisolveSelecction(btnJuridicasAgenda, pnlCarrerasJuridicas);
            
          
        }

        private void btnTecnologiaAgenda_Click(object sender, EventArgs e)
        {
            facultad = guardarFacultadClickeada(sender);
            DisolveSelecction(btnEmpresarialesAgenda, pnlCarrerasEmpresariales);
            KeepSelecction(btnTecnologiaAgenda, pnlCarrerasTenologia);
            DisolveSelecction(btnJuridicasAgenda, pnlCarrerasJuridicas);

        }

        private void btnJuridicasAgenda_Click(object sender, EventArgs e)
        {
            
        }

        private void btnJuridicasAgenda_Click_1(object sender, EventArgs e)
        {
            facultad = guardarFacultadClickeada(sender);
            DisolveSelecction(btnEmpresarialesAgenda, pnlCarrerasEmpresariales);
            DisolveSelecction(btnTecnologiaAgenda, pnlCarrerasTenologia);
            KeepSelecction(btnJuridicasAgenda, pnlCarrerasJuridicas);

        }


        #endregion





        #region Eventos 

        private void btnEmpresarialesPerfiles_MouseHover(object sender, EventArgs e)
        {

            KeepSelecction(btnEmpresarialesPefiles, pnlCarrerasEmpresariales);
            DisolveSelecction(btnTecnologiaPerfiles, pnlCarrerasTenologia);
            DisolveSelecction(btnJuridicasPerfiles, pnlCarrerasJuridicas);

        }
        private void btnEmpresariales_MouseLeave(object sender, EventArgs e)
        {
            if(pnlCarrerasEmpresariales.Visible == true)
            {

            }
            else
            {
                pnlCarrerasEmpresariales.Visible = false;
            }
        }

        private void btnJuridicasPerfiles_MouseHover(object sender, EventArgs e)
        {
            DisolveSelecction(btnEmpresarialesPefiles, pnlCarrerasEmpresariales);
            DisolveSelecction(btnTecnologiaPerfiles, pnlCarrerasTenologia);
            KeepSelecction(btnJuridicasPerfiles, pnlCarrerasJuridicas);


        }

        private void btnJuridicasPerfiles_MouseLeave(object sender, EventArgs e)
        {
            
        }

   
        private void btnTecnologiaPerfiles_MouseHover(object sender, EventArgs e)
        {
            DisolveSelecction(btnEmpresarialesPefiles, pnlCarrerasEmpresariales);
            KeepSelecction(btnTecnologiaPerfiles, pnlCarrerasTenologia);
            DisolveSelecction(btnJuridicasPerfiles, pnlCarrerasJuridicas);
        }

        private void btnTecnologiaPerfiles_MouseLeave(object sender, EventArgs e)
        {

        }

      
        private void btnEmpresarialesAgenda_MouseHover(object sender, EventArgs e)
        {
            KeepSelecction(btnEmpresarialesAgenda, pnlCarrerasEmpresariales);
            DisolveSelecction(btnTecnologiaAgenda, pnlCarrerasTenologia);
            DisolveSelecction(btnJuridicasAgenda, pnlCarrerasJuridicas);
        }

        private void btnEmpresarialesAgenda_MouseLeave(object sender, EventArgs e)
        {
            
        }

      
        private void btnJuridicasAgenda_MouseHover(object sender, EventArgs e)
        {
            DisolveSelecction(btnEmpresarialesAgenda, pnlCarrerasEmpresariales);
            DisolveSelecction(btnTecnologiaAgenda, pnlCarrerasTenologia);
            KeepSelecction(btnJuridicasAgenda, pnlCarrerasJuridicas);
        }

        private void btnJuridicasAgenda_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnTecnologiaAgenda_MouseHover(object sender, EventArgs e)
        {
            DisolveSelecction(btnEmpresarialesAgenda, pnlCarrerasEmpresariales);
            KeepSelecction(btnTecnologiaAgenda, pnlCarrerasTenologia);
            DisolveSelecction(btnJuridicasAgenda, pnlCarrerasJuridicas);
        }
        private void btnTecnologiaAgenda_MouseLeave(object sender, EventArgs e)
        {
            
        }



        //EVENTO PARA DESAJUSTAR EL TAMAÑO DEL FORMULARIO PRINCIPAL
        private void FrmPrincipal_Resize(object sender, EventArgs e)
        {
            revisarEstadoVentana();
        }

        //EVENTO PARA AJUSTAR EL TAMAÑO DEL FORMULARIO PRINCIPAL
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



        #region Metodos
        //METODO PARA REINICIAR FORMULARIO
       /* private void ReiniciarForm()
        {
            pnlDefensaExterna.Size = MinimumSize;
            pnlPerfiles.Size = MinimumSize;
            deshabilitarResaltado();
        }*/

        //METODO PARA HABILITAR  EL COLOR DEL BUTTON
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

        //METODO PARA DESHABILITAR EL COLOR DEL BUTTON
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

        //METODO PARA GUARDAR FACULTAD CUANDO SE HACE CLICK EN EL BUTTON
        private string guardarFacultadClickeada(object btnRemitente)
        {
            btnFacultadActual = (IconButton)btnRemitente;
            return btnFacultadActual.Text;
        }

        //METODO PARA GUARDAR CARRERA CUANDO SE HACE CLICK EN EL BUTTON
        private string guardarCarreraClickeada(object btnRemitente)
        {
            btnCarreraActual = (IconButton)btnRemitente;
            return btnCarreraActual.Text;

        }

        //METODO PARA ABRIR FORMULARIOS HIJOS
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

        //METODO PARA REVISAR ESTADO DE LA VENTANA
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
                DisolveSelecction(btnAdministracion,pnlCarrerasEmpresariales);
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                DisolveSelecction(btnAdministracion, pnlCarrerasEmpresariales);
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
                DisolveSelecction(btnTurismo, pnlCarrerasEmpresariales);
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                DisolveSelecction(btnTurismo, pnlCarrerasEmpresariales);
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
                DisolveSelecction(btnComercial, pnlCarrerasEmpresariales);
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                DisolveSelecction(btnComercial, pnlCarrerasEmpresariales);
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
                DisolveSelecction(btnComInternacional, pnlCarrerasEmpresariales);
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                DisolveSelecction(btnComInternacional, pnlCarrerasEmpresariales);
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
                DisolveSelecction(btnMarketing, pnlCarrerasEmpresariales);
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                DisolveSelecction(btnMarketing, pnlCarrerasEmpresariales);
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

                DisolveSelecction(btnContaduria, pnlCarrerasEmpresariales);
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                DisolveSelecction(btnContaduria, pnlCarrerasEmpresariales);
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

                DisolveSelecction(btnFinanciera, pnlCarrerasEmpresariales);
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio)); 
                DisolveSelecction(btnFinanciera, pnlCarrerasEmpresariales);
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
                DisolveSelecction(btnComunicacion, pnlCarrerasEmpresariales);
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                DisolveSelecction(btnComunicacion, pnlCarrerasEmpresariales);
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
                DisolveSelecction(btnIndustrial, pnlCarrerasTenologia);
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                DisolveSelecction(btnIndustrial, pnlCarrerasTenologia);
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
                DisolveSelecction(btnPetrolera, pnlCarrerasTenologia);
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                DisolveSelecction(btnPetrolera, pnlCarrerasTenologia);
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
                DisolveSelecction(btnElectronica, pnlCarrerasTenologia);
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                DisolveSelecction(btnElectronica, pnlCarrerasTenologia);
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
                DisolveSelecction(iconButton5, pnlCarrerasTenologia);
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                DisolveSelecction(iconButton5, pnlCarrerasTenologia);
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
                DisolveSelecction(btnMecanica, pnlCarrerasTenologia);
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                DisolveSelecction(btnMecanica, pnlCarrerasTenologia);
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
                DisolveSelecction(btnRedes, pnlCarrerasTenologia);
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                DisolveSelecction(btnRedes, pnlCarrerasTenologia);
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
                DisolveSelecction(btnElectrica, pnlCarrerasTenologia);
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                DisolveSelecction(btnElectrica, pnlCarrerasTenologia);
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
                DisolveSelecction(btnDerecho, pnlCarrerasJuridicas);
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                DisolveSelecction(btnDerecho, pnlCarrerasJuridicas);
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
                DisolveSelecction(btnRelInter, pnlCarrerasJuridicas);
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                DisolveSelecction(btnRelInter, pnlCarrerasJuridicas);
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
                DisolveSelecction(btnPsicologia, pnlCarrerasJuridicas);
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                DisolveSelecction(btnPsicologia, pnlCarrerasJuridicas);
            }
        }



        #endregion

        private void pnlFrmHijo_Paint(object sender, PaintEventArgs e)
        {

        }

        

        public void HidenMenus()
        {
            if (pnlSubMenuPerfiles.Visible == true)
                pnlSubMenuPerfiles.Visible = false;
            if (pnlSubMenuDefensa.Visible == true)
                pnlSubMenuDefensa.Visible = false;

        }
        public void ShowMenus(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                HidenMenus();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
                

        }
        public void CustomizeDesing()
        {

            pnlSubMenuPerfiles.Visible = false;
            pnlSubMenuDefensa.Visible = false;
            pnlCarrerasJuridicas.Visible = false;
            pnlCarrerasEmpresariales.Visible = false;
            pnlCarrerasTenologia.Visible = false;
        }
        

        private void KeepSelecction(IconButton iconbtn, Panel pnl)
        {
            
          
                pnl.Visible = true;
                iconbtn.BackColor = Color.FromArgb(178, 8, 55);
                iconbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                iconbtn.TextAlign = ContentAlignment.MiddleRight;
                iconbtn.ImageAlign = ContentAlignment.MiddleRight;

                
           

        }
        private void DisolveSelecction(IconButton iconbtn, Panel pnl)
        {
        
            pnl.Visible = false;
            iconbtn.BackColor = Color.FromArgb(64, 64, 64);
            iconbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtn.TextAlign = ContentAlignment.MiddleLeft;
            iconbtn.ImageAlign = ContentAlignment.MiddleLeft;
        }

        
    }
}
