using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace G2_DesarrolloHabilidades01
{
    public partial class InputForm : Form
    {
        public string UserInput { get; private set; }
        public InputForm( string text)
        {
            InitializeComponent();
            lblText.Text = text;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            UserInput = txtInput.Text;
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
