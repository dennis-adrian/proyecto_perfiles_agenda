using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;
using CapaNegocio.src;

namespace CapaNegocio.revisionPerfil
{
    public class Index
    {
        public Index()
        {
        }

        #region Instancias
        Revision revision = new Revision();
        PerfilTesis perfilTesis = new PerfilTesis();
        DetalleRevision detalleRevision = new DetalleRevision();
        FuncionLicenciado funcionLicenciado = new FuncionLicenciado();
        DataTypes type = new DataTypes();

        #endregion



        public void createRevision(string estado, string fec_entrega_alumno, string fec_entrega_tribunal, string fec_limite_devolucion, string fec_devolucion_tribunal, string fec_devolucion_alumno, string observacion, int nro_tribunal, int nro_revision, string fec_empaste, int id_tesis, int id_licenciado)
        {
            try
            {

                revision.Estado = estado;              
                revision.Fecha_entrega_alumno = fec_entrega_alumno;
                revision.Fecha_entrega_tribunal = fec_entrega_tribunal;              
                revision.Fecha_limite_devolucion = fec_limite_devolucion;
                revision.Fecha_devolucion_tribunal = fec_devolucion_tribunal;
                revision.Fecha_devolucion_alumno = fec_devolucion_alumno;
                revision.Observacion =observacion;
                revision.Nro_tribunal = nro_tribunal;
                revision.Nro_revision = nro_revision;
                revision.Fecha_empaste = fec_empaste;
                revision.Id_tesis = id_tesis;
                revision.Insert();
                detalleRevision.Id_revision = revision.LastId();
                detalleRevision.Id_licenciado = id_licenciado;
                detalleRevision.Id_funcion_licenciado = funcionLicenciado.FindIdBySearch("Tribunal de Revision");
                detalleRevision.Insert();
                perfilTesis.updateStatus(id_tesis, estado);
            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }
        }

        public void updateRevision(int idRevision,int idDetalleRevision, string estado, string fec_entrega_alumno, string fec_entrega_tribunal, string fec_limite_devolucion, string fec_devolucion_tribunal, string fec_devolucion_alumno, string observacion, int nro_tribunal, int nro_revision, string fec_empaste, int id_tesis, int id_licenciado)
        {
            try
            {

                revision.Estado = estado;
                revision.Fecha_entrega_alumno = fec_entrega_alumno;
                revision.Fecha_entrega_tribunal = fec_entrega_tribunal;
                revision.Fecha_limite_devolucion = fec_limite_devolucion;
                revision.Fecha_devolucion_tribunal = fec_devolucion_tribunal;
                revision.Fecha_devolucion_alumno = fec_devolucion_alumno;
                revision.Observacion = observacion;
                revision.Nro_tribunal = nro_tribunal;
                revision.Nro_revision = nro_revision;
                revision.Fecha_empaste = fec_empaste;
                revision.Id_tesis = id_tesis;
                revision.Update(idRevision);
                detalleRevision.Id_revision = idRevision;
                detalleRevision.Id_licenciado = id_licenciado;
                detalleRevision.Id_funcion_licenciado = funcionLicenciado.FindIdBySearch("Tribunal de Revision");
                detalleRevision.Update(idDetalleRevision);
                perfilTesis.updateStatus(id_tesis, estado);
            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }
        }

        public struct RevisionStruct
        {
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
            private int id_detalle_revision;
            private int id_licenciado;
            private string licenciado;
            private string tipo;
            private int id_funcion_licenciado;
            private string funcion_licenciado;

            public RevisionStruct(
                int id,
                string estado,
                string fecha_entrega_alumno,
                string fecha_entrega_tribunal,
                string fecha_limite_devolucion,
                string fecha_devolucion_tribunal,
                string fecha_devolucion_alumno,
                string observacion,
                int nro_tribunal,
                int nro_revision,
                string fecha_empaste,
                int id_tesis,
                int id_detalle_revision,
                int id_licenciado,
                string licenciado,
                string tipo,
                int id_funcion_licenciado,
                string funcion_licenciado
            )
            {
                this.id = id;
                this.estado = estado;
                this.fecha_entrega_alumno = fecha_entrega_alumno;
                this.fecha_entrega_tribunal = fecha_entrega_tribunal;
                this.fecha_limite_devolucion = fecha_limite_devolucion;
                this.fecha_devolucion_tribunal = fecha_devolucion_tribunal;
                this.fecha_devolucion_alumno = fecha_devolucion_alumno;
                this.observacion = observacion;
                this.nro_tribunal = nro_tribunal;
                this.nro_revision = nro_revision;
                this.fecha_empaste = fecha_empaste;
                this.id_tesis = id_tesis;
                this.id_detalle_revision = id_detalle_revision;
                this.id_licenciado = id_licenciado;
                this.licenciado = licenciado;
                this.id_funcion_licenciado = id_funcion_licenciado;
                this.funcion_licenciado = funcion_licenciado;
                this.tipo = tipo;

            }

            public int Id { get => id; set => id = value; }
            public string Estado { get => estado; set => estado = value; }
            public string Fecha_entrega_alumno { get => fecha_entrega_alumno; set => fecha_entrega_alumno = value; }
            public string Fecha_entrega_tribunal { get => fecha_entrega_tribunal; set => fecha_entrega_tribunal = value; }
            public string Fecha_limite_devolucion { get => fecha_limite_devolucion; set => fecha_limite_devolucion = value; }
            public string Fecha_devolucion_tribunal { get => fecha_devolucion_tribunal; set => fecha_devolucion_tribunal = value; }
            public string Fecha_devolucion_alumno { get => fecha_devolucion_alumno; set => fecha_devolucion_alumno = value; }
            public string Observacion { get => observacion; set => observacion = value; }
            public int Nro_tribunal { get => nro_tribunal; set => nro_tribunal = value; }
            public int Nro_revision { get => nro_revision; set => nro_revision = value; }
            public string Fecha_empaste { get => fecha_empaste; set => fecha_empaste = value; }
            public int Id_tesis { get => id_tesis; set => id_tesis = value; }
            public int Id_detalle_revision { get => id_detalle_revision; set => id_detalle_revision = value; }
            public int Id_licenciado { get => id_licenciado; set => id_licenciado = value; }
            public string Licenciado { get => licenciado; set => licenciado = value; }
            public string Tipo { get => tipo; set => tipo = value; }
            public int Id_funcion_licenciado { get => id_funcion_licenciado; set => id_funcion_licenciado = value; }
            public string Funcion_licenciado { get => funcion_licenciado; set => funcion_licenciado = value; }
        }

        public RevisionStruct infoRevision(int idtesis,int nrorevision,int nrotribunal)
        {
            RevisionStruct revisionStruct = new RevisionStruct();

            var cursor = revision.infoRevisionByTribunal(idtesis,nrorevision,nrotribunal);

            for (int i = 0; i < cursor.Rows.Count; i++)
            {
                revisionStruct.Id = Convert.ToInt32(cursor.Rows[i]["Id"].ToString());

                revisionStruct.Estado = cursor.Rows[i]["Estado"].ToString();

                revisionStruct.Fecha_entrega_alumno = cursor.Rows[i]["Fecha_entrega_alumno"].ToString();

                revisionStruct.Fecha_entrega_tribunal = cursor.Rows[i]["Fecha_entrega_tribunal"].ToString();

                revisionStruct.Fecha_limite_devolucion = cursor.Rows[i]["Fecha_limite_devolucion"].ToString();

                revisionStruct.Fecha_devolucion_tribunal = cursor.Rows[i]["Fecha_devolucion_tribunal"].ToString();

                revisionStruct.Fecha_devolucion_alumno = cursor.Rows[i]["Fecha_devolucion_alumno"].ToString();

                revisionStruct.Observacion = cursor.Rows[i]["Observacion"].ToString();

                revisionStruct.Nro_tribunal = Convert.ToInt32(cursor.Rows[i]["Nro_tribunal"].ToString());
                revisionStruct.Nro_revision = Convert.ToInt32(cursor.Rows[i]["Nro_revision"].ToString());

                revisionStruct.Fecha_empaste = cursor.Rows[i]["Fecha_empaste"].ToString();

                revisionStruct.Id_tesis = Convert.ToInt32(cursor.Rows[i]["Id_tesis"].ToString());

                revisionStruct.Id_detalle_revision = Convert.ToInt32(cursor.Rows[i]["Id_detalle_revision"].ToString());

                revisionStruct.Id_licenciado = Convert.ToInt32(cursor.Rows[i]["Id_licenciado"].ToString());

                revisionStruct.Licenciado= cursor.Rows[i]["Licenciado"].ToString();

                revisionStruct.Tipo = cursor.Rows[i]["Tipo"].ToString();

                revisionStruct.Id_funcion_licenciado = Convert.ToInt32(cursor.Rows[i]["Id_funcion_licenciado"].ToString());

                revisionStruct.Funcion_licenciado = cursor.Rows[i]["Funcion_licenciado"].ToString();

            }
            return revisionStruct;
        }

        public bool ValidarFechasTribunal(int it, int nt)
        {
            string[] fechas = new string[5];
            bool result = true;
            var rev = revision.LastRevisionByTribunal(it, nt);
            for (int i = 0; i < rev.Rows.Count; i++)
            {
                fechas[0] = rev.Rows[i][2].ToString();
                fechas[1] = rev.Rows[i][3].ToString();
                fechas[2] = rev.Rows[i][4].ToString();
                fechas[3] = rev.Rows[i][5].ToString();
                fechas[4] = rev.Rows[i][6].ToString();
            }
            bool fec_vacio = fechas.Contains("");
            bool fec_null = fechas.Contains(null);
            if (fec_vacio == true || fec_null == true)
            {
                result = false;
            }
            return result;
        }
        public bool ValidarFechaEmpasteTribunal(int it, int nt)
        {
            string fec_empaste = "";
            bool result = true;
            var rev = revision.LastRevisionByTribunal(it, nt);

            for (int i = 0; i < rev.Rows.Count; i++)
            {
                fec_empaste = rev.Rows[i][10].ToString();

            }

            if (fec_empaste == "" || fec_empaste == null)
            {
                result = false;
            }

            return result;


        }

        public bool ValidateNextRevision(int it, int t1, int t2)
        {
            bool result = false;
            var rev1 = revision.MaxNumberOfRevsionesByTribunal(it, t1);
            var rev2 = revision.MaxNumberOfRevsionesByTribunal(it, t2);

            int max1 = 0;
            int max2 = 0;
            for (int i = 0; i < rev1.Rows.Count; i++)
            {
                max1 = Convert.ToInt32(rev1.Rows[i][0].ToString());

            }
            for (int i = 0; i < rev2.Rows.Count; i++)
            {
                max2 = Convert.ToInt32(rev2.Rows[i][0].ToString());

            }

            if (max1 == max2)
            {
                result = true;
            }
            return result;


        }

        public bool ValidarFechasEmpasteforNewInsert(int it, int t1, int t2)
        {
            bool result = true;
            try
            {

                string empastet1 = "";
                string empastet2 = "";
                bool res = ValidateNextRevision(it, t1, t2);
                if (res == true)
                {
                    var revt1 = revision.LastRevisionByTribunal(it, t1);
                    var revt2 = revision.LastRevisionByTribunal(it, t2);

                    for (int i = 0; i < revt1.Rows.Count; i++)
                    {
                        empastet1 = revt1.Rows[i][10].ToString();
                    }
                    for (int i = 0; i < revt2.Rows.Count; i++)
                    {
                        empastet2 = revt2.Rows[i][10].ToString();

                    }


                    if ((empastet1 == "" || empastet1 == null) || (empastet2 == "" || empastet2 == null))
                    {
                        result = false;
                    }


                }
                else
                {
                    result = false;

                }


                return result;
            }
            catch
            {
                result = false;
                return result;
            }

        }


        public bool ExisteAlgunaFechaEmpasteforNewInsert(int it, int t1, int t2)
        {
            bool result = false;
            string empastet1 = "";
            string empastet2 = "";
            bool res = ValidateNextRevision(it, t1, t2);
            if (res == true)
            {
                var revt1 = revision.LastRevisionByTribunal(it, t1);
                var revt2 = revision.LastRevisionByTribunal(it, t2);

                for (int i = 0; i < revt1.Rows.Count; i++)
                {
                    empastet1 = revt1.Rows[i][10].ToString();
                }
                for (int i = 0; i < revt2.Rows.Count; i++)
                {
                    empastet2 = revt2.Rows[i][10].ToString();

                }


                if ((empastet1 != "" && empastet1 != null) || (empastet2 != "" && empastet2 != null))
                {
                    result = true;
                }


            }
            return result;
        }


        public void test1(int it, int t1, int t2)
        {

            string empastet1 = "";
            string empastet2 = "nada";
            try
            {
                bool res = ValidateNextRevision(it, t1, t2);
                if (res == true)
                {
                    var revt1 = revision.LastRevisionByTribunal(it, t1);
                    var revt2 = revision.LastRevisionByTribunal(it, t2);

                    for (int i = 0; i < revt1.Rows.Count; i++)
                    {
                        empastet1 = revt1.Rows[i][10].ToString();
                    }
                    for (int i = 0; i < revt2.Rows.Count; i++)
                    {
                        empastet2 = revt2.Rows[i][10].ToString();

                    }
                }
                Console.WriteLine(empastet1);
                Console.WriteLine(empastet2);
            }
            catch
            {
                Console.WriteLine("hbo un error");
            }







        }


        public void deleteRevision(int id)
        {
            try
            {

                revision.Delete(id);
            }
            catch (Exception e)
            {
                throw new ArgumentException("" + e);
            }

        }
    }
}
