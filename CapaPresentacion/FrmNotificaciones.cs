using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmNotificaciones : Form
    {
        private int perfil;
        public enum enmAcciones
        {
            esperar,
            abrir,
            empezar,
            eliminar
        }

        private FrmNotificaciones.enmAcciones accion;

        private int x, y;

        #region Methods

        public FrmNotificaciones()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.accion)
            {
                case enmAcciones.esperar:
                    timer1.Interval = 10000;
                    accion = enmAcciones.eliminar;
                    break;
                case enmAcciones.empezar:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if(this.x < this.Location.X)
                    {
                        this.Left--;
                    } 
                    else
                    {
                        if(this.Opacity == 1.0)
                        {
                            accion = enmAcciones.esperar;
                        }
                    }
                    break;
                    case enmAcciones.eliminar:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        public void mostrarNotificaciones(int idNotficacion, string titulo, string mensaje, string prioridad, string tipo, string hora, string fecha, int idPerfil)
        {
            this.perfil = idPerfil;
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fnombre;

            for (int i = 1; i < 10; i++)
            {
                fnombre = "alerta" + i.ToString();
                FrmNotificaciones frm = (FrmNotificaciones)Application.OpenForms[fnombre];

                if (frm == null)
                {
                    this.Name = fnombre;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (tipo)
            {
                case "perfil":
                    this.BackColor = Color.FromArgb(102,102,102);
                    break;
                case "perfils":
                    this.BackColor = Color.DarkRed;
                    break;
            }
            this.lblTitulo.Text = $"{idNotficacion} {titulo}";
            this.lblMsg.Text = mensaje;
            this.lblHora.Text = $"{hora} / {fecha.Substring(0, fecha.Length - 5)}";

            this.Show();
            this.accion = enmAcciones.empezar;
            this.timer1.Interval = 1;
            timer1.Start();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            CapaNegocio.notificaciones.Index obj = new CapaNegocio.notificaciones.Index();
            bool result = obj.markAsRead(perfil);

            MessageBox.Show(perfil.ToString());
            MessageBox.Show(result.ToString());
            
            timer1.Interval = 1;
            accion = enmAcciones.eliminar;
        }
        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            FrmRevisiones frm = new FrmRevisiones(perfil);
            frm.Show();
            timer1.Interval = 1;
            accion = enmAcciones.eliminar;
        }
        #endregion
    }
}
