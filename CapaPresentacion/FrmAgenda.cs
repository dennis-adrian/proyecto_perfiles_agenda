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


namespace CapaPresentacion
{//comentario

    public partial class FrmAgenda : Form
    {
        NegocioDefensaExterna obj = new NegocioDefensaExterna();

        string carrera = null;
        public FrmAgenda(string criterio)
        {
            InitializeComponent();
            cargarTodo(criterio);
            carrera = criterio;

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        public void cargarTodo(string carrera)
        {
           
            if(carrera == null)
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

        public void  estudiante(string estudiante){
            if(carrera == null)
            {
                var list = obj.Defensas(estudiante);
                var bindingList = new BindingList<ViewDefensas>(list);
                var source = new BindingSource(bindingList, null);
                dtgDefensaExterna.DataSource = source;

            }
            else
            {
                var list2 = obj.DefensasCarrera(carrera,estudiante);
                var bindingList = new BindingList<ViewDefensasCarrera>(list2);
                var source = new BindingSource(bindingList, null);
                dtgDefensaExterna.DataSource = source;
            }
        }
    }
}
