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
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmRevisionIndividual : Form, IContractLicenciado
    {
        

        string nroTribunal = "1";
        int idperfil;
        int nrorev;
        public FrmRevisionIndividual(int idperf, int nro)
        {
            InitializeComponent();
            this.idperfil = idperf;
            this.nrorev = nro;
        }
        public FrmRevisionIndividual()
        {
        }
        #region instancias
        NegocioNuevaRevision obj = new NegocioNuevaRevision();       
        #endregion
        public void reiniciarValores()
        {
            cmbTribunal.Items.Clear();
            ComboBoxItem item = new ComboBoxItem();
            item.Text = "";
            item.Value = 0;

            cmbTribunal.Items.Add(item);
            cmbTribunal.SelectedIndex = 0;

            //---------------------------
            txtObservaciones.Text = "";
            dttDevolucionAlumno.Value = DateTime.Parse("12-12-2000");
            dttDevolucionTribunal.Value = DateTime.Parse("12-12-2000");
            dttEmpaste.Value = DateTime.Parse("12-12-2000");
            dttEntregaAlumno.Value = DateTime.Parse("12-12-2000");
            dttEntregaTribunal.Value = DateTime.Parse("12-12-2000");
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




        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnElegirTribunal_Click(object sender, EventArgs e)
        {
          
            FrmTutor frm = new FrmTutor();
            frm.contrato = this;
            frm.Show();
        }

        private void btnCancelarNuevop_Click(object sender, EventArgs e)
        {
            FrmRevisiones frm = new FrmRevisiones();
            frm.Close();
        }

        private void rbTribunal2_CheckedChanged(object sender, EventArgs e)
        {
            this.nroTribunal = "2";
            reiniciarValores();
            //txtTribunal.Text = nroTribunal;
        }

        private void rbTribunal1_CheckedChanged(object sender, EventArgs e)
        {
            this.nroTribunal = "1";
            reiniciarValores();
            //txtTribunal.Text = nroTribunal;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Insert();
                reiniciarValores();


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        public void Insert()
        {

            string estado = "revision";

            string fec_entrega_alumno = dttEntregaAlumno.Value.ToString("dd-MM-yyyy");

            string fec_entrega_tribunal = dttEntregaTribunal.Value.ToString("dd-MM-yyyy");

            string fec_limite_devolucion = dttLimiteSugerido.Value.ToString("dd-MM-yyyy");

            string fec_devolucion_tribunal = dttDevolucionTribunal.Value.ToString("dd-MM-yyyy");

            string fec_devolucion_alumno = dttDevolucionAlumno.Value.ToString("dd-MM-yyyy");

            string observacion = txtObservaciones.Text;

            int nro_tribunal = (rbTribunal1.Checked == true) ? 1 : ((rbTribunal2.Checked == true) ? 2 : 0);

            int nro_revision = nrorev;

            string fec_empaste = dttEmpaste.Value.ToString("dd-MM-yyyy");

            int id_tesis = idperfil;

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

        public void ClearForms()
        {
           
            

        }
    }
}
