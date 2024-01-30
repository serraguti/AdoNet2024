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
    public class RepositoryParametrosSalida
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryParametrosSalida()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<string> GetDepartamentos()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_DEPARTAMENTOS";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<string> departamentos = new List<string>();
            while (this.reader.Read())
            {
                departamentos.Add(this.reader["DNOMBRE"].ToString());
            }
            this.reader.Close();
            this.cn.Close();
            return departamentos;
        }

        public ResumenEmpleados 
            GetResumenEmpleados(string nombreDepartamento)
        {
            SqlParameter pamNombre = new SqlParameter("@NOMBRE", nombreDepartamento);
            this.com.Parameters.Add(pamNombre);
            //UN PARAMETRO DE SALIDA NO LLEVA VALOR, SINO QUE RECUPERAMOS SU VALOR
            //DEL PROCEDIMIENTO
            SqlParameter pamSuma = new SqlParameter();
            pamSuma.Value = 0;
            pamSuma.ParameterName = "@suma";
            //DEBEMOS INDICAR LA DIRECCION DEL PARAMETRO
            pamSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamSuma);
            SqlParameter pamMedia = new SqlParameter();
            pamMedia.Value = 0;
            pamMedia.ParameterName = "@media";
            pamMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamMedia);
            SqlParameter pamPersonas = new SqlParameter();
            pamPersonas.Value = 0;
            pamPersonas.ParameterName = "@personas";
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamPersonas);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_EMPLEADOS_DEPARTAMENTO";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            ResumenEmpleados resumen = new ResumenEmpleados();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                resumen.Apellidos.Add(apellido);
            }
            this.reader.Close();
            //ALMACENAMOS LOS PARAMETROS
            int suma = int.Parse(pamSuma.Value.ToString());
            int media = int.Parse(pamMedia.Value.ToString());
            int personas = int.Parse(pamPersonas.Value.ToString());

            resumen.SumaSalarial = suma;
            resumen.MediaSalarial = media;
            resumen.Personas = personas;

            this.cn.Close();
            this.com.Parameters.Clear();
            return resumen;
        }
    }
}
