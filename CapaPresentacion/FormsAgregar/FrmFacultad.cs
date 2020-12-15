using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.FormsAgregar
{
    public partial class FrmFacultad : Form
    {
        //BORDE SOMBREADO FORMULAR
        private const int CS_DROPSHADOW = 0x20000;
        CapaNegocio.facultad.Index obj = new CapaNegocio.facultad.Index();
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        public FrmFacultad()
        {
            InitializeComponent();
            incializador();
        }

        int posY = 0;
        int posX = 0;
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
        public void incializador()
        {
            cargarfacultades();
        }

        void cargarfacultades(string criterio = null)
        {
            bool pass = String.IsNullOrEmpty(criterio);
            if(pass)
            {

                dtgFacultad.Rows.Clear();
                int campo1 = 1;
                var list = obj.showFacultades();
                foreach (var item in list)
                {
                    string campo0 = Convert.ToString(item.Id);
                    string campo2 = item.Nombre;
                    string[] row = new string[] { campo0, Convert.ToString(campo1), campo2 };
                    this.dtgFacultad.Rows.Add(row);
                    campo1++;
                }
            }
            else
            {
                dtgFacultad.Rows.Clear();
                int campo1 = 1;
                var list = obj.showFacultades(criterio);
                foreach (var item in list)
                {
                    string campo0 = Convert.ToString(item.Id);
                    string campo2 = item.Nombre;
                    string[] row = new string[] { campo0, Convert.ToString(campo1), campo2 };
                    this.dtgFacultad.Rows.Add(row);
                    campo1++;
                }

            }
        }

        private void btnGuardarFacu_Click(object sender, EventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(idlbl.Text);
                if(id > 0)
                {
                    string nombre = txtNombreFacultad.Text;
                    obj.updateFacultad(id, nombre);
                    cargarfacultades();
                    txtNombreFacultad.Clear();
                    idlbl.Text = "0";
                }
                else
                {

                    string nombre = txtNombreFacultad.Text;
                    obj.createFacultad(nombre);
                    cargarfacultades();
                    txtNombreFacultad.Clear();
                    idlbl.Text = "0";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgFacultad.CurrentRow != null)
            {
                int id_seleccionado = Convert.ToInt32(dtgFacultad.CurrentRow.Cells[0].Value.ToString());
                obj.deleteFacultad(id_seleccionado);
                cargarfacultades();

            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna revisión");
            }
        }

        private void btnEditarFacu_Click(object sender, EventArgs e)
        {
            if (dtgFacultad.CurrentRow != null)
            {
                int id_seleccionado = Convert.ToInt32(dtgFacultad.CurrentRow.Cells[0].Value.ToString());
                string nombre = dtgFacultad.CurrentRow.Cells[2].Value.ToString();
                idlbl.Text = Convert.ToString(id_seleccionado);
                txtNombreFacultad.Text = nombre; 
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
                string criterio = txtBuscarFacultad.Text;
                cargarfacultades(criterio);


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelecFacu_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarFacultad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void idlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
