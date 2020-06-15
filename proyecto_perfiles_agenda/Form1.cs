using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        //campos
        private bool esMinimizado;
        //guardamos el boton actual
        private IconButton btnActual;
        //borde izquierdo del boton
        private Panel bordeIzqBtn;
        private Form currentChildForm;
        
        //constructor
        public Form1()
        {
            InitializeComponent();
            //inicializamos el borde izq del boton
            bordeIzqBtn = new Panel();
            //asiganmos un tamano
            bordeIzqBtn.Size = new Size(7, 51);

            //agregamos el borde a los botones del panel menu
            panel1.Controls.Add(bordeIzqBtn);
            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        #region Expandir_Retraer_Facultades
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (esMinimizado)
            {
                mostrarFacultades();
            }
            else
            {
                ocultarFacultades();
            }
        }
        private void mostrarFacultades()
        {
            pnlPerfiles.Height += 80;
            if (pnlPerfiles.Size == pnlPerfiles.MaximumSize)
            {
                timer1.Stop();
                esMinimizado = false;
            }
        }
        private void ocultarFacultades()
        {
            pnlPerfiles.Height -= 124;
            if (pnlPerfiles.Size == pnlPerfiles.MinimumSize)
            {
                timer1.Stop();
                esMinimizado = true;
            }
        }
        #endregion
        #region Botones_Y_Efectos
        private struct ColoresRgb
        {
            public static Color color1 = Color.FromArgb(43, 228, 240);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color rojoUtepsa = Color.FromArgb(178, 8, 55);
        }
        private void  ActivarBoton(object btnRemitente, Color color)
        {
            Panel borde = new Panel();
            if(btnRemitente != null)
            {
                DeshabilitarResaltado();

                btnActual = (IconButton)btnRemitente;
                btnActual.BackColor = Color.FromArgb(178, 8, 55);
                //btnActual.ForeColor = color;
                btnActual.TextAlign = ContentAlignment.MiddleCenter;
                //btnActual.IconColor = color;
                btnActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnActual.ImageAlign = ContentAlignment.MiddleCenter;
                btnActual.Padding = new Padding(40, 0, 0, 0);
                //panel borde izquierdo de boton
                pnlMenu.FlowDirection = FlowDirection.LeftToRight;
                borde.BackColor = color;
                //bordeIzqBtn.Location = new Point(0, btnActual.Location.Y);
                borde.Location = new Point(30, 248);
                borde.Visible = true;
                borde.BringToFront();
            }
        }
        private void DeshabilitarResaltado()
        {
            if(btnActual != null)
            {
                btnActual.Padding = new Padding(40, 0, 0, 0);
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
            timer1.Start();
            ActivarBoton(sender, ColoresRgb.rojoUtepsa);
            pnlMenu.Controls.Add(bordeIzqBtn);
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, ColoresRgb.color1);
            pnlMenu.Controls.Add(bordeIzqBtn);
            ocultarFacultades();
            
        }
        #endregion
    }
}
