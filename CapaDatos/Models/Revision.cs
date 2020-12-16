using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class Revision : Conexion, IMetodos
    {
        public Revision()
        {
            id = 0;
            estado = "";//campo nuevo
            fecha_entrega_alumno = "";
            fecha_entrega_tribunal = "";
            fecha_limite_devolucion = "";
            fecha_devolucion_tribunal = "";
            fecha_devolucion_alumno = "";
            observacion = "";//campo nuevo
            nro_tribunal = 0;
            nro_revision = 0;
            fecha_empaste = "";
            id_tesis = 0;
        }
        #region Atributos
        private int id;
        private string estado;
        private string fecha_entrega_alumno;
        private string fecha_entrega_tribunal;
        private string fecha_limite_devolucion;
        private string fecha_devolucion_tribunal;
        private string fecha_devolucion_alumno;
        private string observacion;
        private int nro_tribunal;
        private int nro_revision;
        private string fecha_empaste;
        private int id_tesis;
        private static string table_name = "revision";
        #endregion
        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Fecha_entrega_alumno { get => fecha_entrega_alumno; set => fecha_entrega_alumno = value; }
        public string Fecha_entrega_tribunal { get => fecha_entrega_tribunal; set => fecha_entrega_tribunal = value; }
        public string Fecha_limite_devolucion { get => fecha_limite_devolucion; set => fecha_limite_devolucion = value; }
        public string Fecha_devolucion_tribunal { get => fecha_devolucion_tribunal; set => fecha_devolucion_tribunal = value; }
        public string Fecha_devolucion_alumno { get => fecha_devolucion_alumno; set => fecha_devolucion_alumno = value; }
        public int Nro_tribunal { get => nro_tribunal; set => nro_tribunal = value; }
        public int Nro_revision { get => nro_revision; set => nro_revision = value; }
        public string Fecha_empaste { get => fecha_empaste; set => fecha_empaste = value; }
        public int Id_tesis { get => id_tesis; set => id_tesis = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Observacion { get => observacion; set => observacion = value; }


        #endregion
        #region Metodos

        public void Insert()
        {
            string sql = $"  INSERT INTO {table_name} (  estado,fecha_entrega_alumno,fecha_entrega_tribunal,fecha_limite_devolucion,fecha_devolucion_tribunal,fecha_devolucion_alumno,observacion,nro_tribunal,nro_revision,fecha_empaste, id_tesis  ) VALUES ( @parametro0,@parametro1,@parametro2,@parametro3,@parametro4,@parametro5,@parametro6,@parametro7,@parametro8,@parametro9,@parametro10); ";
            Object[] Parametros = new Object[] { Estado, Fecha_entrega_alumno, Fecha_entrega_tribunal, Fecha_limite_devolucion, Fecha_devolucion_tribunal, Fecha_devolucion_alumno, Observacion, Nro_tribunal, Nro_revision, Fecha_empaste, Id_tesis };
            QueryBuilder(sql, Parametros);

        }
        public void Delete(int id)
        {
            string sql = $" DELETE FROM {table_name} WHERE id = @parametro0 ; ";
            Object[] Parametros = new Object[] { id };
            QueryBuilder(sql, Parametros);

        }
        public void Update(int id)
        {
            string sql = $" UPDATE {table_name}  SET estado = @parametro0, fecha_entrega_alumno = @parametro1 ,fecha_entrega_tribunal = @parametro2 ,fecha_limite_devolucion = @parametro3 ,fecha_devolucion_tribunal = @parametro4 ,fecha_devolucion_alumno  = @parametro5 , observacion = @parametro6, nro_tribunal = @parametro7 , nro_revision = @parametro8 ,fecha_empaste =@parametro9, id_tesis=@parametro10   WHERE id = @parametro11 ; ";
            Object[] Parametros = new Object[] { Estado, Fecha_entrega_alumno, Fecha_entrega_tribunal, Fecha_limite_devolucion, Fecha_devolucion_tribunal, Fecha_devolucion_alumno, Observacion, Nro_tribunal, Nro_revision, Fecha_empaste, Id_tesis, id };
            QueryBuilder(sql, Parametros);

        }

        public DataTable Select()
        {
            string sql = $" SELECT * FROM {table_name} ; ";
            return SelectConexion(sql);
        }
        public int LastId()
        {

            return LastIdConexion(table_name);
        }
        public DataTable LastRevisionByTribunal(int itesis, int nrotri)
        {
            string idtesis = Convert.ToString(itesis);
            string nrotribunal = Convert.ToString(nrotri);
            string sql = $" SELECT * FROM {table_name} WHERE id_tesis = @parametro0 AND nro_tribunal = @parametro1 AND nro_revision = (SELECT MAX(nro_revision) FROM revision WHERE id_tesis = @parametro0 AND nro_tribunal = @parametro1); ";

            return SelectConexion(sql, idtesis, nrotribunal);
        }
        public DataTable MaxNumberOfRevsionesByTribunal(int itesis, int nrotri)
        {
            string idtesis = Convert.ToString(itesis);
            string nrotribunal = Convert.ToString(nrotri);
            string sql = $" select MAX(nro_revision) from {table_name} where id_tesis = @parametro0 and nro_tribunal = @parametro1 ; ";
            return SelectConexion(sql, idtesis, nrotribunal);
        }

        public DataTable SelectView(int idtesis)
        {
            string sql = $" SELECT * FROM ViewRevisiones WHERE Id_tesis = {idtesis} ; ";
            return SelectConexion(sql);
        }
        public DataTable infoRevisionByTribunal(int idtesis, int nrorevision, int nrotribunal)
        {
            string sql = $" SELECT * FROM ViewRevisiones WHERE Id_tesis = {idtesis} AND Nro_revision ={nrorevision} AND Nro_tribunal = {nrotribunal}; ";
            return SelectConexion(sql);
        }


        //este metodo no hace nada
        public void validarAgregarDefensa()
        {

            // select * from revision where id_tesis = 6;

            //select* from revision where id_tesis = 5 and nro_tribunal = 1;

            //select* from revision where id_tesis = 5 and nro_tribunal = 2;

            //select count(nro_revision) as Num_revisiones from revision where id_tesis = 5 and nro_tribunal = 1;

            //select count(nro_revision) as Num_revisiones from revision where id_tesis = 5 and nro_tribunal = 2;

            //select MAX(nro_revision) as Ultima_revision from revision where id_tesis = 5 and nro_tribunal = 1;

            //select MAX(nro_revision) as Ultima_revision from revision where id_tesis = 5 and nro_tribunal = 2;

            //select* from revision where id_tesis = 5 and nro_tribunal = 2 and nro_revision = 3;
//            string sql = @" select* from revision
//           where id_tesis = 5
//and nro_tribunal = 2
//and nro_revision = 3
//and fecha_entrega_alumno<>""
//and fecha_entrega_tribunal<>""
//and fecha_limite_devolucion<>""
//and fecha_devolucion_tribunal<>""
//and fecha_devolucion_alumno<>""
//and fecha_empaste<>"";";

           // select* from defensa_externa where id_tesis = 5;
        }

        public int getCantidadRevisionByIdAndTribunal(int idtesis,int nrotribunal)
        {

            string sql = $" select count(nro_revision) as Num_revisiones from revision where id_tesis = {idtesis} and nro_tribunal = {nrotribunal} ;";
            var cursor = SelectConexion(sql);
            if (cursor.Rows.Count<=0)
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
        public int getMaxRevisionByIdAndTribunal(int idtesis, int nrotribunal)
        {
            string sql = $" select MAX(nro_revision) as last from revision where id_tesis = {idtesis} and nro_tribunal = {nrotribunal} ; ";
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

        public int verifyCantidadAndMax(int idtesis)
        {
            //try
            //{

            //}
            //catch(Exception ex)
            //{
            //    throw new ArgumentException(ex.Message);
            //}
            int cantidad_t1 = getCantidadRevisionByIdAndTribunal(idtesis, 1);
            int cantidad_t2 = getCantidadRevisionByIdAndTribunal(idtesis, 2);

            int max_t1 = getMaxRevisionByIdAndTribunal(idtesis, 1);
            int max_t2 = getMaxRevisionByIdAndTribunal(idtesis, 2);

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

        public bool verifyAllFechas(int idtesis,int nrotribunal)
        {
            //try
            //{

            //}catch(Exception ex)
            //{
            //    throw new ArgumentException(ex.Message);
            //}
            int num_rev = verifyCantidadAndMax(idtesis);

            if (num_rev == 0)
            {
                return false;
            }
            else
            {
                string sql = $" select * from revision where id_tesis = {idtesis} and nro_tribunal = {nrotribunal} and nro_revision = {num_rev} and fecha_entrega_alumno <> '' and fecha_entrega_tribunal <> '' and fecha_limite_devolucion <> '' and fecha_devolucion_tribunal <> '' and fecha_devolucion_alumno <> '' and fecha_empaste <> '' ;  ";

                var cursor = SelectConexion(sql);
                if (cursor.Rows.Count <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }


            }

        }

        public bool byPassAllFechasDefensExterna(int idtesis)
        {
            //try
            //{
            //}catch(Exception ex)
            //{
            //    throw new ArgumentException(ex.Message);
            //}

            bool t1 = verifyAllFechas(idtesis, 1);

            bool t2 = verifyAllFechas(idtesis, 2);

            if (t1 == true && t2 == true)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public struct byPassDefensa
        {
            private int id_defensa;
            private int id_tesis;
            public byPassDefensa(int id_defensa,int id_tesis)
            {
                this.id_defensa = id_defensa;
                this.id_tesis = id_tesis;
            }

            public int Id_defensa { get => id_defensa; set => id_defensa = value; }
            public int Id_tesis { get => id_tesis; set => id_tesis = value; }
        }
        public byPassDefensa byPassDefensaExterna(int idtesis)
        {
            //try
            //{

            //}
            //catch(Exception ex)
            //{
            //    throw new ArgumentException(ex.Message);
            //}
            byPassDefensa pass = new byPassDefensa();
            bool res = byPassAllFechasDefensExterna(idtesis);
            if (res == true)
            {
                string sql = $" select * from defensa_externa where id_tesis = {idtesis} ; ";

                var cursor = SelectConexion(sql);
                if (cursor.Rows.Count <= 0)
                {
                    pass.Id_tesis = idtesis;
                    pass.Id_defensa = 0;
                    return pass;
                }
                else
                {
                    for (int i = 0; i < cursor.Rows.Count; i++)
                    {
                        pass.Id_tesis = idtesis;
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
