using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.View;

namespace CapaNegocio
{
    public class NegocioPerfilGeneral

    {
        #region Constructor
        public NegocioPerfilGeneral()
        {

        }

        #endregion
        #region Instancias
        ViewPerfilGeneral viewPerfilGeneral = new ViewPerfilGeneral();

        #endregion

        #region Propiedades

        #endregion
        #region Metodos

        public List<ViewPerfilGeneral> PerfilGeneral(int id_perfil)
        {
            List<ViewPerfilGeneral> perfilgeneral = new List<ViewPerfilGeneral>();
            DataTable tabla = viewPerfilGeneral.Select(id_perfil);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                perfilgeneral.Add(new ViewPerfilGeneral()
                {
                    Id = Convert.ToInt32(tabla.Rows[i][0].ToString()),
                    Revisiones = Convert.ToInt32(tabla.Rows[i][1].ToString()),
                    Tema = tabla.Rows[i][2].ToString(),
                    Estado_Proyecto = tabla.Rows[i][3].ToString(),
                    Fecha_Aprobacion = tabla.Rows[i][4].ToString(),
                    Fecha_Recepcion = tabla.Rows[i][5].ToString(),
                    Estado_Defensa = tabla.Rows[i][6].ToString(),
                    Calificacion = Convert.ToDouble(tabla.Rows[i][7].ToString()),
                    Registro = tabla.Rows[i][8].ToString(),
                    Nombre = tabla.Rows[i][9].ToString(),
                    Apellido = tabla.Rows[i][10].ToString(),
                    Email = tabla.Rows[i][11].ToString(),
                    Telefono = tabla.Rows[i][12].ToString(),
                    Celular = tabla.Rows[i][13].ToString(),
                    Carrera = tabla.Rows[i][14].ToString(),
                    Facultad = tabla.Rows[i][15].ToString(),
                    Tutor = tabla.Rows[i][16].ToString(),
                    Tipo = tabla.Rows[i][17].ToString(),
                    Funcion = tabla.Rows[i][18].ToString(),
                    Institucion = tabla.Rows[i][19].ToString(),
                    Carrera_Licenciado = tabla.Rows[i][20].ToString()

                });

            }

            return perfilgeneral;
        }

        #endregion


        #region Destructor
        ~NegocioPerfilGeneral()
        {

        }
        #endregion
    }
}
