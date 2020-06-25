using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{//comentario

    public partial class FrmAgenda : Form
    {
        Conexion obj = new Conexion();
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
            string sql = " select * from facultad";

           // dtgAgenda.DataSource = obj.mostrarDatos(sql);

        }
    }
}
