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
    public class NegocioLicenciados : ValidationInputUI
    {
        #region Constructor
        public NegocioLicenciados()
        {

        }

        #endregion

        #region Instancias

        ViewLicenciados viewlicenciados = new ViewLicenciados();

        Licenciado licenciado = new Licenciado();
        Institucion institucion = new Institucion();
        CarreraLicenciado carreraLicenciado = new CarreraLicenciado();

        DataTypes type = new DataTypes();

        #endregion

        #region Atributos
        Object[] parametros;

        #endregion
 
        #region Metodos

        public List<ViewLicenciados> Licenciados()
        {
            List<ViewLicenciados> ListaLicenciados = new List<ViewLicenciados>();
            DataTable tabla = viewlicenciados.Select();


            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                ListaLicenciados.Add(new ViewLicenciados()
                {
                    Id = Convert.ToInt32(tabla.Rows[i][0].ToString()),
                    Nombre = tabla.Rows[i][1].ToString(),
                    Apellido = tabla.Rows[i][2].ToString(),
                    Tipo = tabla.Rows[i][3].ToString(),
                    Telefono = tabla.Rows[i][4].ToString(),
                    Celular = tabla.Rows[i][5].ToString(),
                    Email = tabla.Rows[i][6].ToString()
                });

            }

            return ListaLicenciados;

        }
        public DataTable cargarCarrerasLicenciados()
        {
            return carreraLicenciado.Select();
        }
        public DataTable cargarInstitucio()
        {
            return institucion.Select();
        }
        public void UpdateLicenciado(Object[] Collection, int id)
        {
            try
            {
                type.Texto = Convert.ToString(Collection[0]);
                licenciado.Nombre = type.Texto;

                type.Texto = Convert.ToString(Collection[1]);
                licenciado.Apellido = type.Texto;

                type.Texto = Convert.ToString(Collection[2]);
                licenciado.Descripcion = type.Texto;


                type.Email = Convert.ToString(Collection[3]);
                licenciado.Email = type.Email;

                type.Telefono = Convert.ToString(Collection[4]);
                licenciado.Telefono = type.Telefono;

                type.Celular = Convert.ToString(Collection[5]);
                licenciado.Celular = type.Celular;

                type.Texto = Convert.ToString(Collection[6]);
                licenciado.Tipo = type.Texto;

                licenciado.Docente = Convert.ToInt32(Collection[7]);

                licenciado.Id_institucion_representada = Convert.ToInt32(Collection[8]);

                licenciado.Id_carrera_licenciado = Convert.ToInt32(Collection[9]);

                licenciado.Update(id);


            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }


        }   
        public void DeleteLicenciado(int id)
        {
            try
            {

                licenciado.Delete(id);
            }
            catch(Exception e)
            {
                throw new ArgumentException("" + e);
            }

        }
        public void InsertLicenciado(Object[] Collection)
        {

            try
            {
                type.Texto = Convert.ToString(Collection[0]);
                licenciado.Nombre = type.Texto;

                type.Texto = Convert.ToString(Collection[1]);
                licenciado.Apellido = type.Texto;

                type.Texto = Convert.ToString(Collection[2]);
                licenciado.Descripcion = type.Texto;


                type.Email = Convert.ToString(Collection[3]);
                licenciado.Email = type.Email;

                type.Telefono = Convert.ToString(Collection[4]);
                licenciado.Telefono = type.Telefono;

                type.Celular = Convert.ToString(Collection[5]);
                licenciado.Celular = type.Celular;

                type.Texto = Convert.ToString(Collection[6]);
                licenciado.Tipo = type.Texto;
                
             
                licenciado.Docente = Convert.ToInt32(Collection[7]);

                licenciado.Id_institucion_representada = Convert.ToInt32(Collection[8]);

               licenciado.Id_carrera_licenciado = Convert.ToInt32(Collection[9]);

                licenciado.Insert();


            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }
        }
        public Object[] InfoLicenciado(int id)
        {


            Licenciado container = new Licenciado();
           DataTable  dt = licenciado.FindById(id);
            for(int i = 0; i<dt.Rows.Count; i++)
            {
                container.Id = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                container.Nombre = dt.Rows[i]["nombre"].ToString();
                container.Apellido = dt.Rows[i]["apellido"].ToString();
                container.Descripcion = dt.Rows[i]["descripcion"].ToString();
                container.Email = dt.Rows[i]["email"].ToString();
                container.Telefono = dt.Rows[i]["telefono"].ToString();
                container.Celular = dt.Rows[i]["celular"].ToString();
                container.Tipo = dt.Rows[i]["tipo"].ToString();
                container.Docente = Convert.ToInt32(dt.Rows[i]["docente"].ToString());
                container.Id_institucion_representada = Convert.ToInt32(dt.Rows[i]["id_institucion_representada"].ToString());
                container.Id_carrera_licenciado = Convert.ToInt32(dt.Rows[i]["id_carrera_licenciado"].ToString());
               

            }

            Object[] datos = new Object[] { container.Id, container.Nombre, container.Apellido, container.Descripcion, container.Email, container.Telefono, container.Celular, container.Tipo, container.Docente, container.Id_institucion_representada, container.Id_carrera_licenciado };

            return datos;



        }
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
                InsertLicenciado(parametros);
            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }


        }
        public void MainUpdate(int idupdated)
        {
            try
            {
                UpdateLicenciado(parametros, idupdated);
            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }


        }

        public void MainDelete(int idupdated)
        {
            try
            {
                DeleteLicenciado(idupdated);
            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }


        }


        #endregion

        #region Destructor
        ~NegocioLicenciados()
        {

        }
        #endregion
    }
}
