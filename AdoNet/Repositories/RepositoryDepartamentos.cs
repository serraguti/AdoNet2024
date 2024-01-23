﻿using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Repositories
{
    public class RepositoryDepartamentos
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        //QUIERO REALIZAR UN CRUD SOBRE DEPARTAMENTOS
        //ME GUSTARIA DIBUJAR LOS DEPARTAMENTOS.
        //BUSCAR LOS DEPARTAMENTOS
        //INSERT, DELETE, UPDATE

        public RepositoryDepartamentos()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        //METODO PARA RECUPERAR TODOS LOS DEPARTAMENTOS
        public List<Departamento> GetDepartamentos()
        {
            string sql = "select * from DEPT";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            //DEBEMOS CREAR LA COLECCION PARA DEVOLVER
            //LOS DEPARTAMENTOS
            List<Departamento> departamentos = new List<Departamento>();
            while (this.reader.Read()) {
                int id = int.Parse(this.reader["DEPT_NO"].ToString());
                string nombre = this.reader["DNOMBRE"].ToString();
                string loc = this.reader["LOC"].ToString();
                Departamento dept = new Departamento();
                dept.IdDepartamento = id;
                dept.Nombre = nombre;
                dept.Localidad = loc;
                departamentos.Add(dept);
            }
            this.reader.Close();
            this.cn.Close();
            return departamentos;
        }

        public Departamento FindDepartamento(int idDepartamento)
        {
            string sql = "select * from DEPT where DEPT_NO=@id";
            SqlParameter pamId = new SqlParameter("@id", idDepartamento);
            this.com.Parameters.Add(pamId);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();
            int id = int.Parse(this.reader["DEPT_NO"].ToString());
            string nombre = this.reader["DNOMBRE"].ToString();
            string loc = this.reader["LOC"].ToString();
            Departamento departamento = new Departamento();
            departamento.IdDepartamento = id;
            departamento.Nombre = nombre;
            departamento.Localidad = loc;
            this.reader.Close();
            this.com.Parameters.Clear();
            this.cn.Close();
            return departamento;
        }

        public int InsertarDepartamento
            (int id, string nombre, string localidad) 
        {
            string sql = "insert into DEPT values(@id, @nombre, @localidad)";
            SqlParameter pamId =
                new SqlParameter("@id", id);
            SqlParameter pamNombre =
                new SqlParameter("@nombre", nombre);
            SqlParameter pamLocalidad =
                new SqlParameter("@localidad", localidad);
            this.com.Parameters.Add(pamId);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamLocalidad);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int results = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return results;
        }

        public int ModificarDepartamento(int id, string nombre, string localidad)
        {
            string sql = "update DEPT set DNOMBRE=@nombre, LOC=@localidad "
                + " where DEPT_NO=@id";
            SqlParameter pamId = new SqlParameter("@id", id);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            SqlParameter pamLocalidad = new SqlParameter("@localidad", localidad);
            this.com.Parameters.Add(pamId);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamLocalidad);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int resultados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return resultados;
        }

        public int EliminarDepartamento(int idDepartamento)
        {
            string sql = "delete from DEPT where DEPT_NO=@iddepartamento";
            SqlParameter pamId = new SqlParameter("@iddepartamento", idDepartamento);
            this.com.Parameters.Add(pamId);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int deleted = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return deleted;
        }
    }
}
