using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.carreraExterna
{
    public class Index
    {
        public Index()
        {

        }


        #region Atributos
        CapaDatos.Models.CarreraLicenciado obj = new CapaDatos.Models.CarreraLicenciado();
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
