using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDatos.Models;
using System.Data.SQLite;
using System.Data;

namespace test_project
{

    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestMethod1()
        {
            Carrera obj = new Carrera();

            obj.Nombre = "teddssst";
            obj.Id_facultad = 1;

            obj.Insert();
        }
        [TestMethod]
        public void TestMethod2()
        {
            Carrera obj = new Carrera();

            obj.LastId();
        }
        [TestMethod]
        public void TestMethod3()
        {
            CapaNegocio.ValidationInputUI obj = new CapaNegocio.ValidationInputUI();
            char c = 'c';
            bool b = true;

            Object[] objeto = new Object[] { 1,"2",3.3,c,b,1,15,"hello world"};
            obj.Validation(objeto);
        }
        [TestMethod]
        public void TestMethod4()
        {
            CapaNegocio.src.DataTypes obj = new CapaNegocio.src.DataTypes();
            obj.Email = "emaisadas111l@example.com";
            Console.WriteLine(obj.Email);
        }
        [TestMethod]
        public void TestMethod5()
        {
            CapaNegocio.src.DataTypes obj = new CapaNegocio.src.DataTypes();
            obj.Telefono = "777777";
            Console.WriteLine(obj.Telefono);
        }
        
        [TestMethod]
        public void BUGD002()
        {
            DetalleRevision obj = new DetalleRevision();

            obj.Id_funcion_licenciado = 1;
            obj.Id_licenciado = 1;
            obj.Id_revision = 1;
            obj.Insert();
        }
        [TestMethod]
        public void BUGD003()
        {
            Institucion i = new Institucion();
            CarreraLicenciado cl = new CarreraLicenciado();
            Licenciado obj = new Licenciado();

            i.Nombre = "institucionx";
            i.Insert();
            cl.Nombre = "carrera12356";
            cl.Insert();


            obj.Nombre = "licenciado 1";
            obj.Apellido = "apellido1";
            obj.Descripcion = "descripcion";
            obj.Email = "email@example.com";
            obj.Telefono = "777773";
            obj.Celular = "6555465";
            obj.Tipo = "externo"; //interno o externo
            obj.Docente = 0;// 0 no 1 si

            obj.Id_institucion_representada = 1;
            obj.Id_carrera_licenciado = 1 ;
            obj.Insert();
        }
        [TestMethod]
        public void TestMethod6()
        {
            CapaNegocio.ValidationInputUI obj = new CapaNegocio.ValidationInputUI();
            string s = "s";

            Object[] lista = new Object[] { "string1", 1, 1, 2,s};

            obj.Validation(lista);
        }
        [TestMethod]
        public void TestMethod7()
        {
            CapaNegocio.NegocioNuevoPerfil obj = new CapaNegocio.NegocioNuevoPerfil();
            string s = "s/3s";

            Object[] lista = new Object[] { "string1", 1, 1, 2, s };

            obj.ControlInput(lista);
        }
        [TestMethod]
        public void TestMethod8()
        {
            CapaNegocio.src.DataTypes type = new CapaNegocio.src.DataTypes();
            //type.Texto = "s/3s";
            // Console.WriteLine(type.Texto);

            type.Registro = "510687a";
            Console.WriteLine(type.Registro);

        }

        [TestMethod]
        public void TestMethod9()
        {
            CapaNegocio.NegocioNuevoPerfil obj = new CapaNegocio.NegocioNuevoPerfil();
            //type.Texto = "s/3s";
            // Console.WriteLine(type.Texto);
            string registro = "551561";//input 0
            string nombre = "perfilnom";//input 1
            string apellido = "perfilape";//input 2
            string email = "email@examplle.com";//input 3
            string telefono = "333536";//input 4
            string celular = "77747421";//input 5
            int id = 1;//input 6

            string tema = "tema de tesis";//input 7
            string fecha_aprobacion = "24/05/2020";//input 8
            string fecha_recep = "28/05/2020";//input 9
            int id_licenciado = 1 ;//input 10





            Object[] datos = new Object[] {registro,nombre ,apellido,email,telefono,celular,id,tema,fecha_aprobacion,fecha_recep,id_licenciado};

            obj.ControlInput(datos);
            obj.Main();
        }
        [TestMethod]
        public void TestMethod10()
        {
            Estudiante obj = new Estudiante();
            //type.Texto = "s/3s";
            // Console.WriteLine(type.Texto);

            int i = obj.LastId();
            Console.WriteLine(Convert.ToString(i));

        }
        [TestMethod]
        public void TestMethod11()
        {
            FuncionLicenciado obj = new FuncionLicenciado();
            //type.Texto = "s/3s";
            // Console.WriteLine(type.Texto);

            string c = "Tutor";
            string  i = Convert.ToString(obj.FindIdBySearch(c));


            Console.WriteLine(i);


        }

    }
}
