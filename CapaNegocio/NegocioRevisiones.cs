using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.View;
using CapaDatos.Models;
using CapaNegocio.src;

namespace CapaNegocio
{
    public class NegocioRevisiones : ValidationInputUI
    {
        public NegocioRevisiones()
        {

        }

        #region Atributos
        Object[] parametros;

        #endregion
        #region Instancias

        ViewRevisiones viewRevisiones = new ViewRevisiones();
        Revision revision = new Revision();
        DetalleRevision detalleRevision = new DetalleRevision();
        FuncionLicenciado funcionLicenciado = new FuncionLicenciado();
        DataTypes type = new DataTypes();
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
       
        #region Metodos

        public void ControlInput(Object[] Collection)
        {
            try
            {
                Validation(Collection);
                parametros = Collection;
            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }

        }

        public void MainInsert()
        {
            try
            {
                NuevaRevision(parametros);
            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }


        }
        public void MainUpdate(int id)
        {
            try
            {
                UpdateRevision(parametros,id);
            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }


        }

        public void NuevaRevision(Object[] Collection)
        {
            try
            {

                type.Texto2 = Convert.ToString(Collection[0]);

                revision.Estado = type.Texto2;

                string fec1 = Convert.ToString(Collection[1]);
                revision.Fecha_entrega_alumno = (fec1 == "") ? "" : fec1;

                string fec2 = Convert.ToString(Collection[2]);
                revision.Fecha_entrega_tribunal = (fec2 == "") ? "" : fec2;

                string fec3 = Convert.ToString(Collection[3]);

                revision.Fecha_limite_devolucion = (fec3 == "") ? "" : fec3;

                string fec4 = Convert.ToString(Collection[4]);
                revision.Fecha_devolucion_tribunal = (fec4 == "") ? "" : fec4; 

                string fec5 = Convert.ToString(Collection[5]);
                revision.Fecha_devolucion_alumno = (fec5 == "") ? "" : fec5; 

                string obs = Convert.ToString(Collection[6]);
                revision.Observacion = (obs == "") ? "" : obs;

                revision.Nro_tribunal = Convert.ToInt32(Collection[7]);

                revision.Nro_revision = Convert.ToInt32(Collection[8]);

                string fec_empaste = Convert.ToString(Collection[9]);
                revision.Fecha_empaste = (fec_empaste == "") ? "" : fec_empaste;

                revision.Id_tesis = Convert.ToInt32(Collection[10]);

                revision.Insert();

                detalleRevision.Id_revision = revision.LastId();
                detalleRevision.Id_licenciado = Convert.ToInt32(Collection[11]);
                detalleRevision.Id_funcion_licenciado = funcionLicenciado.FindIdBySearch("Tribunal de Revision");


                detalleRevision.Insert();






            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }
        }
        public void UpdateRevision(Object[] Collection, int idselected)
        {
            try
            {

                type.Texto2 = Convert.ToString(Collection[0]);
                revision.Estado = type.Texto2;

                string fec1 = Convert.ToString(Collection[1]);
                revision.Fecha_entrega_alumno = (fec1 == "") ? "" : fec1;

                string fec2 = Convert.ToString(Collection[2]);
                revision.Fecha_entrega_tribunal = (fec2 == "") ? "" : fec2;

                string fec3 = Convert.ToString(Collection[3]);
                revision.Fecha_limite_devolucion = (fec3 == "") ? "" : fec3;

                string fec4 = Convert.ToString(Collection[4]);
                revision.Fecha_devolucion_tribunal = (fec4 == "") ? "" : fec4;

                string fec5 = Convert.ToString(Collection[5]);
                revision.Fecha_devolucion_alumno = (fec5 == "") ? "" : fec5;


                string obs = Convert.ToString(Collection[6]);
                revision.Observacion = (obs == "") ? "" : obs;

                revision.Nro_tribunal = Convert.ToInt32(Collection[7]);

                revision.Nro_revision = Convert.ToInt32(Collection[8]);

                string fec_empaste = Convert.ToString(Collection[9]);
                revision.Fecha_empaste = (fec_empaste == "") ? "" : fec_empaste;

                revision.Id_tesis = Convert.ToInt32(Collection[10]);

                revision.Update(idselected);


            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }
        }
        public void DeleteRevision(int id)
        {
            try
            {

                revision.Delete(id);
            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }

        }


        public Object[] InfoRevisionTribunal(int id, int nro, int tri)
        {


            ViewRevisiones container = new ViewRevisiones();
            DataTable tabla = viewRevisiones.RevisionByTribunal(id, nro, tri);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                container.Id = Convert.ToInt32(tabla.Rows[i][0].ToString());
                container.Id_tesis = Convert.ToInt32(tabla.Rows[i][1].ToString());
                container.Estado = tabla.Rows[i][2].ToString();
                container.Fecha_entrega_alumno = tabla.Rows[i][3].ToString();
                container.Fecha_entrega_tribunal = tabla.Rows[i][4].ToString();
                container.Fecha_limite_devolucion = tabla.Rows[i][5].ToString();
                container.Fecha_devolucion_tribunal = tabla.Rows[i][6].ToString();
                container.Fecha_devolucion_alumno = tabla.Rows[i][7].ToString();
                container.Observacion = tabla.Rows[i][8].ToString();
                container.Nro_tribunal = Convert.ToInt32(tabla.Rows[i][9].ToString());
                container.Nro_revision = Convert.ToInt32(tabla.Rows[i][10].ToString());
                container.Fecha_empaste = tabla.Rows[i][11].ToString();
                container.Id_Licenciado = Convert.ToInt32(tabla.Rows[i][12].ToString());
                container.Licenciado = tabla.Rows[i][13].ToString();
                container.Tipo = tabla.Rows[i][14].ToString();
                container.Funcion = tabla.Rows[i][15].ToString();

            }

            Object[] datos = new Object[] {
                container.Id,
                container.Id_tesis,
                container.Estado,
               container.Fecha_entrega_alumno,
                container.Fecha_entrega_tribunal,
                container.Fecha_limite_devolucion,
                container.Fecha_devolucion_tribunal,
                 container.Fecha_devolucion_alumno,
                 container.Observacion,
                container.Nro_tribunal,
                container.Nro_revision,
                container.Fecha_empaste,
                container.Id_Licenciado,
                 container.Licenciado,
                 container.Tipo,
                container.Funcion



            };

            return datos;



        }

        public bool ValidarFechasTribunal(int it, int nt)
        {
            string[] fechas = new string[5]; 
            bool result = true;
            var rev = revision.LastRevisionByTribunal(it, nt);
            for (int i = 0; i < rev.Rows.Count; i++)
            {              
                fechas[0] = rev.Rows[i][2].ToString();
                fechas[1] = rev.Rows[i][3].ToString();
                fechas[2] = rev.Rows[i][4].ToString();
                fechas[3] = rev.Rows[i][5].ToString();
                fechas[4] = rev.Rows[i][6].ToString();
            }
            bool fec_vacio = fechas.Contains("");
            bool fec_null = fechas.Contains(null);
            if(fec_vacio == true || fec_null == true)
            {
                result = false;
            }
            return result;
        }
        public bool ValidarFechaEmpasteTribunal(int it, int nt)
        {
            string fec_empaste = "" ;
            bool result = true;
            var rev = revision.LastRevisionByTribunal(it, nt);

            for (int i = 0; i < rev.Rows.Count; i++)
            {
                fec_empaste = rev.Rows[i][10].ToString();

            }
                        
            if (fec_empaste == "" || fec_empaste == null)
            {
                result = false;
            }

            return result;


        }

        public bool ValidateNextRevision(int it, int t1,int t2)
        {
            bool result = false;
            var rev1 =  revision.MaxNumberOfRevsionesByTribunal(it,t1);
            var rev2 = revision.MaxNumberOfRevsionesByTribunal(it, t2);
            
            int max1 = 0;
            int max2 = 0;
            for (int i = 0; i < rev1.Rows.Count; i++)
            {
                max1 = Convert.ToInt32(rev1.Rows[i][0].ToString());

            }
            for (int i = 0; i < rev2.Rows.Count; i++)
            {
                max2 = Convert.ToInt32(rev2.Rows[i][0].ToString());

            }

            if(max1 == max2)
            {
                result = true;
            }
            return result;


        }
        #endregion

    }
}
