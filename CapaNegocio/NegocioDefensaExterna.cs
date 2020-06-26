using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;
using CapaDatos;
using CapaNegocio.Views;

namespace CapaNegocio
{
    public class NegocioDefensaExterna
    {
        Vistas Vista = new Vistas();
       

       




        DefensaExterna defensaExterna = new DefensaExterna();
       
        public NegocioDefensaExterna()
        {

        }
        #region FrmDefensaExterna

        public List<ViewDefensas> Defensas()
        {
            List<ViewDefensas> ListaDefensas = new List<ViewDefensas>();
            DataTable tabla = Vista.ViewDefensas();
          

            for (int i=0; i <tabla.Rows.Count; i++)
            {
                ListaDefensas.Add( new ViewDefensas() {
                    Id = Convert.ToInt32(tabla.Rows[i][0].ToString()),
                    Fecha_Defensa = tabla.Rows[i][1].ToString(), 
                    Hora = tabla.Rows[i][2].ToString(), 
                    Aula = tabla.Rows[i][3].ToString(), 
                    Tipo = tabla.Rows[i][4].ToString(),
                    Tema = tabla.Rows[i][5].ToString(), 
                    Registro = tabla.Rows[i][6].ToString(), 
                    Nombre = tabla.Rows[i][7].ToString(),
                    Apellido = tabla.Rows[i][8].ToString(),
                    Carrera = tabla.Rows[i][9].ToString(),
                    Facultad = tabla.Rows[i][10].ToString()
                });

            }

            return ListaDefensas;

        }



        #endregion
    }
}
