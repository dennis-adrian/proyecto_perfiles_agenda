using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmNuevoLicenciado : Form
    {
        CapaNegocio.NegocioLicenciados obj = new CapaNegocio.NegocioLicenciados();
        
        public FrmNuevoLicenciado()
        {
            InitializeComponent();
            cargar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlbarralicenciado_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarForm.ReleaseCapture();
            ArrastrarForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlNuevoLicenciado_Paint(object sender, PaintEventArgs e)
        {
               
        }

        private void btnGuardarNuevoP_Click(object sender, EventArgs e)
        {
            try
            {
                guardar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btnAgregarLicenciado_Click(object sender, EventArgs e)
        {
           
        }
        public void cargar()
        {
            cmbcarrera.Items.Clear();
            cmbinstitucion.Items.Clear();
            cmbcarrera.DataSource = obj.cargarCarrerasLicenciados();
            cmbcarrera.ValueMember = "id";
            cmbcarrera.DisplayMember = "nombre";

            cmbinstitucion.DataSource = obj.cargarInstitucio();
            cmbinstitucion.ValueMember = "id";
            cmbinstitucion.DisplayMember = "nombre";




           
        }
        public void guardar()
        {
            
                int doc = 2;
            if (rbdocentesi.Checked)
            {
                doc = 1;

            }
            else if (rbdocenteno.Checked)
            {
                doc = 2;

            }
            else
            {
                throw new ArgumentException("sin id");
            }


                string n = txtnombre.Text;
                string a = txtapellido.Text;
                string d = txtdescripcion.Text;
                string e = txtemail.Text;
                string t = txttelefono.Text;
                string c = txtcelular.Text;
                string ti = txtTipo.Text;
                //doc
                int ii = Convert.ToInt32(cmbinstitucion.SelectedValue.ToString());
                int ic = Convert.ToInt32(cmbcarrera.SelectedValue.ToString());



                Object[] datos = new Object[] { n, a, d, e, t, c, ti, doc, ii, ic };

                obj.ControlInput(datos);
            obj.MainInsert();
           

        }
        public void actualizar()
        {


            int doc = 0;
            if (rbdocentesi.Checked)
            {
                doc = 1;

            }
            else if (rbdocenteno.Checked)
            {
                doc = 2;

            }
            else
            {
                throw new ArgumentException("sin id");
            }

            string n = txtnombre.Text;
            string a = txtapellido.Text;
            string d = txtdescripcion.Text;
            string e = txtemail.Text;
            string t = txttelefono.Text;
            string c = txtcelular.Text;
            string ti = txtTipo.Text;
            //doc
            
          
            int ii = Convert.ToInt32(cmbinstitucion.SelectedValue.ToString());
            int ic = Convert.ToInt32(cmbcarrera.SelectedValue.ToString());



            Object[] datos = new Object[] { n, a, d, e, t, c, ti, doc, ii, ic };
            int x = Convert.ToInt32(lblTitulo.Text);
           
            obj.ControlInput(datos);
            obj.MainUpdate(x);
            MessageBox.Show(Convert.ToString(x));


        }



        private void button2_Click(object sender, EventArgs e)
        {
            info();

            
        }
        public void info()
        {
            int id = Convert.ToInt32(txtid.Text);
            var Collection = obj.InfoLicenciado(id);


            lblTitulo.Text = Convert.ToString(Collection[0]);
             txtnombre.Text = Convert.ToString(Collection[1]);
           txtapellido.Text = Convert.ToString(Collection[2]);
            txtdescripcion.Text = Convert.ToString(Collection[3]);
             txtemail.Text = Convert.ToString(Collection[4]) ;
            txttelefono.Text = Convert.ToString(Collection[5]);
            txtcelular.Text = Convert.ToString(Collection[6]); 
            txtTipo.Text = Convert.ToString(Collection[7]); 
            if (Convert.ToInt32(Collection[8]) == 1)
            {
                rbdocentesi.Checked = true;
            }
            else
            {
                rbdocenteno.Checked = true;
            }
            //doc
            cmbinstitucion.SelectedValue =  Convert.ToInt32(Collection[9]);
            cmbcarrera.SelectedValue = Convert.ToInt32(Collection[10]);

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            actualizar();

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(lblTitulo.Text);

           

        }
    }
}
