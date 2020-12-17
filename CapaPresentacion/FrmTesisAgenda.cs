﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.defensaExterna.defensaPerfil.otros;
using CapaPresentacion.ContractForms;
using CapaPresentacion.Resources;

namespace CapaPresentacion
{
    public partial class FrmTesisAgenda : Form, IContractLicenciado
    {


        #region Instancias

        private FrmTutor Tutor = null;
        InfoDefensa info = new InfoDefensa();
        #endregion


        #region Atributos

        bool isEmpty;
        string carrera;
        int student;
        string tipo;
        int tipolicenciado=0;
        List<dynamic> lista_detalle_defensa = new List<dynamic>();
        dynamic defensa_externa = new ExpandoObject();
        dynamic estudiante = new ExpandoObject();
        dynamic perfil_tesis = new ExpandoObject();
        List<Dictionary<string, string>> listLicenciados = new List<Dictionary<string, string>>();

        Dictionary<string, string> InfoDefensa = new Dictionary<string, string>();
        #endregion


        #region  Construcctor
        public FrmTesisAgenda(int ES = 0, string CA = "", string TI = "")
        {
            InitializeComponent();
            FirstButtonDesactiveAll();
            this.carrera = CA;
            this.student = ES;
            this.tipo = TI;
            Inicializar();
            loadDictionary(ES);
            ShowInfo();

        }


        #endregion


        #region Logica
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
        public void Inicializar()
        {
            lblTituloTesis.Text = tipo;
            cmbCarrera.Items.Clear();
            cmbCarrera.DataSource = info.cargarCarreras();
            cmbCarrera.ValueMember = "id";
            cmbCarrera.DisplayMember = "nombre";

        }
        public void ShowInfo()
        {
            txtTemaGral.Text = InfoDefensa["Tema"];
            txtNombreAlum.Text = InfoDefensa["Nombre"];
            txtApellidoAlum.Text = InfoDefensa["Apellido"];
            txtEmailAlum.Text = InfoDefensa["Email"];
            txtRegistroAlum.Text = InfoDefensa["Registro"];
            txtTelefonoAlum.Text = InfoDefensa["Telefono"];
            txtCelularAlum.Text = InfoDefensa["Celular"];
            cmbCarrera.SelectedValue = Convert.ToInt32(InfoDefensa["Id_carrera"]);
            string fec_defensa = (string.IsNullOrEmpty(InfoDefensa["Fecha_presentacion"])) ? "01/01/1970" : InfoDefensa["Fecha_presentacion"];
            dtFechaDefensa.Value = DateTime.Parse(fec_defensa, new CultureInfo("en-GB"));
            string hor_defensa = (string.IsNullOrEmpty(InfoDefensa["Hora"])) ? "00:00:00" : InfoDefensa["Hora"];
            dtHora.Value = DateTime.Parse(hor_defensa, new CultureInfo("en-GB"));
            cbbLetraAula.Text = string.IsNullOrEmpty(InfoDefensa["Aula"]) ? 'N'.ToString() : InfoDefensa["Aula"][0].ToString();
            char[] charsToTrim = { 'N', 'S', 'O', 'E' };
            txtAula.Text = InfoDefensa["Aula"].Trim(charsToTrim);
            txtNota.Text = InfoDefensa["Calificacion"];
            txtTutorGral.Text = $"{InfoDefensa["NombreLicenciado"]} {InfoDefensa["ApellidoLicenciado"]}";

            getLicenciados();

            showLinceciados();

        }
        public void getLicenciados()
        {
                      

            int id_defensa = Convert.ToInt32(InfoDefensa["Id"]);
            var list = info.getLicenciadosDefensa(id_defensa);
            this.isEmpty = !list.Any();
            if (!this.isEmpty)
            {

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


        }
        public void showLinceciados()
        {
            foreach (var item in listLicenciados)
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
                        loadComboLicenciado(cmbRepresentanteUagrm1, item["Nombre"], item["Apellido"], Convert.ToInt32(item["Id_licenciado"]));
                        break;
                    case "Representante Uagrm 2":
                        loadComboLicenciado(cmbRepresentanteUagrm2, item["Nombre"], item["Apellido"], Convert.ToInt32(item["Id_licenciado"]));
                        break;
                    case "Secretario":
                        loadComboLicenciado(cmbSecretario, item["Nombre"], item["Apellido"], Convert.ToInt32(item["Id_licenciado"]));
                        break;
                    case "Representante del Ministerio de Educacion":
                        loadComboLicenciado(cmbRepresentanteMinisterio, item["Nombre"], item["Apellido"], Convert.ToInt32(item["Id_licenciado"]));
                        break;
                    default:
                        break;
                }

            }
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
        public string SetAndEval(TextBox txt, string key, Dictionary<string, string> dic)
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
        public string SetAndEvalDatetime(DateTimePicker dtp, string key, Dictionary<string, string> dic, string tipo = "F")
        {

            string text;
            switch (tipo)
            {
                case "F":
                    text = ((dtp.Value.ToString("dd-MM-yyyy") == dic[key])||(dtp.Value.ToString("dd-MM-yyyy")=="01-01-1970")) ? dic[key] : dtp.Value.ToString("dd-MM-yyyy");
                    return text;
                case "H":
                    text = ((dtp.Value.ToString("HH:mm") == dic[key])|| (dtp.Value.ToString("HH:mm") == "00:00")) ? dic[key] : dtp.Value.ToString("HH:mm");
                    return text;
                default:
                    throw new Exception("entrada de formato invalido");
            }


        }
        public string setAndEvalEstadoDefensa()
        {
            string estado = InfoDefensa["Estado_defensa"];
            string calificacion = InfoDefensa["Calificacion"];
            string fecha_presentacion = InfoDefensa["Fecha_presentacion"];
            if (!string.IsNullOrEmpty(fecha_presentacion))
            {
                if (calificacion == "0.0")
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
            defensa_externa.Id = InfoDefensa["Id"];
            defensa_externa.Fecha_presentacion = SetAndEvalDatetime(dtFechaDefensa, "Fecha_presentacion", InfoDefensa);
            defensa_externa.Hora = SetAndEvalDatetime(dtHora, "Hora", InfoDefensa, "H");
            string aula = cbbLetraAula.Text + txtAula.Text;
            //defensa_externa.Aula = SetAndEval(aula, "Aula", InfoDefensa);
            defensa_externa.Aula = aula;
            defensa_externa.Id_tesis = InfoDefensa["Id_tesis"];
            estudiante.Id = InfoDefensa["Id_estudiante"];
            estudiante.Registro = SetAndEval(txtRegistroAlum, "Registro", InfoDefensa);
            estudiante.Apellido = SetAndEval(txtApellidoAlum, "Apellido", InfoDefensa);
            estudiante.Nombre = SetAndEval(txtNombreAlum, "Nombre", InfoDefensa);
            estudiante.Email = SetAndEval(txtEmailAlum, "Email", InfoDefensa);
            estudiante.Telefono = SetAndEval(txtTelefonoAlum, "Telefono", InfoDefensa);
            estudiante.Celular = SetAndEval(txtCelularAlum, "Celular", InfoDefensa);
            estudiante.Id_carrera = SetAndEvalCombo(cmbCarrera, "Id_carrera", InfoDefensa);
            perfil_tesis.Id = InfoDefensa["Id_tesis"];
            perfil_tesis.Estado_defensa = setAndEvalEstadoDefensa();
            perfil_tesis.Tema = SetAndEval(txtTemaGral, "Tema", InfoDefensa);
            perfil_tesis.Calificacion = SetAndEval(txtNota, "Calificacion", InfoDefensa);
            perfil_tesis.Id_estudiante = InfoDefensa["Id_estudiante"];
            perfil_tesis.Id_licenciado = InfoDefensa["Id_licenciado"];
            perfil_tesis.Id_funcion_licenciado = InfoDefensa["Id_funcion_licenciado"];
            perfil_tesis.Estado = InfoDefensa["Estado"];
            perfil_tesis.Fecha_aprobacion_jefe_carrera = InfoDefensa["Fecha_aprobacion_jefe_carrera"];
            perfil_tesis.Fecha_recepcion_titulacion = InfoDefensa["Fecha_recepcion_titulacion"];


            if (!this.isEmpty)
            {
                ////recolecion y evaluacion de licenciados
                recolectDataDetalleDefensa();
                return true;
            }
            else
            {
                MessageBox.Show("Necesita llenar todos los datos correspondientes a la defensa para guardar sus cambios");
                return false;
            }

        }
        public void recolectDataDetalleDefensa()
        {

            foreach (var item in listLicenciados)
            {
                dynamic detalle_defensa = new ExpandoObject();
                detalle_defensa.Id = item["Id_detalle_defensa"];
                detalle_defensa.Id_defensa_externa = item["Id_defensa_externa"];
                detalle_defensa.Id_funcion_licenciado = item["Id_funcion_licenciado"];
                detalle_defensa.Id_licenciado = setAndEvalIdLicenciado(Convert.ToString(item["Funcion"]), item);
                lista_detalle_defensa.Add(detalle_defensa);

            }

        }
        public string setAndEvalIdLicenciado(string funcion, Dictionary<string, string> dic)
        {
            string res = "";
            if (funcion == "Presidente")
            {
                res = SetAndEvalComboLicenciado(cmbPresidente, "Id_licenciado", dic);
            }
            else if (funcion == "Secretario")
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
        void form_Disposed3(object sender, EventArgs e)
        {
            Tutor = null;

        }

        public void loadComboLicenciado(ComboBox cmb, string nombre = "", string apellido = "", int id_licenciado = 0)
        {
            ComboBoxItem cmb_item = new ComboBoxItem();
            cmb_item.Text = $"{nombre} {apellido}";
            cmb_item.Value = id_licenciado;
            cmb.Items.Clear();
            cmb.Items.Add(cmb_item);
            cmb.SelectedIndex = 0;
        }
        public void loadDictionary(int id)
        {           
            var list = info.getInfoDefensaTesis(id);
            InfoDefensa.Add("Id", Convert.ToString(list.Id));
            InfoDefensa.Add("Fecha_presentacion", Convert.ToString(list.Fecha_presentacion));
            InfoDefensa.Add("Hora", Convert.ToString(list.Hora));
            InfoDefensa.Add("Aula", Convert.ToString(list.Aula));
            InfoDefensa.Add("Id_tesis", Convert.ToString(list.Id_tesis));
            InfoDefensa.Add("Estado", Convert.ToString(list.Estado));
            InfoDefensa.Add("Fecha_aprobacion_jefe_carrera", Convert.ToString(list.Fecha_aprobacion_jefe_carrera));
            InfoDefensa.Add("Fecha_recepcion_titulacion", Convert.ToString(list.Fecha_recepcion_titulacion));
            InfoDefensa.Add("Estado_defensa", Convert.ToString(list.Estado_defensa));
            InfoDefensa.Add("Tema", Convert.ToString(list.Tema));
            InfoDefensa.Add("Calificacion", Convert.ToString(list.Calificacion));
            InfoDefensa.Add("Id_estudiante", Convert.ToString(list.Id_estudiante));
            InfoDefensa.Add("Registro", Convert.ToString(list.Registro));
            InfoDefensa.Add("Nombre", Convert.ToString(list.Nombre));
            InfoDefensa.Add("Apellido", Convert.ToString(list.Apellido));
            InfoDefensa.Add("Email", Convert.ToString(list.Email));
            InfoDefensa.Add("Telefono", Convert.ToString(list.Telefono));
            InfoDefensa.Add("Celular", Convert.ToString(list.Celular));
            InfoDefensa.Add("Id_carrera", Convert.ToString(list.Id_carrera));
            InfoDefensa.Add("Carrera", Convert.ToString(list.Carrera));
            InfoDefensa.Add("Id_licenciado", Convert.ToString(list.Id_licenciado));
            InfoDefensa.Add("NombreLicenciado", Convert.ToString(list.NombreLicenciado));
            InfoDefensa.Add("ApellidoLicenciado", Convert.ToString(list.ApellidoLicenciado));
            InfoDefensa.Add("Id_funcion_licenciado", Convert.ToString(list.Id_funcion_licenciado));
            InfoDefensa.Add("Funcion", Convert.ToString(list.Funcion));

        }

        #endregion



        #region Diseño

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnCancelarNuevaDefensa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        
        public void insertLicenciados()
        {
            List<dynamic> setListLicenciados = new List<dynamic>();
            Dictionary<ComboBox, int> key_cmb = new Dictionary<ComboBox, int>();

            key_cmb.Add(cmbPresidente, 3);
            key_cmb.Add(cmbSecretario, 4);
            key_cmb.Add(cmbTribunalInterno1, 5);
            key_cmb.Add(cmbTribunalInterno2, 6);
            key_cmb.Add(cmbRepresentanteUagrm1, 8);
            key_cmb.Add(cmbRepresentanteUagrm2, 9);
            key_cmb.Add(cmbRepresentanteMinisterio, 7);
            List<ComboBox> cmb_licenciados = new List<ComboBox>();
            cmb_licenciados.Add(cmbPresidente);
            cmb_licenciados.Add(cmbSecretario);
            cmb_licenciados.Add(cmbTribunalInterno1);
            cmb_licenciados.Add(cmbTribunalInterno2);
            cmb_licenciados.Add(cmbRepresentanteUagrm1);
            cmb_licenciados.Add(cmbRepresentanteUagrm2);
            cmb_licenciados.Add(cmbRepresentanteMinisterio);

            if (cmb_licenciados.Count < 0)
            {
                foreach (var item in cmb_licenciados)
                {
                    dynamic obj = new ExpandoObject();
                    obj.Id_defensa_externa = InfoDefensa["Id"];
                    obj.Id_licenciado = (item.SelectedItem as ComboBoxItem).Value.ToString();
                    obj.Id_funcion_licenciado = Convert.ToString(key_cmb[item]);
                    setListLicenciados.Add(obj);
                }
                AgregarDefensa addLicenciadosDefensa = new AgregarDefensa();

                addLicenciadosDefensa.mainTesisDetalle(setListLicenciados);
            }
            else
            {
                MessageBox.Show("Necesita llenar todos los datos necesarios");
            }
            

        }


        private void btnGuardarNuevaDefensa_Click(object sender, EventArgs e)
        {
            if(recolectData())
            {
                ActualizarDefensa actualizar = new ActualizarDefensa();
                if (this.isEmpty)
                {

                    actualizar.updateTesis(estudiante, perfil_tesis, defensa_externa);
                    insertLicenciados();

                }
                else
                {

                    actualizar.updateTesis(estudiante, perfil_tesis, defensa_externa, lista_detalle_defensa);

                }
            }
            else
            {
                return;
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

                    default:
                        throw new ArgumentException();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void btnElegirPresidente_Click(object sender, EventArgs e)
        {
            tipolicenciado = 1;
            FirstButtonActive(btnElegirPresidente);
            FrmTutor frm = this.FormInstance3;
            frm.contrato = this;
            frm.Show();
            frm.lblLicen.Text = "Licenciado : "; //+ lblPresidente.Text;(falta nombrar los labels)
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
    }
}
