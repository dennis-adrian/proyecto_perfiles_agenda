﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace CapaDatos
{
    public class Conexion
    {
        #region Atributos

        private SQLiteConnection cnx;
        private string pathBd;
        private string ENV = "dev";

        #endregion
        #region Propiedades
        public string PathBd { get => pathBd; set => pathBd = value; }
        public SQLiteConnection Cnx { get => cnx; set => cnx = value; }

        #endregion


        public Conexion()
        {
            determinarConexion();
        }

        #region Metodos

        public void determinarConexion()
        {
            string dev = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\"));
            string prod = @"C:\Perfiles\";
            string pathBd = ENV == "dev" ? dev : prod;
            cnx = new SQLiteConnection("data source=" + pathBd + @"bd\perfiles.db;foreign keys=true;");
        }
        public SQLiteConnection AbrirConexion()
        {
            if (cnx.State == ConnectionState.Closed)
            {
                cnx.Open();

            }
            return cnx;
        }
        public SQLiteConnection cerrarConexion()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();

            }
            return cnx;

        }

        public void QueryBuilder(string sql, Object[] Parametros)
        {
            try
            {
                SQLiteConnection cnx = AbrirConexion();
                SQLiteTransaction sqlTransaction = cnx.BeginTransaction();
                SQLiteCommand command = cnx.CreateCommand();
                command.CommandText = sql;

                for (int i = 0; i < Parametros.Length; i++)
                {
                    string parametro = "@parametro" + Convert.ToString(i);
                    command.Parameters.Add(new SQLiteParameter(parametro, Parametros[i]));
                }

                int filas = command.ExecuteNonQuery();
                if (filas > 0)
                {
                    sqlTransaction.Commit();
                    cerrarConexion();

                }
                else
                {
                    throw new ArgumentException("datos no afectados");
                }

            }
            catch (Exception e)
            {
                throw new ArgumentException("Error en  QueryBuilder: " + e.Message);
            }
            finally
            {
                cerrarConexion();
            }

        }
        public void execQuery(string sql)
        {
            try
            {
                SQLiteConnection cnx = AbrirConexion();
                SQLiteTransaction sqlTransaction = cnx.BeginTransaction();
                SQLiteCommand command = new SQLiteCommand(cnx);
                command.CommandText = sql;
                int filas = command.ExecuteNonQuery();
                if (filas > 0)
                {
                    sqlTransaction.Commit();
                    cerrarConexion();

                }
                else
                {
                    throw new ArgumentException("datos no afectados");
                }

            }
            catch (Exception e)
            {
                throw new ArgumentException("Error en  ExecQuery: " + e.Message);
            }
            finally
            {
                cerrarConexion();
            }

        }
        public DataTable SelectConexion(string sql)
        {

            try
            {
                SQLiteConnection cnx = AbrirConexion();
                SQLiteCommand command = cnx.CreateCommand();
                command.CommandText = sql;
                DataTable items = new DataTable();
                items.Load(command.ExecuteReader());

                //cerrarConexion();
                return items;
            }
            catch (Exception e)
            {
                throw new ArgumentException("Error en  Select conexion"+ e);
            }
            finally
            {
                cerrarConexion();
            }
        }
        public DataTable SelectConexion(string sql, string parametro0)
        {
            try
            {
                SQLiteConnection cnx = AbrirConexion();
                SQLiteCommand command = cnx.CreateCommand();
                command.CommandText = sql;
                command.Parameters.Add(new SQLiteParameter("@parametro0", parametro0));

                DataTable items = new DataTable();
                items.Load(command.ExecuteReader());

                cerrarConexion();
                return items;
            }
            catch (Exception e)
            {
                throw new ArgumentException("Error  en  Select conexion over2" + e);
            }
            finally
            {
                cerrarConexion();
            }

        }
        public DataTable SelectConexion(string sql, string parametro0, string parametro1)
        {
            try
            {
                SQLiteConnection cnx = AbrirConexion();
                SQLiteCommand command = cnx.CreateCommand();
                command.CommandText = sql;
                command.Parameters.Add(new SQLiteParameter("@parametro0", parametro0));
                command.Parameters.Add(new SQLiteParameter("@parametro1", parametro1));
                DataTable items = new DataTable();
                items.Load(command.ExecuteReader());

                cerrarConexion();
                return items;
            }
            catch(Exception e)
            {
                throw new ArgumentException("Error  en  Select conexion over3"+e);
            }
            finally
            {
                cerrarConexion();
            }

        }


        public int LastIdConexion(string tabla)
        {


            string sql = "SELECT * FROM " + tabla + " WHERE ID = (SELECT MAX(ID) FROM " + tabla + ");";

            try
            {
                int last = 0;
                SQLiteConnection cnx = AbrirConexion();
                SQLiteCommand cmd = new SQLiteCommand(sql, cnx);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    last = reader.GetInt32(0);

                }
                cerrarConexion();
                return last;
            }
            catch
            {
                throw new ArgumentException("Error al obtener el ultimo registro");
            }
            finally
            {
                cerrarConexion();
            }
        }
        public int FindIdBySearchConexion(string sql)
        {


            try
            {
                int findId = 0;
                SQLiteConnection cnx = AbrirConexion();
                SQLiteCommand command = cnx.CreateCommand();
                command.CommandText = sql;

                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    findId = reader.GetInt32(0);

                }
                cerrarConexion();
                return findId;
            }
            catch
            {
                throw new ArgumentException("Error");
            }
            finally
            {
                cerrarConexion();
            }
        }

        public string modificadoDate()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        #endregion



    }
}
