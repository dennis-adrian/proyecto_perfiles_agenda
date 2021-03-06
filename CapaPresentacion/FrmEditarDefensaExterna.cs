﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaPresentacion.ContractForms;
using CapaPresentacion.Resources;
using CapaNegocio.defensaExterna.defensaPerfil.otros;
using System.Dynamic;

namespace CapaPresentacion
{
    public partial class FrmEditarDefensaExterna : Form, IContractLicenciado
    {

        #region Instancias

        private FrmTutor Tutor = null;
        InfoDefensa info = new InfoDefensa();
        #endregion


        #region Atributos
        string carrera;
        int student;
        string tipo;
        int tipolicenciado = 0;
        List<dynamic> lista_detalle_defensa = new List<dynamic>();
        dynamic defensa_externa = new ExpandoObject();
        dynamic estudiante = new ExpandoObject();
        dynamic titulacion_otros = new ExpandoObject();
        List<Dictionary<string, string>> listLicenciados = new List<Dictionary<string, string>>();

        Dictionary<string, string> InfoDefensa = new Dictionary<string, string>();
        #endregion


        #region constructor
        public FrmEditarDefensaExterna(int ES = 0,string CA = "",string TI = "")
        {
            InitializeComponent();
            FirstButtonDesactiveAll();
            this.carrera = CA;
            this.student = ES;
            this.tipo = TI;
            Inicializar();
            loadDictionary(ES);
            ShowInfo();
            //getLicenciados();
            //showLinceciados();
        }
        #endregion


        #region Logica
        public void Inicializar()
        {
            lblTituloDefensa.Text = tipo;
            cmbCarrera.Items.Clear();
            cmbCarrera.DataSource = info.cargarCarreras();
            cmbCarrera.ValueMember = "id";
            cmbCarrera.DisplayMember = "nombre";
            loadAula();

        }
        public void loadDictionary(int id)
        {
                     
            var list = info.getInfoDefensaOtros(id);
            InfoDefensa.Add("Id", Convert.ToString(list.Id));
            InfoDefensa.Add("Fecha_presentacion", Convert.ToString(list.Fecha_presentacion));
            InfoDefensa.Add("Hora", Convert.ToString(list.Hora));
            InfoDefensa.Add("Aula", Convert.ToString(list.Aula));
            InfoDefensa.Add("Id_titulacion_otro", Convert.ToString(list.Id_titulacion_otro));
            InfoDefensa.Add("Estado_defensa", Convert.ToString(list.Estado_defensa));
            InfoDefensa.Add("Tema", Convert.ToString(list.Tema));
            InfoDefensa.Add("Calificacion", Convert.ToString(list.Calificacion));
            InfoDefensa.Add("Id_tipo_titulacion", Convert.ToString(list.Id_tipo_titulacion));
            InfoDefensa.Add("Id_estudiante", Convert.ToString(list.Id_estudiante));
            InfoDefensa.Add("Registro", Convert.ToString(list.Registro));
            InfoDefensa.Add("Nombre", Convert.ToString(list.Nombre));
            InfoDefensa.Add("Apellido", Convert.ToString(list.Apellido));
            InfoDefensa.Add("Email", Convert.ToString(list.Email));
            InfoDefensa.Add("Telefono", Convert.ToString(list.Telefono));
            InfoDefensa.Add("Celular", Convert.ToString(list.Celular));
            InfoDefensa.Add("Id_carrera", Convert.ToString(list.Id_carrera));
            InfoDefensa.Add("Carrera", Convert.ToString(list.Carrera));
            
        }        
        public string SetAndEval(TextBox txt,string key,Dictionary<string,string> dic)
        {
            
            string text = txt.Text == dic[key] ? dic[key] : txt.Text;
            return text;
        }
        public string SetAndEvalCombo(ComboBox cmb, string key, Dictionary<string, string> dic)
        {

            string text = cmb.SelectedValue.ToString() == dic[key] ? dic[key] : cmb.SelectedValue.ToString();
            return text;
        }
        public string SetAndEvalComboLicenciado(ComboBox cmb, string key, Dictionary<string, string> dic)
        {

            string text = (cmb.SelectedItem as ComboBoxItem).Value.ToString() == dic[key] ? dic[key] : (cmb.SelectedItem as ComboBoxItem).Value.ToString();
            return text;
        }
        public string SetAndEvalDatetime(CheckBox check, DateTimePicker dtp, string key, Dictionary<string, string> dic,string tipo = "F")
        {

            if (check.Checked)
            {
                string text;
                switch (tipo)
                {
                    case "F":
                        text = dtp.Value.ToString("dd-MM-yyyy") == dic[key] ? dic[key] : dtp.Value.ToString("dd-MM-yyyy");
                        return text;
                    case "H":
                        text = dtp.Value.ToString("HH:mm") == dic[key] ? dic[key] : dtp.Value.ToString("HH:mm");
                        return text;
                    default:
                        throw new Exception("entrada de formato invalido");
                }
            }
            else
            {
                return "";
            }
               

            
        }
        public string setAndEvalEstadoDefensa()
        {
            string estado = InfoDefensa["Estado_defensa"];
            string calificacion = InfoDefensa["Calificacion"];
            string fecha_presentacion = InfoDefensa["Fecha_presentacion"];
            if (!string.IsNullOrEmpty(fecha_presentacion))
            {
                if (calificacion=="0.0")
                {
                    estado = "asignado";
                }
                else
                {
                    estado = "defendido";
                }
            }
            else
            {
                estado = "pendiente";
            }
            return estado;
        }
        public bool recolectData()
        {
            bool res = String.IsNullOrEmpty(txtAula.Text);
            if (res)
            {
                MessageBox.Show("El numero del aula no puede estar vacio");
                return false;
            }
            else
            {

                defensa_externa.Id = InfoDefensa["Id"];
            defensa_externa.Fecha_presentacion = SetAndEvalDatetime(chFechaDefensa, dtFechaDefensa,"Fecha_presentacion",InfoDefensa);
            defensa_externa.Hora = SetAndEvalDatetime(chHoraDefensa, dtHora, "Hora", InfoDefensa,"H");
            
            string aula = $"{((cmbAula.Text).ToUpper())}{txtAula.Text}";
            //defensa_externa.Aula = SetAndEval(aula, "Aula", InfoDefensa);
            defensa_externa.Aula = aula;
            defensa_externa.Id_titulacion_otro = InfoDefensa["Id_titulacion_otro"];
            estudiante.Id = InfoDefensa["Id_estudiante"];
            estudiante.Registro = SetAndEval(txtRegistroAlum, "Registro", InfoDefensa);
            estudiante.Apellido = SetAndEval(txtApellidoAlum, "Apellido", InfoDefensa);
            estudiante.Nombre = SetAndEval(txtNombreAlum,"Nombre",InfoDefensa);
            estudiante.Email = SetAndEval(txtEmailAlum,"Email",InfoDefensa);
            estudiante.Telefono = SetAndEval(txtTelefonoAlum,"Telefono",InfoDefensa);
            estudiante.Celular = SetAndEval(txtCelularAlum,"Celular",InfoDefensa);
            estudiante.Id_carrera = SetAndEvalCombo(cmbCarrera, "Id_carrera", InfoDefensa);
            titulacion_otros.Id = InfoDefensa["Id_titulacion_otro"];
            titulacion_otros.Estado_defensa = setAndEvalEstadoDefensa();
            titulacion_otros.Tema = SetAndEval(txtTema, "Tema", InfoDefensa);
            titulacion_otros.Calificacion = SetAndEval(txtNota, "Calificacion", InfoDefensa);
            titulacion_otros.Id_estudiante = InfoDefensa["Id_estudiante"];
            titulacion_otros.Id_tipo_titulacion = InfoDefensa["Id_tipo_titulacion"];
            recolectDataDetalleDefensa();

                return true;
            }

        }
        public string setAndEvalIdLicenciado(string funcion,Dictionary<string,string> dic)
        {
            string res = "";
            if (funcion == "Presidente")
            {
                res = SetAndEvalComboLicenciado(cmbPresidente, "Id_licenciado", dic);
            }
            else if(funcion == "Secretario")
            {
                res = SetAndEvalComboLicenciado(cmbSecretario, "Id_licenciado", dic);
            }
            else if (funcion == "Tribunal Interno 1")
            {
                res = SetAndEvalComboLicenciado(cmbTribunalInterno1, "Id_licenciado", dic);
            }

            else if (funcion == "Tribunal Interno 2")
            {
                res = SetAndEvalComboLicenciado(cmbTribunalInterno2, "Id_licenciado", dic);
            }
            else if (funcion == "Representante Uagrm 1")
            {
                res = SetAndEvalComboLicenciado(cmbRepresentanteUagrm1, "Id_licenciado", dic);
            }

            else if (funcion == "Representante Uagrm 2")
            {
                res = SetAndEvalComboLicenciado(cmbRepresentanteUagrm2, "Id_licenciado", dic);
            }

            else if (funcion == "Representante del Ministerio de Educacion")
            {
                res = SetAndEvalComboLicenciado(cmbRepresentanteMinisterio, "Id_licenciado", dic);
            }
            else
            {
                throw new Exception("Entrada invalida");
            }
            return res;
        


        }
        public void recolectDataDetalleDefensa()
        {

            foreach(var item in listLicenciados)
            { 
                dynamic detalle_defensa = new ExpandoObject();
                detalle_defensa.Id = item["Id_detalle_defensa"];
                detalle_defensa.Id_defensa_externa = item["Id_defensa_externa"];
                detalle_defensa.Id_funcion_licenciado = item["Id_funcion_licenciado"];
                detalle_defensa.Id_licenciado = setAndEvalIdLicenciado(Convert.ToString(item["Funcion"]),item);
                lista_detalle_defensa.Add(detalle_defensa);

            }

        }
        void loadAula()
        {
            cmbAula.Items.Insert(0, "N");

            cmbAula.Items.Insert(1, "S");

            cmbAula.Items.Insert(2, "E");

            cmbAula.Items.Insert(3, "O");

            cmbAula.SelectedIndex = 0;
        }
        public void ShowInfo()
        {
            txtTema.Text =  InfoDefensa["Tema"];
            txtNombreAlum.Text = InfoDefensa["Nombre"];
            txtApellidoAlum.Text = InfoDefensa["Apellido"];
            txtEmailAlum.Text = InfoDefensa["Email"];
            txtRegistroAlum.Text = InfoDefensa["Registro"];
            txtTelefonoAlum.Text = InfoDefensa["Telefono"];
            txtCelularAlum.Text = InfoDefensa["Celular"];


            cmbCarrera.SelectedValue = Convert.ToInt32(InfoDefensa["Id_carrera"]);

            DateChecked(dtFechaDefensa, chFechaDefensa, InfoDefensa["Fecha_presentacion"]);

            DateChecked(dtHora, chHoraDefensa, InfoDefensa["Hora"]);

            string aula = InfoDefensa["Aula"];
            bool res = String.IsNullOrEmpty(aula);
            if (res)
            {
                cmbAula.SelectedIndex = 0;

            }
            else
            {

                char[] charsToTrim = { 'N', 'S', 'O', 'E' };
                string letra = aula[0].ToString();
                switch (letra)
                {
                    case "N":
                        cmbAula.SelectedIndex = 0;
                        txtAula.Text = InfoDefensa["Aula"].Trim(charsToTrim);
                        break;
                    case "S":
                        cmbAula.SelectedIndex = 1;
                        txtAula.Text = InfoDefensa["Aula"].Trim(charsToTrim);
                        break;
                    case "E":
                        cmbAula.SelectedIndex = 2;
                        txtAula.Text = InfoDefensa["Aula"].Trim(charsToTrim);
                        break;
                    case "O":
                        cmbAula.SelectedIndex = 3;
                        txtAula.Text = InfoDefensa["Aula"].Trim(charsToTrim);
                        break;
                    default:

                        break;

                }

            }

            txtNota.Text = InfoDefensa["Calificacion"];
            getLicenciados();
            showLinceciados();


        }
        public void getLicenciados()
        {
            int id_defensa = Convert.ToInt32(InfoDefensa["Id"]);
            
            var list = info.getLicenciadosDefensa(id_defensa);

            foreach (var item in list)
            {

                Dictionary<string, string> licenciado = new Dictionary<string, string>();
                licenciado.Add("Id_detalle_defensa", Convert.ToString(item.Id_detalle_defensa));
                licenciado.Add("Id_defensa_externa", Convert.ToString(item.Id_defensa_externa));
                licenciado.Add("Id_licenciado", Convert.ToString(item.Id_licenciado));
                licenciado.Add("Nombre", Convert.ToString(item.Nombre));
                licenciado.Add("Apellido", Convert.ToString(item.Apellido));
                licenciado.Add("Id_funcion_licenciado", Convert.ToString(item.Id_funcion_licenciado));

                licenciado.Add("Funcion", Convert.ToString(item.Funcion));

                listLicenciados.Add(licenciado);
                
            }
        }
        public void showLinceciados()
        {
            foreach(var item in listLicenciados)
            {
                string funcion = item["Funcion"];
                switch (funcion)
                {
                    case "Presidente":
                        loadComboLicenciado(cmbPresidente, item["Nombre"], item["Apellido"], Convert.ToInt32(item["Id_licenciado"]));
                        break;
                    case "Tribunal Interno 1":
                        loadComboLicenciado(cmbTribunalInterno1, item["Nombre"], item["Apellido"], Convert.ToInt32(item["Id_licenciado"]));
                        break;
                    case "Tribunal Interno 2":
                        loadComboLicenciado(cmbTribunalInterno2, item["Nombre"], item["Apellido"], Convert.ToInt32(item["Id_licenciado"]));
                        break;
                    case "Representante Uagrm 1":
                        loadComboLicenciado(cmbRepresentanteUagrm1,item["Nombre"], item["Apellido"], Convert.ToInt32(item["Id_licenciado"]));
                        break;
                    case "Representante Uagrm 2":
                        loadComboLicenciado(cmbRepresentanteUagrm2, item["Nombre"], item["Apellido"], Convert.ToInt32(item["Id_licenciado"]));
                        break;
                    case "Secretario":
                        loadComboLicenciado(cmbSecretario,item["Nombre"], item["Apellido"], Convert.ToInt32(item["Id_licenciado"]));
                        break;
                    case "Representante del Ministerio de Educacion":
                        loadComboLicenciado(cmbRepresentanteMinisterio,item["Nombre"], item["Apellido"], Convert.ToInt32(item["Id_licenciado"]));
                        break;
                    default:
                        break;
                }

            }
        }
        public void loadComboLicenciado(ComboBox cmb,string nombre="", string apellido="",int id_licenciado=0)
        {
            ComboBoxItem cmb_item = new ComboBoxItem();
            cmb_item.Text = $"{nombre} {apellido}";
            cmb_item.Value = id_licenciado;
            cmb.Items.Clear();
            cmb.Items.Add(cmb_item);
            cmb.SelectedIndex = 0;
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
        public void FirstButtonActive(Button btn)
        {
            FirstButtonDesactiveAll();
            btn.BackColor = Color.FromArgb(178, 8, 55);

        }
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

        #endregion



        #region Diseño
        private void FrmEditarDefensaExterna_Load(object sender, EventArgs e)
        {

            validarCalificacion();


        }
        void validarCalificacion()
        {
            string fec_defensa = InfoDefensa["Fecha_presentacion"];
            if (string.IsNullOrEmpty(fec_defensa))
            {
                txtNota.Visible = false;
                chCalificacion.Visible = false;
                label19.Visible = false;
            }
            else
            {
                int res = DateTime.Compare(DateTime.Now, dtFechaDefensa.Value);
                if (res > 0)
                {
                    txtNota.Visible = true;
                    chCalificacion.Visible = true;
                    label19.Visible = true;
                }
                else
                {
                    txtNota.Visible = false;
                    chCalificacion.Visible = false;
                    label19.Visible = false;

                }
            }

        }
        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            
                if (e.Button == MouseButtons.Left && e.Clicks >= 2)
                {
                    if (FormWindowState.Normal == WindowState)
                    {
                        Rectangle workingArea = new Rectangle();
                        workingArea = Screen.GetWorkingArea(pnlBarraTitulo);
                        MaximumSize = workingArea.Size;
                        WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        MaximumSize = new Size(0, 0);
                        WindowState = FormWindowState.Normal;
                    }
                    pnlBarraTitulo.Select();
                    return;
                }
                ArrastrarForm.ReleaseCapture();
                ArrastrarForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
                this.Close();
        }
        private void btnCancelarNuevaDefensa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int getCmb(ComboBox cmb, string nameCombo = "")
        {
            if (string.IsNullOrEmpty(cmb.Text))
            {

                throw new ArgumentException($"campo {nameCombo} vacio.");
            }
            else
            {

                return Convert.ToInt32((cmb.SelectedItem as ComboBoxItem).Value.ToString());
            }
        }
        bool validatingLicenciados()
        {
            List<int> licenciados = new List<int>();
            List<int> tmp = new List<int>();
            licenciados.Add(getCmb(cmbPresidente));
            licenciados.Add(getCmb(cmbSecretario));
            licenciados.Add(getCmb(cmbTribunalInterno1));
            licenciados.Add(getCmb(cmbTribunalInterno2));
            licenciados.Add(getCmb(cmbRepresentanteMinisterio));
            licenciados.Add(getCmb(cmbRepresentanteUagrm1));
            licenciados.Add(getCmb(cmbRepresentanteUagrm2));
    


            foreach (var n in licenciados)
            {
                bool res = tmp.Contains(n);
                if (res)
                {
                    return false;
                }
                else
                {
                    tmp.Add(n);

                }
            }
            return true;



        }


        private void btnGuardarNuevaDefensa_Click(object sender, EventArgs e)
        {
            try
            {

                bool validacion = validatingLicenciados();

                if (!validacion)
                {
                    MessageBox.Show("Verifique que ingresó todos los datos correctamente.\n\n" +
                        "1. Necesita ingresar el nombre de todos los licenciados que van a participar de la defensa.\n\n" +
                        "2. No puede repetir nombres.");
                    return;
                }
                bool res = recolectData();
                if (res)
                {
                    ActualizarDefensa actualizar = new ActualizarDefensa();
                    if (actualizar.updateOtros(estudiante, titulacion_otros, defensa_externa, lista_detalle_defensa))
                    {
                        MessageBox.Show("Datos guardados correctamente");
                        validarCalificacion();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al guardar los datos");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
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

                    case 100:
                        
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnElegirPresidente_Click(object sender, EventArgs e)
        {
            tipolicenciado = 1;
            FirstButtonActive(btnElegirPresidente);
            FrmTutor frm = this.FormInstance3;
            frm.contrato = this;
            frm.Show();
            frm.lblLicen.Text = "Licenciado : ";//+ lblPresidente.Text;(falta nombrar los labels)
            frm.BringToFront();
        }


        private void btnElegirTribunal1_Click(object sender, EventArgs e)
        {
            tipolicenciado = 2;
            FirstButtonActive(btnElegirTribunal1);
            FrmTutor frm = this.FormInstance3;
            frm.contrato = this;
            frm.Show();
            //frm.lblLicen.Text = "Licenciado : " + lbltribiInterno1.Text;
            frm.BringToFront();
        }

        private void btnElegirTribunal2_Click(object sender, EventArgs e)
        {
            tipolicenciado = 3;
            FirstButtonActive(btnElegirTribunal2);
            FrmTutor frm = this.FormInstance3;
            frm.contrato = this;
            frm.Show();
            //frm.lblLicen.Text = "Licenciado : " + lblTribuInterno2.Text;
            frm.BringToFront();
        }

        private void btnElegirSecretario_Click(object sender, EventArgs e)
        {
            tipolicenciado = 4;
            FirstButtonActive(btnElegirSecretario);
            FrmTutor frm = this.FormInstance3;
            frm.contrato = this;
            frm.Show();
            //frm.lblLicen.Text = "Licenciado : " + lblSecretario.Text;
            frm.BringToFront();
        }

        private void btnElegirRepresentanteMinisterio_Click(object sender, EventArgs e)
        {
            tipolicenciado = 5;
            FirstButtonActive(btnElegirRepresentanteMinisterio);
            FrmTutor frm = this.FormInstance3;
            frm.contrato = this;
            frm.Show();
            //frm.lblLicen.Text = "Licenciado : " + lblRME.Text;
            frm.BringToFront();
        }

        private void btnElegirRepresentanteUagrm1_Click(object sender, EventArgs e)
        {
            tipolicenciado = 6;
            FirstButtonActive(btnElegirRepresentanteUagrm1);
            FrmTutor frm = this.FormInstance3;
            frm.contrato = this;
            frm.Show();
            //frm.lblLicen.Text = "Elegir : " + lblRepreGaby1.Text;
            frm.BringToFront();
        }

        private void btnElegirRepresentanteUagrm2_Click(object sender, EventArgs e)
        {
            tipolicenciado = 7;
            FirstButtonActive(btnElegirRepresentanteUagrm2);
            FrmTutor frm = this.FormInstance3;
            frm.contrato = this;
            frm.Show();
            //frm.lblLicen.Text = "Licenciado : " + lblRepreGaby2.Text;
            frm.BringToFront();
        }
        #endregion

        void validatingNumeric(object sender, KeyPressEventArgs e)
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
        private void txtTelefonoAlum_KeyPress(object sender, KeyPressEventArgs e)
        {
            validatingNumeric(sender,e);
        }

        private void txtCelularAlum_KeyPress(object sender, KeyPressEventArgs e)
        {
            validatingNumeric(sender, e);
        }

        private void txtAula_KeyPress(object sender, KeyPressEventArgs e)
        {
            validatingNumeric(sender, e);
        }

        private void cambiarEstadoDateTimePicker(DateTimePicker dateTimePicker, object obj)
        {
            CheckBox checkBox = (CheckBox)obj;
            if (!checkBox.Checked)
            {
                dateTimePicker.Enabled = false;
            }
            else
            {
                dateTimePicker.Enabled = true;
            }
        }

        private void chFechaDefensa_CheckedChanged(object sender, EventArgs e)
        {
            cambiarEstadoDateTimePicker(dtFechaDefensa, sender);
        }

        private void chHoraDefensa_CheckedChanged(object sender, EventArgs e)
        {
            cambiarEstadoDateTimePicker(dtHora, sender);
        }

        private void chCalificacion_CheckedChanged(object sender, EventArgs e)
        { 
            if (!chCalificacion.Checked)
            {
                txtNota.Enabled = false;
            }
            else
            {
                txtNota.Enabled = true;
            }
        }
        public void DateChecked(DateTimePicker dtt, CheckBox check, string fec)
        {
            bool result = string.IsNullOrEmpty(fec);
            if (result)
            {

                dtt.Value = DateTime.Now;
                dtt.Enabled = false;
                check.Checked = false;

            }
            else
            {

                dtt.Value = DateTime.Parse(fec, new CultureInfo("en-GB"));
                dtt.Enabled = true;
                check.Checked = true;
            }
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            validatingNumeric(sender, e);
        }
        //DateChecked(dttEmpaste, chbEmpaste, info.Fecha_empaste);
    }
}
