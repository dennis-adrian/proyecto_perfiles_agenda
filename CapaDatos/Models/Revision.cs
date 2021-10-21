using CapaDatos.Structures;
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
    public class Revision : Conexion, IMetodos
    {

        #region Atributos
        /// <summary>
        /// Id de la revision
        /// </summary>
        private int id;

        /// <summary>
        /// Estado de la revision
        /// </summary>
        private string estado;

        /// <summary>
        /// Fecha de Entrega del perfil de tesis del departamento de titulacion al Alumno
        /// </summary>
        private string fecha_entrega_alumno;

        /// <summary>
        /// Fecha de Entrega del perfil de tesis del departamento de titulacion al tribunal de Revision
        /// </summary>
        private string fecha_entrega_tribunal;

        /// <summary>
        /// Fecha limite para devolver el perfil de tesis cuando se hizo la entrega al tribunal de revision, la fecha limite puede variar segun el numero de revision
        /// </summary>
        private string fecha_limite_devolucion;

        /// <summary>
        /// Fecha en la que el tribunal de revision entrega el perfil al departamento de titulacion
        /// </summary>
        private string fecha_devolucion_tribunal;

        /// <summary>
        /// Fecha de devolucion del perfil de tesis al Alumno, si existio una observacion del tribunal en la revision, para las correcciones correspondientes
        /// </summary>
        private string fecha_devolucion_alumno;

        /// <summary>
        /// Detalles de las Observaciones del perfil de tesis
        /// </summary>
        private string observacion;

        /// <summary>
        /// Numero de tribunal que realizo la revision
        /// </summary>
        private int nro_tribunal;

        /// <summary>
        /// Numero de la revision del perfil de tesis
        /// </summary>
        private int nro_revision;

        /// <summary>
        /// Fecha de Empaste, si existe la fecha el perfil esta disponible para la defensa
        /// </summary>
        private string fecha_empaste;

        /// <summary>
        /// Id del perfil de tesis
        /// </summary>
        private int id_tesis;

        private static string table_name = "revision";
        #endregion
        #region Propiedades

        /// <summary>
        /// 
        /// </summary>
        /// <value>Propiedad <c>Id</c> retorna el valor del id de la revision</value>
        public int Id { get => id; set => id = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <value>Propiedad <c>Fecha_entrega_alumno</c> retorna fecha_entrega_alumno</value>
        public string Fecha_entrega_alumno { get => fecha_entrega_alumno; set => fecha_entrega_alumno = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <value>Propiedad <c>Fecha_entrega_tribunal</c> retorna fecha_entrega_tribunal</value>
        public string Fecha_entrega_tribunal { get => fecha_entrega_tribunal; set => fecha_entrega_tribunal = value; }

        /// <summary>
        ///  
        /// </summary>
        /// <value>Propiedad <c>Fecha_limite_devolucion</c> retorna fecha_limite_devolucion</value>
        public string Fecha_limite_devolucion { get => fecha_limite_devolucion; set => fecha_limite_devolucion = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <value>Propiedad <c>Fecha_devolucion_tribunal</c> retorna fecha_devolucion_tribunal</value>
        public string Fecha_devolucion_tribunal { get => fecha_devolucion_tribunal; set => fecha_devolucion_tribunal = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <value>Propiedad <c>Fecha_devolucion_alumno</c> retorna fecha_devolucion_alumno</value>
        public string Fecha_devolucion_alumno { get => fecha_devolucion_alumno; set => fecha_devolucion_alumno = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <value>Propiedad <c>Nro_tribunal</c> retorna nro_tribunal</value>
        public int Nro_tribunal { get => nro_tribunal; set => nro_tribunal = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <value>Propiedad <c>Nro_revision</c> retorna nro_revision</value>
        public int Nro_revision { get => nro_revision; set => nro_revision = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <value>Propiedad <c>Fecha_empaste</c> retorna fecha_empaste</value>
        public string Fecha_empaste { get => fecha_empaste; set => fecha_empaste = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <value>Propiedad <c>Id_tesis</c> retorna el id_tesis o el id del perfil</value>
        public int Id_tesis { get => id_tesis; set => id_tesis = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <value>Propiedad <c>Estado</c> retorna el estado</value>
        public string Estado { get => estado; set => estado = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <value>Propiedad <c>Observacion</c> retorna la observacion</value>
        public string Observacion { get => observacion; set => observacion = value; }


        #endregion
        #region Metodos


        /// <summary>
        /// Metodo para crear una revision, llama a la funcion <c>QueryBuilder</c> de la clase base y le pasa un <c>Object[]</c> con los parametros en orden correspondiente a la cadena <c>sql</c> 
        /// </summary>
        public void Insert()
        {
            string sql = $"  INSERT INTO {table_name} (  estado,fecha_entrega_alumno,fecha_entrega_tribunal,fecha_limite_devolucion,fecha_devolucion_tribunal,fecha_devolucion_alumno,observacion,nro_tribunal,nro_revision,fecha_empaste, id_tesis  ) VALUES ( @parametro0,@parametro1,@parametro2,@parametro3,@parametro4,@parametro5,@parametro6,@parametro7,@parametro8,@parametro9,@parametro10); ";
            Object[] Parametros = new Object[] { Estado, Fecha_entrega_alumno, Fecha_entrega_tribunal, Fecha_limite_devolucion, Fecha_devolucion_tribunal, Fecha_devolucion_alumno, Observacion, Nro_tribunal, Nro_revision, Fecha_empaste, Id_tesis };
            QueryBuilder(sql, Parametros);

        }

        /// <summary>
        /// Metodo para Eliminar una revision, llama a la funcion <c>QueryBuilder</c> de la clase base y le pasa un <c>Object[]</c> con los parametros en orden correspondiente a la cadena <c>sql</c> 
        /// </summary>
        /// <param name="id">id de la revision</param>
        public void Delete(int id)
        {
            string sql = $" DELETE FROM {table_name} WHERE id = @parametro0 ; ";
            Object[] Parametros = new Object[] { id };
            QueryBuilder(sql, Parametros);

        }

        /// <summary>
        ///  Metodo para Actualizar una revision, llama a la funcion <c>QueryBuilder</c> de la clase base y le pasa un <c>Object[]</c> con los parametros en orden correspondiente a la cadena <c>sql</c>
        /// </summary>
        /// <param name="id">id de la revision</param>
        public void Update(int id)
        {
            string sql = $" UPDATE {table_name}  SET estado = @parametro0, fecha_entrega_alumno = @parametro1 ,fecha_entrega_tribunal = @parametro2 ,fecha_limite_devolucion = @parametro3 ,fecha_devolucion_tribunal = @parametro4 ,fecha_devolucion_alumno  = @parametro5 , observacion = @parametro6, nro_tribunal = @parametro7 , nro_revision = @parametro8 ,fecha_empaste =@parametro9, id_tesis=@parametro10   WHERE id = @parametro11 ; ";
            Object[] Parametros = new Object[] { Estado, Fecha_entrega_alumno, Fecha_entrega_tribunal, Fecha_limite_devolucion, Fecha_devolucion_tribunal, Fecha_devolucion_alumno, Observacion, Nro_tribunal, Nro_revision, Fecha_empaste, Id_tesis, id };
            QueryBuilder(sql, Parametros);

        }

        /// <summary>
        /// Metodo para obtener el id de la ultima revision, 
        /// </summary>
        /// <returns>retorna el id revision</returns>
        public int LastId()
        {

            return LastIdConexion(table_name);
        }

        /// <summary>
        /// Metodo que obtiene la ultima revison perfil de tesis y el tribunal especificos
        /// </summary>
        /// <param name="idTesis">id del perfil de tesis</param>
        /// <param name="nroTribunal">numero del tribunal de revision</param>
        /// <returns>retorna una tabla con los valores de la consulta</returns>
        public DataTable LastRevisionByTribunal(int idTesis, int nroTribunal)
        {
            string sql = $" SELECT * FROM {table_name} WHERE id_tesis = {idTesis} AND nro_tribunal = {nroTribunal} AND nro_revision = (SELECT MAX(nro_revision) FROM revision WHERE id_tesis = {idTesis} AND nro_tribunal ={nroTribunal} ); ";

            return SelectConexion(sql);
        }


        /// <summary>
        /// Metodo para obtener la informacion de las revisiones segun el perfil, numero de revision  y numero de tribunal especificos
        /// </summary>
        /// <param name="idTesis">id del perfil de tesis</param>
        /// <param name="nroRevision">numero de revision</param>
        /// <param name="nroTribunal">numero de tribunal de revision</param>
        /// <returns>retorna una tabla con las revisiones</returns>
        public DataTable infoRevisionByTribunal(int idTesis, int nroRevision, int nroTribunal)
        {
            string sql = $" SELECT * FROM ViewRevisiones WHERE Id_tesis = {idTesis} AND Nro_revision ={nroRevision} AND Nro_tribunal = {nroTribunal}; ";
            return SelectConexion(sql);
        }

        /// <summary>
        /// Metodo para obtener la cantidad total de revisiones por perfil y numero de tribunal
        /// </summary>
        /// <param name="idTesis">id del perfil tesis</param>
        /// <param name="nroTribunal">numero de tribunal de revision</param>
        /// <returns>retorna la cantidad de revisiones</returns>
        public int getCantidadRevisionByIdAndTribunal(int idTesis, int nroTribunal)
        {

            string sql = $" select count(nro_revision) as Num_revisiones from revision where id_tesis = {idTesis} and nro_tribunal = {nroTribunal} ;";
            var cursor = SelectConexion(sql);
            if (cursor.Rows.Count <= 0)
            {
                return 0;
            }
            else
            {
                int num = 0;
                string response = null;
                for (int i = 0; i < cursor.Rows.Count; i++)
                {
                    response = cursor.Rows[i][0].ToString();

                }
                bool passresponse = String.IsNullOrEmpty(response);
                if (passresponse)
                {
                    Console.WriteLine("esta vacio");
                    return num;

                }
                else
                {
                    num = Convert.ToInt32(response);
                    Console.WriteLine("esta definido");
                    return num;
                }
            }
        }


        /// <summary>
        /// Metodo para obtener el numero maximo de revisiones por tribunal y perfil especificos
        /// </summary>
        /// <param name="idTesis">id del perfil de tesis</param>
        /// <param name="nroTribunal">numero del tribunal</param>
        /// <returns>retorna el numero revisiones maximo</returns>
        public int getMaxRevisionByIdAndTribunal(int idTesis, int nroTribunal)
        {
            string sql = $" select MAX(nro_revision) as last from revision where id_tesis = {idTesis} and nro_tribunal = {nroTribunal} ; ";
            var cursor = SelectConexion(sql);
            if (cursor.Rows.Count <= 0)
            {
                Console.WriteLine("primer if ");
                return 0;
            }
            else
            {
                int num = 0;
                string response = null;
                for (int i = 0; i < cursor.Rows.Count; i++)
                {
                    response = cursor.Rows[i][0].ToString();

                }
                bool passresponse = String.IsNullOrEmpty(response);
                if (passresponse)
                {
                    Console.WriteLine("esta vacio");
                    return num;

                }
                else
                {
                    num = Convert.ToInt32(response);
                    Console.WriteLine("esta definido");
                    return num;
                }

            }
        }

        /// <summary>
        /// Metodo para validar las cantidades de revisiones entre tribunales
        /// </summary>
        /// <param name="idTesis">id del perfil tesis</param>
        /// <returns> retorna cero o el numero de revision</returns>
        private int verifyCantidadAndMax(int idTesis)
        {
            int cantidad_t1 = getCantidadRevisionByIdAndTribunal(idTesis, 1);
            int cantidad_t2 = getCantidadRevisionByIdAndTribunal(idTesis, 2);
            int max_t1 = getMaxRevisionByIdAndTribunal(idTesis, 1);
            int max_t2 = getMaxRevisionByIdAndTribunal(idTesis, 2);

            if (cantidad_t1 == 0 || cantidad_t2 == 0 || max_t1 == 0 || max_t2 == 0)
            {
                return 0;
            }
            else
            {
                if (max_t1 == max_t2 && cantidad_t1 == cantidad_t2)
                {
                    return max_t1;
                }
                else
                {
                    return 0;
                }
            }

        }

        /// <summary>
        /// Metodo para verificar las que todas las fechas de las revisiones esten asignadas
        /// </summary>
        /// <param name="idTesis">id del perfil de tesis</param>
        /// <param name="nroTribunal">numero del tribunal</param>
        /// <returns></returns>
        public bool verifyAllFechas(int idTesis, int nroTribunal)
        {
            int num_rev = verifyCantidadAndMax(idTesis);

            if (num_rev == 0) return false;

            string sql = $" select * from revision where id_tesis = {idTesis} and nro_tribunal = {nroTribunal} and nro_revision = {num_rev} and fecha_entrega_alumno <> '' and fecha_entrega_tribunal <> '' and fecha_limite_devolucion <> '' and fecha_devolucion_tribunal <> '' and fecha_devolucion_alumno <> '' and fecha_empaste <> '' ;  ";

            var cursor = SelectConexion(sql);

            if (cursor.Rows.Count <= 0) return false;


            return true;
        }

        /// <summary>
        /// Metodo para comparar que las fechas esten asignadas en cada revision por cada tribunal y que coincidan 
        /// </summary>
        /// <param name="idTesis">id del perfil de tesis</param>
        /// <returns></returns>
        public bool compareAllFechasDefensa(int idTesis)
        {
            bool t1 = verifyAllFechas(idTesis, 1);

            bool t2 = verifyAllFechas(idTesis, 2);

            if (t1 == true && t2 == true)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        /// <summary>
        /// Metodo que llama a <c>compareAllFechasDefensa</c> para validar y realizar el pase del perfil de tesis a la defensa externa
        /// </summary>
        /// <param name="idTesis">id del perfil de tesis</param>
        /// <returns>retorna una estructura de bypass con los datos de la validacion</returns>
        public ByPassDefensa getByPassDefensa(int idTesis)
        {
            var pass = new ByPassDefensa();
            bool res = compareAllFechasDefensa(idTesis);
            if (res == true)
            {
                string sql = $" select * from defensa_externa where id_tesis = {idTesis} ; ";

                var cursor = SelectConexion(sql);
                if (cursor.Rows.Count <= 0)
                {
                    pass.Id_tesis = idTesis;
                    pass.Id_defensa = 0;
                    return pass;
                }
                else
                {
                    for (int i = 0; i < cursor.Rows.Count; i++)
                    {
                        pass.Id_tesis = idTesis;
                        pass.Id_defensa = Convert.ToInt32(cursor.Rows[i][0].ToString());
                    }

                    return pass;
                }
            }
            else
            {
                pass.Id_defensa = 0;
                pass.Id_tesis = 0;
                return pass;
            }
        }

        #endregion
    }
}
