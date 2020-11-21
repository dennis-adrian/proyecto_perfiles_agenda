using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDatos;
using CapaNegocio;

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
    }
}
