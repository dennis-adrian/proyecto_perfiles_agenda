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

using CapaPresentacion.ContractForms;
using CapaPresentacion.Resources;

namespace CapaPresentacion
{
    public partial class FrmTesisAgenda : Form
    {
        #region Instancias
           CapaNegocio.defensaExterna.defensaPerfil.otros.InfoDefensa info = new CapaNegocio.defensaExterna.defensaPerfil.otros.InfoDefensa();
        #endregion
        #region Atributos
        string carrera;
        int estudiante;
        string tipo;
        int tipolicenciado = 0;
        Dictionary<string, string> InfoDefensa = new Dictionary<string, string>();
        #endregion

        public FrmTesisAgenda(int ES = 0, string CA = "", string TI = "")
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
            txtAula.Text = InfoDefensa["Aula"];
            //getLicenciados();


        }
        public void loadDictionary(int id)
        {
            
            var list = info.getInfoDefensaTesis(id);

            InfoDefensa.Add("Id", Convert.ToString(list.Id));
            InfoDefensa.Add("Fecha_presentacion", Convert.ToString(list.Fecha_presentacion));
            InfoDefensa.Add("Hora", Convert.ToString(list.Hora));
            InfoDefensa.Add("Aula", Convert.ToString(list.Aula));
            InfoDefensa.Add("Id_tesis", Convert.ToString(list.Id_tesis));
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
            ;



        }


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
       

        private void btnGuardarNuevaDefensa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtFechaDefensa.Value.ToString("dd-MM-yyyy"));
        }
    }
}
