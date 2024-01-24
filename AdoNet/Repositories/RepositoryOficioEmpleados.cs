using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Repositories
{
    public class RepositoryOficioEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryOficioEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<string> GetOficios()
        {
            string sql = "select distinct OFICIO from EMP";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<string> oficios = new List<string>();
            while (this.reader.Read())
            {
                oficios.Add(this.reader["OFICIO"].ToString());
            }
            this.reader.Close();
            this.cn.Close();
            return oficios;
        }

        public List<string> GetEmpleadosOficio(string oficio)
        {
            string sql = "select * from EMP where OFICIO=@oficio";
            SqlParameter pamOficio = new SqlParameter("@oficio", oficio);
            this.com.Parameters.Add(pamOficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<string> apellidos = new List<string>();
            while (this.reader.Read())
            {
                apellidos.Add(this.reader["APELLIDO"].ToString());
            }
            this.reader.Close();
            this.com.Parameters.Clear();
            this.cn.Close();
            return apellidos;
        }

        public DatosEmpleadosOficio 
            GetDatosEmpleadosOficio(string oficio)
        {
            string sql = "select SUM(SALARIO) as SUMASALARIAL, " 
                + " AVG(SALARIO) AS MEDIASALARIAL, "
                + " MIN(SALARIO) AS MINIMOSALARIO, "
                + " OFICIO from EMP "
                + " group by OFICIO having OFICIO=@OFICIO";
            SqlParameter pamOficio = new SqlParameter("@OFICIO", oficio);
            this.com.Parameters.Add(pamOficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();
            int sumaSalarial = int.Parse(this.reader["SUMASALARIAL"].ToString());
            int mediaSalarial = int.Parse(this.reader["MEDIASALARIAL"].ToString());
            int minimoSalario = int.Parse(this.reader["MINIMOSALARIO"].ToString());
            DatosEmpleadosOficio datos = new DatosEmpleadosOficio();
            datos.SumaSalarial = sumaSalarial;
            datos.MediaSalarial = mediaSalarial;
            datos.MinimoSalario = minimoSalario;
            this.reader.Close();
            this.com.Parameters.Clear();
            this.cn.Close();
            return datos;
        }


        public int GetSumaSalarialOficio(string oficio)
        {
            string sql = "select SUM(SALARIO) as SUMASALARIAL, "
                + " OFICIO from EMP "
                + " group by OFICIO having OFICIO=@OFICIO";
            SqlParameter pamOficio = new SqlParameter("@OFICIO", oficio);
            this.com.Parameters.Add(pamOficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();
            int sumaSalarial = int.Parse(this.reader["SUMASALARIAL"].ToString());
            this.reader.Close();
            this.com.Parameters.Clear();
            this.cn.Close();
            return sumaSalarial;
        }

        public int IncrementarSalarioOficio(string oficio, int incremento)
        {
            string sql = "update EMP set SALARIO=SALARIO + @incremento "
                + " where OFICIO=@oficio";
            SqlParameter pamIncremento =
                new SqlParameter("@incremento", incremento);
            SqlParameter pamOficio =
                new SqlParameter("@oficio", oficio);
            this.com.Parameters.Add(pamIncremento);
            this.com.Parameters.Add(pamOficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int results = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return results;
        }
    }
}
