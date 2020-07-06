using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaPresentacion.ContractForms;

namespace CapaPresentacion.Revisiones
{
    public partial class FrmGeneral : Form
    {
        public FrmGeneral(int id)
        {
            InitializeComponent();
            ShowPerfilGeneral(id);
        }

        #region Instancias
        NegocioPerfilGeneral obj = new NegocioPerfilGeneral();



        #endregion
        #region Metodos

      

        #endregion

        public void ShowPerfilGeneral(int id)
        {
            var Collection = obj.PerfilGeneral(id);
            foreach (var item in Collection)
            {
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
                txtTutorGral.Text = item.Tutor.ToString();


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
        }
    }
}
