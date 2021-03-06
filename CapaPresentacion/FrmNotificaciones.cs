﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private int idnotificacion;
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
        private string generarTituloNotificacion(string tipoNotificacion)
        {
            string title;
            if (tipoNotificacion == "revision")
                title = "Notificación de Revisión";
            else
                title = "Notificación de Perfil";
            return title;
        }
        private void generarMensajeYBackground(string tipo, string prioridad, string nombre)
        {
            switch (prioridad)
            {
                case "low":
                    this.BackColor = Color.FromArgb(245, 189, 31);
                    this.lblMsg.Text = tipo == "revision"
                        ? $"Al tribunal {nombre} le quedan 25 días para entregar el trabajo."
                        : $"Al perfil de {nombre} le quedan 25 días para expirar.";
                    break;
                case "normal":
                    this.BackColor = Color.FromArgb(250, 169, 51);
                    this.lblMsg.Text = tipo == "revision"
                        ? $"Al tribunal {nombre} le quedan 15 días para entregar el trabajo."
                        : $"Al perfil de {nombre} le quedan 15 días para expirar.";
                    break;
                case "important":
                    this.BackColor = Color.FromArgb(247, 147, 82);
                    this.lblMsg.Text = tipo == "revision"
                        ? $"Al tribunal {nombre} le quedan 10 días para entregar el trabajo."
                        : $"Al perfil de {nombre} le quedan 10 días para expirar.";
                    break;
                case "critical":
                    this.BackColor = Color.FromArgb(211, 89, 89);
                    this.lblMsg.Text = tipo == "revision"
                        ? $"Al tribunal {nombre} le quedan 5 días para entregar el trabajo."
                        : $"Al perfil de {nombre} le quedan 5 días para expirar.";
                    break;
                case "time-out":
                    this.BackColor = Color.FromArgb(147, 95, 95);
                    this.lblMsg.Text = tipo == "revision"
                        ? $"El tiempo de entrega para el tribunal {nombre} ya expiró."
                        : $"El perfil de {nombre} ya expiró.";
                    break;
            }
        }
        public void mostrarNotificaciones(int idNotficacion, string titulo, string mensaje, string prioridad, string tipo, string hora, string fecha, int idPerfil)
        {
            this.perfil = idPerfil;
            this.idnotificacion = idNotficacion;
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

            this.lblTitulo.Text = generarTituloNotificacion(tipo);
            generarMensajeYBackground(tipo, prioridad, "dennis");
            var fechaConvertida = DateTime.ParseExact(fecha, "dd-MM-yyyy", new CultureInfo("es-ES"));
            this.lblHora.Text = $"{fechaConvertida.ToString("dd MMM", new CultureInfo("es-ES"))} {hora}";

            this.Show();
            this.accion = enmAcciones.empezar;
            this.timer1.Interval = 1;
            timer1.Start();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            CapaNegocio.notificaciones.Index obj = new CapaNegocio.notificaciones.Index();
            bool result = obj.markAsRead(idnotificacion);

            //MessageBox.Show(perfil.ToString());
            //MessageBox.Show(result.ToString());
            
            timer1.Interval = 1;
            accion = enmAcciones.eliminar;
        }
        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            

            CapaNegocio.notificaciones.Index obj = new CapaNegocio.notificaciones.Index();
            bool result = obj.markAsRead(idnotificacion);
            if (result)
            {
                FrmRevisiones frm = new FrmRevisiones(perfil);
                frm.Show();
                timer1.Interval = 1;
                accion = enmAcciones.eliminar;

            }
            //MessageBox.Show(perfil.ToString());
            //MessageBox.Show(result.ToString());

        }
        #endregion
    }
}
