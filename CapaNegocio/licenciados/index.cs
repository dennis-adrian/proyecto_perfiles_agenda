using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.View;
using CapaDatos.Models;
using System.Data;

namespace CapaNegocio.licenciados
{
    public class Index 
    {

        Licenciado instanceLicenciado = new Licenciado();

        public Index()
        {
        }
        public DataTable cargarCarrerasLicenciados()
        {
            CarreraLicenciado carreraLicenciado = new CarreraLicenciado();
            return carreraLicenciado.Select();
        }
        public DataTable cargarInstitucion()
        {
            
            Institucion institucion = new Institucion();
            return institucion.Select();
        }
        public void createNewLicenciado(Licenciado licenciado)
        {
            licenciado.Insert();
        }
        public void updateLicenciado(Licenciado licenciado)
        {
            licenciado.Update(licenciado.Id);
        }
        public Licenciado getLicenciado(Licenciado licenciado)
        {
            try
            {
                var dt = licenciado.FindById(licenciado.Id);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    licenciado.Id = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                    licenciado.Nombre = dt.Rows[i]["nombre"].ToString();
                    licenciado.Apellido = dt.Rows[i]["apellido"].ToString();
                    licenciado.Descripcion = dt.Rows[i]["descripcion"].ToString();
                    licenciado.Email = dt.Rows[i]["email"].ToString();
                    licenciado.Telefono = dt.Rows[i]["telefono"].ToString();
                    licenciado.Celular = dt.Rows[i]["celular"].ToString();
                    licenciado.Tipo = dt.Rows[i]["tipo"].ToString();
                    licenciado.Docente = Convert.ToInt32(dt.Rows[i]["docente"].ToString());
                    string str1 = dt.Rows[i]["id_institucion_representada"].ToString();
                    int iir = String.IsNullOrEmpty(str1) ? 0 : Convert.ToInt32(str1);
                    licenciado.Id_institucion_representada = iir;
                    string str2 = dt.Rows[i]["id_carrera_licenciado"].ToString();
                    int icl = String.IsNullOrEmpty(str2) ? 0 : Convert.ToInt32(str2);
                    licenciado.Id_carrera_licenciado = icl;
                }

                return licenciado;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public List<Licenciado> getLicenciados(string criterio = null)
        {
            List<Licenciado> ListaLicenciados = new List<Licenciado>();
            var dt = String.IsNullOrEmpty(criterio) ? instanceLicenciado.Select()
                    : instanceLicenciado.Select(criterio);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Licenciado licenciado = new Licenciado();
                licenciado.Id = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                licenciado.Nombre = dt.Rows[i]["nombre"].ToString();
                licenciado.Apellido = dt.Rows[i]["apellido"].ToString();
                licenciado.Descripcion = dt.Rows[i]["descripcion"].ToString();
                licenciado.Email = dt.Rows[i]["email"].ToString();
                licenciado.Telefono = dt.Rows[i]["telefono"].ToString();
                licenciado.Celular = dt.Rows[i]["celular"].ToString();
                licenciado.Tipo = dt.Rows[i]["tipo"].ToString();
                licenciado.Docente = Convert.ToInt32(dt.Rows[i]["docente"].ToString());
                string str1 = dt.Rows[i]["id_institucion_representada"].ToString();
                int iir = String.IsNullOrEmpty(str1) ? 0 : Convert.ToInt32(str1);
                licenciado.Id_institucion_representada = iir;
                string str2 = dt.Rows[i]["id_carrera_licenciado"].ToString();
                int icl = String.IsNullOrEmpty(str2) ? 0 : Convert.ToInt32(str2);
                licenciado.Id_carrera_licenciado = icl;
                ListaLicenciados.Add(licenciado);
            }

            return ListaLicenciados;
        }
    }
}
