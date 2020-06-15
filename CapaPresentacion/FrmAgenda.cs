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
{
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
            string sql = " select AG.id as idagenda, AG.fecha_presentacion as fecha ,AG.hora as Hora,AG.aula as Aula,PF.tema as Tema, EG.fecha_aprobacion as Fechaaprobacion, ES.registro as Registro, ES.nombre as Nombres, ES.apellido as Apellidos, CA.nombre as Carreras,FA.nombre as Facultad " +
                            " from agenda AG inner join perfil_tesis PF on AG.id_tesis = PF.id inner join examen_grado as EG on AG.id_examen_grado = EG.id inner join estudiante as ES on EG.id_estudiante = ES.id inner join carrera as CA on ES.id_carrera = CA.id inner join facultad as FA on CA.id_facultad = FA.id ";

            dtgAgenda.DataSource = obj.mostrarDatos(sql);

        }
    }
}
