using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App3A.HolaMundo
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            float valor1 = float.Parse(txtValor1.Text);
            float valor2 = float.Parse(txtValor2.Text);
            float resultado= valor1 + valor2;
            lblResultado.Text = "El resultado de la suma es : "+ resultado;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Estas sobre el titulo");
        }

        private void txtValor1_Leave(object sender, EventArgs e)
        {
            int contenido = txtValor1.Text.Length;
            if (contenido == 0)
            {
                MessageBox.Show("Esta caja no puede estar vacia");
                txtValor1.Focus();
            }
        }
    }
}
