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
    public partial class FrmCarreraExterna : Form
    {
        //BORDE SOMBREADO FORMULAR
        private const int CS_DROPSHADOW = 0x20000;
        CapaNegocio.carreraExterna.Index obj = new CapaNegocio.carreraExterna.Index();
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

        public FrmCarreraExterna()
        {
            InitializeComponent();
            cargarCarrerasExternas();
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

       

        void cargarCarrerasExternas(string criterio = null)
        {
            bool pass = String.IsNullOrEmpty(criterio);
            if (pass)
            {

                dtgCarreraExterna.Rows.Clear();
                int campo1 = 1;
                var list = obj.showCarreraExterna();
                foreach (var item in list)
                {
                    string campo0 = Convert.ToString(item.Id);
                    string campo2 = item.Nombre;
                    string[] row = new string[] { campo0, Convert.ToString(campo1), campo2 };
                    this.dtgCarreraExterna.Rows.Add(row);
                    campo1++;
                }
            }
            else
            {
                dtgCarreraExterna.Rows.Clear();
                int campo1 = 1;
                var list = obj.showCarreraExterna(criterio);
                foreach (var item in list)
                {
                    string campo0 = Convert.ToString(item.Id);
                    string campo2 = item.Nombre;
                    string[] row = new string[] { campo0, Convert.ToString(campo1), campo2 };
                    this.dtgCarreraExterna.Rows.Add(row);
                    campo1++;
                }

            }
        }



        #endregion

        private void FrmCarrera_Load(object sender, EventArgs e)
        {

        }

        private void pnlBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCarreraExt_Click(object sender, EventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(idlbl.Text);
                if (id > 0)
                {
                    string nombre = txtNombreCarreraLic.Text;
                    obj.updateCarreraExterna(id, nombre);
                    cargarCarrerasExternas();
                    txtNombreCarreraLic.Clear();
                    idlbl.Text = "0";
                }
                else
                {

                    string nombre = txtNombreCarreraLic.Text;
                    obj.createCarreraExterna(nombre);
                    cargarCarrerasExternas();
                    txtNombreCarreraLic.Clear();
                    idlbl.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditarCarreraExt_Click(object sender, EventArgs e)
        {
            if (dtgCarreraExterna.CurrentRow != null)
            {
                int id_seleccionado = Convert.ToInt32(dtgCarreraExterna.CurrentRow.Cells[0].Value.ToString());
                string nombre = dtgCarreraExterna.CurrentRow.Cells[2].Value.ToString();
                idlbl.Text = Convert.ToString(id_seleccionado);
                txtNombreCarreraLic.Text = nombre;
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna revisión");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgCarreraExterna.CurrentRow != null)
            {
                int id_seleccionado = Convert.ToInt32(dtgCarreraExterna.CurrentRow.Cells[0].Value.ToString());
                obj.deleteCarreraExterna(id_seleccionado);
                cargarCarrerasExternas();

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
                string criterio = txtBuscarCarreraExt.Text;
                cargarCarrerasExternas(criterio);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
