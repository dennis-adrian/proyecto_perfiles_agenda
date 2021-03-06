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
    public partial class FrmAgregarGenerico : Form
    {
        //BORDE SOMBREADO FORMULAR
        private const int CS_DROPSHADOW = 0x20000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        #region Constructor

        public FrmAgregarGenerico()
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

        private void FrmInstitucion_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgInstitucion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevaInstitu_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.btnBuscar.IconColor = Color.White;
            this.btnBuscar.IconColor = Color.Black;
        }
    }
}
