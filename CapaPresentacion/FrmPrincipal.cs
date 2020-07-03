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
        //campos
        private bool facultadJuridicasClickeada;
        private bool facultadTecnologiaClickeada;
        private bool facultadEmpresarialesClickeada;
        private IconButton btnFacultadActual;
        private IconButton btnCarreraActual;
        private IconButton btnActual;
        private string facultad;
        private string carrera;
        //frm hijo
        private Form frmHijoActual;


        //constructor
        public FrmPrincipal()
        {
            InitializeComponent();
            pnlPerfiles.Size = MinimumSize;
            pnlDefensaExterna.Size = MinimumSize;
            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
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
            /*frmNuevaDefensaExterna = new FrmNuevaDefensaExterna();
            frmNuevaDefensaExterna.Show();*/
            ///////////////SE ESTA PONIENDO DENTRO DEL FORMULARIO PRINCIPAL//////////
            lblTitulo.Text = "NUEVA DEFENSA";
            frmNuevaDefensaExterna = new FrmNuevaDefensaExterna();
            abrirFrmHijo(frmNuevaDefensaExterna);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (frmHijoActual != null)
            {
                frmHijoActual.Close();
            }
            ReiniciarForm();
        }
        private void ReiniciarForm()
        {
            pnlDefensaExterna.Size = MinimumSize;
            pnlPerfiles.Size = MinimumSize;
            deshabilitarResaltado();
        }
        #region Expandir_Retraer_Facultades
        private void btnPerfiles_Click(object sender, EventArgs e)
        {
            btnActual = (IconButton)sender;
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
            activarBoton(sender, ColoresRgb.rojoUtepsa);
        }
        private void btnDefensaExterna_Click(object sender, EventArgs e)
        {
            btnActual = (IconButton)sender;
           
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
            activarBoton(sender, ColoresRgb.rojoUtepsa);
        }
        private void mostrarFacultades(Panel panel)
        {
            //btnActual = (IconButton)boton;
            panel.Height += 124;
            //if (panel.Size == panel.MaximumSize)
            //{
            //    switch (btnActual.Name)
            //    {
            //        case "btnDefensaExterna":
            //            esMinimizadoPerfiles = true;
            //            esMinimizadoAgenda = false;
            //            break;
            //        case "btnPerfiles":
            //            esMinimizadoAgenda = true;
            //            esMinimizadoPerfiles = false;
            //            break;
            //        default:
            //            break;
            //    }
            //}
        }
        private void ocultarFacultades(Panel panel)
        {
            //btnActual = (IconButton)boton;
            panel.Height -= 124;
            //if (panel.Size == panel.MinimumSize)
            //{
            //    switch (btnActual.Name)
            //    {
            //        case "btnDefensaExterna":
            //            esMinimizadoPerfiles = true;
            //            esMinimizadoAgenda = false;
            //            break;
            //        case "btnPerfiles":
            //            esMinimizadoAgenda = true;
            //            esMinimizadoPerfiles = false;
            //            break;
            //        default:
            //            break;
            //    }
            //}
        }
        private struct ColoresRgb
        {
            public static Color color1 = Color.FromArgb(43, 228, 240);
            public static Color rojoUtepsa = Color.FromArgb(178, 8, 55);
        }
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
        #endregion
        #region Botones_Y_Efectos

        #endregion
        #region Mostrar_Ocultar_Carreras
        private void btnEmpresarialesPerfiles_Click(object sender, EventArgs e)
        {
            string facultad = guardarFacultadClickeada(sender);
            facultadEmpresarialesClickeada = true;
            ocultarCarrerasTecnologia();
            facultadTecnologiaClickeada = false;
            ocultarCarrerasJuridicas();
            facultadJuridicasClickeada = false;
        }
        private void btnEmpresarialesPerfiles_MouseHover(object sender, EventArgs e)
        {
            facultad = guardarFacultadClickeada(sender);
            mostrarCarrerasEmpresariales();
            ocultarCarrerasTecnologia();
            facultadTecnologiaClickeada = false;
            ocultarCarrerasJuridicas();
            facultadJuridicasClickeada = false;
        }
        private void btnEmpresariales_MouseLeave(object sender, EventArgs e)
        {
            if (!this.facultadEmpresarialesClickeada)
            {
                ocultarCarrerasEmpresariales();
            }
        }
        private void mostrarCarrerasEmpresariales()
        {
            pnlCarrerasEmpresariales.Visible = true;
            btnEmpresarialesPefiles.BackColor = Color.FromArgb(178, 8, 55);
            btnEmpresarialesPefiles.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEmpresarialesPefiles.TextAlign = ContentAlignment.MiddleRight;
            btnEmpresarialesPefiles.ImageAlign = ContentAlignment.MiddleRight;

        }
        private void ocultarCarrerasEmpresariales()
        {
            pnlCarrerasEmpresariales.Visible = false;
            btnEmpresarialesPefiles.BackColor = Color.FromArgb(64, 64, 64);
            btnEmpresarialesPefiles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmpresarialesPefiles.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpresarialesPefiles.ImageAlign = ContentAlignment.MiddleLeft;
        }
        private void btnJuridicasPerfiles_Click(object sender, EventArgs e)
        {
            facultad = guardarFacultadClickeada(sender);
            ocultarCarrerasTecnologia();
            facultadTecnologiaClickeada = false;
            ocultarCarrerasEmpresariales();
            facultadEmpresarialesClickeada = false;
            facultadJuridicasClickeada = true;
        }
        private void mostrarCarrerasJuridicas()
        {
            pnlCarrerasJuridicas.Visible = true;
            btnJuridicasPerfiles.BackColor = Color.FromArgb(178, 8, 55);
            btnJuridicasPerfiles.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnJuridicasPerfiles.TextAlign = ContentAlignment.MiddleRight;
            btnJuridicasPerfiles.ImageAlign = ContentAlignment.MiddleRight;
            
        }
        private void ocultarCarrerasJuridicas()
        {
            pnlCarrerasJuridicas.Visible = false;
            btnJuridicasPerfiles.BackColor = Color.FromArgb(64, 64, 64);
            btnJuridicasPerfiles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnJuridicasPerfiles.TextAlign = ContentAlignment.MiddleLeft;
            btnJuridicasPerfiles.ImageAlign = ContentAlignment.MiddleLeft;
        }
        private void btnJuridicasPerfiles_MouseLeave(object sender, EventArgs e)
        {
            if (!facultadJuridicasClickeada)
            {
                ocultarCarrerasJuridicas();
            }
        }

        private void btnJuridicasPerfiles_MouseHover(object sender, EventArgs e)
        {
            mostrarCarrerasJuridicas();
            ocultarCarrerasTecnologia();
            facultadTecnologiaClickeada = false;
            ocultarCarrerasEmpresariales();
            facultadEmpresarialesClickeada = false;
        }

        private void btnTecnologiaPerfiles_Click(object sender, EventArgs e)
        {
            string facultad = guardarFacultadClickeada(sender);
            facultadTecnologiaClickeada = true;
            ocultarCarrerasEmpresariales();
            facultadEmpresarialesClickeada = false;
            ocultarCarrerasJuridicas();
            facultadJuridicasClickeada = false;
        }

        private void btnTecnologiaPerfiles_MouseHover(object sender, EventArgs e)
        {
            mostrarCarrerasTenologia();
            ocultarCarrerasEmpresariales();
            facultadEmpresarialesClickeada = false;
            ocultarCarrerasJuridicas();
            facultadJuridicasClickeada = false;
        }

        private void btnTecnologiaPerfiles_MouseLeave(object sender, EventArgs e)
        {
            if (!this.facultadTecnologiaClickeada)
            {
                ocultarCarrerasTecnologia();
            }
        }
        private void mostrarCarrerasTenologia()
        {
            pnlCarrerasTenologia.Visible = true;
            btnTecnologiaPerfiles.BackColor = Color.FromArgb(178, 8, 55);
            btnTecnologiaPerfiles.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnTecnologiaPerfiles.TextAlign = ContentAlignment.MiddleRight;
            btnTecnologiaPerfiles.ImageAlign = ContentAlignment.MiddleRight;

        }
        private void ocultarCarrerasTecnologia()
        {
            pnlCarrerasTenologia.Visible = false;
            btnTecnologiaPerfiles.BackColor = Color.FromArgb(64, 64, 64);
            btnTecnologiaPerfiles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTecnologiaPerfiles.TextAlign = ContentAlignment.MiddleLeft;
            btnTecnologiaPerfiles.ImageAlign = ContentAlignment.MiddleLeft;
        }
        #endregion
        #region Botones_Facultades
        private void btnEmpresarialesAgenda_MouseHover(object sender, EventArgs e)
        {
            mostrarCarrerasEmpresariales();
            ocultarCarrerasTecnologia();
            facultadTecnologiaClickeada = false;
            ocultarCarrerasJuridicas();
            facultadJuridicasClickeada = false;
        }

        private void btnEmpresarialesAgenda_MouseLeave(object sender, EventArgs e)
        {
            if (!this.facultadEmpresarialesClickeada)
            {
                ocultarCarrerasEmpresariales();
            }
        }

        private void btnTecnologiaAgenda_MouseHover(object sender, EventArgs e)
        {
            mostrarCarrerasTenologia();
            ocultarCarrerasEmpresariales();
            facultadEmpresarialesClickeada = false;
            ocultarCarrerasJuridicas();
            facultadJuridicasClickeada = false;
        }
        private void btnTecnologiaAgenda_MouseLeave(object sender, EventArgs e)
        {
            if (!this.facultadTecnologiaClickeada)
            {
                ocultarCarrerasTecnologia();
            }
        }
        private void btnJuridicasAgenda_MouseHover(object sender, EventArgs e)
        {
            pnlCarrerasJuridicas.Visible = true;
            btnJuridicasPerfiles.BackColor = Color.FromArgb(178, 8, 55);
            btnJuridicasPerfiles.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnJuridicasPerfiles.TextAlign = ContentAlignment.MiddleRight;
            btnJuridicasPerfiles.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void btnJuridicasAgenda_MouseLeave(object sender, EventArgs e)
        {
            if (!facultadJuridicasClickeada)
            {
                ocultarCarrerasJuridicas();
            }
        }

        private void btnEmpresarialesAgenda_Click(object sender, EventArgs e)
        {
            facultad = guardarFacultadClickeada(sender);
            facultadEmpresarialesClickeada = true;
            ocultarCarrerasTecnologia();
            facultadTecnologiaClickeada = false;
            ocultarCarrerasJuridicas();
            facultadJuridicasClickeada = false;
        }

        private void btnTecnologiaAgenda_Click(object sender, EventArgs e)
        {
            facultad = guardarFacultadClickeada(sender);
            facultadTecnologiaClickeada = true;
            ocultarCarrerasEmpresariales();
            facultadEmpresarialesClickeada = false;
            ocultarCarrerasJuridicas();
            facultadJuridicasClickeada = false;
        }

        private void btnJuridicasAgenda_Click(object sender, EventArgs e)
        {
            facultad = guardarFacultadClickeada(sender);
            ocultarCarrerasTecnologia();
            facultadTecnologiaClickeada = false;
            ocultarCarrerasEmpresariales();
            facultadEmpresarialesClickeada = false;
            facultadJuridicasClickeada = true;
        }
        private string guardarFacultadClickeada(object btnRemitente)
        {
            btnFacultadActual = (IconButton)btnRemitente;
            return btnFacultadActual.Text;
        }
        #endregion
        #region Botones_Carreras
        private string guardarCarreraClickeada(object btnRemitente)
        {
            btnCarreraActual = (IconButton)btnRemitente;
            return btnCarreraActual.Text;
            
        }
        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            carrera = guardarCarreraClickeada(sender);
            lblTitulo.Text = carrera;
            string criterio = carrera;
            string actual = btnActual.Text;
            if (actual == "Defensa Externa")
            {
                abrirFrmHijo(new FrmAgenda(criterio));
                ocultarCarrerasEmpresariales();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                ocultarCarrerasEmpresariales();
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
                ocultarCarrerasEmpresariales();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                ocultarCarrerasEmpresariales();
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
                ocultarCarrerasEmpresariales();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                ocultarCarrerasEmpresariales();
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
                ocultarCarrerasEmpresariales();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                ocultarCarrerasEmpresariales();
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
                ocultarCarrerasEmpresariales();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                ocultarCarrerasEmpresariales();
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
                ocultarCarrerasEmpresariales();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                ocultarCarrerasEmpresariales();
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
                ocultarCarrerasEmpresariales();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                ocultarCarrerasEmpresariales();
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
                ocultarCarrerasEmpresariales();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                ocultarCarrerasEmpresariales();
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
                ocultarCarrerasTecnologia();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                ocultarCarrerasTecnologia();
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
                ocultarCarrerasTecnologia();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                ocultarCarrerasTecnologia();
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
                ocultarCarrerasTecnologia();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                ocultarCarrerasTecnologia();
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
                ocultarCarrerasTecnologia();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                ocultarCarrerasTecnologia();
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
                ocultarCarrerasTecnologia();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                ocultarCarrerasTecnologia();
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
                ocultarCarrerasTecnologia();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                ocultarCarrerasTecnologia();
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
                ocultarCarrerasTecnologia();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                ocultarCarrerasTecnologia();
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
                ocultarCarrerasJuridicas();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                ocultarCarrerasJuridicas();
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
                ocultarCarrerasJuridicas();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                ocultarCarrerasJuridicas();
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
                ocultarCarrerasJuridicas();
            }
            else
            {
                abrirFrmHijo(new FrmPerfiles(criterio));
                ocultarCarrerasJuridicas();
            }
        }
        #endregion

        #region Abriendo_Formularios
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
        #endregion
        #region BarraTituloYBotones
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

        
    }
}
