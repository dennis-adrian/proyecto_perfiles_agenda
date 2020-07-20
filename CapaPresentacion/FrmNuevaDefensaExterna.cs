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
    public partial class FrmNuevaDefensaExterna : Form,IContractLicenciado
    {
        #region Constructor

        public FrmNuevaDefensaExterna()
        {
            InitializeComponent();
            FormsControls();
        }
        #endregion

        #region Atributos

        int tipolicenciado = 0;

        #endregion

        #region Instancias

        NegocioNuevaDefensa obj = new NegocioNuevaDefensa();

        #endregion

        #region Buttons

        private void btnCancelarNuevaD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnElegirPresidente_Click(object sender, EventArgs e)
        {
            tipolicenciado = 1;
            FrmTutor frm = new FrmTutor();
            frm.contrato = this;
            frm.Show();
        }
        private void btnElegirSecretario_Click(object sender, EventArgs e)
        {
            tipolicenciado = 4;
            FrmTutor frm = new FrmTutor();
            frm.contrato = this;
            frm.Show();

        }

        private void btnElegirTribunal1_Click(object sender, EventArgs e)
        {
            tipolicenciado = 2;
            FrmTutor frm = new FrmTutor();
            frm.contrato = this;
            frm.Show();
        }

        private void btnElegirTribunal2_Click(object sender, EventArgs e)
        {
            tipolicenciado = 3;
            FrmTutor frm = new FrmTutor();
            frm.contrato = this;
            frm.Show();
        }

        private void btnElegirRepresentanteMinisterio_Click(object sender, EventArgs e)
        {
            tipolicenciado = 5;
            FrmTutor frm = new FrmTutor();
            frm.contrato = this;
            frm.Show();
        }

        private void btnElegirRepresentanteUagrm1_Click(object sender, EventArgs e)
        {
            tipolicenciado = 6;
            FrmTutor frm = new FrmTutor();
            frm.contrato = this;
            frm.Show();
        }

        private void btnElegirRepresentanteUagrm2_Click(object sender, EventArgs e)
        {
            tipolicenciado = 7;
            FrmTutor frm = new FrmTutor();
            frm.contrato = this;
            frm.Show();
        }



        #endregion

        #region Metodos

        public void FormsControls()
        {

            //cmbTutorElegido.Items.Clear();
            cmbCarrera.Items.Clear();
            cmbCarrera.DataSource = obj.cargarCarreras();
            cmbCarrera.ValueMember = "id";
            cmbCarrera.DisplayMember = "nombre";

            ClearForms();



        }
        public void ClearForms()
        {
            ComboBoxItem item = new ComboBoxItem();

            item.Text = "";
            item.Value = 0;
            cmbPresidente.Items.Clear();
            cmbPresidente.Items.Add(item);
            cmbPresidente.SelectedIndex = 0;

            cmbSecretario.Items.Clear();
            cmbSecretario.Items.Add(item);
            cmbSecretario.SelectedIndex = 0;

            cmbTribunalInterno1.Items.Clear();
            cmbTribunalInterno1.Items.Add(item);
            cmbTribunalInterno1.SelectedIndex = 0;

            cmbTribunalInterno2.Items.Clear();
            cmbTribunalInterno2.Items.Add(item);
            cmbTribunalInterno2.SelectedIndex = 0;

            cmbRepresentanteUagrm1.Items.Clear();
            cmbRepresentanteUagrm1.Items.Add(item);
            cmbRepresentanteUagrm1.SelectedIndex = 0;

            cmbRepresentanteUagrm2.Items.Clear();
            cmbRepresentanteUagrm2.Items.Add(item);
            cmbRepresentanteUagrm2.SelectedIndex = 0;

            cmbRepresentanteMinisterio.Items.Clear();
            cmbRepresentanteMinisterio.Items.Add(item);
            cmbRepresentanteMinisterio.SelectedIndex = 0;

            txtAula.Clear();
            txtTema.Clear();
            txtNombreAlum.Clear();
            txtApellidoAlum.Clear();
            txtEmailAlum.Clear();
            txtRegistroAlum.Clear();
            txtCelularAlum.Clear();
            txtTelefonoAlum.Clear();

            dtFechaDefensa.Value = DateTime.Now;



        }

        public void Insert(int tipo)
        {
            string tema = txtTema.Text;
            string nombre = txtNombreAlum.Text;
            string apellido = txtApellidoAlum.Text;
            string email = txtEmailAlum.Text;
            string registro = txtRegistroAlum.Text;
            string celular = txtCelularAlum.Text;
            string telefono = txtTelefonoAlum.Text;
            int id_carrera = Convert.ToInt32(cmbCarrera.SelectedValue.ToString());
            string tipo_titulacion = (tipo == 1) ? "Examen de Grado" : "Graduacion por Excelencia";

            string fechadefensa = dtFechaDefensa.Value.ToString("dd-MM-yyyy");
            string hora = dtHora.Value.ToString();
            string aula = txtAula.Text;

            int id_presidente = Convert.ToInt32(cmbPresidente.SelectedValue.ToString());
            string f_presidente = "Presidente";
            int id_secretario = Convert.ToInt32(cmbSecretario.SelectedValue.ToString());
            int tribunal1 = Convert.ToInt32(cmbTribunalInterno1.SelectedValue.ToString());
            int tribunal2 = Convert.ToInt32(cmbTribunalInterno2.SelectedValue.ToString());
            int ministerio = Convert.ToInt32(cmbRepresentanteMinisterio.SelectedValue.ToString());
            int uagrm1 = Convert.ToInt32(cmbRepresentanteUagrm1.SelectedValue.ToString());
            int uagrm2 = Convert.ToInt32(cmbRepresentanteUagrm2.SelectedValue.ToString());

            Object[] datos = new Object[]
           {
               registro,//input 0
                nombre,//input 1
                apellido,//input 2
                email,//input 3
                telefono,//input 4
                celular,//input 5
                id_carrera,//input 6
                tema,//input 7
                tipo_titulacion,//input 8
                fechadefensa,//input 9
                hora,//input 10
                aula,//input 11

                id_presidente,//input 12
                f_presidente,//input 13
                id_secretario,//input 14
                "Secretario",//input 15
                tribunal1,
                tribunal2,
                ministerio,
                uagrm1,
                uagrm2,

           };
        }
        

        #endregion


        #region Destructor

        ~FrmNuevaDefensaExterna()
        {

        }


        #endregion

        

        public void Ejecutar(int id, string nombre)
        {
            try
            {

                ComboBoxItem item = new ComboBoxItem();
                switch (tipolicenciado)
                {
                    case 1:
                        cmbPresidente.Items.Clear();
                        item.Text = nombre;
                        item.Value = id;
                        cmbPresidente.Items.Add(item);
                        cmbPresidente.SelectedIndex = 0;
                        break;
                    case 2:
                        cmbTribunalInterno1.Items.Clear();
                        item.Text = nombre;
                        item.Value = id;
                        cmbTribunalInterno1.Items.Add(item);
                        cmbTribunalInterno1.SelectedIndex = 0;
                        break;
                    case 3:
                        cmbTribunalInterno2.Items.Clear();
                        item.Text = nombre;
                        item.Value = id;
                        cmbTribunalInterno2.Items.Add(item);
                        cmbTribunalInterno2.SelectedIndex = 0;

                        break;
                    case 4:                        
                        cmbSecretario.Items.Clear();
                        item.Text = nombre;
                        item.Value = id;
                        cmbSecretario.Items.Add(item);
                        cmbSecretario.SelectedIndex = 0;

                        break;
                    case 5:
                        cmbRepresentanteMinisterio.Items.Clear();
                        item.Text = nombre;
                        item.Value = id;
                        cmbRepresentanteMinisterio.Items.Add(item);
                        cmbRepresentanteMinisterio.SelectedIndex = 0;
                        break;
                    case 6:
                        cmbRepresentanteUagrm1.Items.Clear();
                        item.Text = nombre;
                        item.Value = id;
                        cmbRepresentanteUagrm1.Items.Add(item);
                        cmbRepresentanteUagrm1.SelectedIndex = 0;

                        break;
                    case 7:
                        cmbRepresentanteUagrm2.Items.Clear();
                        item.Text = nombre;
                        item.Value = id;
                        cmbRepresentanteUagrm2.Items.Add(item);
                        cmbRepresentanteUagrm2.SelectedIndex = 0;
                        break;
                  
                    default:
                        throw new ArgumentException();

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            
        }

      
    }
}
