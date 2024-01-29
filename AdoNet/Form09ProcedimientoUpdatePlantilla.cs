using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


#region PROCEDIMIENTOS ALMACENADOS

//create procedure SP_HOSPITALES
//as
//	select * from HOSPITAL
//GO
//create procedure SP_UPDATE_PLANTILLA_HOSPITAL
//(@NOMBREHOSPITAL nvarchar(50))
//as
//	declare @codigohospital int
//	select @codigohospital = HOSPITAL_COD from HOSPITAL
//	where NOMBRE=@NOMBREHOSPITAL
//	update PLANTILLA set SALARIO = SALARIO + 1
//	where HOSPITAL_COD=@codigohospital
//	select * from PLANTILLA where HOSPITAL_COD=@codigohospital
//go

#endregion

namespace AdoNet
{
    public partial class Form09ProcedimientoUpdatePlantilla : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form09ProcedimientoUpdatePlantilla()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_HOSPITALES";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.cmbHospitales.Items.Add
                    (this.reader["NOMBRE"].ToString());
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnModificarSalarios_Click(object sender, EventArgs e)
        {
            string nombre = this.cmbHospitales.SelectedItem.ToString();
            SqlParameter pamNombre =
                new SqlParameter("@NOMBREHOSPITAL", nombre);
            this.com.Parameters.Add(pamNombre);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_UPDATE_PLANTILLA_HOSPITAL";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstPlantilla.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string funcion = this.reader["FUNCION"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                this.lstPlantilla.Items.Add(apellido + " " + funcion + " " + salario);
            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int valor = random.Next(1, 4);
            this.label1.Text = valor.ToString();
        }
    }
}
