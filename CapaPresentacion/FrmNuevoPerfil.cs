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
using CapaPresentacion.ContractForms;
using CapaPresentacion.Resources;

namespace CapaPresentacion
{
    public partial class FrmNuevoPerfil : Form, IContractLicenciado
    {

        #region Constructor
        public FrmNuevoPerfil()
        {
            InitializeComponent();
            FormsControls();
        }

        #endregion


        #region Instancias

        NegocioNuevoPerfil obj = new NegocioNuevoPerfil();


        #endregion


        #region Buttons

        private void btnElegirTutor_Click(object sender, EventArgs e)
        {
            FrmTutor frm = new FrmTutor();
            frm.contrato = this;
            frm.Show();
        }
        private void btnCancelarNuevop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGuardarNuevoP_Click(object sender, EventArgs e)
        {
             try
             {
                Insert();
                ClearForms();
               

            }
             catch(Exception ex)
             {
                 MessageBox.Show("" + ex);
             }
        }


        #endregion


        #region Arrastrar_Form

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarForm.ReleaseCapture();
            ArrastrarForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


        #region Metodos
        public void Ejecutar(int id, string nombre)
        {
            cmbTutorElegido.Items.Clear();
            ComboBoxItem item = new ComboBoxItem();
            item.Text = nombre;
            item.Value = id;

            cmbTutorElegido.Items.Add(item);
            cmbTutorElegido.SelectedIndex = 0;
        }

        public void FormsControls()
        {
            cmbTutorElegido.Items.Clear();
            cmbCarrera.Items.Clear();
            cmbCarrera.DataSource = obj.cargarCarreras();
            cmbCarrera.ValueMember = "id";
            cmbCarrera.DisplayMember = "nombre";

        }
        public void ClearForms()
        {
            cmbTutorElegido.Items.Clear();
            ComboBoxItem item = new ComboBoxItem();
            item.Text = "";
            item.Value = 0;
            cmbTutorElegido.Items.Add(item);
            cmbTutorElegido.SelectedIndex = 0;

            txtRegistroAlum.Clear();//input
            txtNombreAlum.Clear();//input
            txtApellidoAlum.Clear();//input
            txtEmailAlum.Clear();//input
            txtTelefonoAlum.Clear();//input
            txtCelularAlum.Clear();//input
            txtTemaTesis.Clear();//input
           

        }

        public void Insert()
        {
            string registro = txtRegistroAlum.Text;//input 0
            string nombre = txtNombreAlum.Text;//input 1
            string apellido = txtApellidoAlum.Text;//input 2
            string email = txtEmailAlum.Text;//input 3
            string telefono = txtTelefonoAlum.Text;//input 4
            string celular = txtCelularAlum.Text;//input 5
            int id_carrera = Convert.ToInt32(cmbCarrera.SelectedValue.ToString());//input 6
            string tema = txtTemaTesis.Text;//input 7
            string fecha_aprobacion = dtFechaAprobacion.Value.Date.ToString("dd-MM-yyyy");//input 8
            string fecha_recepcion = dtFechaRecepcion.Value.Date.ToString("dd-MM-yyyy");//input 9
            int id_tutor = Convert.ToInt32((cmbTutorElegido.SelectedItem as ComboBoxItem).Value.ToString());//input 10

            Object[] datos = new Object[]
           {
               registro,
                nombre,
                apellido,
                email,
                telefono,
                celular,
                id_carrera,
                tema,
                fecha_aprobacion,
                fecha_recepcion,
                id_tutor
           };

            obj.ControlInput(datos);
            obj.Main();

        }



        #endregion


        #region Destructor

        ~FrmNuevoPerfil()
        {

        }
        #endregion

      
    }
}
