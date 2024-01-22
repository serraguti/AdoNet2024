using System;
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
    public partial class Form05DepartamentosEmpleados : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form05DepartamentosEmpleados()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadDepartamentos();
        }

        private void LoadDepartamentos()
        {
            string sql = "select DNOMBRE from DEPT";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.lstDepartamentos.Items.Add(this.reader["DNOMBRE"].ToString());
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select EMP.APELLIDO from EMP " +
                " inner join DEPT on EMP.DEPT_NO = DEPT.DEPT_NO "
                + " where DEPT.DNOMBRE=@nombredepartamento";
            string nombreDepartamento = this.lstDepartamentos.SelectedItem.ToString();
            SqlParameter pamnombre =
                new SqlParameter("@nombredepartamento", nombreDepartamento);
            this.com.Parameters.Add(pamnombre);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                this.lstEmpleados.Items.Add(this.reader["APELLIDO"].ToString());
            }
            this.reader.Close();
            this.com.Parameters.Clear();
            this.cn.Close();
        }

        private void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select OFICIO, SALARIO from EMP " +
                " where APELLIDO=@apellido";
            string apellido = this.lstEmpleados.SelectedItem.ToString();
            SqlParameter pamapellido =
                new SqlParameter("@apellido", apellido);
            this.com.Parameters.Add(pamapellido);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();
            this.txtOficio.Text = this.reader["OFICIO"].ToString();
            this.txtSalario.Text = this.reader["SALARIO"].ToString();
            this.reader.Close();
            this.com.Parameters.Clear();
            this.cn.Close();
        }

        private void btnModificarDatos_Click(object sender, EventArgs e)
        {
            string sql = "update EMP set OFICIO=@oficio " 
                + ", SALARIO=@salario " 
                + " where APELLIDO=@apellido";
            string oficio = this.txtOficio.Text;
            int salario = int.Parse(this.txtSalario.Text);
            string apellido = this.lstEmpleados.SelectedItem.ToString();
            SqlParameter pamapellido =
                new SqlParameter("@apellido", apellido);
            SqlParameter pamoficio =
                new SqlParameter("@oficio", oficio);
            SqlParameter pamsalario =
                new SqlParameter("@salario", salario);
            this.com.Parameters.Add(pamsalario);
            this.com.Parameters.Add(pamoficio);
            this.com.Parameters.Add(pamapellido);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int updates = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            MessageBox.Show("Modificados " + updates);
        }
    }
}
