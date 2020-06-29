﻿using System;
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
{
    public partial class FrmPerfiles : Form
    {
       NegocioPerfiles obj = new NegocioPerfiles();
        string carrera = null;
        public FrmPerfiles(string criterio)
        {
            InitializeComponent();
            cargarTodo(criterio);
            carrera = criterio;
        }
        

        private void btnBuscarPerfil_Click(object sender, EventArgs e)
        {
            
           
        }
        public void cargarTodo(string carrera)
        {

            if (carrera == null)
            {
                var list = obj.Perfiles();
                var bindingList = new BindingList<ViewPerfiles>(list);
                var source = new BindingSource(bindingList, null);
                dtgPerfilesTesis.DataSource = source;

            }
            else
            {
                var list2 = obj.PerfilesCarrera(carrera);
                var bindingList = new BindingList<ViewPerfilesCarrera>(list2);
                var source = new BindingSource(bindingList, null);
                dtgPerfilesTesis.DataSource = source;
            }

        }
    }
}
