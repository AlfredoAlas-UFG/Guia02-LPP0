using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G2_DesarrolloHabilidades02
{
    public partial class EntradaForm : Form
    {
        public string UserInput { get; private set; }
        public EntradaForm()
        {
            InitializeComponent();
        }
        public EntradaForm(string _text)
        {
            InitializeComponent();
            text.Text = _text;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            UserInput = input.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            UserInput = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
