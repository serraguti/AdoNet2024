using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AdoNet.Helpers;

namespace AdoNet
{
    public partial class Form01PrimerAdo : Form
    {
        //DECLARAMOS TODOS LOS OBJETOS DE ACCESO A DATOS
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form01PrimerAdo()
        {
            InitializeComponent();
            this.connectionString = HelperConfiguration.GetConnectionString();
            this.cn = new SqlConnection(this.connectionString);
            //VAMOS A RECUPERAR UN EVENTO DE LA CONEXION PARA QUE NOS 
            //INDIQUE SU CAMBIO DE ESTADO
            this.cn.StateChange += Cn_StateChange;
            this.com = new SqlCommand();
        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblMensaje.Text = "La conexión está pasando de " + e.OriginalState
                + " a " + e.CurrentState;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
            }
            this.lblMensaje.BackColor = Color.LightGreen;


            //try
            //{
            //    if (this.cn.State == ConnectionState.Closed)
            //    {
            //        this.cn.Open();
            //    }
            //    this.lblMensaje.BackColor = Color.LightGreen;
            //}
            //catch (SqlException ex)
            //{
            //    this.lblMensaje.Text = "Excepción SQL. "
            //        + ex.ToString();
            //    this.lblMensaje.BackColor = Color.Red;
            //}
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblMensaje.BackColor = Color.LightCoral;
        }

        private void btnLeerDatos_Click(object sender, EventArgs e)
        {
            //INDICAMOS LA CONEXION QUE UTILIZARA EL COMMAND
            this.com.Connection = this.cn;
            //CREAMOS LA CONSULTA A REALIZAR
            string sql = "select * from EMP";
            //INDICAMOS EL TIPO DE CONSULTA A EJECUTAR EN EL COMMAND
            this.com.CommandType = CommandType.Text;
            //INDICAMOS AL COMMAND LA CONSULTA 
            this.com.CommandText = sql;
            //AQUI LA CONEXION DEBE ESTAR ABIERTA
            //EJECUTAMOS LA CONSULTA DE SELECCION EN EL COMMAND
            //DICHO METODO NOS DEVUELVE UN OBJETO DATAREADER
            this.reader = this.com.ExecuteReader();
            //LEEMOS EL NOMBRE DE LA PRIMERA COLUMNA
            for (int i = 0; i < this.reader.FieldCount; i++)
            {
                string columna = this.reader.GetName(i);
                string tipoDato = this.reader.GetDataTypeName(i);
                this.lstColumnas.Items.Add(columna);
                this.lstTiposDato.Items.Add(tipoDato);
            }

            //LEEMOS UN REGISTRO
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstApellidos.Items.Add(apellido);
            }
            //SIEMPRE DEBEMOS CERRAR EL READER DESPUES DE LEER
            this.reader.Close();
        }
    }
}
