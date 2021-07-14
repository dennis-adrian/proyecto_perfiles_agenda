using System;
using System.Collections.Generic;
using System.Data;
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
        CapaDatos.Models.Estudiante estudiante = new CapaDatos.Models.Estudiante();
        CapaDatos.Models.PerfilTesis obj = new CapaDatos.Models.PerfilTesis();

        public bool updatePerfilGeneral(PerfilGeneral perfil)
        {
            try
            {
                estudiante.Id = perfil.Id_estudiante;
                estudiante.Registro = perfil.Registro;
                estudiante.Nombre = perfil.Nombre;
                estudiante.Apellido = perfil.Apellido;

                estudiante.Email = perfil.Email;
                estudiante.Telefono = perfil.Telefono;
                estudiante.Celular = perfil.Celular;
                estudiante.Id_carrera = perfil.Id_carrera;

                estudiante.Update(estudiante.Id);

                obj.Id = perfil.Id;
                obj.Tema = perfil.Tema;
                obj.Estado = perfil.Estado_Proyecto;
                obj.Fecha_aprobacion_jefe_carrera = perfil.Fecha_Aprobacion;
                obj.Fecha_recepcion_titulacion = perfil.Fecha_Recepcion;

                obj.Estado_defensa = perfil.Estado_Defensa;
                obj.Calificacion = perfil.Calificacion;
                obj.Id_estudiante = perfil.Id_estudiante;
                obj.Id_licenciado = perfil.Id_licenciado;
                obj.Id_funcion_licenciado = perfil.Id_funcion_licenciado;
                obj.Fecha_limite = perfil.Fecha_limite;

                obj.Update(obj.Id);

                return true;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }





        }
        public struct PerfilGeneral
        {
            private int id;

            private int revisiones;
            private string tema;
            private string estado_Proyecto;
            private string fecha_Aprobacion;
            private string fecha_Recepcion;
            private string fecha_limite;

            private string estado_Defensa;
            private double calificacion;
            private int id_estudiante;
            private string registro;
            private string nombre;
            private string apellido;

            private string email;
            private string telefono;
            private string celular;
            private int id_carrera;
            private string carrera;
            private string facultad;

            private int id_licenciado;
            private string licenciado;
            private string tipo;
            private int id_funcion_licenciado;
            private string funcion;
            //private string institucion;
            //private string carrera_Licenciado;


            public PerfilGeneral(
            int id,
            int revisiones,
            string tema,
            string estado_Proyecto,
            string fecha_Aprobacion,
            string fecha_Recepcion,
            string fecha_limite,
            string estado_Defensa,
            double calificacion,
            int id_estudiante,
            string registro,
            string nombre,
            string apellido,
            string email,
            string telefono,
            string celular,
            int id_carrera,
            string carrera,
            string facultad,
            int id_licenciado,
            string licenciado,
            string tipo,
            int id_funcion_licenciado,
            string funcion
            //string institucion,
            //string carrera_Licenciado
            )
            {
                this.id = id;

                this.revisiones = revisiones;
                this.tema = tema;
                this.estado_Proyecto = estado_Proyecto;
                this.fecha_Aprobacion = fecha_Aprobacion;
                this.fecha_Recepcion = fecha_Recepcion;
                this.fecha_limite = fecha_limite;

                this.estado_Defensa = estado_Defensa;
                this.calificacion = calificacion;
                this.id_estudiante = id_estudiante;
                this.registro = registro;
                this.nombre = nombre;
                this.apellido = apellido;

                this.email = email;
                this.telefono = telefono;
                this.celular = celular;
                this.id_carrera = id_carrera;
                this.carrera = carrera;
                this.facultad = facultad;

                this.id_licenciado = id_licenciado;
                this.licenciado = licenciado;
                this.tipo = tipo;
                this.id_funcion_licenciado = id_funcion_licenciado;

                this.funcion = funcion;
                //this.institucion = institucion;
                //this.carrera_Licenciado = carrera_Licenciado;
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
            //public string Institucion { get => institucion; set => institucion = value; }
            //public string Carrera_Licenciado { get => carrera_Licenciado; set => carrera_Licenciado = value; }
            public string Licenciado { get => licenciado; set => licenciado = value; }
            public int Id_carrera { get => id_carrera; set => id_carrera = value; }
            public int Id_licenciado { get => id_licenciado; set => id_licenciado = value; }
            public int Id_estudiante { get => id_estudiante; set => id_estudiante = value; }
            public int Id_funcion_licenciado { get => id_funcion_licenciado; set => id_funcion_licenciado = value; }
            public string Fecha_limite { get => fecha_limite; set => fecha_limite = value; }
        }

        /// <summary>
        /// metodo extraido
        /// </summary>
        /// <param name="tabla"></param>
        /// <returns></returns>
        public PerfilGeneral perfilGeneral(DataTable tabla)
        {
            PerfilGeneral perfil = new PerfilGeneral();

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

                perfil.Id_estudiante = Convert.ToInt32(tabla.Rows[i]["Id_estudiante"].ToString());

                perfil.Registro = tabla.Rows[i]["Registro"].ToString();
                perfil.Nombre = tabla.Rows[i]["Nombre"].ToString();
                perfil.Apellido = tabla.Rows[i]["Apellido"].ToString();
                perfil.Email = tabla.Rows[i]["Email"].ToString();
                perfil.Telefono = tabla.Rows[i]["Telefono"].ToString();
                perfil.Celular = tabla.Rows[i]["Celular"].ToString();
                perfil.Id_carrera = Convert.ToInt32(tabla.Rows[i]["Id_carrera"].ToString());
                perfil.Carrera = tabla.Rows[i]["Carrera"].ToString();
                perfil.Facultad = tabla.Rows[i]["Facultad"].ToString();
                perfil.Id_licenciado = Convert.ToInt32(tabla.Rows[i]["Id_licenciado"].ToString());
                perfil.Licenciado = tabla.Rows[i]["Licenciado"].ToString();
                perfil.Tipo = tabla.Rows[i]["Tipo"].ToString();
                perfil.Funcion = tabla.Rows[i]["Funcion"].ToString();
                //perfil.Institucion = tabla.Rows[i]["Institucion"].ToString();
                //perfil.Carrera_Licenciado = tabla.Rows[i]["Carrera_Licenciado"].ToString();


                perfil.Id_funcion_licenciado = Convert.ToInt32(tabla.Rows[i]["Id_funcion_licenciado"].ToString());
                perfil.Fecha_limite = tabla.Rows[i]["Fecha_limite"].ToString();

            }

            return perfil;
        }

        /// <summary>
        /// Metodo extraido 
        /// </summary>
        /// <param name="tabla"></param>
        /// <returns></returns>
        public List<PerfilGeneral> perfilesGenerales(DataTable tabla)
        {
            List<PerfilGeneral> list = new List<PerfilGeneral>();
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
                
                perfil.Id_estudiante = Convert.ToInt32(tabla.Rows[i]["Id_estudiante"].ToString());

                perfil.Registro = tabla.Rows[i]["Registro"].ToString();
                perfil.Nombre = tabla.Rows[i]["Nombre"].ToString();
                perfil.Apellido = tabla.Rows[i]["Apellido"].ToString();
                perfil.Email = tabla.Rows[i]["Email"].ToString();
                perfil.Telefono = tabla.Rows[i]["Telefono"].ToString();
                perfil.Celular = tabla.Rows[i]["Celular"].ToString();
                perfil.Id_carrera = Convert.ToInt32(tabla.Rows[i]["Id_carrera"].ToString());
                perfil.Carrera = tabla.Rows[i]["Carrera"].ToString();
                perfil.Facultad = tabla.Rows[i]["Facultad"].ToString();
                perfil.Id_licenciado = Convert.ToInt32(tabla.Rows[i]["Id_licenciado"].ToString());
                perfil.Licenciado = tabla.Rows[i]["Licenciado"].ToString();
                perfil.Tipo = tabla.Rows[i]["Tipo"].ToString();
                perfil.Funcion = tabla.Rows[i]["Funcion"].ToString();
                //perfil.Institucion = tabla.Rows[i]["Institucion"].ToString();
                //perfil.Carrera_Licenciado = tabla.Rows[i]["Carrera_Licenciado"].ToString();

                perfil.Id_funcion_licenciado = Convert.ToInt32(tabla.Rows[i]["Id_funcion_licenciado"].ToString());
                perfil.Fecha_limite = tabla.Rows[i]["Fecha_limite"].ToString();

                list.Add(perfil);
            }
            return list;
        }

        public PerfilGeneral showPerfilGeneral(int idperfil)
        {
            var tabla = obj.perfilesById(idperfil);
            return perfilGeneral(tabla);
        }

        public List<PerfilGeneral> Perfiles()
        {           
            var tabla = obj.perfilesAll();
            return perfilesGenerales(tabla);
        }
        public List<PerfilGeneral> PerfilesEstudiante(string estudiante)
        {
            
            var tabla = obj.perfilesAllByEstudiante(estudiante);
            return perfilesGenerales(tabla);

        }

        public List<PerfilGeneral> PerfilesCarrera(string carrera)
        {
            var tabla = obj.perfilesAllByCarrera(carrera);
            return perfilesGenerales(tabla);
        }


        public List<PerfilGeneral> PerfilesCarreraEstudiante(string carrera,string estudiante)
        {
            var tabla = obj.perfilesAllByCarreraAndEstudiante(carrera,estudiante);
            return perfilesGenerales(tabla);
        }


        CapaDatos.Models.Carrera carrera = new CapaDatos.Models.Carrera();
        public DataTable cargarCarreras()
        {
            DataTable dt1 = carrera.Select();

            return dt1;
        }

    }

}
