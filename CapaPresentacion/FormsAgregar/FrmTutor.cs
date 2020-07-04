using CapaPresentacion.FormsAgregar;
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
using CapaDatos.View;

namespace CapaPresentacion
{
    public partial class FrmTutor : Form
    {
        #region Constructor
        public FrmTutor()
        {
            InitializeComponent();
            InitialForms();
            
        }

        #endregion

        #region Instancias

        NegocioLicenciados obj = new NegocioLicenciados();

        #endregion

        #region Atributos
        int id_parametro = 0;
        #endregion

        #region Arrastrar_Form
        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarForm.ReleaseCapture();
            ArrastrarForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Buttons


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarLicenciado_Click(object sender, EventArgs e)
        {
            try
            {
                int id_seleccionado = Convert.ToInt32(dtgLicenciados.CurrentRow.Cells[0].Value.ToString());

                info(id_seleccionado);
                id_parametro = id_seleccionado;
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            

        }

        private void btnSeleccionarLicenciado_Click(object sender, EventArgs e)
        {
            int id_seleccionado = Convert.ToInt32(dtgLicenciados.CurrentRow.Cells[0].Value.ToString());


        }
        private void btnEliminarLicenciado_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Quiere eliminar este registro?", "Eliminar Licenciado", MessageBoxButtons.YesNo);
            if(dialogo == DialogResult.Yes)
            {
                try
                {
                    int id_seleccionado = Convert.ToInt32(dtgLicenciados.CurrentRow.Cells[0].Value.ToString());
                    delete(id_seleccionado);
                    ShowLicenciados();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(""+ex);

                }

            }
            else if(dialogo == DialogResult.No)
            {

            }

        }
        private void btnGuardarLicenciado_Click(object sender, EventArgs e)
        {
            try
            {
                int referencia = Convert.ToInt32(dtgLicenciados.CurrentRow.Cells[0].Value.ToString());

                if (id_parametro <= 0)
                {
                    Insert();
                    ClearForms();
                    ShowLicenciados();

                }
                else if(id_parametro > 0 && id_parametro == referencia)
                {
                    Update(id_parametro);
                    ClearForms();
                    ShowLicenciados();
                    id_parametro = 0;
                }
                else
                {
                    throw new ArgumentException("sin referencia para actualizar");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        private void btnAgregarCarrera_Click(object sender, EventArgs e)
        {
            FrmCarrera frm = new FrmCarrera();
            frm.ShowDialog();
        }

        private void btnAgregarInstitucion_Click(object sender, EventArgs e)
        {
            FrmInstitucion frm1 = new FrmInstitucion();
            frm1.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearForms();
            id_parametro = 0;
        }

        #endregion

        #region Metodos

        public void Insert()
        {
            string nombre = txtNombreLicenciado.Text; //input 0
            string apellido = txtApellidoLicenciado.Text;//input 1
            string descripcion = txtDescripcion.Text;//input 3
            string email = txtEmailLicenciado.Text;// input 4
            string telefono = txtTelefono.Text;// input 5
            string celular = txtCelular.Text;// input 6
            string tipo = txtTipo.Text;// input 7
            int docente = (rbDocenteSi.Checked) ? 1 : ((rbDocenteNo.Checked) ? 2 : 0);// input 8
            int id_institucion = Convert.ToInt32(cmbInstitucion.SelectedValue.ToString());// input 9
            int id_carrera = Convert.ToInt32(cmbCarreraLicenciado.SelectedValue.ToString());// input 10

            Object[] datos = new Object[]
            {
                nombre,
                apellido,
                descripcion,
                email,
                telefono,
                celular,
                tipo,
                docente,
                id_institucion ,
                id_carrera
            };

            obj.ControlInput(datos);
            obj.MainInsert();

        }
        public void Update(int i)
        {
            string nombre = txtNombreLicenciado.Text; //input 0
            string apellido = txtApellidoLicenciado.Text;//input 1
            string descripcion = txtDescripcion.Text;//input 3
            string email = txtEmailLicenciado.Text;// input 4
            string telefono = txtTelefono.Text;// input 5
            string celular = txtCelular.Text;// input 6
            string tipo = txtTipo.Text;// input 7
            int docente = (rbDocenteSi.Checked) ? 1 : ((rbDocenteNo.Checked) ? 2 : 0);// input 8
            int id_institucion = Convert.ToInt32(cmbInstitucion.SelectedValue.ToString());// input 9
            int id_carrera = Convert.ToInt32(cmbCarreraLicenciado.SelectedValue.ToString());// input 10

            Object[] datos = new Object[]
            {
                nombre,
                apellido,
                descripcion,
                email,
                telefono,
                celular,
                tipo,
                docente,
                id_institucion ,
                id_carrera
            };

            obj.ControlInput(datos);
            obj.MainUpdate(i);///

        }
        public void info(int i)
        {

            var Collection = obj.InfoLicenciado(i);

            txtNombreLicenciado.Text = Convert.ToString(Collection[1]);
            txtApellidoLicenciado.Text = Convert.ToString(Collection[2]);
            txtDescripcion.Text = Convert.ToString(Collection[3]);
            txtEmailLicenciado.Text = Convert.ToString(Collection[4]);
            txtTelefono.Text = Convert.ToString(Collection[5]);
            txtCelular.Text = Convert.ToString(Collection[6]);
            txtTipo.Text = Convert.ToString(Collection[7]);
            if (Convert.ToInt32(Collection[8]) == 1) { rbDocenteSi.Checked = true; } else { rbDocenteNo.Checked = true; }
            cmbInstitucion.SelectedValue = Convert.ToInt32(Collection[9]);
            cmbCarreraLicenciado.SelectedValue = Convert.ToInt32(Collection[10]);
        }
        
        public void delete(int i) 
        {
            obj.DeleteLicenciado(i);

        }
        public void ClearForms()
        {
            txtNombreLicenciado.Clear();
            txtApellidoLicenciado.Clear();
            txtDescripcion.Clear();
            txtEmailLicenciado.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();
            txtTipo.Clear();
            if (rbDocenteNo.Checked) { rbDocenteNo.Checked = false; } else { rbDocenteSi.Checked = false; }
        }
        public void InitialForms()
        {
            cmbInstitucion.Items.Clear();
            cmbCarreraLicenciado.Items.Clear();

            cmbInstitucion.DataSource = obj.cargarInstitucio();
            cmbInstitucion.ValueMember = "id";
            cmbInstitucion.DisplayMember = "nombre";

            cmbCarreraLicenciado.DataSource = obj.cargarCarrerasLicenciados();
            cmbCarreraLicenciado.ValueMember = "id";
            cmbCarreraLicenciado.DisplayMember = "nombre";

            ShowLicenciados();
        }
        public void ShowLicenciados()
        {
            var list = obj.Licenciados();
            var bindingList = new BindingList<ViewLicenciados>(list);
            var source = new BindingSource(bindingList, null);
            dtgLicenciados.DataSource = source;
        }













        #endregion

      
    }
}
