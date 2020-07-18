using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;



namespace CapaNegocio
{
    public class NegocioNuevaDefensa : ValidationInputUI
    {
        #region  Construct
        public NegocioNuevaDefensa(){

        }

        #endregion


        #region Instancias

        Estudiante estudiante = new Estudiante();
        DefensaExterna defensaExterna = new DefensaExterna();
        DetalleDefensa detalleDefensa = new DetalleDefensa();


        #endregion

        #region Atributos
        
        Object[] parametros;

        #endregion

        #region  Metodos
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
        public void Main()
        {
            try
            {
                NuevaDefensa(parametros);
            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }
           

        }
        public void NuevaDefensa(Object[] Collection)
        {
            try
            {
                
                
                                                          
            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }
        }
        #endregion



        #region Destruct

        ~NegocioNuevaDefensa(){

        }
        #endregion
    }
}
