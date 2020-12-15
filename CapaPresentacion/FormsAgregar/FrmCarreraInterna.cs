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
    public partial class FrmCarreraInterna : Form
    {
        //BORDE SOMBREADO FORMULAR
        CapaNegocio.carreraInterna.Index obj = new CapaNegocio.carreraInterna.Index();
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

        public FrmCarreraInterna()
        {
            InitializeComponent();
            cargarCarreras();
            cargarFacultades();
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
                txtNombreCarrera.Clear();
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
            string nombre = txtNombreCarrera.Text;
            Object[] datos = new Object[] { nombre };
            helper.ControlInput(datos);
            helper.MainInsertInstitucion();
        }


        #endregion

        void cargarCarreras(string criterio = null)
        {
            bool pass = String.IsNullOrEmpty(criterio);
            if (pass)
            {

                dtgCarrera.Rows.Clear();
                int campo1 = 1;
                var list = obj.showCarrera();
                foreach (var item in list)
                {
                    string campo0 = Convert.ToString(item.Id);
                    string campo2 = item.Nombre;
                    string campo3 = Convert.ToString(item.Id_facultad);
                    string campo4 = item.Facultad;
                    string[] row = new string[] { campo0, Convert.ToString(campo1), campo2, campo3, campo4 };
                    this.dtgCarrera.Rows.Add(row);
                    campo1++;
                }
            }
            else
            {
                dtgCarrera.Rows.Clear();
                int campo1 = 1;
                var list = obj.showCarrera(criterio);
                foreach (var item in list)
                {
                    string campo0 = Convert.ToString(item.Id);
                    string campo2 = item.Nombre;
                    string campo3 = Convert.ToString(item.Id_facultad);
                    string campo4 = item.Facultad;
                    string[] row = new string[] { campo0, Convert.ToString(campo1), campo2,campo3,campo4 };
                    this.dtgCarrera.Rows.Add(row);
                    campo1++;
                }

            }
        }

        void cargarFacultades()
        {
            cmbFacultad.Items.Clear();
            cmbFacultad.DataSource = obj.showFacultades();
            cmbFacultad.ValueMember = "id";
            cmbFacultad.DisplayMember = "nombre";
        }

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
            try
            {

                int id = Convert.ToInt32(idlbl.Text);
                if (id > 0)
                {
                    string nombre = txtNombreCarrera.Text; 
                    int id_facultad = Convert.ToInt32(cmbFacultad.SelectedValue.ToString());
                    obj.updateCarrera(id, nombre,id_facultad);
                    cargarCarreras();
                    txtNombreCarrera.Clear();
                    idlbl.Text = "0";
                }
                else
                {

                    string nombre = txtNombreCarrera.Text;
                    int id_facultad = Convert.ToInt32(cmbFacultad.SelectedValue.ToString());
                    obj.createCarrera(nombre,id_facultad);
                    cargarCarreras();
                    txtNombreCarrera.Clear();
                    idlbl.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.btnBuscar.IconColor = Color.White;
            this.btnBuscar.IconColor = Color.Black;

            try
            {
                string criterio = txtBuscarCarrera.Text;
                cargarCarreras(criterio);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditarCarrera_Click(object sender, EventArgs e)
        {
            if (dtgCarrera.CurrentRow != null)
            {
                int id_seleccionado = Convert.ToInt32(dtgCarrera.CurrentRow.Cells[0].Value.ToString());
                string nombre = dtgCarrera.CurrentRow.Cells[2].Value.ToString();
                int id_fac = Convert.ToInt32(dtgCarrera.CurrentRow.Cells[3].Value.ToString());



                idlbl.Text = Convert.ToString(id_seleccionado);
                txtNombreCarrera.Text = nombre;
                cmbFacultad.SelectedValue = id_fac;
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna revisión");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtgCarrera.CurrentRow != null)
            {
                int id_seleccionado = Convert.ToInt32(dtgCarrera.CurrentRow.Cells[0].Value.ToString());
                obj.deleteCarrera(id_seleccionado);
                cargarCarreras();

            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna revisión");
            }
        }
    }
}
