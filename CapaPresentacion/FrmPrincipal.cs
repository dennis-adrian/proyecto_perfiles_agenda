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
        private bool esMinimizadoPerfiles = true;
        private bool esMinimizadoAgenda = true;
        private bool facultadJuridicasClickeada;
        private bool facultadTecnologiaClickeada;
        private bool facultadEmpresarialesClickeada;
        private IconButton btnActual;
        public static bool frmNuevoPerfilCerrado = false;
        private bool carrerasVisible;
        //frm hijo
        private Form frmHijoActual;


        //constructor
        public FrmPrincipal()
        {
            InitializeComponent();

            pnlPerfiles.Size = MinimumSize;
            pnlAgenda.Size = MinimumSize;
            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        #region Expandir_Retraer_Facultades
        private void mostrarFacultades(Panel panel, string nombrePanel)
        {
            panel.Height += 124;
            if (panel.Size == panel.MaximumSize)
            {
                switch (nombrePanel)
                {
                    case "agenda":
                        esMinimizadoPerfiles = true;
                        esMinimizadoAgenda = false;
                        break;
                    case "perfiles":
                        esMinimizadoAgenda = true;
                        esMinimizadoPerfiles = false;
                        break;
                    default:
                        break;
                }
            }
        }
        private void ocultarFacultades(Panel panel, string nombrePanel)
        {
            panel.Height -= 124;
            if (panel.Size == panel.MinimumSize)
            {
                switch (nombrePanel)
                {
                    case "agenda":
                        esMinimizadoPerfiles = true;
                        esMinimizadoAgenda = false;
                        break;
                    case "perfiles":
                        esMinimizadoAgenda = true;
                        esMinimizadoPerfiles = false;
                        break;
                    default:
                        break;
                }
            }
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

                btnActual = (IconButton)btnRemitente;
                btnActual.BackColor = Color.FromArgb(178, 8, 55);
                //btnActual.ForeColor = color;
                btnActual.TextAlign = ContentAlignment.MiddleCenter;
                //btnActual.IconColor = color;
                btnActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnActual.ImageAlign = ContentAlignment.MiddleCenter;
                //btnActual.Padding = new Padding(40, 0, 0, 0);
            }
        }
        private void deshabilitarResaltado()
        {
            if (btnActual != null)
            {
                //btnActual.Padding = new Padding(40, 0, 0, 0);
                btnActual.BackColor = Color.FromArgb(102, 102, 102);
                btnActual.ForeColor = Color.White;
                //btnActual.TextAlign = ContentAlignment.MiddleLeft;
                btnActual.IconColor = Color.White;
                btnActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                //btnActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void btnPerfiles_Click(object sender, EventArgs e)
        {
            if (esMinimizadoPerfiles)
            {
                mostrarFacultades(pnlPerfiles, "perfiles");
            }
            else
            {
                ocultarFacultades(pnlPerfiles, "perfiles");
            }
            activarBoton(sender, ColoresRgb.rojoUtepsa);
            ocultarFacultades(pnlAgenda, "perfiles");
        }
        private void btnAgenda_Click(object sender, EventArgs e)
        {
            abrirFrmHijo(new FrmAgenda());
            if (esMinimizadoAgenda)
            {
                mostrarFacultades(pnlAgenda, "agenda");
            }
            else
            {
                ocultarFacultades(pnlAgenda, "agenda");
            }
            activarBoton(sender, ColoresRgb.color1);
            ocultarFacultades(pnlPerfiles, "agenda");
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
            carrerasVisible = true;

        }
        private void ocultarCarrerasEmpresariales()
        {
            pnlCarrerasEmpresariales.Visible = false;
            btnEmpresarialesPefiles.BackColor = Color.FromArgb(64, 64, 64);
            btnEmpresarialesPefiles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmpresarialesPefiles.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpresarialesPefiles.ImageAlign = ContentAlignment.MiddleLeft;
            carrerasVisible = false;
        }
        private void btnJuridicasPerfiles_Click(object sender, EventArgs e)
        {
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
            carrerasVisible = true;
            
        }
        private void ocultarCarrerasJuridicas()
        {
            pnlCarrerasJuridicas.Visible = false;
            btnJuridicasPerfiles.BackColor = Color.FromArgb(64, 64, 64);
            btnJuridicasPerfiles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnJuridicasPerfiles.TextAlign = ContentAlignment.MiddleLeft;
            btnJuridicasPerfiles.ImageAlign = ContentAlignment.MiddleLeft;
            carrerasVisible = false;
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
            carrerasVisible = true;

        }
        private void ocultarCarrerasTecnologia()
        {
            pnlCarrerasTenologia.Visible = false;
            btnTecnologiaPerfiles.BackColor = Color.FromArgb(64, 64, 64);
            btnTecnologiaPerfiles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTecnologiaPerfiles.TextAlign = ContentAlignment.MiddleLeft;
            btnTecnologiaPerfiles.ImageAlign = ContentAlignment.MiddleLeft;
            carrerasVisible = false;
        }
        #endregion

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
            carrerasVisible = true;
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
            string facultad = guardarFacultadClickeada(sender);
            facultadEmpresarialesClickeada = true;
            ocultarCarrerasTecnologia();
            facultadTecnologiaClickeada = false;
            ocultarCarrerasJuridicas();
            facultadJuridicasClickeada = false;
        }

        private void btnTecnologiaAgenda_Click(object sender, EventArgs e)
        {
            string facultad = guardarFacultadClickeada(sender);
            facultadTecnologiaClickeada = true;
            ocultarCarrerasEmpresariales();
            facultadEmpresarialesClickeada = false;
            ocultarCarrerasJuridicas();
            facultadJuridicasClickeada = false;
        }

        private void btnJuridicasAgenda_Click(object sender, EventArgs e)
        {
            string facultad = guardarFacultadClickeada(sender);
            ocultarCarrerasTecnologia();
            facultadTecnologiaClickeada = false;
            ocultarCarrerasEmpresariales();
            facultadEmpresarialesClickeada = false;
            facultadJuridicasClickeada = true;
        }
        private string guardarFacultadClickeada(object btnRemitente)
        {
            btnActual = (IconButton)btnRemitente;
            return btnActual.Name;
        }

        private void btnNuevoPerfil_Click(object sender, EventArgs e)
        {
            activarBoton(sender, ColoresRgb.rojoUtepsa);
            Form frmNuevoPerfil = new FrmNuevoPerfil();
            frmNuevoPerfil.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHijoActual.Close();
            ReiniciarForm();
        }
        private void ReiniciarForm()
        {
            esMinimizadoAgenda = true;
            pnlAgenda.Size = MinimumSize;
            esMinimizadoPerfiles = true;
            pnlPerfiles.Size= MinimumSize;
            deshabilitarResaltado();
        }
        #region Arrastrar_Form
        
        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarForm.ReleaseCapture();
            ArrastrarForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
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

    }
}
