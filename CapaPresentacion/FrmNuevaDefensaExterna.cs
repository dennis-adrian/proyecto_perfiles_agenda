﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.defensaExterna.defensaPerfil.otros;
using CapaPresentacion.ContractForms;
using CapaPresentacion.Resources;

namespace CapaPresentacion
{
    public partial class FrmNuevaDefensaExterna : Form, IContractLicenciado
    {
        #region Instancias

        AgregarDefensa obj = new AgregarDefensa();
        
        #endregion
        #region Atributos
        private FrmTutor Tutor = null;
        int titulacion = 0;
        int tipolicenciado = 0;

        #endregion
        #region Constructor

        public FrmNuevaDefensaExterna(int titulacion)
        {
            InitializeComponent();
            FormsControls();
            this.titulacion = titulacion;
        }
        public FrmNuevaDefensaExterna()
        {
            InitializeComponent();
            FormsControls();
        }
        #endregion

        //Patron Singleton
        private FrmTutor FormInstance3
        {
            get
            {
                if (Tutor == null)
                {
                    Tutor = new FrmTutor();
                    Tutor.Disposed += new EventHandler(form_Disposed3);
                }

                return Tutor;
            }
        }

        void form_Disposed3(object sender, EventArgs e)
        {
            Tutor = null;

        }

        

        #region Buttons

        private void btnCancelarNuevaD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnElegirPresidente_Click(object sender, EventArgs e)
        {
            tipolicenciado = 1;
            FirstButtonActive(btnElegirPresidente);
            FrmTutor frm = this.FormInstance3;
            frm.contrato = this;
            frm.Show();
            frm.lblLicen.Text = "Licenciado : " + lblPresidente.Text;
            frm.BringToFront();
        }
        private void btnElegirSecretario_Click(object sender, EventArgs e)
        {
            tipolicenciado = 4;
            FirstButtonActive(btnElegirSecretario);
            FrmTutor frm = this.FormInstance3;
            frm.contrato = this;
            frm.Show();
            frm.lblLicen.Text = "Licenciado : " + lblSecretario.Text;
            frm.BringToFront();

        }

        private void btnElegirTribunal1_Click(object sender, EventArgs e)
        {
            tipolicenciado = 2;
            FirstButtonActive(btnElegirTribunal1);
            FrmTutor frm = this.FormInstance3;
            frm.contrato = this;
            frm.Show();
            frm.lblLicen.Text = "Licenciado : " + lbltribiInterno1.Text;
            frm.BringToFront();
        }

        private void btnElegirTribunal2_Click(object sender, EventArgs e)
        {
            tipolicenciado = 3;
            FirstButtonActive(btnElegirTribunal2);
            FrmTutor frm = this.FormInstance3;
            frm.contrato = this;
            frm.Show();
            frm.lblLicen.Text = "Licenciado : " + lblTribuInterno2.Text;
            frm.BringToFront();
        }

        private void btnElegirRepresentanteMinisterio_Click(object sender, EventArgs e)
        {
            tipolicenciado = 5;
            FirstButtonActive(btnElegirRepresentanteMinisterio);
            FrmTutor frm = this.FormInstance3;
            frm.contrato = this;
            frm.Show();
            frm.lblLicen.Text = "Licenciado : " + lblRME.Text;
            frm.BringToFront();
        }

        private void btnElegirRepresentanteUagrm1_Click(object sender, EventArgs e)
        {
            tipolicenciado = 6;
            FirstButtonActive(btnElegirRepresentanteUagrm1);
            FrmTutor frm = this.FormInstance3;
            frm.contrato = this;
            frm.Show();
            frm.lblLicen.Text = "Elegir : " + lblRepreGaby1.Text;
            frm.BringToFront();
        }

        private void btnElegirRepresentanteUagrm2_Click(object sender, EventArgs e)
        {
            tipolicenciado = 7;
            FirstButtonActive(btnElegirRepresentanteUagrm2);
            FrmTutor frm = this.FormInstance3;
            frm.contrato = this;
            frm.Show();
            frm.lblLicen.Text = "Licenciado : " + lblRepreGaby2.Text;
            frm.BringToFront();
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

        public bool Insert()
        {
            string tema = txtTema.Text;
            string nombre = txtNombreAlum.Text;
            string apellido = txtApellidoAlum.Text;
            string email = txtEmailAlum.Text;
            string registro = txtRegistroAlum.Text;
            string celular = txtCelularAlum.Text;
            string telefono = txtTelefonoAlum.Text;
            int id_carrera = Convert.ToInt32(cmbCarrera.SelectedValue.ToString());
            string tipo_titulacion = (this.titulacion == 1) ? "Examen de Grado" : ((this.titulacion == 2) ? "Graduacion por Excelencia" : "");

            string fechadefensa = dtFechaDefensa.Value.ToString("dd-MM-yyyy");
            string hora = dtHora.Value.ToString("HH:mm");
            string aula = cbbLetraAula.Text + txtAula.Text;



            int id_presidente = Convert.ToInt32((cmbPresidente.SelectedItem as ComboBoxItem).Value.ToString());
            string f_presidente = "Presidente";


            int id_secretario = Convert.ToInt32((cmbSecretario.SelectedItem as ComboBoxItem).Value.ToString());
            string f_secretario = "Secretario";


            int tribunal1 = Convert.ToInt32((cmbTribunalInterno1.SelectedItem as ComboBoxItem).Value.ToString());
            string f_tribunal1 = "Tribunal Interno 1";


            int tribunal2 = Convert.ToInt32((cmbTribunalInterno2.SelectedItem as ComboBoxItem).Value.ToString());
            string f_tribunal2 = "Tribunal Interno 2";

            int ministerio = Convert.ToInt32((cmbRepresentanteMinisterio.SelectedItem as ComboBoxItem).Value.ToString());
            string f_ministerio = "Representante del Ministerio de Educacion";


            int uagrm1 = Convert.ToInt32((cmbRepresentanteUagrm1.SelectedItem as ComboBoxItem).Value.ToString());
            string f_uagram1 = "Representante Uagrm 1";
            int uagrm2 = Convert.ToInt32((cmbRepresentanteUagrm2.SelectedItem as ComboBoxItem).Value.ToString());
            string f_uagram2 = "Representante Uagrm 2";


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
                f_secretario,//input 15
                tribunal1,//input 16
                f_tribunal1,//input 17
                tribunal2,//input 18
                f_tribunal2,//input 19
                ministerio,//input 20
                f_ministerio,//input 21
                uagrm1,//input 22
                f_uagram1,//input 23
                uagrm2,//input 24
                f_uagram2 //input 25

           };
            try
            {
                obj.inputController(datos, obj.mainOtros);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Console.WriteLine(e);
                return false;
            }
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
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        public void FirstButtonActive(Button btn)
        {
            FirstButtonDesactiveAll();
            btn.BackColor = Color.FromArgb(178, 8, 55);

        }
        public void FirstButtonDesactiveAll()
        {
            btnElegirPresidente.BackColor = Color.FromArgb(102, 102, 102);
            btnElegirSecretario.BackColor = Color.FromArgb(102, 102, 102);
            btnElegirTribunal1.BackColor = Color.FromArgb(102, 102, 102);
            btnElegirTribunal2.BackColor = Color.FromArgb(102, 102, 102);
            btnElegirRepresentanteMinisterio.BackColor = Color.FromArgb(102, 102, 102);
            btnElegirRepresentanteUagrm1.BackColor = Color.FromArgb(102, 102, 102);
            btnElegirRepresentanteUagrm2.BackColor = Color.FromArgb(102, 102, 102);
        }

        private void btnGuardarNuevaDefensa_Click(object sender, EventArgs e)
        {
            try
            {
                bool validacion = validarLicenciado(cmbPresidente.Text.ToString(), cmbSecretario.Text.ToString(), cmbTribunalInterno1.Text.ToString(), cmbTribunalInterno2.Text.ToString(), cmbRepresentanteMinisterio.Text.ToString(), cmbRepresentanteUagrm1.Text.ToString(), cmbRepresentanteUagrm2.Text.ToString());

                if (!validacion)
                {
                    MessageBox.Show("Verifique que ingresó todos los datos correctamente.\n\n" +
                        "1. Necesita ingresar el nombre de todos los licenciados que van a participar de la defensa.\n\n" +
                        "2. No puede repetir nombres.");
                }
                if (Insert())
                {
                    MessageBox.Show("Datos guardados correctamente");
                    ClearForms();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        #region validacionDeLicenciados
        List<string> listaLicenciados = new List<string>();
        private bool validarLicenciado(string presidente = null, string secretario = null, string tribunal1 = null, string tribunal2 = null, string repMinisterio = null, string repUagrm1 = null, string repUagrm2 = null)
        {
            List<string> temporal = new List<string>();
            agregarALista(presidente);
            agregarALista(secretario);
            agregarALista(tribunal1);
            agregarALista(tribunal2);
            agregarALista(repMinisterio);
            agregarALista(repUagrm1);
            agregarALista(repUagrm2);
            
            listaLicenciados.Sort();

            foreach (var item in listaLicenciados)
            {
                if (temporal.Count == 0)
                {
                    temporal.Add(item);
                }
                else if (item != temporal[temporal.Count - 1])
                {
                    temporal.Add(item);
                }
                else
                {
                    listaLicenciados.Clear();
                    return false;
                }
            }
            listaLicenciados.Clear();
            return true;
        }
        private void agregarALista(string valor)
        {
            if (valor != null)
            {
                listaLicenciados.Add(valor);
            }
        }
        #endregion

        private void txtTelefonoAlum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCelularAlum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtAula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
