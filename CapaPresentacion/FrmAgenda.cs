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
using FontAwesome.Sharp;

namespace CapaPresentacion
{

    public partial class FrmAgenda : Form
    {
        NegocioDefensaExterna obj = new NegocioDefensaExterna();

        string carrera = null;
       
        public FrmAgenda(string criterio)
        {
            InitializeComponent();
            Inicializador(criterio);
            //personalizarDiseño();
            carrera = criterio;
        }

        
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

       
        public void Inicializador(string criterio)
        {
            if(criterio == null)
            {
                var list = obj.Defensas();
                int campo1 = 1;
                foreach (var item in list)
                {
                    
                    string campo0 = Convert.ToString(item.Id);
                    string campo2 = item.Registro;
                    string campo3 = item.Fecha_Defensa;
                    string campo4 = item.Hora;
                    string campo5 = item.Aula;
                    string campo6 = item.Tipo;
                    string campo7 = item.Tema;
                    string campo8 = item.Estudiante;
                    string campo9 = item.Carrera;
                    string campo10 = item.Facultad;

                    string[] row = new string[] {campo0, Convert.ToString(campo1),campo3,campo4,campo5,campo6,campo7, campo2, campo8,campo9, campo10 };
                    this.dtgDefensaExterna.Rows.Add(row);
                    campo1++;
                  
                }
               
               /* var bindingList = new BindingList<ViewDefensas>(list);
                var source = new BindingSource(bindingList, null);
                dtgDefensaExterna.DataSource = source;*/



            }
            else
            {
                var list2 = obj.DefensasCarrera(criterio);
                int campo1 = 1;
                foreach (var item in list2)
                {

                    string campo0 = Convert.ToString(item.Id);
                    string campo2 = item.Registro;
                    string campo3 = item.Fecha_Defensa;
                    string campo4 = item.Hora;
                    string campo5 = item.Aula;
                    string campo6 = item.Tipo;
                    string campo7 = item.Tema;
                    string campo8 = item.Estudiante;


                    string[] row = new string[] {campo0, Convert.ToString(campo1), campo3, campo4, campo5, campo6, campo7, campo2, campo8 };
                    this.dtgDefensaExterna.Rows.Add(row);
                    this.ColumnaCarrera.Visible = false;
                    this.ColumnaFacultad.Visible = false;
                    campo1++;

                }
                /*

                var bindingList = new BindingList<ViewDefensasCarrera>(list2);
                var source = new BindingSource(bindingList, null);
                dtgDefensaExterna.DataSource = source;*/
            }

           

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

       
   
        public void DefensasTipo(IconButton btn)
        {
            string tipo = btn.Text;
            if(tipo == "Todas las Defensas")
            {

                if (carrera == null)
                {
                    this.dtgDefensaExterna.Rows.Clear();

                    var list = obj.Defensas();
                    //for(int x = 0; x < list.Count ; x++  )
                    int campo1 = 1;
                    foreach (var item in list)
                    {

                        string campo0 = Convert.ToString(item.Id);
                        string campo2 = item.Registro;
                        string campo3 = item.Fecha_Defensa;
                        string campo4 = item.Hora;
                        string campo5 = item.Aula;
                        string campo6 = item.Tipo;
                        string campo7 = item.Tema;
                        string campo8 = item.Estudiante;
                        string campo9 = item.Carrera;
                        string campo10 = item.Facultad;

                        string[] row = new string[] { campo0, Convert.ToString(campo1),  campo3, campo4, campo5, campo6, campo7, campo2, campo8, campo9, campo10 };
                        this.dtgDefensaExterna.Rows.Add(row);
                        campo1++;

                    }

                }
                else
                {
                    this.dtgDefensaExterna.Rows.Clear();
                    var list2 = obj.DefensasCarrera(carrera);
                    int campo1 = 1;
                    foreach (var item in list2)
                    {

                        string campo0 = Convert.ToString(item.Id);
                        string campo2 = item.Registro;
                        string campo3 = item.Fecha_Defensa;
                        string campo4 = item.Hora;
                        string campo5 = item.Aula;
                        string campo6 = item.Tipo;
                        string campo7 = item.Tema;
                        string campo8 = item.Estudiante;


                        string[] row = new string[] { campo0, Convert.ToString(campo1),  campo3, campo4, campo5, campo6, campo7, campo2, campo8 };
                        this.dtgDefensaExterna.Rows.Add(row);
                        this.ColumnaCarrera.Visible = false;
                        this.ColumnaFacultad.Visible = false;
                        campo1++;

                    }
                }

            }
            else
            {
                if (carrera == null)
                {
                    this.dtgDefensaExterna.Rows.Clear();
                    var list = obj.DefensasTipo(tipo);
                    int campo1 = 1;
                    foreach (var item in list)
                    {

                        string campo0 = Convert.ToString(item.Id);
                        string campo2 = item.Registro;
                        string campo3 = item.Fecha_Defensa;
                        string campo4 = item.Hora;
                        string campo5 = item.Aula;
                        string campo6 = item.Tipo;
                        string campo7 = item.Tema;
                        string campo8 = item.Estudiante;
                        string campo9 = item.Carrera;
                        string campo10 = item.Facultad;

                        string[] row = new string[] { campo0, Convert.ToString(campo1),  campo3, campo4, campo5, campo6, campo7, campo2, campo8, campo9, campo10 };
                        this.dtgDefensaExterna.Rows.Add(row);
                        campo1++;

                    }

                }
                else
                {
                    this.dtgDefensaExterna.Rows.Clear();
                    var list2 = obj.DefensasCarreraTipo(carrera,tipo);
                    int campo1 = 1;
                    foreach (var item in list2)
                    {

                        string campo0 = Convert.ToString(item.Id);
                        string campo2 = item.Registro;
                        string campo3 = item.Fecha_Defensa;
                        string campo4 = item.Hora;
                        string campo5 = item.Aula;
                        string campo6 = item.Tipo;
                        string campo7 = item.Tema;
                        string campo8 = item.Estudiante;


                        string[] row = new string[] { campo0, Convert.ToString(campo1),  campo3, campo4, campo5, campo6, campo7, campo2, campo8 };
                        this.dtgDefensaExterna.Rows.Add(row);
                        this.ColumnaCarrera.Visible = false;
                        this.ColumnaFacultad.Visible = false;
                        campo1++;

                    }
                }
            }
           

        }
       

        private void btnExamenGrado_Click(object sender, EventArgs e)
        {
           
            DefensasTipo(btnExamenGrado);
            ocultarPaneles();
        }

        private void btnTesis_Click(object sender, EventArgs e)
        {
            DefensasTipo(btnTesis);
            ocultarPaneles();
        }

        private void btnPorExecencia_Click(object sender, EventArgs e)
        {
            DefensasTipo(btnPorExecencia);
            ocultarPaneles();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            mostrarPaneles(pnlFiltroDefensa);
        }

        private void btntTodasDefensas_Click(object sender, EventArgs e)
        {
            DefensasTipo(btntTodasDefensas);
            ocultarPaneles();
        }

        private void btnBuscarPerfil_Click(object sender, EventArgs e)
        {

        }
    }
}
