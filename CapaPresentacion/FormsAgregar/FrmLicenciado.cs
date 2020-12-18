﻿using CapaPresentacion.FormsAgregar;
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
        //NegocioLicenciados obj = new NegocioLicenciados();

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
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            

        }

        private void btnSeleccionarLicenciado_Click(object sender, EventArgs e)
        {
            int id_seleccionado = Convert.ToInt32(dtgLicenciados.CurrentRow.Cells[0].Value.ToString());
            string tutor = (dtgLicenciados.CurrentRow.Cells[2].Value.ToString() +" "+ dtgLicenciados.CurrentRow.Cells[3].Value.ToString());

          //usando el contrato interfaz
            contrato.Ejecutar(id_seleccionado, tutor);
            this.Close();
        }
        //private void btnEliminarLicenciado_Click(object sender, EventArgs e)
        //{
        //    DialogResult dialogo = MessageBox.Show("¿Quiere eliminar este registro?", "Eliminar Licenciado", MessageBoxButtons.YesNo);
        //    if(dialogo == DialogResult.Yes)
        //    {
        //        try
        //        {
        //            int id_seleccionado = Convert.ToInt32(dtgLicenciados.CurrentRow.Cells[0].Value.ToString());
        //            delete(id_seleccionado);
        //            ShowLicenciados();
        //        }
        //        catch(Exception ex)
        //        {
        //            MessageBox.Show(""+ex);
        //            //mike :)

        //        }

        //    }
        //    else if(dialogo == DialogResult.No)
        //    {

        //    }

        //}
        private void btnGuardarLicenciado_Click(object sender, EventArgs e)
        {
            try
            {
                int referencia = Convert.ToInt32(dtgLicenciados.CurrentRow.Cells[0].Value.ToString());

                if (id_parametro <= 0)
                {
                    if(Insert())
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
                else if(id_parametro > 0 && id_parametro == referencia)
                {
                    Update(id_parametro);
                    ClearForms();
                    cargarLicenciados();
                    id_parametro = 0;
                    MessageBox.Show("Datos guardados correctamente");
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

        public bool Insert()
        {
            try
            {
                string nombre = txtNombreLicenciado.Text; //input 0
                string apellido = txtApellidoLicenciado.Text;//input 1
                string descripcion = txtDescripcion.Text;//input 3
                string email = txtEmailLicenciado.Text;// input 4
                string telefono = txtTelefono.Text;// input 5
                string celular = txtCelular.Text;// input 6
                string tipo = cmbTipo.Text == "Trabaja fuera de Utepsa" ? "externo" : cmbTipo.Text == "Trabaja en Utepsa" ? "interno" : " ";// input 7
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
                AgregarLicenciado obj = new AgregarLicenciado();
                obj.inputController(datos, obj.main);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }
        public void Update(int i)
        {
            string nombre = txtNombreLicenciado.Text; //input 0
            string apellido = txtApellidoLicenciado.Text;//input 1
            string descripcion = txtDescripcion.Text;//input 3
            string email = txtEmailLicenciado.Text;// input 4
            string telefono = txtTelefono.Text;// input 5
            string celular = txtCelular.Text;// input 6
            string tipo = cmbTipo.Text == "Trabaja fuera de Utepsa" ? "externo" : cmbTipo.Text == "Trabaja en Utepsa" ? "interno" : " ";// input 7
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

            ActualizarLicenciado obj = new ActualizarLicenciado(i);
            obj.inputController(datos, obj.main);

        }
        public void info(int i)
        {

            InfoLicenciado obj = new InfoLicenciado(i);
            var Collection = obj.main();

            txtNombreLicenciado.Text = Convert.ToString(Collection[1]);
            txtApellidoLicenciado.Text = Convert.ToString(Collection[2]);
            txtDescripcion.Text = Convert.ToString(Collection[3]);
            txtEmailLicenciado.Text = Convert.ToString(Collection[4]);
            txtTelefono.Text = Convert.ToString(Collection[5]);
            txtCelular.Text = Convert.ToString(Collection[6]);
            cmbTipo.SelectedIndex = (Convert.ToString(Collection[7])== "externo") ? 0 : 1;
            if (Convert.ToInt32(Collection[8]) == 1) { rbDocenteSi.Checked = true; } else { rbDocenteNo.Checked = true; }
            cmbInstitucion.SelectedValue = Convert.ToInt32(Collection[9]);
            cmbCarreraLicenciado.SelectedValue = Convert.ToInt32(Collection[10]);
        }
        
       
        public void ClearForms()
        {
            txtNombreLicenciado.Clear();
            txtApellidoLicenciado.Clear();
            txtDescripcion.Clear();
            txtEmailLicenciado.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();
            if (rbDocenteNo.Checked) { rbDocenteNo.Checked = false; } else { rbDocenteSi.Checked = false; }
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
        public void cargarLicenciados(string criterio=null)
        {
            bool pass = String.IsNullOrEmpty(criterio);
            if (pass)
            {

                dtgLicenciados.Rows.Clear();
                MostrarLicenciados obj = new MostrarLicenciados();
                var list = obj.showLicenciados();


                int campo1 = 1;
                foreach (var item in list)
                {

                    string campo0 = Convert.ToString(item.Id);
                    string campo2 = item.Nombre;
                    string campo3 = item.Apellido;
                    string campo4 = item.Tipo;
                    string campo5 = item.Telefono;
                    string campo6 = item.Calular;
                    string campo7 = item.Email;

                    string[] row = new string[] { campo0, Convert.ToString(campo1), campo2, campo3, campo4, campo5, campo6, campo7 };
                    this.dtgLicenciados.Rows.Add(row);
                    campo1++;

                }
            }
            else
            {
                dtgLicenciados.Rows.Clear();
                MostrarLicenciados obj = new MostrarLicenciados();
                var list = obj.showLicenciados(criterio);


                int campo1 = 1;
                foreach (var item in list)
                {

                    string campo0 = Convert.ToString(item.Id);
                    string campo2 = item.Nombre;
                    string campo3 = item.Apellido;
                    string campo4 = item.Tipo;
                    string campo5 = item.Telefono;
                    string campo6 = item.Calular;
                    string campo7 = item.Email;

                    string[] row = new string[] { campo0, Convert.ToString(campo1), campo2, campo3, campo4, campo5, campo6, campo7 };
                    this.dtgLicenciados.Rows.Add(row);
                    campo1++;

                }
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
            //int id_seleccionado = Convert.ToInt32(dtgLicenciados.CurrentRow.Cells[0].Value.ToString());
            //string tutor = (dtgLicenciados.CurrentRow.Cells[2].Value.ToString() + " " + dtgLicenciados.CurrentRow.Cells[3].Value.ToString());

            ////usando el contrato interfaz
            //contrato.Ejecutar(id_seleccionado, tutor);
            //this.Close();
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
                MessageBox.Show("" + ex);
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
                MessageBox.Show("" + ex);
            }
        }
    }
}
