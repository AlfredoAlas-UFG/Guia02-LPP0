using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G2_DesarrolloHabilidades01.Models
{
    internal class Celular
    {
        //Atributos
        public string marca {  get; set; }
        public string modelo {  get; set; }
        public string color { get; set; }
        public double precio { get; set; }
        public bool estaEncendido { get; set; }

        //Constructor
        public Celular(string marca, string modelo, string color, double precio)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.precio = precio;
            this.estaEncendido = true;
        }

        //Metodos
        public void Encender()
        {
            if(!estaEncendido)
            {
                estaEncendido = true;
                var mensaje = "¡El celular está encendido!";
                MessageBox.Show(mensaje);
                Form1.Instance.lblNotificaciones.Text = mensaje;
            }
            else
            {
                var mensaje = "¡El celular ya está encendido!";
                MessageBox.Show(mensaje);
                Form1.Instance.lblNotificaciones.Text = mensaje;
            }
        }

        public void Apagar()
        {
            if (estaEncendido)
            {
                estaEncendido = false;
                var mensaje = "¡El celular está apagado!";
                MessageBox.Show(mensaje);
                Form1.Instance.lblNotificaciones.Text = mensaje;
            }
            else
            {
                var mensaje = "¡El celular ya está apagado!";
                MessageBox.Show(mensaje);
                Form1.Instance.lblNotificaciones.Text = mensaje;
            }
        }
        public void Llamar()
        {
            string numero = Form1.Instance.MostrarInputBox("Ingrese el número");

            if (estaEncendido && !string.IsNullOrEmpty(numero))
            {
                var msg = $"Llamando al número: {numero}";
                MessageBox.Show(msg);
                Form1.Instance.lblNotificaciones.Text = msg;
            }
            else if (string.IsNullOrEmpty(numero))
            {
                var msg = "Ingrese un número por favor no sea menso...";
                MessageBox.Show(msg);
                Form1.Instance.lblNotificaciones.Text = msg;
            }
            else
            {
                var msg = "No se puede llamar porque el celular está apagado.";
                MessageBox.Show(msg);
                Form1.Instance.lblNotificaciones.Text = msg;
            }
        }

        public void EnviarMensaje()
        {
            var numero = Form1.Instance.MostrarInputBox("Ingrese el número");
            var mensaje = Form1.Instance.MostrarInputBox("Ingrese el mensaje");

            if (estaEncendido
                && !string.IsNullOrEmpty(numero)
                && !string.IsNullOrEmpty(mensaje))
            {
                var msg = $"Enviando mensaje a {numero}: {mensaje}";
                MessageBox.Show(msg);
                Form1.Instance.lblNotificaciones.Text = msg;
            }
            else if (string.IsNullOrEmpty(numero))
            {
                var msg = "Ingrese un número por favor";
                MessageBox.Show(msg);
                Form1.Instance.lblNotificaciones.Text = msg;
            }
            else if (string.IsNullOrEmpty(mensaje))
            {
                var msg = "Ingrese un mensaje por favor";
                MessageBox.Show(msg);
                Form1.Instance.lblNotificaciones.Text = msg;
            }
            else
            {
                var msg = "No se puede enviar el mensaje porque el celular está apagado.";
                MessageBox.Show(msg);
                Form1.Instance.lblNotificaciones.Text = msg;
            }
        }

    }
}
