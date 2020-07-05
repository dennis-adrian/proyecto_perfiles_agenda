using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;
using CapaNegocio.src;

namespace CapaNegocio
{
    public class NegocioRevision : ValidationInputUI
    {
        #region Constructor


        #endregion
        #region Instancias
        Revision revision = new Revision();
        DetalleRevision detalleRevision = new DetalleRevision();
        DataTypes type = new DataTypes();

        #endregion
        #region Atributos

        Object[] parametros;
        #endregion
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



        public void InsertRevision(Object[] Collection)
        {
            try
            {

                type.Texto2 = Convert.ToString(Collection[0]);
                revision.Estado = type.Texto2;

                type.Fecha = Convert.ToString(Collection[1]);
                revision.Fecha_entrega_alumno = type.Fecha;

                type.Fecha = Convert.ToString(Collection[2]);
                revision.Fecha_entrega_tribunal = type.Fecha;

                type.Fecha = Convert.ToString(Collection[3]);
                revision.Fecha_limite_devolucion = type.Fecha;

                type.Fecha = Convert.ToString(Collection[4]);
                revision.Fecha_devolucion_tribunal = type.Fecha;

                type.Fecha = Convert.ToString(Collection[5]);
                revision.Fecha_devolucion_alumno = type.Fecha;

                type.Texto2 = Convert.ToString(Collection[6]);
                revision.Observacion = type.Texto2;

                revision.Nro_tribunal = Convert.ToInt32(Collection[7]);

                revision.Nro_revision = Convert.ToInt32(Collection[8]);

                type.Fecha = Convert.ToString(Collection[9]);
                revision.Fecha_empaste = type.Fecha;

                revision.Id_tesis = Convert.ToInt32(Collection[10]);

                revision.Insert();


            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }
        }
        public void UpdateRevision(Object[] Collection,int idselected)
        {
            try
            {

                type.Texto2 = Convert.ToString(Collection[0]);
                revision.Estado = type.Texto2;

                type.Fecha = Convert.ToString(Collection[1]);
                revision.Fecha_entrega_alumno = type.Fecha;

                type.Fecha = Convert.ToString(Collection[2]);
                revision.Fecha_entrega_tribunal = type.Fecha;

                type.Fecha = Convert.ToString(Collection[3]);
                revision.Fecha_limite_devolucion = type.Fecha;

                type.Fecha = Convert.ToString(Collection[4]);
                revision.Fecha_devolucion_tribunal = type.Fecha;

                type.Fecha = Convert.ToString(Collection[5]);
                revision.Fecha_devolucion_alumno = type.Fecha;

                type.Texto2 = Convert.ToString(Collection[6]);
                revision.Observacion = type.Texto2;

                revision.Nro_tribunal = Convert.ToInt32(Collection[7]);

                revision.Nro_revision = Convert.ToInt32(Collection[8]);

                type.Fecha = Convert.ToString(Collection[9]);
                revision.Fecha_empaste = type.Fecha;

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
       
        public void MainInsertRevision()
        {

        }
        public void MainUpdateInsert()
        {

        }

        #endregion

        #region Destructor
        ~NegocioRevision()
        {

        }
        #endregion
    }
}
