using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.defensaExterna;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    /// <summary>
    /// funcionalidad:
    /// 1:ver todas las defensas(general)
    /// 2:filtro de tipo (general) 
    /// 3:filtro de estudiante(general) 
    /// 4:filro de tipo y estudiante(general)
    /// 
    /// 5:ver defensas por carrera(carrera)
    /// 6:filtro de tipo (carrera)
    /// 7:filro de estudiante (carrera)
    /// 8:filtro de tipo y estudiante (carrera)
    /// </summary>
    public partial class FrmAgenda : Form
    {
        #region Instancias y atributos
        CapaNegocio.defensaExterna.Index General = new CapaNegocio.defensaExterna.Index();


        //Main general = new Main();
        string carrera = null;
        string tipo = null;
        #endregion


        #region Constructor
        public FrmAgenda(string criterio)
        {
            InitializeComponent();
            this.carrera = criterio;
            InitializeDefensas();
        }
        #endregion


        #region Logica


        public void InitializeDefensas()
        {
            ClearDatagrid();
            Defensa();

        }
        Dictionary<int, string> keyDefensas = new Dictionary<int, string>()
        {
            {1,"DEFENSAS" },
            {2,"CARRERA" },
            {3,"CARRERA_TIPO" },
            {4,"CARRERA_ESTUDIANTE" },
            {5,"CARRERA_TIPO_ESTUDIANTE" },
            {6,"TIPO" },
            {7,"ESTUDIANTE" },
            {8,"TIPO_ESTUDIANTE" },
        };
        public void Defensa()
        {
            CapaDatos.View.DaoDefensas dao = new CapaDatos.View.DaoDefensas();
            dao.Carrera = this.carrera;
            dao.Key = dao.Carrera == null ? keyDefensas[1] : keyDefensas[2];
            var data = General.getDefensas(dao);
            fillDefensas(data, dao.Carrera);


        }
        void fillDefensas(
            List<CapaNegocio.defensaExterna.Index.DefensaStruct> data,
            string carrera = null)
        {

            int count = 1;
            if (carrera == null)
            {
                foreach (var item in data)
                {
                    string[] row = new string[] {

                        Convert.ToString(item.Id),
                        count.ToString(),
                        item.Fecha_Defensa,
                        item.Hora,
                        item.Aula,
                        item.Tipo,
                        item.Tema,
                        item.Registro,
                        item.Estudiante,
                        item.Carrera,
                        item.Facultad

                        };
                    dtgDefensaExterna.Rows.Add(row);
                    count++;

                }
            }
            else
            {
                dtgDefensaExterna.Columns["ColumnaCarrera"].Visible = false;
                dtgDefensaExterna.Columns["ColumnaFacultad"].Visible = false;
                foreach (var item in data)
                {
                    string[] row = new string[] {


                            Convert.ToString(item.Id),
                            count.ToString(),
                            item.Fecha_Defensa,
                            item.Hora,
                            item.Aula,
                            item.Tipo,
                            item.Tema,
                            item.Registro,
                            item.Estudiante


                        };
                    dtgDefensaExterna.Rows.Add(row);
                    count++;
                }
            }

        }
        public void DefensaTipo(string tipo)
        {
            CapaDatos.View.DaoDefensas dao = new CapaDatos.View.DaoDefensas();
            dao.Carrera = this.carrera;
            dao.Tipo = tipo;
            dao.Key = dao.Carrera == null ? keyDefensas[6] : keyDefensas[3];
            var data = General.getDefensas(dao);
            fillDefensas(data, dao.Carrera);
        }

        public void DefensaEstudiante(string estudiante)
        {
            CapaDatos.View.DaoDefensas dao = new CapaDatos.View.DaoDefensas();
            dao.Carrera = this.carrera;
            dao.Estudiante = estudiante;
            dao.Key = dao.Carrera == null ? keyDefensas[7] : keyDefensas[4];
            var data = General.getDefensas(dao);
            fillDefensas(data, dao.Carrera);


        }
        public void DefensaTipoEstudiante(string tipo, string estudiante)
        {
            CapaDatos.View.DaoDefensas dao = new CapaDatos.View.DaoDefensas();
            dao.Carrera = this.carrera;
            dao.Estudiante = estudiante;
            dao.Tipo = tipo;
            dao.Key = dao.Carrera == null ? keyDefensas[8] : keyDefensas[5];
            var data = General.getDefensas(dao);
            fillDefensas(data, dao.Carrera);

            

        }

        public void typeButtonAction(IconButton btn)
        {
            string type = btn.Text == "Todas las Defensas" ? null : btn.Text;
            this.tipo = type;
            ClearDatagrid();
            DefensaTipo(type);
            ocultarPaneles();

        }

        public void ClearDatagrid()
        {
            dtgDefensaExterna.Rows.Clear();
        }


        #endregion


        #region Diseño
        private void ocultarPaneles()
        {
            if (pnlFiltroDefensa.Visible == true)
                pnlFiltroDefensa.Visible = false;
        }

        private void mostrarPaneles(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarPaneles();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        public void actionEdit(Form form, DataGridView dtg)
        {


            if (dtg.CurrentRow != null)
            {
                form.ShowDialog();

            }
            else
            {
                ;
            }
        }

        private void btnEditarAgenda_Click(object sender, EventArgs e)
        {

            string tipo = dtgDefensaExterna.CurrentRow?.Cells[5].Value.ToString();
            if (tipo != null)
            {

                int id_seleccionado = Convert.ToInt32(dtgDefensaExterna.CurrentRow.Cells[0].Value.ToString());
                switch (tipo)
                {
                    case "Tesis":
                        FrmTesisAgenda formTesis = new FrmTesisAgenda(id_seleccionado, "", "Tesis");
                        formTesis.ShowDialog();
                        InitializeDefensas();
                        break;
                    case "Examen de Grado":
                        FrmEditarDefensaExterna formExamen = new FrmEditarDefensaExterna(id_seleccionado, "", tipo);
                        formExamen.ShowDialog();
                        InitializeDefensas();
                        break;
                    case "Graduacion por Excelencia":
                        FrmEditarDefensaExterna formGraduacion = new FrmEditarDefensaExterna(id_seleccionado, "", tipo);
                        formGraduacion.ShowDialog();
                        InitializeDefensas();
                        break;
                    default:
                        break;
                }
            }
            else
            {

                MessageBox.Show("No ha seleccionado ninguna revisión");
            }


        }

        private void dtgDefensaExterna_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnExamenGrado_Click(object sender, EventArgs e)
        {

            typeButtonAction(btnExamenGrado);
        }

        private void btnTesis_Click(object sender, EventArgs e)
        {
            typeButtonAction(btnTesis);
        }

        private void btnPorExecencia_Click(object sender, EventArgs e)
        {
            typeButtonAction(btnPorExecencia);
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            mostrarPaneles(pnlFiltroDefensa);
        }

        private void btntTodasDefensas_Click(object sender, EventArgs e)
        {
            typeButtonAction(btntTodasDefensas);
        }

        private void btnBuscarPerfil_Click(object sender, EventArgs e)
        {
            string estudiante = txtBuscarDefensa.Text;
            if (this.tipo == null)
            {

                ClearDatagrid();
                DefensaEstudiante(estudiante);

            }
            else
            {

                ClearDatagrid();
                DefensaTipoEstudiante(this.tipo, estudiante);

            }
        }

        #endregion
    }
}
