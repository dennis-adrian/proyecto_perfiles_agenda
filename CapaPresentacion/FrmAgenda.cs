using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.defensaExterna.defensaGeneral;
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
        Main general = new Main();
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
            general.Carrera = this.carrera;
            ClearDatagrid();
            Defensa();
        
        }
        public void Defensa()
        {
            if(general.Carrera == null)
            {

                var lista = general.defensas();
                int count = 1;
                foreach (var item in lista)
                {
                    string[] row = new string[] {

                        item.Id,
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
                var lista = general.defensasCarrera();
                int count = 1;
                foreach (var item in lista)
                {
                    string[] row = new string[] {

                            item.Id,
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
            general.Tipo = tipo;
            if (general.Carrera == null)
            {

                var lista = general.defensasTipo();
                int count = 1;
                foreach (var item in lista)
                {
                    string[] row = new string[] {

                        item.Id,
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
                var lista = general.defensasCarreraTipo();
                int count = 1;
                foreach (var item in lista)
                {
                    string[] row = new string[] {

                            item.Id,
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

        public void DefensaEstudiante(string estudiante)
        {

            general.Estudiante = estudiante;
            if (general.Carrera == null)
            {

                var lista = general.defensasEstudiante();
                int count = 1;
                foreach (var item in lista)
                {
                    string[] row = new string[] {

                        item.Id,
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
                var lista = general.defensasCarreraEstudiante();
                int count = 1;
                foreach (var item in lista)
                {
                    string[] row = new string[] {

                            item.Id,
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
        public void DefensaTipoEstudiante(string tipo ,string estudiante)
        {
            general.Tipo = tipo;
            general.Estudiante = estudiante;
            if (general.Carrera == null)
            {

                var lista = general.defensasTipoEstudiante();
                int count = 1;
                foreach (var item in lista)
                {
                    string[] row = new string[] {

                        item.Id,
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
                var lista = general.defensasCarreraTipoEstudiante();
                int count = 1;
                foreach (var item in lista)
                {
                    string[] row = new string[] {

                            item.Id,
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

        
        
        private void btnEditarAgenda_Click(object sender, EventArgs e)
        {
            string tipo = dtgDefensaExterna.CurrentRow.Cells[5].Value.ToString();
            switch (tipo)
            {
                case "Tesis":
                    if (dtgDefensaExterna.CurrentRow != null)
                    {
                        int id_seleccionado = Convert.ToInt32(dtgDefensaExterna.CurrentRow.Cells[0].Value.ToString());
                        FrmTesisAgenda frm = new FrmTesisAgenda();
                        frm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("No ha seleccionado ninguna revisión");
                    }


                    break;
                case "Examen de Grado":
                    if (dtgDefensaExterna.CurrentRow != null)
                    {
                        int id_seleccionado = Convert.ToInt32(dtgDefensaExterna.CurrentRow.Cells[0].Value.ToString());
                        FrmEditarDefensaExterna frm = new FrmEditarDefensaExterna(id_seleccionado,"",tipo);
                        frm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("No ha seleccionado ninguna revisión");
                    }



                    break;
                case "Graduacion por Excelencia":
                    if (dtgDefensaExterna.CurrentRow != null)
                    {
                        int id_seleccionado = Convert.ToInt32(dtgDefensaExterna.CurrentRow.Cells[0].Value.ToString());
                        FrmEditarDefensaExterna frm = new FrmEditarDefensaExterna(id_seleccionado, "", tipo);
                        frm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("No ha seleccionado ninguna revisión");
                    }



                    break;
                default:
                    break;


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
            if(this.tipo == null)
            {

                ClearDatagrid();
                DefensaEstudiante(estudiante);

            }
            else
            {

                ClearDatagrid();
                DefensaTipoEstudiante(this.tipo,estudiante);

            }
        }

        #endregion
    }
}
