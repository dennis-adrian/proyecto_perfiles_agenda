﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaNegocio.src;

namespace CapaPresentacion.FormsAgregar
{
    public partial class FrmInstitucion : Form
    {
        #region Constructor

        public FrmInstitucion()
        {
            InitializeComponent();
        }

        #endregion

        #region Instancias

        Helpers helper = new Helpers();
        #endregion

        #region Atributos

        int posY = 0;
        int posX = 0;

        #endregion

        #region Buttons y Controls
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNuevaInstitucion_Click(object sender, EventArgs e)
        {
            try
            {
                Insert();
                txtNuevaInstitucion.Clear();
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void pnlBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        #endregion

        #region Metodos
        public void Insert()
        {
            string nombre = txtNuevaInstitucion.Text;
            Object[] datos = new Object[] { nombre };
            helper.ControlInput(datos);
            helper.MainInsertInstitucion();
        }


        #endregion
    }
}
