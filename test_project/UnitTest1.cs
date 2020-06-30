﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDatos.Models;
using System.Data.SQLite;

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
            obj.ValidateInput(objeto);
        }
        [TestMethod]
        public void TestMethod4()
        {
            CapaNegocio.src.Email obj = new CapaNegocio.src.Email();
            obj.Direccion = "emaisadas111l@example.com";
            Console.WriteLine(obj.Direccion);
        }
        [TestMethod]
        public void TestMethod5()
        {
            CapaNegocio.src.Numero obj = new CapaNegocio.src.Numero();
            obj.Telefono = "336565";
            Console.WriteLine(obj.Telefono);
        }
        [TestMethod]
        public void TestMethod6()
        {
            CapaNegocio.src.Numero obj = new CapaNegocio.src.Numero();
            obj.Celular = "336565";
            Console.WriteLine(obj.Celular);
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

    }
}
