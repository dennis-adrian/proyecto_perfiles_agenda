using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;

namespace CapaNegocio.facultad
{
    public class Index
    {
        public Index()
        {

        }


        #region Atributos
        Facultad obj = new Facultad();
        public struct facultad{

            private int id;
            private string nombre;

            public facultad(int id,string nombre)
            {
                this.id = id;
                this.nombre = nombre;
            }

            public int Id { get => id; set => id = value; }
            public string Nombre { get => nombre; set => nombre = value; }
        }

        #endregion

        #region Metodos
        public void createFacultad(string nombre)
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
        public void deleteFacultad(int id)
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
        
        
        public void updateFacultad(int id,string nombre)
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
        public List<facultad> showFacultades()
        {
            List<facultad> list = new List<facultad>();
            var cursor = obj.Select();
            for(int i = 0; i < cursor.Rows.Count; i++)
            {
                int id = Convert.ToInt32(cursor.Rows[i][0].ToString());
                string nombre = cursor.Rows[i][1].ToString();

                facultad obj = new facultad(id,nombre);

                list.Add(obj);

            }
            return list;
        }
        public List<facultad> showFacultades(string criterio)
        {
            List<facultad> list = new List<facultad>();
            var cursor = obj.Select(criterio);
            for (int i = 0; i < cursor.Rows.Count; i++)
            {
                int id = Convert.ToInt32(cursor.Rows[i][0].ToString());
                string nombre = cursor.Rows[i][1].ToString();

                facultad obj = new facultad(id, nombre);

                list.Add(obj);

            }
            return list;
        }



        #endregion
    }

}
