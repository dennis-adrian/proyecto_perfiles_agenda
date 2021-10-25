using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    /// <summary>
    /// Clase Revision que tiene como clase base <c>Conexion</c> e implementa la interface <c>IMetodos</c>
    /// </summary>
    public class Licenciado : Conexion, IMetodos
    {
        /// <summary>
        ///  datos de un licenciado. ya sea tribunal, tutor, presidente o secretaria. 
        /// </summary>
        public Licenciado()

        {

            id = 0;
            nombre = "";
            apellido = "";
            descripcion = "";
            email = "";
            telefono = "";
            celular = "";
            tipo = ""; //interno o externo
            docente = 0;// 0 no 1 si
            id_institucion_representada = 0;
            id_carrera_licenciado = 0;


        }

        #region Atributos
        /// <summary>
        /// id del licenciado
        /// </summary>
        private int id;
        /// <summary>
        /// nombre de un licenciado
        /// </summary>
        private string nombre;
        /// <summary>
        /// apellido de un licenciado
        /// </summary>
        private string apellido;
        /// <summary>
        /// descripcion de un licenciado
        /// </summary>
        private string descripcion;
        /// <summary>
        /// correo de un licenciado
        /// </summary>
        private string email;
        /// <summary>
        /// telefono de un licenciado
        /// </summary>
        private string telefono;
        /// <summary>
        /// celular de un licenciado
        /// </summary>
        private string celular;
        /// <summary>
        /// tipo de licenciado (externo o interno)
        /// </summary>
        private string tipo;
        /// <summary>
        /// define si es docente de la universidad o no lo es
        /// </summary>
        private int docente;
        /// <summary>
        /// id de la intitucion a la que representa
        /// </summary>
        private int id_institucion_representada;
        /// <summary>
        /// id carrera del licenciado
        /// </summary>
        private int id_carrera_licenciado;
        /// <summary>
        /// tabla con los datos de un licneciado
        /// </summary>
        private static string table_name = "licenciado";

        #endregion
        #region Propiedades
        /// <value>retorna valor id de licenciado</value>
        public int Id { get => id; set => id = value; }
        /// <value>retorna nombre del licenciado</value>
        public string Nombre { get => nombre; set => nombre = value; }
        /// <value>retorna apellido del licenciado</value>
        public string Apellido { get => apellido; set => apellido = value; }
        /// <value>retorna descripcion del licenciado</value>
        public string Descripcion { get => descripcion; set => descripcion = value; }
        /// <value>retorna correo del licenciado</value>
        public string Email { get => email; set => email = value; }
        /// <value>retorna telefono del licenciado</value>
        public string Telefono { get => telefono; set => telefono = value; }
        /// <value>retorna celular del licenciado</value>
        public string Celular { get => celular; set => celular = value; }
        /// <value>retorna tipo del licenciado (interno o externo)</value>
        public string Tipo { get => tipo; set => tipo = value; }
        /// <value>retorna si el licenciado es docente de la universidad o no lo es</value>
        public int Docente { get => docente; set => docente = value; }
        /// <value>retorna id de la institucion a la que representa el licenciado</value>
        public int Id_institucion_representada { get => id_institucion_representada; set => id_institucion_representada = value; }
        /// <value>retorna id de la carrera del licenciado</value>
        public int Id_carrera_licenciado { get => id_carrera_licenciado; set => id_carrera_licenciado = value; }
        #endregion
        #region Metodos
        /// <summary>
        /// Metodo para insertar datos de un licenciado, llama a la funcion <c>QueryBuilder</c> de la clase base y le pasa un <c>Object[]</c> con los parametros en orden correspondiente a la cadena <c>sql</c> 
        /// </summary>
        public void Insert()
        {
            string idInstitucion = Id_institucion_representada == 0 ? null : Convert.ToString(id_institucion_representada);
            string idCarrera = id_carrera_licenciado == 0 ? null : Convert.ToString(id_carrera_licenciado);
            string sql = $"  INSERT INTO " + table_name + " (  nombre,apellido,descripcion,email,telefono,celular,tipo,docente,id_institucion_representada,id_carrera_licenciado  ) VALUES ( @parametro0, @parametro1, @parametro2, @parametro3, @parametro4, @parametro5, @parametro6,@parametro7,@parametro8,@parametro9); ";
            Object[] Parametros = new Object[] { Nombre, Apellido, Descripcion, Email, Telefono, Celular, Tipo, Docente, idInstitucion, idCarrera };
            QueryBuilder(sql, Parametros);

        }
        /// <summary>
        /// Metodo para Eliminar un licenciado, llama a la funcion <c>QueryBuilder</c> de la clase base y le pasa un <c>Object[]</c> con los parametros en orden correspondiente a la cadena <c>sql</c> 
        /// </summary>
        /// <param name="id">id del licenciado</param>
        public void Delete(int id)
        {
            string sql = $" DELETE FROM {table_name} WHERE id = @parametro0 ; ";
            Object[] Parametros = new Object[] { id };
            QueryBuilder(sql, Parametros);

        }
        /// <summary>
        ///  Metodo para Actualizar datos de un licenciado, llama a la funcion <c>QueryBuilder</c> de la clase base y le pasa un <c>Object[]</c> con los parametros en orden correspondiente a la cadena <c>sql</c>
        /// </summary>
        /// <param name="id">id del licenciado</param>
        public void Update(int id)
        {

            string idInstitucion = Id_institucion_representada == 0 ? null : Convert.ToString(id_institucion_representada);
            string idCarrera = id_carrera_licenciado == 0 ? null : Convert.ToString(id_carrera_licenciado);

            string sql = $" UPDATE {table_name}  SET  nombre = @parametro0 ,apellido = @parametro1, descripcion = @parametro2 , email = @parametro3 , telefono = @parametro4 , celular = @parametro5, tipo = @parametro6, docente = @parametro7,id_institucion_representada = @parametro8  ,id_carrera_licenciado = @parametro9   WHERE id = @parametro10 ; ";
            Object[] Parametros = new Object[] { Nombre, Apellido, Descripcion, Email, Telefono, Celular, Tipo, Docente, idInstitucion, idCarrera, id };
            QueryBuilder(sql, Parametros);

        }
        /// <summary>
        /// filtra datos de un licenciado a la tabla
        /// </summary>
        /// <returns>datos de un licenciado</returns>
        public DataTable Select()
        {
            string sql = $" SELECT * FROM {table_name} ; ";
            return SelectConexion(sql);
        }
        /// <summary>
        /// filtra datos de un licenciado a la tabla 
        /// </summary>
        /// <param name="criterio">busca por nombre o apellido del licenciado</param>
        /// <returns>datos del licenciado</returns>
        public DataTable Select(string criterio)
        {
            string search = criterio.Trim();
            string sql = $" SELECT * FROM {table_name} WHERE nombre LIKE '%{search}%' or apellido LIKE '%{search}%'  ; ";
            return SelectConexion(sql);
        }
        public int LastId()
        {
            return LastIdConexion(table_name);
        }
        /// <summary>
        /// retorna una tabla con el ultimo registro
        /// </summary>
        /// <param name="Id">id del licenciado</param>
        /// <returns>datos del licenciado</returns>
        public DataTable FindById(int Id)
        {
            string sql = $" SELECT * FROM {table_name} WHERE id = {Id}  ;";
            return SelectConexion(sql);

        }

        #endregion

        ~Licenciado()
        {

        }
    }
}
