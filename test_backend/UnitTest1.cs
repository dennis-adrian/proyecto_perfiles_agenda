using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDatos;
using CapaNegocio;
using System.Data;

namespace test_backend
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void determinarPrioridadTest()
        {
            CapaNegocio.notificaciones.Index obj = new CapaNegocio.notificaciones.Index();
          string res = obj.determinarPrioridad("09-11-2020","04-12-2020");
            Console.WriteLine(res);
        }

        [TestMethod]
        public void ifexistnot()
        {
            CapaDatos.Models.Notificacion obj = new CapaDatos.Models.Notificacion();

            var res = obj.notificacionExistente("normal",17,"perfil");

            if (res.Rows.Count > 0)
            {


            for(int i = 0; i < res.Rows.Count; i++)
            {
                Console.WriteLine(res.Rows[i]["id_perfil"].ToString());
            }
            }
            else
            {
                Console.WriteLine("sin notificacion");
            }
        }
        [TestMethod]
        public void test12()
        {
            CapaDatos.Models.Revision obj = new CapaDatos.Models.Revision();

            int res = obj.getMaxRevisionByIdAndTribunal(5, 1);

            Console.WriteLine(res);
        }
    }
}
