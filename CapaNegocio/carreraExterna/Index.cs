using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.carreraExterna
{
    /// <summary>
    /// Clase encargada de validar y traer datos para el usuario
    /// </summary>
    public class Index
    {
        public Index()
        {

        }


        #region Atributos
        /// <summary>
        /// instanciamos un objeto de Carreralicenciado para la manipulacion y validacion de datos.
        /// </summary>
        CapaDatos.Models.CarreraLicenciado obj = new CapaDatos.Models.CarreraLicenciado();
        /// <summary>
        /// Este constructor permite instanciar los atributos de la clase determinado
        /// </summary>
        public struct carreraExterna
        {

            private int id;
            private string nombre;

            public carreraExterna(int id, string nombre)
            {
                this.id = id;
                this.nombre = nombre;
            }

            public int Id { get => id; set => id = value; }
            public string Nombre { get => nombre; set => nombre = value; }
        }

        #endregion

        #region Metodos
        /// <summary>
        /// metodo encargado para el registro de nuevas Carreras Externas
        /// </summary>
        /// <param name="nombre"></param>
        public void createCarreraExterna(string nombre)
        {
            try
            {
                obj.Nombre = nombre;
                obj.Insert();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        /// <summary>
        /// Metodo encargado para la eliminacion de alguna carrera existente requiriendo el id de la carrera
        /// </summary>
        /// <param name="id"></param>
        public void deleteCarreraExterna(int id)
        {
            try
            {
                obj.Delete(id);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }
        /// <summary>
        /// Metodo encargado de la actualizacion de alguna carrera existente requiriendo como parametro el id y nombre que se actualizara
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        public void updateCarreraExterna(int id, string nombre)
        {
            try
            {
                obj.Nombre = nombre;
                obj.Update(id);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        /// <summary>
        /// Metodo encargado de obtener una lista de carreras existente en la BD
        /// </summary>
        /// <returns></returns>
        public List<carreraExterna> showCarreraExterna()
        {
            List<carreraExterna> list = new List<carreraExterna>();
            var cursor = obj.Select();
            for (int i = 0; i < cursor.Rows.Count; i++)
            {
                int id = Convert.ToInt32(cursor.Rows[i][0].ToString());
                string nombre = cursor.Rows[i][1].ToString();

                carreraExterna obj = new carreraExterna(id, nombre);

                list.Add(obj);

            }
            return list;
        }
        /// <summary>
        /// Metodo encargado de obtener una lista de carreras existentes con el requisito de alguna coincidencia dada por el usuario
        /// </summary>
        /// <param name="criterio"></param>
        /// <returns></returns>
        public List<carreraExterna> showCarreraExterna(string criterio)
        {
            List<carreraExterna> list = new List<carreraExterna>();
            var cursor = obj.Select(criterio);
            for (int i = 0; i < cursor.Rows.Count; i++)
            {
                int id = Convert.ToInt32(cursor.Rows[i][0].ToString());
                string nombre = cursor.Rows[i][1].ToString();

                carreraExterna obj = new carreraExterna(id, nombre);

                list.Add(obj);

            }
            return list;
        }



        #endregion
    }

}
