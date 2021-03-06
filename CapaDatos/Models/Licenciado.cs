﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public  class Licenciado : Conexion, IMetodos
    {
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
        private int id;
        private string nombre;
        private string apellido;
        private string descripcion;
        private string email;
        private string telefono;
        private string celular;
        private string tipo;
        private int docente;
        private int id_institucion_representada;
        private int id_carrera_licenciado;
        private static string table_name = "licenciado";
        #endregion
        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Docente { get => docente; set => docente = value; }
        public int Id_institucion_representada { get => id_institucion_representada; set => id_institucion_representada = value; }
        public int Id_carrera_licenciado { get => id_carrera_licenciado; set => id_carrera_licenciado = value; }
        #endregion
        #region Metodos
        public void Insert()
        {
            string idInstitucion = Id_institucion_representada == 0 ? null: Convert.ToString(id_institucion_representada);
            string idCarrera = id_carrera_licenciado == 0 ? null : Convert.ToString(id_carrera_licenciado);
            string sql = $"  INSERT INTO " + table_name + " (  nombre,apellido,descripcion,email,telefono,celular,tipo,docente,id_institucion_representada,id_carrera_licenciado  ) VALUES ( @parametro0, @parametro1, @parametro2, @parametro3, @parametro4, @parametro5, @parametro6,@parametro7,@parametro8,@parametro9); ";
            Object[] Parametros = new Object[] { Nombre,Apellido,Descripcion,Email,Telefono,Celular,Tipo,Docente, idInstitucion , idCarrera };
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

            string idInstitucion = Id_institucion_representada == 0 ? null : Convert.ToString(id_institucion_representada);
            string idCarrera = id_carrera_licenciado == 0 ? null : Convert.ToString(id_carrera_licenciado);

            string sql = $" UPDATE {table_name}  SET  nombre = @parametro0 ,apellido = @parametro1, descripcion = @parametro2 , email = @parametro3 , telefono = @parametro4 , celular = @parametro5, tipo = @parametro6, docente = @parametro7,id_institucion_representada = @parametro8  ,id_carrera_licenciado = @parametro9   WHERE id = @parametro10 ; ";
            Object[] Parametros = new Object[] { Nombre, Apellido, Descripcion, Email, Telefono, Celular, Tipo ,Docente, idInstitucion, idCarrera, id };
            QueryBuilder(sql, Parametros);

        }

        public DataTable Select()
        {
            string sql = $" SELECT * FROM {table_name} ; ";
            return SelectConexion(sql);
        }
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
