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
           
            Licenciado obj = new Licenciado();

         


            obj.Nombre = "licenciadooo ";
            obj.Apellido = "apellidooo";
            obj.Descripcion = "descripcion";
            obj.Email = "email@example.com";
            obj.Telefono = "777773";
            obj.Celular = "6555465";
            obj.Tipo = "externo"; //interno o externo
            obj.Docente = 2;// 2 no 1 si

            obj.Id_institucion_representada = 1;
            obj.Id_carrera_licenciado = 1 ;
            obj.Update(1);
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
            string registro = "646581";//input 0
            string nombre = "nombredebug";//input 1
            string apellido = "ape";//input 2
            string email = "emaisdl@sesedampls.com";//input 3
            string telefono = "333536";//input 4
            string celular = "77747421";//input 5
            int id = 1;//input 6

            string tema = "tema de tesiss";//input 7
            string fecha_aprobacion = "24-05-2020";//input 8
            string fecha_recep = "28-05-2020";//input 9
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
        [TestMethod]
        public void TestMethod12()
        {
            CapaNegocio.NegocioLicenciados obj = new CapaNegocio.NegocioLicenciados();

           


            string n = "licccccccxyz";
            string a = "licapellixdo";
            string d = "licdecripcion";
            string e = "mickxccccd@exampllee.com";
            string t = "3566778";
            string c ="77975878";
            string ti = "interno";
            int doc = 1;
            int ii = 1;
            int ic = 1;



            Object[] datos = new Object[] { n, a, d, e, t, c, ti, doc, ii, ic };

            obj.ControlInput(datos);



        }
        [TestMethod]
        public void TestMethod13()
        {

            CapaNegocio.src.DataTypes type = new CapaNegocio.src.DataTypes();

            type.Aula = "SS000";
            Console.WriteLine(type.Aula);



        }
        [TestMethod]
        public void TestMethod14()
        {

            CapaNegocio.src.DataTypes type = new CapaNegocio.src.DataTypes();

            type.Texto2 = "Hola";
            Console.WriteLine(type.Texto2);



        }
        [TestMethod]
        public void TestMethod15()
        {

            TipoTitulacionOtros obj = new TipoTitulacionOtros();

            obj.Select();



        }
        [TestMethod]
        public void TestMethod16()
        {

            TitulacionOtros obj = new TitulacionOtros();

            obj.Select();



        }
        [TestMethod]
        public void Test1()
        {
            CapaNegocio.NegocioRevisiones obj = new CapaNegocio.NegocioRevisiones();
            bool res1 = obj.ValidarFechasTribunal(1, 1);
            bool res2 = obj.ValidarFechaEmpasteTribunal(1, 1);
            if (res1 ==  true && res2 == true)
            {
                Console.WriteLine("tienes las fechas asignadas y la fecha de empaste tambien");
            }
            else if(res1 == true)
            {
                
                Console.WriteLine("no hay fecha de empaste");

                
            }
            else
            {
                Console.WriteLine("las fechas estan incompletas");

            }

        }
        [TestMethod]
        public void Test2()
        {
            CapaNegocio.NegocioRevisiones obj = new CapaNegocio.NegocioRevisiones();
            bool res1 = obj.ValidarFechasEmpasteforNewInsert(1, 1, 2);
            if (res1 == true )
            {
                Console.WriteLine("puedes hacer el insert");
            }
            else
            {
                Console.WriteLine("no puedes hace un insert");

            }

        }


    }
}
