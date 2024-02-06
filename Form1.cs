using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia02
{
    public partial class Form1 : Form
    {
        Empleado miEmpleado = new Empleado();
        Salario miSalario = new Salario();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            miEmpleado.nombre = txtnombre.Text;
            miEmpleado.identificacion = txtidentificacion.Text; miEmpleado.salarioDiario = Convert.ToDecimal(txtdiario.Text); miSalario.diasLaborados = int.Parse(txtdias.Text);
            MessageBox.Show("Datos ingresados con éxito");
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            txtsalario.Text = Convert.ToString(miSalario.CalcularSalario(miSalario.diasLaborados, miEmpleado.salarioDiario));
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtidentificacion.Clear();
            txtdias.Clear();
            txtdiario.Clear();
            txtsalario.Clear();
            txtnombre.Focus();
        }
    }
}
