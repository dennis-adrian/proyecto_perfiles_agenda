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

        CapaNegocio.defensaExterna.defensaGeneral.Main general = new CapaNegocio.defensaExterna.defensaGeneral.Main();
        public FrmAgenda(string carrera)
        {
            general.Carrera = carrera;
            InitializeComponent();
            InitializeDefensas();
        }
        /// <summary>
        /// LOGICA DEL FORMULARIO
        /// </summary>
        public void InitializeDefensas()
        {
            //if(general.Carrera != "" || general.Carrera != null)
            //{

            //    ClearDatagrid();

            //    defensaGeneralCarrera();
            //}
            //else
            //{
            
                ClearDatagrid();
                DefensaGeneral();
            

            //}
        }
        /// <summary>
        /// PRIMER METODO
        /// </summary>
        public void DefensaGeneral()
        {
            var lista =  general.defensas();
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
        
        public void DefensaGeneralTipo(string tipo)
        {
            general.Tipo = tipo;

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

        public void DefensaGeneralEstudiante(string estudiante)
        {
            general.Estudiante = estudiante;

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
        public void ClearDatagrid()
        {
            dtgDefensaExterna.Rows.Clear();
        }


        public void defensaGeneralCarrera()
        {
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



        /// <summary>
        /// DISEÑO Y EFECTOS
        /// </summary>
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
            string tipo = btnExamenGrado.Text;
            ClearDatagrid();
            DefensaGeneralTipo(tipo);
            ocultarPaneles();
        }

        private void btnTesis_Click(object sender, EventArgs e)
        {

            string tipo = btnTesis.Text;
            ClearDatagrid();
            DefensaGeneralTipo(tipo);
            ocultarPaneles();
        }

        private void btnPorExecencia_Click(object sender, EventArgs e)
        {

            string tipo = btnPorExecencia.Text;
            ClearDatagrid();
            DefensaGeneralTipo(tipo);
            ocultarPaneles();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            mostrarPaneles(pnlFiltroDefensa);
        }

        private void btntTodasDefensas_Click(object sender, EventArgs e)
        {
            ClearDatagrid();
            DefensaGeneral();
            ocultarPaneles();
        }

        private void btnBuscarPerfil_Click(object sender, EventArgs e)
        {
            string estudiante = txtBuscarDefensa.Text;
            ClearDatagrid();
            DefensaGeneralEstudiante(estudiante);

        }

    }
    //public class App
    //{
    //    string carrera = null;
    //    string tipo = null;
    //    string estudiante = null;
    //    public App()
    //    {

    //    }


    //    DefensaFactory factory = new ConcreteDefensaFactory();

    //    public string Tipo { get => tipo; set => tipo = value; }
    //    public string Estudiante { get => estudiante; set => estudiante = value; }
    //    public string Carrera { get => carrera; set => carrera = value; }

    //    public void fillcarrera()
    //    {

    //    }
    //    public void fillDefensa(DataGridView dtg,
    //        List<dynamic> lista)
    //    {

    //        int count = 1;
    //        foreach (var item in lista)
    //        {
    //            string[] row = new string[] {

    //                item.Id,
    //                count.ToString(),
    //                item.Fecha_Defensa,
    //                item.Hora,
    //                item.Aula,
    //                item.Tipo,
    //                item.Tema,
    //                item.Registro,
    //                item.Estudiante,
    //                item.Carrera,
    //                item.Facultad

    //            };
    //            dtg.Rows.Add(row);
    //            count++;
    //        }

    //    }
    //    public void main(int type, DataGridView dtg)
    //    {
    //        try
    //        {
    //            List<dynamic> lista = new List<dynamic>();
    //            switch (type)
    //            {

    //                case 1:
    //                    IDefensa general = factory.GetDefensas("general");
    //                    lista = general.defensas();
    //                    fillDefensa(dtg, lista);
    //                    break;
    //                case 2:

    //                    IDefensa general_tipo = factory.GetDefensas("general_tipo");
    //                    lista = general_tipo.defensas(Tipo);
    //                    fillDefensa(dtg, lista);
    //                    break;
    //                case 3:
    //                    IDefensa general_estudiante = factory.GetDefensas("general_estudiante");
    //                    lista = general_estudiante.defensas(null, Tipo);
    //                    fillDefensa(dtg, lista);
    //                    break;
    //                case 4:
    //                    IDefensa general_tipo_estudiante = factory.GetDefensas("general_tipo_estudiante");
    //                    lista = general_tipo_estudiante.defensas(Tipo, Estudiante);
    //                    fillDefensa(dtg, lista);
    //                    break;

    //                default:
    //                    throw new ApplicationException(string.Format("error de operacion"));


    //            }
    //        }
    //        catch(Exception e)
    //        {
    //            MessageBox.Show(e.Message+"XD");
    //        }
            
    //    }


    //}
}
