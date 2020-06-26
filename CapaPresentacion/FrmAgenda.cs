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
using CapaNegocio.Views;

namespace CapaPresentacion
{//comentario

    public partial class FrmAgenda : Form
    {
        NegocioDefensaExterna obj = new NegocioDefensaExterna();
        
       
        public FrmAgenda()
        {
            InitializeComponent();
            cargarTodo();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        public void cargarTodo()
        {


            var list = obj.Defensas();  

            var bindingList = new BindingList<ViewDefensas>(list);
            var source = new BindingSource(bindingList, null);
            dtgDefensaExterna.DataSource = source;

        }
    }
}
