using System;
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

namespace CapaPresentacion
{
    public partial class FrmEditarDefensaExterna : Form, IContractLicenciado
    {
        
        #region Instancias
        NegocioDefensaGeneral defensa = new NegocioDefensaGeneral ();
        #endregion
        #region Atributos
        string carrera;
        int estudiante;
        string tipo;
        int tipolicenciado = 0;
        Dictionary<string, string> InfoDefensa = new Dictionary<string, string>();
        #endregion

        public FrmEditarDefensaExterna(int ES = 0,string CA = "",string TI = "")
        {
            InitializeComponent();            
            this.carrera = CA;
            this.estudiante = ES;
            this.tipo = TI;
            Inicializar();
            loadDictionary(ES);
            ShowInfo();
        }
        public void Inicializar()
        {
            lblTituloDefensa.Text = tipo;
            cmbCarrera.Items.Clear();
            cmbCarrera.DataSource = defensa.cargarCarreras();
            cmbCarrera.ValueMember = "id";
            cmbCarrera.DisplayMember = "nombre";

          //  ClearForms();

           

        }
        public void loadDictionary(int id)
        {
            var list = defensa.InfoDefensaOtros(id);
            InfoDefensa.Add("Id", list[0].ToString());
            InfoDefensa.Add("Fecha_presentacion", list[1].ToString());
            InfoDefensa.Add("Hora", list[2].ToString());
            InfoDefensa.Add("Aula", list[3].ToString());
            InfoDefensa.Add("Id_titulacion_otro", list[4].ToString());
            InfoDefensa.Add("Estado_defensa", list[5].ToString());
            InfoDefensa.Add("Tema", list[6].ToString());
            InfoDefensa.Add("Calificacion", list[7].ToString());
            InfoDefensa.Add("Id_tipo_titulacion", list[8].ToString());
            InfoDefensa.Add("Id_estudiante", list[9].ToString());
            InfoDefensa.Add("Registro", list[10].ToString());
            InfoDefensa.Add("Nombre", list[11].ToString());
            InfoDefensa.Add("Apellido", list[12].ToString());
            InfoDefensa.Add("Email", list[13].ToString());
            InfoDefensa.Add("Telefono", list[14].ToString());
            InfoDefensa.Add("Celular", list[15].ToString());
            InfoDefensa.Add("Id_carrera", list[16].ToString());
            InfoDefensa.Add("Carrera", list[17].ToString());


           
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
            dtFechaDefensa.Value = DateTime.Parse(InfoDefensa["Fecha_presentacion"], new CultureInfo("en-GB"));
            dtHora.Value = DateTime.Parse(InfoDefensa["Hora"], new CultureInfo("en-GB"));
            txtAula.Text = InfoDefensa["Aula"];
            getLicenciados();


        }
        public void getLicenciados()
        {
            int id_defensa = Convert.ToInt32(InfoDefensa["Id"]);
            var obj = defensa.getLicenciadosDefensa(id_defensa);
            foreach(var item in obj)
            {   
                int id_lic = item.Id_licenciado;
                string ape = item.Apellido;
                string nom = item.Nombre;
                string fun = item.Funcion;
                switch (fun)
                {
                    case "Presidente":
                        loadComboLicenciado(cmbPresidente, nom, ape, id_lic);
                        break;
                    case "Tribunal Interno 1":
                        loadComboLicenciado(cmbTribunalInterno1, nom, ape, id_lic);
                        break;
                    case "Tribunal Interno 2":
                        loadComboLicenciado(cmbTribunalInterno2, nom, ape, id_lic);
                        break;
                    case "Representante Uagrm 1":
                        loadComboLicenciado(cmbRepresentanteUagrm1, nom, ape, id_lic);
                        break;
                    case "Representante Uagrm 2":
                        loadComboLicenciado(cmbRepresentanteUagrm2, nom, ape, id_lic);
                        break;
                    case "Secretario":
                        loadComboLicenciado(cmbSecretario, nom, ape, id_lic);
                        break;
                    case "Representante del Ministerio de Educacion":
                        loadComboLicenciado(cmbRepresentanteMinisterio, nom, ape, id_lic);
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
        private void FrmEditarDefensaExterna_Load(object sender, EventArgs e)
        {




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
        private void btnGuardarNuevaDefensa_Click(object sender, EventArgs e)
        {

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
