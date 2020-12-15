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
using CapaPresentacion.Resources;
using CapaNegocio.defensaExterna.defensaPerfil.otros;
using CapaNegocio;
using System.Globalization;

namespace CapaPresentacion
{
    public partial class FrmRevisionIndividual : Form, IContractLicenciado
    {

        #region atributos

        //id del perfil de tesis
        int id_perfil;

        //id y numero de revision
        int num_revision;
        int id_revision = 0;

        //?????
        private FrmTutor Tutor = null;


        //instancia de la capa negocios
        //NegocioRevisiones obj = new NegocioRevisiones();
        CapaNegocio.revisionPerfil.Index obj = new CapaNegocio.revisionPerfil.Index();
        AgregarDefensa nuevadefensa = new AgregarDefensa();

        #endregion


       //Constructor
        public FrmRevisionIndividual(int id, int nro)
        {
            InitializeComponent();
            this.id_perfil = id;
            this.num_revision = nro;


            cargarNombreTribunales();
            inicializarDateTimePickers();
            ShowData();
        }
       



        //controles del formulario licenciado
        void form_Disposed3(object sender, EventArgs e)
        {
            Tutor = null;

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

        //checkbox and datetimepicker controles
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

        public bool DateEnabled(DateTimePicker dtp)
        {

            if (dtp.Enabled)
            {
                return true;

            }
            return false;

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

        private void chbEntregaAlumno_CheckedChanged(object sender, EventArgs e)
        {
            cambiarEstadoDateTimePicker(dttEntregaAlumno, sender);
        }

        private void chbEntregaTribunal_CheckedChanged(object sender, EventArgs e)
        {
            cambiarEstadoDateTimePicker(dttEntregaTribunal, sender);
        }

        private void chbDevolucionTribunal_CheckedChanged(object sender, EventArgs e)
        {
            cambiarEstadoDateTimePicker(dttDevolucionTribunal, sender);
        }

        private void chbDevolucionAlumno_CheckedChanged(object sender, EventArgs e)
        {
            cambiarEstadoDateTimePicker(dttDevolucionAlumno, sender);
        }

        private void chbEmpaste_CheckedChanged(object sender, EventArgs e)
        {
            cambiarEstadoDateTimePicker(dttEmpaste, sender);
        }

        private void chbLimiteSugerido_CheckedChanged(object sender, EventArgs e)
        {
            cambiarEstadoDateTimePicker(dttLimiteSugerido, sender);
        }
     
        //button elegir licenciado
        private void btnElegirTribunal_Click(object sender, EventArgs e)
        {
            FrmTutor frm = this.FormInstance3;
            frm.contrato = this;
            frm.Show();
            frm.BringToFront();
        }
        
        //button cancelar 
        private void btnCancelarNuevop_Click(object sender, EventArgs e)
        {
            FrmRevisiones frm = new FrmRevisiones();
            frm.Close();
        }
     
        //button guardar revision
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.id_revision <= 0)
                {
                    Insert();
                    MessageBox.Show("Datos de la revision guardados correctamente");
                    InsertForNewDefensa();
                    rbTribunal1.Checked = false;
                    rbTribunal2.Checked = false;
                    ClearForms();
                    cargarNombreTribunales();


                }
                else
                {
                    Update(this.id_revision);
                    MessageBox.Show("Datos de la revision actualizados correctamente");
                    InsertForNewDefensa();
                    rbTribunal1.Checked = false;
                    rbTribunal2.Checked = false;
                    ClearForms();

                    cargarNombreTribunales();




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

               
        private void rbTribunal2_CheckedChanged(object sender, EventArgs e)
        {
            infoRevision(this.id_perfil, this.num_revision, 2);
        }

        private void rbTribunal1_CheckedChanged(object sender, EventArgs e)
        {
           infoRevision(this.id_perfil, this.num_revision, 1);
        }

       
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }



        private void btnTribunal1_Click(object sender, EventArgs e)
        {
            rbTribunal2.Checked = false;
            rbTribunal1.Checked = true;
            pnlResaltadoTrib1.Visible = true;
            pnlResaltadoTrib2.Visible = false;
        }

        private void btnTribunal2_Click(object sender, EventArgs e)
        {
            rbTribunal1.Checked = false;
            rbTribunal2.Checked = true;
            pnlResaltadoTrib2.Visible = true;
            pnlResaltadoTrib1.Visible = false;
            Console.WriteLine(btnTribunal2.Text);
        }

    

       
        /// <summary>
        /// modificacion ultima
        /// </summary>
        void Insert()
        {

            string estado = "Revision";

            string fec_entrega_alumno = (DateEnabled(dttEntregaAlumno) == true) ? dttEntregaAlumno.Value.ToString("dd-MM-yyyy") : "";

            string fec_entrega_tribunal = (DateEnabled(dttEntregaTribunal) == true) ? dttEntregaTribunal.Value.ToString("dd-MM-yyyy") : "";

            string fec_limite_devolucion = (DateEnabled(dttLimiteSugerido) == true) ? dttLimiteSugerido.Value.ToString("dd-MM-yyyy") : "";

            string fec_devolucion_tribunal = (DateEnabled(dttDevolucionTribunal) == true) ? dttDevolucionTribunal.Value.ToString("dd-MM-yyyy") : "";

            string fec_devolucion_alumno = (DateEnabled(dttDevolucionAlumno) == true) ? dttDevolucionAlumno.Value.ToString("dd-MM-yyyy") : "";

            string observacion = txtObservaciones.Text;

            int nro_tribunal = (rbTribunal1.Checked == true) ? 1 : ((rbTribunal2.Checked == true) ? 2 : 0);

            int nro_revision = num_revision;

            string fec_empaste = (DateEnabled(dttEmpaste) == true) ? dttEmpaste.Value.ToString("dd-MM-yyyy") : "";

            int id_tesis = id_perfil;

            int id_licenciado = Convert.ToInt32((cmbTribunal.SelectedItem as ComboBoxItem).Value.ToString());//input 10

            obj.createRevision(estado,
               fec_entrega_alumno,
                fec_entrega_tribunal,
                fec_limite_devolucion,
                fec_devolucion_tribunal,
                fec_devolucion_alumno,
                observacion,
                nro_tribunal,
                nro_revision,
                fec_empaste,
                id_tesis,
                id_licenciado);
        }
       
        /// <summary>
        /// modificacion ultima
        /// </summary>
        /// <param name="idrevision"></param>
        void Update(int idrevision)
        {

            string estado = "Revision";

            string fec_entrega_alumno = (DateEnabled(dttEntregaAlumno) == true) ? dttEntregaAlumno.Value.ToString("dd-MM-yyyy") : "";

            string fec_entrega_tribunal = (DateEnabled(dttEntregaTribunal) == true) ? dttEntregaTribunal.Value.ToString("dd-MM-yyyy") : "";

            string fec_limite_devolucion = (DateEnabled(dttLimiteSugerido) == true) ? dttLimiteSugerido.Value.ToString("dd-MM-yyyy") : "";

            string fec_devolucion_tribunal = (DateEnabled(dttDevolucionTribunal) == true) ? dttDevolucionTribunal.Value.ToString("dd-MM-yyyy") : "";

            string fec_devolucion_alumno = (DateEnabled(dttDevolucionAlumno) == true) ? dttDevolucionAlumno.Value.ToString("dd-MM-yyyy") : "";

            string observacion = txtObservaciones.Text;

            int nro_tribunal = (rbTribunal1.Checked == true) ? 1 : ((rbTribunal2.Checked == true) ? 2 : 0);

            int nro_revision = num_revision;

            string fec_empaste = (DateEnabled(dttEmpaste) == true) ? dttEmpaste.Value.ToString("dd-MM-yyyy") : "";

            int id_tesis = id_perfil;

            int id_licenciado = Convert.ToInt32((cmbTribunal.SelectedItem as ComboBoxItem).Value.ToString());//input 10
            int idRevision = Convert.ToInt32(txtIdRevision.Text);
            int idDetalleRevision = Convert.ToInt32(txtIdDetalleRevision.Text);


            obj.updateRevision(idRevision,idDetalleRevision, estado,
               fec_entrega_alumno,
                fec_entrega_tribunal,
                fec_limite_devolucion,
                fec_devolucion_tribunal,
                fec_devolucion_alumno,
                observacion,
                nro_tribunal,
                nro_revision,
                fec_empaste,
                id_tesis,
                id_licenciado);
           
        }
        
        




        
        void InsertForNewDefensa()
        {
            bool res = obj.ValidarFechasEmpasteforNewInsert(this.id_perfil, 1, 2);
            if (res == true)
            {
                string msg = "Las Fechas de Empaste del tribunal 1 y tribunal 2 están asignandas, ¿Quiere agregar una defensa de este perfil?";
                string title = "Nueva Defensa Externa";
                DialogResult dialogResult = MessageBox.Show(msg, title, MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {

                    Object[] datos = new Object[]
                   { this.id_perfil};
                    nuevadefensa.inputController(datos, nuevadefensa.mainTesis);
                    MessageBox.Show("Se Agregó una defensa de este perfil, para editar los detalles seleccione el perfil en 'Defensa Externa' ");
                    //hacer el insert aqui
                }
                else if (dialogResult == DialogResult.No)
                {

                    MessageBox.Show("debera asignar manulamente despues");
                }

            }
        }







        /// <summary>
        /// modificacion ultima
        /// </summary>
        /// <param name="idtesis"></param>
        /// <param name="nrorevision"></param>
        /// <param name="nrotribunal"></param>
        void infoRevision(int idtesis, int nrorevision, int nrotribunal)
        {

            var info = obj.infoRevision(idtesis, nrorevision, nrotribunal);

            if(info.Id <= 0)
            {
                txtEstadoDatos.Text = "sin datos asignados";
                this.id_revision = 0;
                lbIdRevision.Text = Convert.ToString(0);
                ClearForms();
            }
            else
            {
                cmbTribunal.Items.Clear();
                ComboBoxItem item = new ComboBoxItem();
                item.Text = info.Licenciado;
                int id_licenciado = info.Id_licenciado;
                item.Value = id_licenciado;
                cmbTribunal.Items.Add(item);
                cmbTribunal.SelectedIndex = 0;

                DateChecked(dttEmpaste, chbEmpaste, info.Fecha_empaste);
                DateChecked(dttEntregaAlumno, chbEntregaAlumno, info.Fecha_entrega_alumno);                
                DateChecked(dttEntregaTribunal, chbEntregaTribunal, info.Fecha_entrega_tribunal);
                DateChecked(dttLimiteSugerido, chbLimiteSugerido, info.Fecha_limite_devolucion);
                DateChecked(dttDevolucionTribunal, chbDevolucionTribunal, info.Fecha_devolucion_tribunal);
                DateChecked(dttDevolucionAlumno, chbDevolucionAlumno, info.Fecha_devolucion_alumno);
                txtObservaciones.Text = info.Observacion;
                txtIdRevision.Text = Convert.ToString(info.Id);
                this.id_revision = info.Id;
                txtIdDetalleRevision.Text= Convert.ToString(info.Id_detalle_revision);
                txtEstadoDatos.Text = "Datos Asignados";

            }
            
        }

        /// <summary>
        /// modificacion ultima
        /// </summary>
        void cargarNombreTribunales()
        {
            try
            {
               

                var trib1 = obj.infoRevision(id_perfil, num_revision, 1);
                var trib2 = obj.infoRevision(id_perfil, num_revision, 2);
                btnTribunal1.Text = trib1.Licenciado;
                btnTribunal2.Text = trib2.Licenciado;

                if (btnTribunal1.Text == "" || btnTribunal1.Text == null)
                {
                    btnTribunal1.Text = "Tribunal 1";
                }
                if (btnTribunal2.Text == "" || btnTribunal2.Text == null)
                {
                    btnTribunal2.Text = "Tribunal 2";
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
        
        /// <summary>
        /// carga los datos al inicio
        /// </summary>
        public void ShowData()
        {
            infoRevision(this.id_perfil, this.num_revision, 1);
            
        }


        /// <summary>
        /// limpia y resetea componentes
        /// </summary>
        public void ClearForms()
        {
            cmbTribunal.Items.Clear();
            ComboBoxItem item = new ComboBoxItem();
            item.Text = "";
            item.Value = 0;
            cmbTribunal.Items.Add(item);
            cmbTribunal.SelectedIndex = 0;
            txtObservaciones.Text = "";
            inicializarDateTimePickers();
        }

        /// <summary>
        /// incializa los datetimepicker
        /// </summary>
        public void inicializarDateTimePickers()
        {
            dttDevolucionAlumno.Value = DateTime.Now;
            dttDevolucionAlumno.Enabled = false;
            chbDevolucionAlumno.Checked = false;

            dttDevolucionTribunal.Value = DateTime.Now;
            dttDevolucionTribunal.Enabled = false;
            chbDevolucionTribunal.Checked = false;

            dttEmpaste.Value = DateTime.Now;
            dttEmpaste.Enabled = false;
            chbEmpaste.Checked = false;

            dttEntregaAlumno.Value = DateTime.Now;
            dttEntregaAlumno.Enabled = false;
            chbEntregaAlumno.Checked = false;

            dttEntregaTribunal.Value = DateTime.Now;
            dttEntregaTribunal.Enabled = false;
            chbEntregaTribunal.Checked = false;

            dttLimiteSugerido.Value = DateTime.Now;
            dttLimiteSugerido.Enabled = false;
            chbLimiteSugerido.Checked = false;
        }


        /// <summary>
        /// metodo de la interfaz que enlaza los datos del licenciado elegido al combobox
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        public void Ejecutar(int id, string nombre)
        {
            cmbTribunal.Items.Clear();

            ComboBoxItem item = new ComboBoxItem();
            item.Text = nombre;
            item.Value = id;

            cmbTribunal.Items.Add(item);
            cmbTribunal.SelectedIndex = 0;
        }



        





        #region Destructor

        ~FrmRevisionIndividual()
        {

        }
        #endregion
    }
}
