using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;
using CapaDatos.View;


namespace CapaNegocio
{
    public class NegocioDefensaExterna
    {
        #region FrmDefensaExterna

        public List<ViewDefensas> Defensas()
        {
            List<ViewDefensas> ListaDefensas = new List<ViewDefensas>();
            DataTable tabla = viewDefensas.Select();
          

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
                    Estudiante = tabla.Rows[i][7].ToString(),
                    Carrera = tabla.Rows[i][8].ToString(),
                    Facultad = tabla.Rows[i][9].ToString()
                });

            }

            return ListaDefensas;

        }

        public List<ViewDefensas> Defensas(string estudiante)
        {
            List<ViewDefensas> ListaDefensas = new List<ViewDefensas>();
            DataTable tabla = viewDefensas.Select(estudiante);


            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                ListaDefensas.Add(new ViewDefensas()
                {
                    Id = Convert.ToInt32(tabla.Rows[i][0].ToString()),
                    Fecha_Defensa = tabla.Rows[i][1].ToString(),
                    Hora = tabla.Rows[i][2].ToString(),
                    Aula = tabla.Rows[i][3].ToString(),
                    Tipo = tabla.Rows[i][4].ToString(),
                    Tema = tabla.Rows[i][5].ToString(),
                    Registro = tabla.Rows[i][6].ToString(),
                    Estudiante = tabla.Rows[i][7].ToString(),
                    Carrera = tabla.Rows[i][8].ToString(),
                    Facultad = tabla.Rows[i][9].ToString()
                });

            }

            return ListaDefensas;

        }
        public List<ViewDefensas> DefensasTipo(string tipo)
        {
            List<ViewDefensas> ListaDefensas = new List<ViewDefensas>();
            DataTable tabla = viewDefensas.SelectTipo(tipo);


            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                ListaDefensas.Add(new ViewDefensas()
                {
                    Id = Convert.ToInt32(tabla.Rows[i][0].ToString()),
                    Fecha_Defensa = tabla.Rows[i][1].ToString(),
                    Hora = tabla.Rows[i][2].ToString(),
                    Aula = tabla.Rows[i][3].ToString(),
                    Tipo = tabla.Rows[i][4].ToString(),
                    Tema = tabla.Rows[i][5].ToString(),
                    Registro = tabla.Rows[i][6].ToString(),
                    Estudiante = tabla.Rows[i][7].ToString(),
                    Carrera = tabla.Rows[i][8].ToString(),
                    Facultad = tabla.Rows[i][9].ToString()
                });

            }

            return ListaDefensas;

        }
       


        #endregion

        #region FrmDefensasCarrera
        public List<ViewDefensasCarrera> DefensasCarrera(string carrera)
        {
            List<ViewDefensasCarrera> ListaDefensasCarreras = new List<ViewDefensasCarrera>();
            DataTable tabla = viewDefensasCarrera.Select(carrera);


            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                ListaDefensasCarreras.Add(new ViewDefensasCarrera()
                {
                    Id = Convert.ToInt32(tabla.Rows[i][0].ToString()),
                    Fecha_Defensa = tabla.Rows[i][1].ToString(),
                    Hora = tabla.Rows[i][2].ToString(),
                    Aula = tabla.Rows[i][3].ToString(),
                    Tipo = tabla.Rows[i][4].ToString(),
                    Tema = tabla.Rows[i][5].ToString(),
                    Registro = tabla.Rows[i][6].ToString(),
                    Estudiante = tabla.Rows[i][7].ToString()
                });

            }

            return ListaDefensasCarreras;

        }

        public List<ViewDefensasCarrera> DefensasCarrera(string carrera,string estudiante)
        {
            List<ViewDefensasCarrera> ListaDefensasCarreras = new List<ViewDefensasCarrera>();
            DataTable tabla = viewDefensasCarrera.Select(carrera, estudiante);


            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                ListaDefensasCarreras.Add(new ViewDefensasCarrera()
                {
                    Id = Convert.ToInt32(tabla.Rows[i][0].ToString()),
                    Fecha_Defensa = tabla.Rows[i][1].ToString(),
                    Hora = tabla.Rows[i][2].ToString(),
                    Aula = tabla.Rows[i][3].ToString(),
                    Tipo = tabla.Rows[i][4].ToString(),
                    Tema = tabla.Rows[i][5].ToString(),
                    Registro = tabla.Rows[i][6].ToString(),
                    Estudiante = tabla.Rows[i][7].ToString()
                });

            }

            return ListaDefensasCarreras;

        }
        public List<ViewDefensasCarrera> DefensasCarreraTipo(string carrera,string tipo)
        {
            List<ViewDefensasCarrera> ListaDefensasCarreras = new List<ViewDefensasCarrera>();
            DataTable tabla = viewDefensasCarrera.SelectTipo(carrera,tipo);


            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                ListaDefensasCarreras.Add(new ViewDefensasCarrera()
                {
                    Id = Convert.ToInt32(tabla.Rows[i][0].ToString()),
                    Fecha_Defensa = tabla.Rows[i][1].ToString(),
                    Hora = tabla.Rows[i][2].ToString(),
                    Aula = tabla.Rows[i][3].ToString(),
                    Tipo = tabla.Rows[i][4].ToString(),
                    Tema = tabla.Rows[i][5].ToString(),
                    Registro = tabla.Rows[i][6].ToString(),
                    Estudiante = tabla.Rows[i][7].ToString()
                });

            }

            return ListaDefensasCarreras;

        }
        #endregion

        #region Constructor

        public NegocioDefensaExterna()
        {

        }
        #endregion

        #region Instancias
       
        ViewDefensas viewDefensas = new ViewDefensas();
        ViewDefensasCarrera viewDefensasCarrera = new ViewDefensasCarrera();

        #endregion


        #region Destructor
        ~NegocioDefensaExterna()
        {

        }
        #endregion
    }
}
