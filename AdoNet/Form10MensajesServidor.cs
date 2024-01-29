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

#region PROCEDIMIENTOS ALMACENADOS

//create procedure SP_DEPARTAMENTOS
//as
//	select * from DEPT
//go
//create procedure SP_INSERT_DEPARTAMENTO
//(@IDDEPARTAMENTO int, @NOMBRE nvarchar(50), @LOCALIDAD nvarchar(50))
//as
//	insert into DEPT values (@IDDEPARTAMENTO, @NOMBRE, @LOCALIDAD)
//go

#endregion

namespace AdoNet
{
    public partial class Form10MensajesServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form10MensajesServidor()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            //CREAMOS UN EVENTO PARA CAPTURAR LOS MENSAJES DEL SERVER
            this.cn.InfoMessage += Cn_InfoMessage;
            this.LoadDepartamentos();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblMensajesServidor.Text = e.Message;
        }

        private void LoadDepartamentos()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_DEPARTAMENTOS";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstDepartamentos.Items.Clear();
            while (this.reader.Read())
            {
                string num = this.reader["DEPT_NO"].ToString();
                string nombre = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();
                this.lstDepartamentos.Items.Add(num + " - " + nombre + " " + localidad);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnInsertarDepartamento_Click(object sender, EventArgs e)
        {
            this.lblMensajesServidor.Text = "";
            int id = int.Parse(this.txtNumero.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            SqlParameter pamId = new SqlParameter("@IDDEPARTAMENTO", id);
            SqlParameter pamNombre = new SqlParameter("@NOMBRE", nombre);
            SqlParameter pamLocalidad = new SqlParameter("@LOCALIDAD", localidad);
            this.com.Parameters.Add(pamId);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamLocalidad);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_INSERT_DEPARTAMENTO";
            this.cn.Open();
            int insertados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            MessageBox.Show("Departamentos insertados: " + insertados);
            this.LoadDepartamentos();
        }
    }
}
