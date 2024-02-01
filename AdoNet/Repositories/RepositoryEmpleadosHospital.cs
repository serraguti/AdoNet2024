using AdoNet.Helpers;
using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region PROCEDIMIENTOS VISTAS SQL
//alter view V_DOCTORES_PLANTILLA
//as
//	select DOCTOR_NO AS IDEMPLEADO, APELLIDO, DOCTOR.SALARIO, DOCTOR.HOSPITAL_COD 
//	from DOCTOR 
//	union
//	select EMPLEADO_NO, apellido, salario, HOSPITAL_COD from plantilla 
//go

//alter procedure SP_DOCTORES_PLANTILLA_HOSPITAL
//(@nombre nvarchar(50)
//, @suma int OUT, @media int OUT, @personas int OUT)
//as
//	declare @idhospital int
//	select @idhospital = HOSPITAL_COD from HOSPITAL
//	where NOMBRE = @nombre
//	select * from V_DOCTORES_PLANTILLA
//	where HOSPITAL_COD=@idhospital
//	select @suma = sum(SALARIO), @media = avg(SALARIO),
//    @personas = count(IDEMPLEADO)
//	from V_DOCTORES_PLANTILLA
//	where HOSPITAL_COD=@idhospital
//go
#endregion

namespace AdoNet.Repositories
{
    public class RepositoryEmpleadosHospital
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryEmpleadosHospital()
        {
            string connectionString = HelperConfiguration.GetConnectionString();
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<string> GetHospitales()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_HOSPITALES";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<string> hospitales = new List<string>();
            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                hospitales.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
            return hospitales;
        }

        public DatosHospital GetDatosHospital(string nombreHospital)
        {
            SqlParameter pamNombre = new SqlParameter("@nombre", nombreHospital);
            SqlParameter pamSuma = new SqlParameter("@suma", 0);
            pamSuma.Direction = ParameterDirection.Output;
            SqlParameter pamMedia = new SqlParameter("@media", 0);
            pamMedia.Direction = ParameterDirection.Output;
            SqlParameter pamPersonas = new SqlParameter("@personas", 0);
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamSuma);
            this.com.Parameters.Add(pamMedia);
            this.com.Parameters.Add(pamPersonas);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_DOCTORES_PLANTILLA_HOSPITAL";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<EmpleadoHospital> empleados = new List<EmpleadoHospital>();
            while (this.reader.Read())
            {
                int id = int.Parse(this.reader["IDEMPLEADO"].ToString());
                string apellido = this.reader["APELLIDO"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                string oficio = this.reader["OFICIO"].ToString();
                EmpleadoHospital empleado = new EmpleadoHospital();
                empleado.IdEmpleado = id;
                empleado.Apellido = apellido;
                empleado.Salario = salario;
                empleado.Oficio = oficio;
                empleados.Add(empleado);
            }
            this.reader.Close();
            int suma = int.Parse(pamSuma.Value.ToString());
            int media = int.Parse(pamMedia.Value.ToString());
            int personas = int.Parse(pamPersonas.Value.ToString());
            this.cn.Close();
            this.com.Parameters.Clear();
            DatosHospital datos = new DatosHospital();
            datos.Empleados = empleados;
            datos.SumaSalarial = suma;
            datos.MediaSalarial = media;
            datos.Personas = personas;
            return datos;
        }
    }
}
