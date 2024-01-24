using AdoNet.Models;
using AdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form08OficiosUpdateEmpleados : Form
    {
        private RepositoryOficioEmpleados repo;

        public Form08OficiosUpdateEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryOficioEmpleados();
            List<string> oficiosList = this.repo.GetOficios();
            foreach (string oficio in oficiosList)
            {
                this.lstOficios.Items.Add(oficio);
            }
        }

        private void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstOficios.SelectedIndex != -1)
            {
                string oficio = this.lstOficios.SelectedItem.ToString();
                List<string> apellidosList = this.repo.GetEmpleadosOficio(oficio);
                int sumaSalarial = this.repo.GetSumaSalarialOficio(oficio);
                this.lblSumaSalarial.Text = "Suma salarial: "
                    + sumaSalarial.ToString();
                this.lstEmpleados.Items.Clear();
                foreach (string apellido in apellidosList)
                {
                    this.lstEmpleados.Items.Add(apellido);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            string oficio = this.lstOficios.SelectedItem.ToString();
            int results = this.repo.IncrementarSalarioOficio(oficio, incremento);
            DatosEmpleadosOficio datos = this.repo.GetDatosEmpleadosOficio(oficio);
            this.lblSumaSalarial.Text = 
                "Suma salarial: " + datos.SumaSalarial;
            this.lblMediaSalarial.Text =
                "Media salarial " + datos.MediaSalarial;
            this.lblMinimoSalario.Text = 
                "Mínimo salario " + datos.MinimoSalario;
            MessageBox.Show("Registros modificados: " + results);
        }
    }
}
