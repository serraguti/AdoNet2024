using AdoNet.Models;
using AdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form06DepartamentosClases : Form
    {
        private RepositoryDepartamentos repo;
        private List<int> idsDepartamentoList;

        public Form06DepartamentosClases()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentos();
            this.idsDepartamentoList = new List<int>();
            this.LoadDepartamentos();
        }

        private void LoadDepartamentos()
        {
            List<Departamento> departamentos = this.repo.GetDepartamentos();
            this.lstDepartamentos.Items.Clear();
            this.idsDepartamentoList.Clear();
            foreach (Departamento dept in departamentos)
            {
                this.idsDepartamentoList.Add(dept.IdDepartamento);
                this.lstDepartamentos.Items.Add(dept.IdDepartamento
                    + " - " + dept.Nombre + " - " + dept.Localidad);
            }
        }

        private void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstDepartamentos.SelectedIndex;
            if (index != -1)
            {
                int idDepartamento = this.idsDepartamentoList[index];
                Departamento departamento = this.repo.FindDepartamento(idDepartamento);
                this.txtId.Text = departamento.IdDepartamento.ToString();
                this.txtNombre.Text = departamento.Nombre;
                this.txtLocalidad.Text = departamento.Localidad;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            int insertados =
                this.repo.InsertarDepartamento(id, nombre, localidad);
            this.LoadDepartamentos();
            MessageBox.Show("Departamentos insertados " + insertados);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idDepartamento = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            int resultados = this.repo.ModificarDepartamento(idDepartamento
                , nombre, localidad);
            this.LoadDepartamentos();
            MessageBox.Show("Departamentos modificados: " + resultados);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = this.lstDepartamentos.SelectedIndex;
            if (index != -1)
            {
                int idDepartamento = this.idsDepartamentoList[index];
                int results = this.repo.EliminarDepartamento(idDepartamento);
                this.LoadDepartamentos();
                MessageBox.Show("Eliminados: " + results);
            }
        }
    }
}
