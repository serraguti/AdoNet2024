﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form02BuscadorEmpleados : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form02BuscadorEmpleados()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023;";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            int salario = int.Parse(this.txtSalario.Text);
            string sql = "select * from EMP where SALARIO >= " + salario;
            //SIEMPRE QUE TRABAJEMOS CON ACCESO A DATOS SE UTILIZA
            //EL METODO ENTRAR--SALIR
            //DEBEMOS ABRIR LA CONEXION, UTILIZAR TODO LO QUE NECESITEMOS
            //Y POSTERIORMENTE CERRAR TODOS LOS RECURSOS UTILIZADOS
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string sal = this.reader["SALARIO"].ToString();
                this.lstEmpleados.Items.Add(apellido + " - " + sal);
            }
            //LIBERAMOS TODOS LOS RECURSOS
            this.reader.Close();
            this.cn.Close();
        }

        private void btnBuscarOficio_Click(object sender, EventArgs e)
        {
            string oficio = this.txtOficio.Text;
            string sql = "select * from EMP where OFICIO ='" + oficio + "'";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string ofi = this.reader["OFICIO"].ToString();
                this.lstEmpleados.Items.Add(apellido + " - " + ofi);
            }
            this.reader.Close();
            this.cn.Close();
        }
    }
}
