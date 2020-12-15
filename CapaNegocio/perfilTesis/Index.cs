using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.perfilTesis
{
    public class Index
    {
        public Index()
        {
        }

        CapaDatos.Models.PerfilTesis obj = new CapaDatos.Models.PerfilTesis();
        public struct PerfilGeneral
        {
            private int id;

            private int revisiones;
            private string tema;
            private string estado_Proyecto;
            private string fecha_Aprobacion;
            private string fecha_Recepcion;

            private string estado_Defensa;
            private double calificacion;
            private string registro;
            private string nombre;
            private string apellido;

            private string email;
            private string telefono;
            private string celular;
            private string carrera;
            private string facultad;

            private string licenciado;
            private string tipo;
            private string funcion;
            private string institucion;
            private string carrera_Licenciado;


            public PerfilGeneral(
            int id,
            int revisiones,
            string tema,
            string estado_Proyecto,
            string fecha_Aprobacion,
            string fecha_Recepcion,
            string estado_Defensa,
            double calificacion,
            string registro,
            string nombre,
            string apellido,
            string email,
            string telefono,
            string celular,
            string carrera,
            string facultad,
            string licenciado,
            string tipo,
            string funcion,
            string institucion,
            string carrera_Licenciado)
            {
                this.id = id;

                this.revisiones = revisiones;
                this.tema = tema;
                this.estado_Proyecto = estado_Proyecto;
                this.fecha_Aprobacion = fecha_Aprobacion;
                this.fecha_Recepcion = fecha_Recepcion;

                this.estado_Defensa = estado_Defensa;
                this.calificacion = calificacion;
                this.registro = registro;
                this.nombre = nombre;
                this.apellido = apellido;

                this.email = email;
                this.telefono = telefono;
                this.celular = celular;
                this.carrera = carrera;
                this.facultad = facultad;

                this.licenciado = licenciado;
                this.tipo = tipo;
                this.funcion = funcion;
                this.institucion = institucion;
                this.carrera_Licenciado = carrera_Licenciado;
            }

            public int Id { get => id; set => id = value; }
            public int Revisiones { get => revisiones; set => revisiones = value; }
            public string Tema { get => tema; set => tema = value; }
            public string Estado_Proyecto { get => estado_Proyecto; set => estado_Proyecto = value; }
            public string Fecha_Aprobacion { get => fecha_Aprobacion; set => fecha_Aprobacion = value; }
            public string Fecha_Recepcion { get => fecha_Recepcion; set => fecha_Recepcion = value; }
            public string Estado_Defensa { get => estado_Defensa; set => estado_Defensa = value; }
            public double Calificacion { get => calificacion; set => calificacion = value; }
            public string Registro { get => registro; set => registro = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido { get => apellido; set => apellido = value; }
            public string Email { get => email; set => email = value; }
            public string Telefono { get => telefono; set => telefono = value; }
            public string Celular { get => celular; set => celular = value; }
            public string Carrera { get => carrera; set => carrera = value; }
            public string Facultad { get => facultad; set => facultad = value; }
            
            public string Tipo { get => tipo; set => tipo = value; }
            public string Funcion { get => funcion; set => funcion = value; }
            public string Institucion { get => institucion; set => institucion = value; }
            public string Carrera_Licenciado { get => carrera_Licenciado; set => carrera_Licenciado = value; }
            public string Licenciado { get => licenciado; set => licenciado = value; }
        }
        public PerfilGeneral showPerfilGeneral(int idperfil)
        {
            PerfilGeneral perfil = new PerfilGeneral();


            var tabla = obj.perfilesById(idperfil);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                perfil.Id = Convert.ToInt32(tabla.Rows[i]["Id"].ToString());
                perfil.Revisiones = Convert.ToInt32(tabla.Rows[i]["Revisiones"].ToString());
                perfil.Tema = tabla.Rows[i]["Tema"].ToString();
                perfil.Estado_Proyecto = tabla.Rows[i]["Estado_Proyecto"].ToString();
                perfil.Fecha_Aprobacion = tabla.Rows[i]["Fecha_Aprobacion"].ToString();
                perfil.Fecha_Recepcion = tabla.Rows[i]["Fecha_Recepcion"].ToString();
                perfil.Estado_Defensa = tabla.Rows[i]["Estado_Defensa"].ToString();
                perfil.Calificacion = Convert.ToDouble(tabla.Rows[i]["Calificacion"].ToString());
                perfil.Registro = tabla.Rows[i]["Registro"].ToString();
                perfil.Nombre = tabla.Rows[i]["Nombre"].ToString();
                perfil.Apellido = tabla.Rows[i]["Apellido"].ToString();
                perfil.Email = tabla.Rows[i]["Email"].ToString();
                perfil.Telefono = tabla.Rows[i]["Telefono"].ToString();
                perfil.Celular = tabla.Rows[i]["Celular"].ToString();
                perfil.Carrera = tabla.Rows[i]["Carrera"].ToString();
                perfil.Facultad = tabla.Rows[i]["Facultad"].ToString();
                perfil.Licenciado = tabla.Rows[i]["Licenciado"].ToString();
                perfil.Tipo = tabla.Rows[i]["Tipo"].ToString();
                perfil.Funcion = tabla.Rows[i]["Funcion"].ToString();
                perfil.Institucion = tabla.Rows[i]["Institucion"].ToString();
                perfil.Carrera_Licenciado = tabla.Rows[i]["Carrera_Licenciado"].ToString();


            }

            return perfil;
        }
    
    
        public List<PerfilGeneral> Perfiles()
        {
            List<PerfilGeneral> list = new List<PerfilGeneral>();         


            var tabla = obj.perfilesAll();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                PerfilGeneral perfil = new PerfilGeneral();
                perfil.Id = Convert.ToInt32(tabla.Rows[i]["Id"].ToString());
                perfil.Revisiones = Convert.ToInt32(tabla.Rows[i]["Revisiones"].ToString());
                perfil.Tema = tabla.Rows[i]["Tema"].ToString();
                perfil.Estado_Proyecto = tabla.Rows[i]["Estado_Proyecto"].ToString();
                perfil.Fecha_Aprobacion = tabla.Rows[i]["Fecha_Aprobacion"].ToString();
                perfil.Fecha_Recepcion = tabla.Rows[i]["Fecha_Recepcion"].ToString();
                perfil.Estado_Defensa = tabla.Rows[i]["Estado_Defensa"].ToString();
                perfil.Calificacion = Convert.ToDouble(tabla.Rows[i]["Calificacion"].ToString());
                perfil.Registro = tabla.Rows[i]["Registro"].ToString();
                perfil.Nombre = tabla.Rows[i]["Nombre"].ToString();
                perfil.Apellido = tabla.Rows[i]["Apellido"].ToString();
                perfil.Email = tabla.Rows[i]["Email"].ToString();
                perfil.Telefono = tabla.Rows[i]["Telefono"].ToString();
                perfil.Celular = tabla.Rows[i]["Celular"].ToString();
                perfil.Carrera = tabla.Rows[i]["Carrera"].ToString();
                perfil.Facultad = tabla.Rows[i]["Facultad"].ToString();
                perfil.Licenciado = tabla.Rows[i]["Licenciado"].ToString();
                perfil.Tipo = tabla.Rows[i]["Tipo"].ToString();
                perfil.Funcion = tabla.Rows[i]["Funcion"].ToString();
                perfil.Institucion = tabla.Rows[i]["Institucion"].ToString();
                perfil.Carrera_Licenciado = tabla.Rows[i]["Carrera_Licenciado"].ToString();

                list.Add(perfil);
            }
            return list;
        }
        public List<PerfilGeneral> PerfilesEstudiante(string estudiante)
        {
            List<PerfilGeneral> list = new List<PerfilGeneral>();


            var tabla = obj.perfilesAllByEstudiante(estudiante);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                PerfilGeneral perfil = new PerfilGeneral();
                perfil.Id = Convert.ToInt32(tabla.Rows[i]["Id"].ToString());
                perfil.Revisiones = Convert.ToInt32(tabla.Rows[i]["Revisiones"].ToString());
                perfil.Tema = tabla.Rows[i]["Tema"].ToString();
                perfil.Estado_Proyecto = tabla.Rows[i]["Estado_Proyecto"].ToString();
                perfil.Fecha_Aprobacion = tabla.Rows[i]["Fecha_Aprobacion"].ToString();
                perfil.Fecha_Recepcion = tabla.Rows[i]["Fecha_Recepcion"].ToString();
                perfil.Estado_Defensa = tabla.Rows[i]["Estado_Defensa"].ToString();
                perfil.Calificacion = Convert.ToDouble(tabla.Rows[i]["Calificacion"].ToString());
                perfil.Registro = tabla.Rows[i]["Registro"].ToString();
                perfil.Nombre = tabla.Rows[i]["Nombre"].ToString();
                perfil.Apellido = tabla.Rows[i]["Apellido"].ToString();
                perfil.Email = tabla.Rows[i]["Email"].ToString();
                perfil.Telefono = tabla.Rows[i]["Telefono"].ToString();
                perfil.Celular = tabla.Rows[i]["Celular"].ToString();
                perfil.Carrera = tabla.Rows[i]["Carrera"].ToString();
                perfil.Facultad = tabla.Rows[i]["Facultad"].ToString();
                perfil.Licenciado = tabla.Rows[i]["Licenciado"].ToString();
                perfil.Tipo = tabla.Rows[i]["Tipo"].ToString();
                perfil.Funcion = tabla.Rows[i]["Funcion"].ToString();
                perfil.Institucion = tabla.Rows[i]["Institucion"].ToString();
                perfil.Carrera_Licenciado = tabla.Rows[i]["Carrera_Licenciado"].ToString();

                list.Add(perfil);
            }
            return list;
        }

        public List<PerfilGeneral> PerfilesCarrera(string carrera)
        {
            List<PerfilGeneral> list = new List<PerfilGeneral>();


            var tabla = obj.perfilesAllByCarrera(carrera);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                PerfilGeneral perfil = new PerfilGeneral();
                perfil.Id = Convert.ToInt32(tabla.Rows[i]["Id"].ToString());
                perfil.Revisiones = Convert.ToInt32(tabla.Rows[i]["Revisiones"].ToString());
                perfil.Tema = tabla.Rows[i]["Tema"].ToString();
                perfil.Estado_Proyecto = tabla.Rows[i]["Estado_Proyecto"].ToString();
                perfil.Fecha_Aprobacion = tabla.Rows[i]["Fecha_Aprobacion"].ToString();
                perfil.Fecha_Recepcion = tabla.Rows[i]["Fecha_Recepcion"].ToString();
                perfil.Estado_Defensa = tabla.Rows[i]["Estado_Defensa"].ToString();
                perfil.Calificacion = Convert.ToDouble(tabla.Rows[i]["Calificacion"].ToString());
                perfil.Registro = tabla.Rows[i]["Registro"].ToString();
                perfil.Nombre = tabla.Rows[i]["Nombre"].ToString();
                perfil.Apellido = tabla.Rows[i]["Apellido"].ToString();
                perfil.Email = tabla.Rows[i]["Email"].ToString();
                perfil.Telefono = tabla.Rows[i]["Telefono"].ToString();
                perfil.Celular = tabla.Rows[i]["Celular"].ToString();
                perfil.Carrera = tabla.Rows[i]["Carrera"].ToString();
                perfil.Facultad = tabla.Rows[i]["Facultad"].ToString();
                perfil.Licenciado = tabla.Rows[i]["Licenciado"].ToString();
                perfil.Tipo = tabla.Rows[i]["Tipo"].ToString();
                perfil.Funcion = tabla.Rows[i]["Funcion"].ToString();
                perfil.Institucion = tabla.Rows[i]["Institucion"].ToString();
                perfil.Carrera_Licenciado = tabla.Rows[i]["Carrera_Licenciado"].ToString();

                list.Add(perfil);
            }
            return list;
        }


        public List<PerfilGeneral> PerfilesCarreraEstudiante(string carrera,string estudiante)
        {
            List<PerfilGeneral> list = new List<PerfilGeneral>();


            var tabla = obj.perfilesAllByCarreraAndEstudiante(carrera,estudiante);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                PerfilGeneral perfil = new PerfilGeneral();
                perfil.Id = Convert.ToInt32(tabla.Rows[i]["Id"].ToString());
                perfil.Revisiones = Convert.ToInt32(tabla.Rows[i]["Revisiones"].ToString());
                perfil.Tema = tabla.Rows[i]["Tema"].ToString();
                perfil.Estado_Proyecto = tabla.Rows[i]["Estado_Proyecto"].ToString();
                perfil.Fecha_Aprobacion = tabla.Rows[i]["Fecha_Aprobacion"].ToString();
                perfil.Fecha_Recepcion = tabla.Rows[i]["Fecha_Recepcion"].ToString();
                perfil.Estado_Defensa = tabla.Rows[i]["Estado_Defensa"].ToString();
                perfil.Calificacion = Convert.ToDouble(tabla.Rows[i]["Calificacion"].ToString());
                perfil.Registro = tabla.Rows[i]["Registro"].ToString();
                perfil.Nombre = tabla.Rows[i]["Nombre"].ToString();
                perfil.Apellido = tabla.Rows[i]["Apellido"].ToString();
                perfil.Email = tabla.Rows[i]["Email"].ToString();
                perfil.Telefono = tabla.Rows[i]["Telefono"].ToString();
                perfil.Celular = tabla.Rows[i]["Celular"].ToString();
                perfil.Carrera = tabla.Rows[i]["Carrera"].ToString();
                perfil.Facultad = tabla.Rows[i]["Facultad"].ToString();
                perfil.Licenciado = tabla.Rows[i]["Licenciado"].ToString();
                perfil.Tipo = tabla.Rows[i]["Tipo"].ToString();
                perfil.Funcion = tabla.Rows[i]["Funcion"].ToString();
                perfil.Institucion = tabla.Rows[i]["Institucion"].ToString();
                perfil.Carrera_Licenciado = tabla.Rows[i]["Carrera_Licenciado"].ToString();

                list.Add(perfil);
            }
            return list;
        }


    }

}
