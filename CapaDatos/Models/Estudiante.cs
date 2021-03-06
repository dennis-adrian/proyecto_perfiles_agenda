﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    public class Estudiante : Conexion
    {
        public Estudiante()
        {
            id = 0;
            registro = "";
            nombre = "";
            apellido = "";
            email = "";
            telefono = "";
            celular = "";
            id_carrera = 0;
        }
        #region Atributos
        private int id;
        private string registro;
        private string nombre;
        private string apellido;
        private string email;
        private string telefono;
        private string celular;
        private int id_carrera;
        private int id_tesis;
        private int id_titulacion_otro;
        private static string table_name = "estudiante";

        #endregion
        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Registro { get => registro; set => registro = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Celular { get => celular; set => celular = value; }
        public int Id_carrera { get => id_carrera; set => id_carrera = value; }
        public int Id_tesis { get => id_tesis; set => id_tesis = value; }
        public int Id_titulacion_otro { get => id_titulacion_otro; set => id_titulacion_otro = value; }

        #endregion
        #region Metodos

        public void Insert()
        {
            string sql = $"  INSERT INTO {table_name} (  registro,nombre, apellido,email,telefono, celular,id_carrera  ) VALUES ( @parametro0,@parametro1,@parametro2,@parametro3,@parametro4,@parametro5,@parametro6); ";
            Object[] Parametros = new Object[] { Registro, Nombre, Apellido, Email, Telefono, Celular, Id_carrera };
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
            string mod = modificadoDate();
            string sql = $" UPDATE {table_name}  SET modificado_en = '{mod}',  registro = @parametro0 ,nombre = @parametro1, apellido=@parametro2 ,email = @parametro3 ,telefono = @parametro4 , celular = @parametro5 ,id_carrera = @parametro6   WHERE id = @parametro7 ; ";

            Object[] Parametros = new Object[] { Registro, Nombre, Apellido, Email, Telefono, Celular, Id_carrera, id };
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
        public DataTable FindById(int Id)
        {
            string sql = $" SELECT * FROM {table_name} WHERE id = {Id}  ;";

            return SelectConexion(sql);

        }
        #endregion
    }
}
