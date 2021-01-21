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
using CapaPresentacion.Resources;

namespace CapaPresentacion
{
    public partial class FrmRevisiones : Form, IContractLicenciado
    {
        int idperfil;
        Panel pnlContenedorGralBackup;

        //SOMBREADO DE BORDES FORMULARIOS
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

        #region Instancias
        CapaNegocio.perfilTesis.Index obj = new CapaNegocio.perfilTesis.Index();
       // NegocioPerfilGeneral obj = new NegocioPerfilGeneral();
        CapaNegocio.revisionPerfil.Index rev = new CapaNegocio.revisionPerfil.Index();
        #endregion

        #region Constructores
        public FrmRevisiones()
        {
            InitializeComponent();
        }
        public FrmRevisiones(int idperfil)
        {
            InitializeComponent();
            this.idperfil = idperfil;
            ShowPerfilGeneral(idperfil);
            //HiddenRevision();
            pnlSubMenus.Visible = false;
            DesactiveColors();
            loadTribunales();
        }
        #endregion

        public void HiddenRevision()
        {
            if(pnlContainerPrimera.Visible == true)
            {
                pnlContainerPrimera.Visible = false;

            }
            if (pnlContainerSegunda.Visible == true)
            {
                pnlContainerSegunda.Visible = false;

            }
            if (pnlContainerTercera.Visible == true)
            {
                pnlContainerTercera.Visible = false;

            }
            if (pnlContainerCuarta.Visible == true)
            {
                pnlContainerCuarta.Visible = false;

            }
            if (pnlAdd1.Visible == true)
            {
                pnlAdd1.Visible = false;

            }
            if (pnlAdd2.Visible == true)
            {
                pnlAdd2.Visible = false;

            }
            if (pnlAdd3.Visible == true)
            {
                pnlAdd3.Visible = false;

            }
            if (pnlAdd4.Visible == true)
            {
                pnlAdd4.Visible = false;

            }



        }
       

        public void DesactiveColors()
        {
            pnlGeneral.BackColor = Color.FromArgb(64, 64, 64);
            pnlRevisiones.BackColor = Color.FromArgb(64, 64, 64);
            pnlPrimeraRev.BackColor = Color.FromArgb(64, 64, 64);
            pnlSegundaRev.BackColor = Color.FromArgb(64, 64, 64);
            pnlTerceraRev.BackColor = Color.FromArgb(64, 64, 64);
            pnlCuartaRev.BackColor = Color.FromArgb(64, 64, 64);
        }

       
        private void FrmRevisiones2_Load(object sender, EventArgs e)
        {
            pnlContenedorGralBackup = pnlContenedorGral;
            btnGeneralRev_Click(null, e);
        }
       
       
        public void ShowPerfilGeneral(int id)
        {
            var item = obj.showPerfilGeneral(id);
           
            txtNumeroRevisiones.Text = item.Revisiones.ToString();
            txtTemaGral.Text = item.Tema.ToString();
            txtEstadoProyectoGral.Text = item.Estado_Proyecto.ToString();
            txtRegistroGral.Text = item.Registro.ToString();
            txtNombreGral.Text = item.Nombre.ToString();
            txtApellidoGral.Text = item.Apellido.ToString();
            txtEmailGral.Text = item.Email.ToString();
            txtTelefonoGral.Text = item.Telefono.ToString();
            txtCelularGral.Text = item.Celular.ToString();
            txtCarreraGral.Text = item.Carrera.ToString();
            txtTutorGral.Text = item.Licenciado.ToString();

            var fecha_aprobacion = item.Fecha_Aprobacion.ToString();
            var array_apr = fecha_aprobacion.Split('-');
            int d = Convert.ToInt32(array_apr[0]);
            int m = Convert.ToInt32(array_apr[1]);
            int y = Convert.ToInt32(array_apr[2]);
            dttFechaAprobacionGral.Value = new DateTime(y, m, d);

            var fecha_recepcion = item.Fecha_Aprobacion.ToString();
            var array_rec = fecha_aprobacion.Split('-');
            int dd = Convert.ToInt32(array_rec[0]);
            int mm = Convert.ToInt32(array_rec[1]);
            int yy = Convert.ToInt32(array_rec[2]);
            dttFechaAprobacionGral.Value = new DateTime(yy, mm, dd);
            
        }
       
       
        private void abrirFormEnPanel(object formhija)
        {
            if (this.pnlContenedorRev.Controls.Count > 0)
                this.pnlContenedorRev.Controls.Clear();
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedorRev.Controls.Add(fh);
            this.pnlContenedorRev.Tag = fh;
            fh.Show();
        }
        private void cerrarFormEnPanel()
        {
            if (this.pnlContenedorRev.Controls.Count > 0)
                this.pnlContenedorRev.Controls.Clear();
        }


        private void btnGeneralRev_Click(object sender, EventArgs e)
        {
            Panel pnlContenedorGral = pnlContenedorGralBackup;
            pnlGeneral.BackColor = Color.Crimson;

            //reiniciarResaltado();
            pnlGeneral.Visible = true;
            cerrarFormEnPanel();
            pnlContenedorRev.Controls.Add(pnlContenedorGral);
            pnlContenedorGral.Visible = true;
            ShowPerfilGeneral(this.idperfil);
        }



        private void btnPrimeraRev_Click(object sender, EventArgs e)
        {
            pnlContenedorGral.Visible = false;
            DesactiveColors();
            pnlPrimeraRev.Visible = true;
            pnlPrimeraRev.BackColor = Color.Crimson;
            abrirFormEnPanel(new FrmRevisionIndividual(this.idperfil,1));
        }

        private void btnSegundaRev_Click(object sender, EventArgs e)
        {
            pnlContenedorGral.Visible = false;
            DesactiveColors();
            pnlSegundaRev.Visible = true;
            pnlSegundaRev.BackColor = Color.Crimson;
            abrirFormEnPanel(new FrmRevisionIndividual(this.idperfil,2));
        }
        private void btnTerceraRev_Click(object sender, EventArgs e)
        {
            pnlContenedorGral.Visible = false;
            DesactiveColors();
            pnlTerceraRev.Visible = true;
            pnlTerceraRev.BackColor = Color.Crimson;
            abrirFormEnPanel(new FrmRevisionIndividual(this.idperfil,3));
        }
        private void btnCuartaRev_Click(object sender, EventArgs e)
        {
            pnlContenedorGral.Visible = false;
            DesactiveColors();
            pnlCuartaRev.Visible = true;
            pnlCuartaRev.BackColor = Color.Crimson;
            abrirFormEnPanel(new FrmRevisionIndividual(this.idperfil,4));
        }

          


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Arrastrar Forms
        private void pnlBarraNuevoLicenciado_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarForm.ReleaseCapture();
            ArrastrarForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRevisiones_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumeroRevisiones.Text);
            pnlSubMenus.Visible = true;
            ShowRevisiones(num);
        }
               
        public void ShowRevisiones(int num)
        {
            
            switch (num)
            {
                case 1:

                    pnlContainerRevisiones.Visible = false;
                    HiddenRevision();
                    pnlAdd2.Visible = true;
                    pnlContainerPrimera.Visible = true;
                    break;
                case 2:

                    pnlContainerRevisiones.Visible = false;
                    HiddenRevision();
                    pnlAdd3.Visible = true;
                    pnlContainerSegunda.Visible = true;
                    pnlContainerPrimera.Visible = true;
                    break;
                case 3:

                    pnlContainerRevisiones.Visible = false;
                    HiddenRevision();
                    pnlAdd4.Visible = true;
                    pnlContainerTercera.Visible = true;
                    pnlContainerSegunda.Visible = true;
                    pnlContainerPrimera.Visible = true;
                    break;
                case 4:

                    pnlContainerRevisiones.Visible = false;
                    HiddenRevision();
                    pnlContainerCuarta.Visible = true;
                    pnlContainerTercera.Visible = true;
                    pnlContainerSegunda.Visible = true;
                    pnlContainerPrimera.Visible = true;

                    break;
                case 0:
                    HiddenRevision();
                    pnlAdd1.Visible = true;
                    pnlContainerRevisiones.Visible = false;
                    break;
                default:
                    break;

            }
        }
        
        private void btnAddNewRev1_Click(object sender, EventArgs e)
        {

            ShowRevisiones(1);

        }

        private void btnAddNewRev2_Click(object sender, EventArgs e)
        {

            bool t1_fechas = rev.ValidarFechasTribunal(this.idperfil, 1);
            bool t1_empaste = rev.ValidarFechaEmpasteTribunal(this.idperfil, 1);

            bool t2_fechas = rev.ValidarFechasTribunal(this.idperfil, 2);
            bool t2_empaste = rev.ValidarFechaEmpasteTribunal(this.idperfil, 2);


            if( (t1_fechas == true && !t1_empaste == true) && (t2_fechas == true && !t2_empaste == true))
            {
               bool res = rev.ValidateNextRevision(this.idperfil, 1, 2);
                if(res == true)
                {
                    ShowRevisiones(2);

                }
                else
                {
                    MessageBox.Show("falta datos en revisiones ");
                }
                
            }
            else
            {
                if (t1_fechas == true)
                {
                    if (!t1_empaste == true)
                    {
                        if(t2_fechas == true)
                        {
                            MessageBox.Show("No se puede agregar otra revision ya existe fecha de empaste en tribunal 2");

                        }
                        else
                        {
                            MessageBox.Show("Hay Fechas Pendientes en la revision del tribunal 2 ");

                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede agregar otra revision ya existe fecha de empaste en tribunal 1");

                    }
                   
                }
                else
                {
                    MessageBox.Show("Hay Fechas Pendientes en la revision del tribunal 1 ");
                }
                  
            }


        }

        private void btnAddNewRev3_Click_1(object sender, EventArgs e)
        {

            bool t1_fechas = rev.ValidarFechasTribunal(this.idperfil, 1);
            bool t1_empaste = rev.ValidarFechaEmpasteTribunal(this.idperfil, 1);

            bool t2_fechas = rev.ValidarFechasTribunal(this.idperfil, 2);
            bool t2_empaste = rev.ValidarFechaEmpasteTribunal(this.idperfil, 2);


            if ((t1_fechas == true && !t1_empaste == true) && (t2_fechas == true && !t2_empaste == true))
            {
                bool res = rev.ValidateNextRevision(this.idperfil, 1, 2);
                if (res == true)
                {
                    ShowRevisiones(3);

                }
                else
                {
                    MessageBox.Show("falta datos en revisiones ");
                }
            }
            else
            {
                if (t1_fechas == true)
                {
                    if (!t1_empaste == true)
                    {
                        if (t2_fechas == true)
                        {
                            MessageBox.Show("No se puede agregar otra revision ya existe fecha de empaste en tribunal 2");

                        }
                        else
                        {
                            MessageBox.Show("Hay Fechas Pendientes en la revision del tribunal 2 ");

                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede agregar otra revision ya existe fecha de empaste en tribunal 1");

                    }

                }
                else
                {
                    MessageBox.Show("Hay Fechas Pendientes en la revision del tribunal 1 ");
                }

            }

        }
        private void btnAddNewRev4_Click(object sender, EventArgs e)
        {

            bool t1_fechas = rev.ValidarFechasTribunal(this.idperfil, 1);
            bool t1_empaste = rev.ValidarFechaEmpasteTribunal(this.idperfil, 1);

            bool t2_fechas = rev.ValidarFechasTribunal(this.idperfil, 2);
            bool t2_empaste = rev.ValidarFechaEmpasteTribunal(this.idperfil, 2);


            if ((t1_fechas == true && !t1_empaste == true) && (t2_fechas == true && !t2_empaste == true))
            {
                bool res = rev.ValidateNextRevision(this.idperfil, 1, 2);
                if (res == true)
                {
                    ShowRevisiones(4);

                }
                else
                {
                    MessageBox.Show("falta datos en revisiones ");
                }
            }
            else
            {
                if (t1_fechas == true)
                {
                    if (!t1_empaste == true)
                    {
                        if (t2_fechas == true)
                        {
                            MessageBox.Show("No se puede agregar otra revision ya existe fecha de empaste en tribunal 2");

                        }
                        else
                        {
                            MessageBox.Show("Hay Fechas Pendientes en la revision del tribunal 2 ");

                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede agregar otra revision ya existe fecha de empaste en tribunal 1");

                    }

                }
                else
                {
                    MessageBox.Show("Hay Fechas Pendientes en la revision del tribunal 1 ");
                }

            }
        }

        private void btnCancelarNuevop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnElegirTribunal1_Click(object sender, EventArgs e)
        {
            
            nro_tribunal = 1;
            FrmTutor frm = this.FormInstance3;
            frm.contrato = this;
            frm.Show();
            frm.lblLicen.Text = "Licenciado : "; 
            frm.BringToFront();
        }

        private void btnElegirTribunal2_Click(object sender, EventArgs e)
        {
            nro_tribunal = 2;
            FrmTutor frm = this.FormInstance3;
            frm.contrato = this;
            frm.Show();
            frm.lblLicen.Text = "Licenciado : ";
            frm.BringToFront();
        }

        #region Tribunales
        private int nro_tribunal = 0;
        private FrmTutor tribunal = null;
        private FrmTutor FormInstance3
        {
            get
            {
                if (tribunal == null)
                {
                    tribunal = new FrmTutor();
                    tribunal.Disposed += new EventHandler(form_Disposed3);
                }

                return tribunal;
            }
        }

        void form_Disposed3(object sender, EventArgs e)
        {
            tribunal = null;

        }

        public void Ejecutar(int id, string nombre)
        {
            try
            {
                ComboBoxItem item = new ComboBoxItem();
                switch (nro_tribunal)
                {
                    case 1:
                        cmbTribunal1.Items.Clear();
                        item.Text = nombre;
                        item.Value = id;
                        cmbTribunal1.Items.Add(item);
                        cmbTribunal1.SelectedIndex = 0;

                        break;
                    case 2:
                        cmbTribunal2.Items.Clear();
                        item.Text = nombre;
                        item.Value = id;
                        cmbTribunal2.Items.Add(item);
                        cmbTribunal2.SelectedIndex = 0;
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


        #endregion


        #region validacion_tribunales

        void loadTribunales()
        {
            var cursor = rev.listTribunalByIdPerfil(idperfil);
            if (cursor.Count <= 0)
            {
                //do nothing...
                txtDatosTribunales.Text = "Sin Datos Asignados";
            }
            else
            {

                txtDatosTribunales.Text = "Datos Asignados";

                foreach (var obj in cursor)
                {
                    ComboBoxItem item = new ComboBoxItem();
                    if (obj.Nro_tribunal == 1)
                    {
                        cmbTribunal1.Items.Clear();
                        item.Text = obj.Licenciado;
                        item.Value = obj.Id_licenciado;
                        cmbTribunal1.Items.Add(item);
                        cmbTribunal1.SelectedIndex = 0;
                    }
                    else if (obj.Nro_tribunal == 2)
                    {
                        cmbTribunal2.Items.Clear();
                        item.Text = obj.Licenciado;
                        item.Value = obj.Id_licenciado;
                        cmbTribunal2.Items.Add(item);
                        cmbTribunal2.SelectedIndex = 0;
                    }
                }
            }
        }
        void validatingTribunales()
        {
            //validar combos vacios 
            bool tri1 = String.IsNullOrEmpty(cmbTribunal1.Text.ToString());
            bool tri2 = String.IsNullOrEmpty(cmbTribunal2.Text.ToString());

            if (tri1 == true || tri2 == true)
            {
                MessageBox.Show("esta sin asignar uno de los tribunales");
            }
            else
            {
                int tribunal1 = Convert.ToInt32((cmbTribunal1.SelectedItem as ComboBoxItem).Value.ToString());
                int tribunal2 = Convert.ToInt32((cmbTribunal2.SelectedItem as ComboBoxItem).Value.ToString());
                if (tribunal1 == tribunal2)
                {
                    MessageBox.Show("tribunales repetidos");
                }
                else
                {

                    MessageBox.Show(tribunal1 + "");
                    MessageBox.Show(tribunal2 + "");
                    tribunales(idperfil, tribunal1, 1);
                    tribunales(idperfil, tribunal2, 2);

                    MessageBox.Show("datos guardados");

                }
            }
        }       

        void tribunales(int idperfil, int idlicenciado, int nrotribunal)
        {
            string datos = txtDatosTribunales.Text;
            if (datos == "Datos Asignados")
            {
                rev.updateTribunalRevision(idlicenciado,idperfil,nrotribunal);
            }else if(datos == "Sin Datos Asignados")
            {
                rev.createTribunalRevision(idperfil, idlicenciado, nrotribunal);
            }
        
        }


        #endregion

        //test validating
        private void button1_Click(object sender, EventArgs e)
        {
            validatingTribunales();
        }

        private void btnGuardarNuevoP_Click(object sender, EventArgs e)
        {

        }
    }
}
