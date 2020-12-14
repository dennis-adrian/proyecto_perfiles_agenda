using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.carreraInterna
{
    public class Index
    {
        public Index()
        {

        }


        #region Atributos
        CapaDatos.Models.Carrera obj = new CapaDatos.Models.Carrera();
        public struct carrera
        {

            private int id;
            private string nombre;
            private int id_facultad;
            private string facultad;

            public carrera(int id, string nombre, int id_facultad, string facultad)
            {
                this.id = id;
                this.nombre = nombre;
                this.id_facultad=  id_facultad;
                this.facultad = facultad;
            }

            public int Id { get => id; set => id = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Facultad { get => facultad; set => facultad = value; }
            public int Id_facultad { get => id_facultad; set => id_facultad = value; }
        }

        #endregion

        #region Metodos
        public void createCarrera(string nombre,int id_facultad)
        {
            try
            {
                obj.Nombre = nombre;
                obj.Id_facultad = id_facultad;
                obj.Insert();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public void deleteCarrera(int id)
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


        public void updateCarrera(int id, string nombre,int id_facultad)
        {
            try
            {
                obj.Nombre = nombre;
                obj.Id_facultad = id_facultad;
                obj.Update(id);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public List<carrera> showCarrera()
        {
            List<carrera> list = new List<carrera>();
            var cursor = obj.Select();
            for (int i = 0; i < cursor.Rows.Count; i++)
            {
                int id = Convert.ToInt32(cursor.Rows[i][0].ToString());
                string nombre = cursor.Rows[i][1].ToString();
                int id_facultad = Convert.ToInt32(cursor.Rows[i][2].ToString());
                string facultad = cursor.Rows[i][3].ToString();
                carrera obj = new carrera(id, nombre,id_facultad,facultad);

                list.Add(obj);

            }
            return list;
        }
        public List<carrera> showCarrera(string criterio)
        {
            List<carrera> list = new List<carrera>();
            var cursor = obj.Select(criterio);
            for (int i = 0; i < cursor.Rows.Count; i++)
            {
                int id = Convert.ToInt32(cursor.Rows[i][0].ToString());
                string nombre = cursor.Rows[i][1].ToString();
                int id_facultad = Convert.ToInt32(cursor.Rows[i][2].ToString());
                string facultad = cursor.Rows[i][3].ToString();
                carrera obj = new carrera(id, nombre, id_facultad, facultad);

                list.Add(obj);

            }
            return list;
        }

        public DataTable showFacultades()
        {
            return obj.loadFacultades();
        }


        #endregion
    }
}
