using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G2_DesarrolloHabilidades01.Models;

namespace G2_DesarrolloHabilidades01
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        private Celular miCelu;
        public Form1()
        {
            InitializeComponent();
            miCelu = new Celular("Xiaomi", "Mi 14 Pro", "Negro", 1400);
            Instance = this;
            lblNotificaciones.Text = "¡El celular esta encendido!";
        }

        public string MostrarInputBox(string text)
        {
            using (var inputForm = new InputForm(text))
            {
                return inputForm.ShowDialog() == DialogResult.OK ? inputForm.UserInput : "";
            }
        }

        private void lblNotificaciones_Click(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e) => miCelu.Apagar();

        private void btnEncender_Click(object sender, EventArgs e) => miCelu.Encender();

        private void btnLlamar_Click(object sender, EventArgs e) => miCelu.Llamar();

        private void btnMensaje_Click(object sender, EventArgs e) => miCelu.EnviarMensaje();
    }
}
