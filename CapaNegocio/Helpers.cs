using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;
using CapaNegocio.src;


namespace CapaNegocio
{

    public class Helpers : ValidationInputUI
    {
        #region Constructor
        public Helpers()
        {


        }

        #endregion


        #region Atributos

        Object[] parametros;
        #endregion


        #region Instancias
        Institucion institucion = new Institucion();
        CarreraLicenciado carreraLicenciado = new CarreraLicenciado();
        DataTypes type = new DataTypes();

        #endregion


        #region Metodos
               
        public void InsertInstitucion(Object[] Collection)
        {            
            try
            {

                type.Texto2  = Convert.ToString(Collection[0]); 
                institucion.Nombre = type.Texto2;
                institucion.Insert();

            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);

            }

        }
        public void InsertCarreraLicenciado(Object[] Collection)
        {
            try
            {

                type.Texto2 = Convert.ToString(Collection[0]);
                carreraLicenciado.Nombre = type.Texto2;
                carreraLicenciado.Insert();

            }
            catch(Exception e)
            {
                throw new ArgumentException("" + e);

            }
            
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

        public void MainInsertInstitucion()
        {
            try
            {
                InsertInstitucion(parametros);
            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }
        }

        public void MainInsertCarreraLicenciado()
        {
            try
            {
                InsertCarreraLicenciado(parametros);
            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }

        }

        #endregion


        #region Destructor

        ~Helpers()
        {

        }
        #endregion

    }
}
