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
using CapaNegocio.src;

namespace CapaPresentacion.FormsAgregar
{
    public partial class FrmInstitucion : Form
    {
        //BORDE SOMBREADO FORMULAR
        private const int CS_DROPSHADOW = 0x20000;
        CapaNegocio.institucion.Index obj = new CapaNegocio.institucion.Index();
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

        public FrmInstitucion()
        {
            InitializeComponent();
            cargarInstituciones();
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        void cargarInstituciones(string criterio = null)
        {
            bool pass = String.IsNullOrEmpty(criterio);
            if (pass)
            {

                dtgInstitucion.Rows.Clear();
                int campo1 = 1;
                var list = obj.showInstituciones();
                foreach (var item in list)
                {
                    string campo0 = Convert.ToString(item.Id);
                    string campo2 = item.Nombre;
                    string[] row = new string[] { campo0, Convert.ToString(campo1), campo2 };
                    this.dtgInstitucion.Rows.Add(row);
                    campo1++;
                }
            }
            else
            {
                dtgInstitucion.Rows.Clear();
                int campo1 = 1;
                var list = obj.showInstituciones(criterio);
                foreach (var item in list)
                {
                    string campo0 = Convert.ToString(item.Id);
                    string campo2 = item.Nombre;
                    string[] row = new string[] { campo0, Convert.ToString(campo1), campo2 };
                    this.dtgInstitucion.Rows.Add(row);
                    campo1++;
                }

            }
        }
        private void btnNuevaInstitu_Click_1(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNuevaInstitucion.Text;
                bool passnombre = String.IsNullOrEmpty(nombre);

                if (passnombre)
                {
                    MessageBox.Show("el Campo nombre esta vacio");
                }
                else
                {


                    int id = Convert.ToInt32(idlbl.Text);
                    if (id > 0)
                    {

                        obj.updateInstitucion(id, nombre);
                        cargarInstituciones();
                        txtNuevaInstitucion.Clear();
                        idlbl.Text = "0";
                    }
                    else
                    {

                        obj.createInstitucion(nombre);
                        cargarInstituciones();
                        txtNuevaInstitucion.Clear();
                        idlbl.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditarInstitu_Click(object sender, EventArgs e)
        {
            if (dtgInstitucion.CurrentRow != null)
            {
                int id_seleccionado = Convert.ToInt32(dtgInstitucion.CurrentRow.Cells[0].Value.ToString());
                string nombre = dtgInstitucion.CurrentRow.Cells[2].Value.ToString();
                idlbl.Text = Convert.ToString(id_seleccionado);
                txtNuevaInstitucion.Text = nombre;
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna revisión");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = txtBuscarInstitu.Text;
                cargarInstituciones(criterio);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
