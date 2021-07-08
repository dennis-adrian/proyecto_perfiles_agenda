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
using CapaPresentacion.ContractForms;
using CapaNegocio;
using CapaNegocio.licenciados;
using CapaDatos.View;
using CapaPresentacion.Resources;

namespace CapaPresentacion
{
    public partial class FrmTutor : Form, IContractInstitucion, IContractCarreras
    {
        //BORDE SOMBREADO FORMULAR
        private const int CS_DROPSHADOW = 0x20000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        #region Constructor
        public FrmTutor()
        {
            InitializeComponent();
            InitialForms();

        }

        #endregion

        private FrmCarreraExterna CarExt = null;
        private FrmInstitucion insti = null;

        #region instanciar 1 sola vez formularios

        private FrmCarreraExterna FormInstance2
        {
            get
            {
                if (CarExt == null)
                {
                    CarExt = new FrmCarreraExterna();
                    CarExt.Disposed += new EventHandler(form_Disposed2);
                }

                return CarExt;
            }
        }

        void form_Disposed2(object sender, EventArgs e)
        {
            CarExt = null;

        }

        private FrmInstitucion FormInstance1
        {
            get
            {
                if (insti == null)
                {
                    insti = new FrmInstitucion();
                    insti.Disposed += new EventHandler(form_Disposed1);
                }

                return insti;
            }
        }

        void form_Disposed1(object sender, EventArgs e)
        {
            insti = null;

        }

        #endregion


        #region Instancias
        Index obj = new Index();

        #endregion

        #region Atributos
        int id_parametro = 0;


        #endregion

        #region Propiedades
        //utilizo la interface como propiedad
        public IContractLicenciado contrato { get; set; }

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnSeleccionarLicenciado_Click(object sender, EventArgs e)
        {
            int id_seleccionado = Convert.ToInt32(dtgLicenciados.CurrentRow.Cells[0].Value.ToString());
            string tutor = (dtgLicenciados.CurrentRow.Cells[2].Value.ToString() + " " + dtgLicenciados.CurrentRow.Cells[3].Value.ToString());

            //usando el contrato interfaz
            contrato.Ejecutar(id_seleccionado, tutor);
            this.Close();
        }
        private void btnGuardarLicenciado_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgLicenciados.CurrentRow == null)
                {
                    if (id_parametro <= 0)
                    {
                        if (Insert())
                        {
                            MessageBox.Show("Datos guardados correctamente");
                            ClearForms();
                            cargarLicenciados();
                        }
                        else
                        {
                            MessageBox.Show("Revise que ingresó los datos correctamente. \n" +
                                "Los únicos datos opcionales son la descripción y el teléfono");
                        }

                    }

                }
                else
                {
                    int referencia = Convert.ToInt32(dtgLicenciados.CurrentRow.Cells[0].Value.ToString());
                    if (id_parametro <= 0)
                    {
                        if (Insert())
                        {
                            MessageBox.Show("Datos guardados correctamente");
                            ClearForms();
                            cargarLicenciados();
                        }
                        else
                        {
                            MessageBox.Show("Revise que ingresó los datos correctamente. \n" +
                                "Los únicos datos opcionales son la descripción y el teléfono");
                        }

                    }
                    else if (id_parametro > 0 && id_parametro == referencia)
                    {
                        Update(id_parametro);
                        ClearForms();
                        cargarLicenciados();
                        id_parametro = 0;
                        MessageBox.Show("Datos actualizados correctamente");
                    }
                    else
                    {
                        throw new ArgumentException("sin referencia para actualizar");
                    }

                }
                //int referencia = Convert.ToInt32(dtgLicenciados.CurrentRow.Cells[0].Value.ToString());

                //if (id_parametro <= 0)
                //{
                //    if(Insert())
                //    {
                //        MessageBox.Show("Datos guardados correctamente");
                //        ClearForms();
                //        cargarLicenciados();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Revise que ingresó los datos correctamente. \n" +
                //            "Los únicos datos opcionales son la descripción y el teléfono");
                //    }

                //}
                //else if(id_parametro > 0 && id_parametro == referencia)
                //{
                //    Update(id_parametro);
                //    ClearForms();
                //    cargarLicenciados();
                //    id_parametro = 0;
                //    MessageBox.Show("Datos guardados correctamente");
                //}
                //else
                //{
                //    throw new ArgumentException("sin referencia para actualizar");
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        private void btnAgregarCarrera_Click(object sender, EventArgs e)
        {
            FrmCarreraExterna frm = this.FormInstance2;
            frm.contratoCarr = this;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ShowCarrerasLicenciado();
                frm.BringToFront();
            }
        }

        private void btnAgregarInstitucion_Click(object sender, EventArgs e)
        {
            FrmInstitucion frm = this.FormInstance1;
            //se crea la instancia del contrato
            frm.contratoInst = this;
            frm.Show();
            frm.BringToFront();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearForms();
            id_parametro = 0;

            MessageBox.Show(cmbTipo.Text);
        }

        #endregion

        #region Metodos
        CapaDatos.Models.Licenciado getData(int i = 0)
        {

            CapaDatos.Models.Licenciado licenciado = new CapaDatos.Models.Licenciado();

            try
            {
                licenciado.Id = i == 0 ? 0 : i;
                licenciado.Nombre = txtNombreLicenciado.Text; //input 0
                licenciado.Apellido = txtApellidoLicenciado.Text;//input 1
                licenciado.Descripcion = txtDescripcion.Text;//input 3
                licenciado.Email = txtEmailLicenciado.Text;// input 4
                licenciado.Telefono = txtTelefono.Text;
                licenciado.Celular = txtCelular.Text;
                licenciado.Tipo = cmbTipo.Text == "Trabaja fuera de Utepsa" ? "externo"
                                                : cmbTipo.Text == "Trabaja en Utepsa" ? "interno" : " ";// input 7
                licenciado.Docente = (rbDocenteSi.Checked) ? 1 : ((rbDocenteNo.Checked) ? 2 : 0);
                licenciado.Id_institucion_representada = cmbInstitucion.SelectedValue == null ? 0
                                                        : Convert.ToInt32(cmbInstitucion.SelectedValue.ToString());// input 9
                licenciado.Id_carrera_licenciado = cmbCarreraLicenciado.SelectedValue == null ? 0
                                                    : Convert.ToInt32(cmbCarreraLicenciado.SelectedValue.ToString());// input 10

                return licenciado;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }


        }
        public bool Insert()
        {
            var data = getData();
            if (data != null)
            {
                obj.createNewLicenciado(data);
                return true;
            }
            return false;

        }
        public bool Update(int i)
        {
            var data = getData(i);
            if (data != null)
            {
                obj.updateLicenciado(data);
                return true;
            }
            return false;


        }
        public void info(int i)
        {


            try
            {
                CapaDatos.Models.Licenciado licenciado = new CapaDatos.Models.Licenciado();
                licenciado.Id = i;
                var data = obj.getLicenciado(licenciado);
                if(data==null)
                {
                    throw new ArgumentException("data is null");
                }
                txtNombreLicenciado.Text = data.Nombre;
                txtApellidoLicenciado.Text = data.Apellido;
                txtDescripcion.Text = data.Descripcion;
                txtEmailLicenciado.Text = data.Email;
                txtTelefono.Text = data.Telefono;
                txtCelular.Text = data.Celular;
                cmbTipo.SelectedIndex = (data.Tipo == "externo") ? 0 : 1;
                RadioButton rb = new RadioButton();
                rb = data.Docente == 1 ? rbDocenteSi : rbDocenteNo;
                rb.Checked = true;

                // if (Convert.ToInt32(Collection[8]) == 1) { rbDocenteSi.Checked = true; } else { rbDocenteNo.Checked = true; }

                cmbInstitucion.SelectedValue = data.Id_institucion_representada;
                cmbCarreraLicenciado.SelectedValue = data.Id_carrera_licenciado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void ClearForms()
        {
            txtNombreLicenciado.Clear();
            txtApellidoLicenciado.Clear();
            txtDescripcion.Clear();
            txtEmailLicenciado.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();
            cmbTipo.SelectedIndex = 0;
            //if (rbDocenteNo.Checked) { rbDocenteNo.Checked = false; } else { rbDocenteSi.Checked = false; }
        }
        public void InitialForms()
        {
            cmbTipo.Items.Clear();
            ShowCarrerasLicenciado();
            ShowInstituciones();
            cmbTipo.SelectedItem = null;
            cmbTipo.Items.Insert(0, "Trabaja fuera de Utepsa");
            cmbTipo.Items.Insert(1, "Trabaja en Utepsa");
            cmbTipo.SelectedIndex = 0;


            cargarLicenciados();
        }
        public void ShowCarrerasLicenciado()
        {
            cmbCarreraLicenciado.DataSource = null;
            cmbCarreraLicenciado.Items.Clear();
            cmbCarreraLicenciado.DataSource = obj.cargarCarrerasLicenciados();
            cmbCarreraLicenciado.ValueMember = "id";
            cmbCarreraLicenciado.DisplayMember = "nombre";

        }
        public void ShowInstituciones()
        {
            cmbInstitucion.DataSource = null;
            cmbInstitucion.Items.Clear();
            cmbInstitucion.DataSource = obj.cargarInstitucion();
            cmbInstitucion.ValueMember = "id";
            cmbInstitucion.DisplayMember = "nombre";

        }
        public void cargarLicenciados(string criterio = null)
        {
            var data = String.IsNullOrEmpty(criterio) ?
                        obj.getLicenciados() : obj.getLicenciados(criterio);
            dtgLicenciados.Rows.Clear();
            int campo1 = 1;
            foreach (var item in data)
            {
                string campo0 = Convert.ToString(item.Id);
                string campo2 = item.Nombre;
                string campo3 = item.Apellido;
                string campo4 = item.Tipo;
                string campo5 = item.Telefono;
                string campo6 = item.Celular;
                string campo7 = item.Email;
                string[] row = new string[] { campo0, Convert.ToString(campo1), campo2, campo3, campo4, campo5, campo6, campo7 };
                this.dtgLicenciados.Rows.Add(row);
                campo1++;

            }


        }



        #endregion

        private void dtgLicenciados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmTutor_Load(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 1)
            {
                rbDocenteSi.Enabled = true;
                rbDocenteNo.Enabled = true;
            }
            if (cmbTipo.SelectedIndex == 0)
            {
                rbDocenteSi.Enabled = false;
                rbDocenteNo.Enabled = false;
                rbDocenteNo.Checked = true;
            }
        }

        private void dtgLicenciados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarLicenciado_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = txtBuscarLicenciado.Text;
                cargarLicenciados(criterio);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EjecutarInstitucion(int id, string nombre)
        {
            try
            {
                cmbInstitucion.DataSource = null;
                cmbInstitucion.Items.Clear();
                cmbInstitucion.DataSource = obj.cargarInstitucion();
                cmbInstitucion.ValueMember = "id";
                cmbInstitucion.DisplayMember = "nombre";
                cmbInstitucion.SelectedIndex = id - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EjecutarCarreraExterna(int id, string nombre)
        {
            try
            {
                cmbCarreraLicenciado.DataSource = null;
                cmbCarreraLicenciado.Items.Clear();
                cmbCarreraLicenciado.DataSource = obj.cargarCarrerasLicenciados();
                cmbCarreraLicenciado.ValueMember = "id";
                cmbCarreraLicenciado.DisplayMember = "nombre";
                cmbCarreraLicenciado.SelectedIndex = id - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
