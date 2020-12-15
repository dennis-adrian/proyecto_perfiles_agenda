using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.institucion
{
    public class Index
    {
        public Index()
        {
        }


        #region Atributos
        CapaDatos.Models.Institucion obj = new CapaDatos.Models.Institucion();
        public struct institucion
        {

            private int id;
            private string nombre;

            public institucion(int id, string nombre)
            {
                this.id = id;
                this.nombre = nombre;
            }

            public int Id { get => id; set => id = value; }
            public string Nombre { get => nombre; set => nombre = value; }
        }

        #endregion

        #region Metodos
        public void createInstitucion(string nombre)
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
        public void deleteInstitucion(int id)
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


        public void updateInstitucion(int id, string nombre)
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
        public List<institucion> showInstituciones()
        {
            List<institucion> list = new List<institucion>();
            var cursor = obj.Select();
            for (int i = 0; i < cursor.Rows.Count; i++)
            {
                int id = Convert.ToInt32(cursor.Rows[i][0].ToString());
                string nombre = cursor.Rows[i][1].ToString();

                institucion obj = new institucion(id, nombre);

                list.Add(obj);

            }
            return list;
        }
        public List<institucion> showInstituciones(string criterio)
        {
            List<institucion> list = new List<institucion>();
            var cursor = obj.Select(criterio);
            for (int i = 0; i < cursor.Rows.Count; i++)
            {
                int id = Convert.ToInt32(cursor.Rows[i][0].ToString());
                string nombre = cursor.Rows[i][1].ToString();

                institucion obj = new institucion(id, nombre);

                list.Add(obj);

            }
            return list;
        }



        #endregion
    }
}
