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

namespace CapaPresentacion
{
    public partial class FrmEditarDefensaExterna : Form
    {
        
        #region Instancias

        NegocioDefensaGeneral defensa = new NegocioDefensaGeneral ();

        #endregion
        #region Atributos
        string carrera;
        int estudiante;
        string tipo;


        Dictionary<string, string> InfoDefensa = new Dictionary<string, string>();
        #endregion

        public FrmEditarDefensaExterna(int ES = 0,string CA = "",string TI = "")
        {
            InitializeComponent();
            
            this.carrera = CA;
            this.estudiante = ES;
            this.tipo = TI;
            Inicializar();
            LoadDictionary(ES);
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
        public void LoadDictionary(int id)
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


    }
}
