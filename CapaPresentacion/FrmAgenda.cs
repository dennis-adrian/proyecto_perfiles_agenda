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

                var bindingList = new BindingList<ViewDefensas>(list);
                var source = new BindingSource(bindingList, null);
                dtgDefensaExterna.DataSource = source;

            }
            else
            {
                var list2 = obj.DefensasCarrera(criterio);

                var bindingList = new BindingList<ViewDefensasCarrera>(list2);
                var source = new BindingSource(bindingList, null);
                dtgDefensaExterna.DataSource = source;
            }

           

        }

       
        private void btnEditarAgenda_Click(object sender, EventArgs e)
        {
            string tipo = dtgDefensaExterna.CurrentRow.Cells[4].Value.ToString();
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
                    var list = obj.Defensas();

                    var bindingList = new BindingList<ViewDefensas>(list);
                    var source = new BindingSource(bindingList, null);
                    dtgDefensaExterna.DataSource = source;

                }
                else
                {
                    var list2 = obj.DefensasCarrera(carrera);

                    var bindingList = new BindingList<ViewDefensasCarrera>(list2);
                    var source = new BindingSource(bindingList, null);
                    dtgDefensaExterna.DataSource = source;
                }

            }
            else
            {
                if (carrera == null)
                {
                    var list = obj.DefensasTipo(tipo);

                    var bindingList = new BindingList<ViewDefensas>(list);
                    var source = new BindingSource(bindingList, null);
                    dtgDefensaExterna.DataSource = source;

                }
                else
                {
                    var list2 = obj.DefensasCarreraTipo(carrera,tipo);

                    var bindingList = new BindingList<ViewDefensasCarrera>(list2);
                    var source = new BindingSource(bindingList, null);
                    dtgDefensaExterna.DataSource = source;
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
    }
}
