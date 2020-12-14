using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.View;

namespace CapaNegocio.licenciados
{
    public class MostrarLicenciados : Index
    {
        public MostrarLicenciados()
        {
        }

        public struct licenciadoStruct
        {
            private int id;
            private string nombre;
            private string apellido;
            private string tipo;
            private string telefono;
            private string calular;
            private string email;



            public licenciadoStruct(int id,string nombre,string apellido,string tipo,string telefono,string celular,string email)
            {
                this.id = id;
                this.nombre = nombre;
                this.apellido = apellido;
                this.tipo = tipo;
                this.telefono = telefono;
                this.calular = celular;
                this.email = email;
            }

            public int Id { get => id; set => id = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido { get => apellido; set => apellido = value; }
            public string Tipo { get => tipo; set => tipo = value; }
            public string Telefono { get => telefono; set => telefono = value; }
            public string Calular { get => calular; set => calular = value; }
            public string Email { get => email; set => email = value; }
        }
        public List<licenciadoStruct> showLicenciados()
        {
            List<licenciadoStruct> ListaLicenciados = new List<licenciadoStruct>();
            var tabla = licenciado.Select();


            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                int id = Convert.ToInt32(tabla.Rows[i]["id"].ToString());
                string nombre = tabla.Rows[i]["nombre"].ToString();
                string apellido = tabla.Rows[i]["apellido"].ToString();
                string tipo = tabla.Rows[i]["tipo"].ToString();
                string telefono = tabla.Rows[i]["telefono"].ToString();
                string celular = tabla.Rows[i]["celular"].ToString();
                string email = tabla.Rows[i]["email"].ToString();

                licenciadoStruct obj = new licenciadoStruct(id, nombre, apellido, tipo, telefono, celular, email);

                ListaLicenciados.Add(obj);

            }

            return ListaLicenciados;

        }
        public List<licenciadoStruct> showLicenciados(string criterio)
        {
            List<licenciadoStruct> ListaLicenciados = new List<licenciadoStruct>();
            var tabla = licenciado.Select(criterio);


            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                int id = Convert.ToInt32(tabla.Rows[i]["id"].ToString());
                string nombre = tabla.Rows[i]["nombre"].ToString();
                string apellido = tabla.Rows[i]["apellido"].ToString();
                string tipo = tabla.Rows[i]["tipo"].ToString();
                string telefono = tabla.Rows[i]["telefono"].ToString();
                string celular = tabla.Rows[i]["celular"].ToString();
                string email = tabla.Rows[i]["email"].ToString();

                licenciadoStruct obj = new licenciadoStruct(id, nombre, apellido, tipo, telefono, celular, email);

                ListaLicenciados.Add(obj);

            }

            return ListaLicenciados;

        }
        ~MostrarLicenciados()
        {

        }
    }
}
