using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G2_DesarrolloHabilidades02.Models;

namespace G2_DesarrolloHabilidades02
{
    public partial class Form1 : Form
    {
        public Cliente currentClient;
        public Form1()
        {
            InitializeComponent();
            SetTiposCuentas();
            SetSucursales();
        }
        private void SetTiposCuentas()
        {
            tbxTipoCuenta.Items.AddRange(new string[] { "Corriente", "Ahorros", "Plazo", "Crédito" });
        }
        private void SetSucursales()
        {
            tbxSucursal.Items.AddRange(new string[] { "Aguilares", "Ilopango", "San Salvador", "Soyapango", "Mejicanos", "Pasaquina" });
        }
        private Cliente GetFormClientData()
        {
            if (!string.IsNullOrEmpty(tbxMonto.Text) && decimal.TryParse(tbxMonto.Text, out decimal montoDisponible))
                return new Cliente(tbxDui.Text, tbxNombre.Text, tbxApellido.Text, tbxTipoCuenta.Text, tbxNit.Text, tbxNumCuenta.Text, montoDisponible, tbxSucursal.Text);
            else
                return null;
        }
        private void ShowCurrentClientData()
        {
            tbxDui.Text = currentClient.dui;
            tbxNombre.Text = currentClient.nombre;
            tbxApellido.Text = currentClient.apellido;
            tbxTipoCuenta.Text = currentClient.tipoCuenta;
            tbxNit.Text = currentClient.nit;
            tbxNumCuenta.Text = currentClient.numeroCuenta;
            tbxMonto.Text = currentClient.montoDisponible.ToString();
            tbxSucursal.Text = currentClient.sucursal;
        }
        private void EnableClientForm(bool enable)
        {
            tbxDui.Enabled =
            tbxNombre.Enabled =
            tbxApellido.Enabled =
            tbxTipoCuenta.Enabled =
            tbxNit.Enabled =
            tbxNumCuenta.Enabled =
            tbxMonto.Enabled =
            tbxSucursal.Enabled = enable;
        }
        private void ClearClientForm()
        {
            tbxDui.Text =
            tbxNombre.Text =
            tbxApellido.Text =
            tbxTipoCuenta.Text =
            tbxNit.Text =
            tbxNumCuenta.Text =
            tbxMonto.Text =
            tbxSucursal.Text = "";
        }
        private bool ValidateIfClientExist()
        {
            var exist = currentClient != null;

            if (!exist)
                MessageBox.Show("No hay ningun cliente agregado.");

            return exist;
        }
        private string MostrarInputBox(string text)
        {
            using (var inputForm = new EntradaForm(text))
            {
                return inputForm.ShowDialog() == DialogResult.OK ? inputForm.UserInput : "";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var client = GetFormClientData();

            if (Cliente.IsModelComplete(client))
            {
                currentClient = client;
                ShowCurrentClientData();
                EnableClientForm(false);
                MessageBox.Show("¡Cliente agregado!");
            }
            else
            {
                currentClient = null;
                MessageBox.Show("¡Cliente no fue agregado, por favor completa el formulario!");
            }
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            if (!ValidateIfClientExist())
                return;

            var input = MostrarInputBox("Digite la cantidad a ingresar");

            if (decimal.TryParse(input, out decimal cantidad) && cantidad > 0)
            {
                currentClient.montoDisponible += cantidad;
                ShowCurrentClientData();
                MessageBox.Show("¡Ingreso realizado exitosamente!");
            }
            else if (cantidad <= 0)
            {
                MessageBox.Show("¡No puedes ingresar cero o número negativos!");
                MessageBox.Show("Matemáticas hijo...");
            }
            else
                MessageBox.Show("¡Por favor ingrese un monto válido!");
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            if (!ValidateIfClientExist())
                return;

            var input = MostrarInputBox("Digite la cantidad a retirar de la cuenta");

            if (decimal.TryParse(input, out decimal cantidad) && currentClient.montoDisponible > cantidad)
            {
                currentClient.montoDisponible -= cantidad;
                ShowCurrentClientData();
                MessageBox.Show("¡Retiro realizado exitosamente!");
            }
            else if (currentClient.montoDisponible < cantidad)
            {
                MessageBox.Show("¡Retiro denegado! Fondos no son suficientes");
                MessageBox.Show("Pongase a chambear pa tener plata...");
            }
            else
                MessageBox.Show("¡Por favor ingrese un monto válido!");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!ValidateIfClientExist())
                return;

            ClearClientForm();
            EnableClientForm(true);
            currentClient = null;

            MessageBox.Show("Cliente eliminado exitosamente.");
        }
    }
}
