using AdoNet.Models;
using AdoNet.Repositories;
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

//create procedure SP_EMPLEADOS_DEPARTAMENTO
//(@NOMBRE nvarchar(50)
//, @suma int OUT
//, @media int OUT
//, @personas int OUT)
//as
//	declare @iddepartamento int
//	select @iddepartamento = DEPT_NO from DEPT
//	where DNOMBRE=@NOMBRE
//	select * from EMP where DEPT_NO=@iddepartamento
//	select @suma = sum(SALARIO), @media = avg(SALARIO),
//    @personas = count(EMP_NO) from EMP
//	where DEPT_NO=@iddepartamento
//go

#endregion

namespace AdoNet
{
    public partial class Form11ParametrosSalida : Form
    {
        RepositoryParametrosSalida repo;

        public Form11ParametrosSalida()
        {
            InitializeComponent();
            this.repo = new RepositoryParametrosSalida();
            this.LoadDepartamentos();
        }

        private void LoadDepartamentos()
        {
            List<string> departamentos = this.repo.GetDepartamentos();
            foreach (string data in departamentos)
            {
                this.cmbDepartamentos.Items.Add(data);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string nombre = this.cmbDepartamentos.SelectedItem.ToString();
            ResumenEmpleados resumen =
                this.repo.GetResumenEmpleados(nombre);
            this.lstEmpleados.Items.Clear();
            foreach (string ape in resumen.Apellidos)
            {
                this.lstEmpleados.Items.Add(ape);
            }
            this.txtSuma.Text = resumen.SumaSalarial.ToString();
            this.txtMedia.Text = resumen.MediaSalarial.ToString();
            this.txtPersonas.Text = resumen.Personas.ToString();
        }
    }
}
