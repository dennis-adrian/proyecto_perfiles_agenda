﻿using System;
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
using CapaNegocio;
using System.Globalization;

namespace CapaPresentacion
{
    public partial class FrmRevisionIndividual : Form, IContractLicenciado
    {
        

        int id_perfil;
        int num_revision;
        int id_revision = 0;

        #region instancias

        NegocioRevisiones obj = new NegocioRevisiones();
        NegocioNuevaDefensa nuevadefensa = new NegocioNuevaDefensa();

        #endregion



        #region Constructor
        public FrmRevisionIndividual(int id, int nro)
        {
            InitializeComponent();
            this.id_perfil = id;
            this.num_revision = nro;
            cargarNombreTribunales();
            inicializarDateTimePickers();
            ShowData();
        }
        #endregion


        private FrmTutor Tutor = null;


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

        public void cargarNombreTribunales()
        {
            try
            {
                var trib1 = obj.InfoRevisionTribunal(id_perfil, num_revision, 1)[13];
                var trib2 = obj.InfoRevisionTribunal(id_perfil, num_revision, 2)[13];
                btnTribunal1.Text = trib1.ToString();
                btnTribunal2.Text = trib2.ToString();

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
        public void ShowData()
        {
            infoRevision(this.id_perfil, this.num_revision, 1);
            /*if (rbTribunal1.Checked == true)
            {
                infoRevision(this.id_perfil, this.num_revision, 1);
            }
            else if(rbTribunal2.Checked == true)
            {
                infoRevision(this.id_perfil, this.num_revision, 2);
            }*/
        }

        
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

        public void Ejecutar(int id, string nombre)
        {
            cmbTribunal.Items.Clear();

            ComboBoxItem item = new ComboBoxItem();
            item.Text = nombre;
            item.Value = id;

            cmbTribunal.Items.Add(item);
            cmbTribunal.SelectedIndex = 0;
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




        #region Eventos

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
        #endregion


        #region Buttons
        private void btnElegirTribunal_Click(object sender, EventArgs e)
        {
            FrmTutor frm = this.FormInstance3;
            frm.contrato = this;
            frm.Show();
            frm.BringToFront();
        }
        private void btnCancelarNuevop_Click(object sender, EventArgs e)
        {
            FrmRevisiones frm = new FrmRevisiones();
            frm.Close();
        }
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
                   

                }
                else
                {
                    Update(this.id_revision);
                    MessageBox.Show("Datos de la revision actualizados correctamente");
                    InsertForNewDefensa();
                    rbTribunal1.Checked = false;
                    rbTribunal2.Checked = false;
                    ClearForms();
                   


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        public void InsertForNewDefensa()
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
                    nuevadefensa.ControlInput(datos);
                    nuevadefensa.Main(2);
                    MessageBox.Show("Se Agregó una defensa de este perfil, para editar los detalles seleccione el perfil en 'Defensa Externa' ");
                    //hacer el insert aqui
                }
                else if (dialogResult == DialogResult.No)
                {

                    MessageBox.Show("debera asignar manulamente despues");
                }

            }
        }

        #endregion



        private void rbTribunal2_CheckedChanged(object sender, EventArgs e)
        {
            infoRevision(this.id_perfil, this.num_revision, 2);
        }

        private void rbTribunal1_CheckedChanged(object sender, EventArgs e)
        {
           infoRevision(this.id_perfil, this.num_revision, 1);
        }

        public void infoRevision(int i, int n, int t)
        {

            var Collection = obj.InfoRevisionTribunal(i, n, t);
            int registro = Convert.ToInt32(Collection[0].ToString());

            if (registro <= 0)
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
                item.Text = Collection[13].ToString();
                int v = Convert.ToInt32(Collection[12].ToString());
                item.Value = v;
                cmbTribunal.Items.Add(item);
                cmbTribunal.SelectedIndex = 0;


                string empaste = Collection[11].ToString();
                DateChecked(dttEmpaste, chbEmpaste, empaste);

                string entregaalumno = Collection[3].ToString();
                DateChecked(dttEntregaAlumno, chbEntregaAlumno, entregaalumno);

                string entregatribunal = Collection[4].ToString();
                DateChecked(dttEntregaTribunal, chbEntregaTribunal, entregatribunal);

                string limite = Collection[5].ToString();
                DateChecked(dttLimiteSugerido, chbLimiteSugerido, limite);

                string devoluciontribunal = Collection[6].ToString();
                DateChecked(dttDevolucionTribunal, chbDevolucionTribunal, devoluciontribunal);

                string devolucionalumno = Collection[7].ToString();
                DateChecked(dttDevolucionAlumno, chbDevolucionAlumno, devolucionalumno);

                txtObservaciones.Text = Collection[8].ToString();

                txtEstadoDatos.Text = "Datos Asignados";
                this.id_revision = Convert.ToInt32(Collection[0].ToString());
                lbIdRevision.Text = Collection[0].ToString();

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

        public bool DateEnabled(DateTimePicker dtp)
        {
           
            if (dtp.Enabled)
            {
                return true;

            }
            return false;

        }

        public void Insert()
        {

            string estado = "revision";

            string fec_entrega_alumno = (DateEnabled(dttEntregaAlumno) == true)? dttEntregaAlumno.Value.ToString("dd-MM-yyyy"): "";

            string fec_entrega_tribunal = (DateEnabled(dttEntregaTribunal) == true) ? dttEntregaTribunal.Value.ToString("dd-MM-yyyy"):"";

            string fec_limite_devolucion = (DateEnabled(dttLimiteSugerido) == true) ? dttLimiteSugerido.Value.ToString("dd-MM-yyyy"):"";

            string fec_devolucion_tribunal = (DateEnabled(dttDevolucionTribunal) == true) ? dttDevolucionTribunal.Value.ToString("dd-MM-yyyy"):"";

            string fec_devolucion_alumno = (DateEnabled(dttDevolucionAlumno) == true) ? dttDevolucionAlumno.Value.ToString("dd-MM-yyyy"):"";

            string observacion = txtObservaciones.Text;

            int nro_tribunal = (rbTribunal1.Checked == true) ? 1 : ((rbTribunal2.Checked == true) ? 2 : 0);

            int nro_revision = num_revision;

            string fec_empaste = (DateEnabled(dttEmpaste) == true) ? dttEmpaste.Value.ToString("dd-MM-yyyy"):"";

            int id_tesis = id_perfil;

            int id_licenciado = Convert.ToInt32((cmbTribunal.SelectedItem as ComboBoxItem).Value.ToString());//input 10



            Object[] datos = new Object[]
         {
               estado,
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
                id_licenciado
         };

            obj.ControlInput(datos);
            obj.MainInsert();
            

        }

        public void Update(int idrevision)
        {

            string estado = "revision";

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



            Object[] datos = new Object[]
         {
               estado,
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
                id_licenciado
         };

            obj.ControlInput(datos);
            obj.MainUpdate(idrevision);


        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        #region Destructor

        ~FrmRevisionIndividual()
        {

        }
        #endregion


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
    }
}
