using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.View;

namespace CapaNegocio
{
    public class NegocioRevisiones
    {
        public NegocioRevisiones()
        {

        }
        #region Instancias

        ViewRevisiones viewRevisiones = new ViewRevisiones();
        #endregion

        public List<ViewRevisiones> Revisiones(int idrev)
        {
            List<ViewRevisiones> listarevisiones = new List<ViewRevisiones>();
            DataTable tabla = viewRevisiones.Select(idrev);

            for(int i = 0; i < tabla.Rows.Count; i++)
            {
                listarevisiones.Add(new ViewRevisiones()
                {
                    Id = Convert.ToInt32(tabla.Rows[i][0].ToString()),
                    Id_tesis = Convert.ToInt32(tabla.Rows[i][1].ToString()),
                    Estado = tabla.Rows[i][2].ToString(),
                    Fecha_entrega_alumno = tabla.Rows[i][3].ToString(),
                    Fecha_entrega_tribunal = tabla.Rows[i][4].ToString(),
                    Fecha_limite_devolucion = tabla.Rows[i][5].ToString(),
                    Fecha_devolucion_tribunal = tabla.Rows[i][6].ToString(),
                    Fecha_devolucion_alumno = tabla.Rows[i][7].ToString(),
                    Observacion = tabla.Rows[i][8].ToString(),
                    Nro_tribunal = Convert.ToInt32(tabla.Rows[i][9].ToString()),
                    Nro_revision = Convert.ToInt32(tabla.Rows[i][10].ToString()),
                    Fecha_empaste = tabla.Rows[i][11].ToString(),
                    Licenciado = tabla.Rows[i][12].ToString(),
                    Tipo = tabla.Rows[i][13].ToString(),
                    Funcion = tabla.Rows[i][14].ToString()

                });

            }
            return listarevisiones;
        }
       
    }
}
