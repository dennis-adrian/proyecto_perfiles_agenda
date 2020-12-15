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
using CapaDatos.View;
using CapaPresentacion.ContractForms;

namespace CapaPresentacion
{
    public partial class FrmPerfiles : Form
    {
        CapaNegocio.perfilTesis.Index obj = new CapaNegocio.perfilTesis.Index();
       //NegocioPerfiles obj = new NegocioPerfiles();
        string carrera = null;
        public FrmPerfiles(string criterio)
        {
            InitializeComponent();
            Inicializador(criterio);
            carrera = criterio;
        }

        #region propiedades



        #endregion


        void generalPerfil()
        {
            int campo1 = 1;
            var list = obj.Perfiles();
            foreach (var item in list)
            {

                string campo0 = Convert.ToString(item.Id);
                string campo2 = item.Estado_Proyecto;
                string campo3 = item.Registro;
                string campo4 = item.Nombre + " " + item.Apellido;
                string campo5 = item.Carrera;
                string campo6 = item.Facultad;
                string campo7 = item.Tema;
                string campo8 = item.Licenciado;
                string campo9 = item.Email;
                string campo10 = item.Telefono;
                string campo11 = item.Fecha_Recepcion;

                string[] row = new string[] { campo0, Convert.ToString(campo1), campo2, campo3, campo4, campo5, campo6, campo7, campo8, campo9, campo10, campo11 };
                this.dtgPerfilesTesis.Rows.Add(row);
                campo1++;

            }
            txtCarreraSeleccionada.Text = "Todas las Carreras";
        }

        void generalPerfilEstudiante(string nombre)
        {
            dtgPerfilesTesis.Rows.Clear();
            int campo1 = 1;
            var list = obj.PerfilesEstudiante(nombre);
            foreach (var item in list)
            {

                string campo0 = Convert.ToString(item.Id);
                string campo2 = item.Estado_Proyecto;
                string campo3 = item.Registro;
                string campo4 = item.Nombre + " " + item.Apellido;
                string campo5 = item.Carrera;
                string campo6 = item.Facultad;
                string campo7 = item.Tema;
                string campo8 = item.Licenciado;
                string campo9 = item.Email;
                string campo10 = item.Telefono;
                string campo11 = item.Fecha_Recepcion;

                string[] row = new string[] { campo0, Convert.ToString(campo1), campo2, campo3, campo4, campo5, campo6, campo7, campo8, campo9, campo10, campo11 };
                this.dtgPerfilesTesis.Rows.Add(row);
                campo1++;

            }
            txtCarreraSeleccionada.Text = "Todas las Carreras";
        }
        void carreraPerfil(string criterio)
        {
            string carreraSeleccionada = "";
            dtgPerfilesTesis.Rows.Clear();
            var list2 = obj.PerfilesCarrera(criterio);
            int campo1 = 1;
            foreach (var item in list2)
            {
                carreraSeleccionada = item.Carrera;
                string campo0 = Convert.ToString(item.Id);
                string campo2 = item.Estado_Proyecto;
                string campo3 = item.Registro;
                string campo4 = item.Nombre + " " + item.Apellido;
                string campo5 = "";
                string campo6 = "";
                string campo7 = item.Tema;
                string campo8 = item.Licenciado;
                string campo9 = item.Email;
                string campo10 = item.Telefono;
                string campo11 = item.Fecha_Recepcion;

                string[] row = new string[] { campo0, Convert.ToString(campo1), campo2, campo3, campo4, campo5, campo6, campo7, campo8, campo9, campo10, campo11 };
                this.dtgPerfilesTesis.Rows.Add(row);
                this.ColumnaFacultad.Visible = false;
                this.ColumnaCarrera.Visible = false;
                campo1++;

            }
            txtCarreraSeleccionada.Text =carreraSeleccionada;
        }

        void carreraPerfilEstudiante(string carrera,string estudiante)
        {
            string carreraSeleccionada = "";
            dtgPerfilesTesis.Rows.Clear();
            var list2 = obj.PerfilesCarreraEstudiante(carrera, estudiante);
            int campo1 = 1;
            foreach (var item in list2)
            {
                carreraSeleccionada = item.Carrera;
                string campo0 = Convert.ToString(item.Id);
                string campo2 = item.Estado_Proyecto;
                string campo3 = item.Registro;
                string campo4 = item.Nombre + " " + item.Apellido;
                string campo5 = "";
                string campo6 = "";
                string campo7 = item.Tema;
                string campo8 = item.Licenciado;
                string campo9 = item.Email;
                string campo10 = item.Telefono;
                string campo11 = item.Fecha_Recepcion;

                string[] row = new string[] { campo0, Convert.ToString(campo1), campo2, campo3, campo4, campo5, campo6, campo7, campo8, campo9, campo10, campo11 };
                this.dtgPerfilesTesis.Rows.Add(row);
                this.ColumnaFacultad.Visible = false;
                this.ColumnaCarrera.Visible = false;
                campo1++;

            }
            txtCarreraSeleccionada.Text = carreraSeleccionada;
        }
        public void Inicializador(string criterio)
        {
            if (criterio == null)
            {
                generalPerfil();
            }
            else
            {
                carreraPerfil(criterio);
               
            }
        }

        private void btnBuscarPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarPerfil.Text;
            string carr = txtCarreraSeleccionada.Text;
            bool passnombre = String.IsNullOrEmpty(nombre);
            if (passnombre)
            {
                if (carr != "Todas las Carreras")
                {
                    dtgPerfilesTesis.Rows.Clear();
                    carreraPerfil(carr);
                }
                else
                {

                    dtgPerfilesTesis.Rows.Clear();
                    generalPerfil();
                }

            }
            else
            {
                if (carr != "Todas las Carreras")
                {

                    dtgPerfilesTesis.Rows.Clear();
                    carreraPerfilEstudiante(carrera, nombre);
                }
                else
                {
                    dtgPerfilesTesis.Rows.Clear();
                    generalPerfilEstudiante(nombre);

                   
                }

            }
           
            //if (carrera == null)
            //{

            //    generalPerfilEstudiante(nombre);

            //}
            //else
            //{
            //    carreraPerfilEstudiante(carrera, nombre);
            //}

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtgPerfilesTesis.CurrentRow != null)
            {
                int id_seleccionado = Convert.ToInt32(dtgPerfilesTesis.CurrentRow.Cells[0].Value.ToString());
                FrmRevisiones frm = new FrmRevisiones(id_seleccionado);
                frm.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna revisión");
            }
        }

        private void txtBuscarPerfil_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dtgPerfilesTesis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgPerfilesTesis.CurrentRow != null)
            {
                int id_seleccionado = Convert.ToInt32(dtgPerfilesTesis.CurrentRow.Cells[0].Value.ToString());
                FrmRevisiones frm = new FrmRevisiones(id_seleccionado);
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna revisión");
            }
        }
    }
}
