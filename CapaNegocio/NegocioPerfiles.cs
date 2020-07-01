using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.View;

namespace CapaNegocio
{
    public class NegocioPerfiles
    {
        ViewPerfiles viewPerfiles = new ViewPerfiles();
        ViewPerfilesCarrera viewPerfilesCarrera = new ViewPerfilesCarrera();

        public NegocioPerfiles()
        {

        }

        #region FrmPerfiles
        public List<ViewPerfiles> Perfiles()
        {
            List<ViewPerfiles> listaperfiles = new List<ViewPerfiles>();
            DataTable tabla = viewPerfiles.Select();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                listaperfiles.Add(new ViewPerfiles()
                {
                    Id = Convert.ToInt32(tabla.Rows[i][0].ToString()),
                    Estado_Proyecto = tabla.Rows[i][1].ToString(),
                    Registro = tabla.Rows[i][2].ToString(),
                    Estudiante = tabla.Rows[i][3].ToString(),
                    Carrera = tabla.Rows[i][4].ToString(),
                    Facultad = tabla.Rows[i][5].ToString(),
                    Tema = tabla.Rows[i][6].ToString(),
                    Tutor = tabla.Rows[i][7].ToString(),
                    Email = tabla.Rows[i][8].ToString(),
                    Telefono = tabla.Rows[i][9].ToString(),
                    Fecha_Recepcion = tabla.Rows[i][10].ToString()

                });

            }

            return listaperfiles;
        }

        public List<ViewPerfiles> Perfiles(string estudiante)
        {
            List<ViewPerfiles> listaperfiles = new List<ViewPerfiles>();
            DataTable tabla = viewPerfiles.Select(estudiante);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                listaperfiles.Add(new ViewPerfiles()
                {
                    Id = Convert.ToInt32(tabla.Rows[i][0].ToString()),
                    Estado_Proyecto = tabla.Rows[i][1].ToString(),
                    Registro = tabla.Rows[i][2].ToString(),
                    Estudiante = tabla.Rows[i][3].ToString(),
                    Carrera = tabla.Rows[i][4].ToString(),
                    Facultad = tabla.Rows[i][5].ToString(),
                    Tema = tabla.Rows[i][6].ToString(),
                    Tutor = tabla.Rows[i][7].ToString(),
                    Email = tabla.Rows[i][8].ToString(),
                    Telefono = tabla.Rows[i][9].ToString(),
                    Fecha_Recepcion = tabla.Rows[i][10].ToString()

                });

            }

            return listaperfiles;
        }


        #endregion
        #region FrmPerfilesCarrera
        public List<ViewPerfilesCarrera> PerfilesCarrera(string carrera)
        {
            List<ViewPerfilesCarrera> listaperfilescarrera = new List<ViewPerfilesCarrera>();
            DataTable tabla = viewPerfilesCarrera.Select(carrera);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                listaperfilescarrera.Add(new ViewPerfilesCarrera()
                {
                    Id = Convert.ToInt32(tabla.Rows[i][0].ToString()),
                    Estado_Proyecto = tabla.Rows[i][1].ToString(),
                    Registro = tabla.Rows[i][2].ToString(),
                    Estudiante = tabla.Rows[i][3].ToString(),
                    Tema = tabla.Rows[i][6].ToString(),
                    Tutor = tabla.Rows[i][7].ToString(),
                    Email = tabla.Rows[i][8].ToString(),
                    Telefono = tabla.Rows[i][9].ToString(),
                    Fecha_Recepcion = tabla.Rows[i][10].ToString()

                });

            }

            return listaperfilescarrera;
        }

        public List<ViewPerfilesCarrera> PerfilesCarrera(string carrera,string estudiante)
        {
            List<ViewPerfilesCarrera> listaperfilescarrera = new List<ViewPerfilesCarrera>();
            DataTable tabla = viewPerfilesCarrera.Select(carrera,estudiante);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                listaperfilescarrera.Add(new ViewPerfilesCarrera()
                {
                    Id = Convert.ToInt32(tabla.Rows[i][0].ToString()),
                    Estado_Proyecto = tabla.Rows[i][1].ToString(),
                    Registro = tabla.Rows[i][2].ToString(),
                    Estudiante = tabla.Rows[i][3].ToString(),
                    Tema = tabla.Rows[i][6].ToString(),
                    Tutor = tabla.Rows[i][7].ToString(),
                    Email = tabla.Rows[i][8].ToString(),
                    Telefono = tabla.Rows[i][9].ToString(),
                    Fecha_Recepcion = tabla.Rows[i][10].ToString()

                });

            }

            return listaperfilescarrera;
        }


        #endregion



    }
}
