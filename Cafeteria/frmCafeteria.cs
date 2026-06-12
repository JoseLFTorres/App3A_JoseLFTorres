using Calificaciones.Cafeteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace App3A.Cafeteria
{
    public partial class frmCafeteria : Form
    {
        private List<Bebida> bebidas;

        public frmCafeteria()
        {
            InitializeComponent();
            bebidas = new List<Bebida>();

            rdbFrio.CheckedChanged += rdbCaliente_CheckedChanged;
            rdbSuero.CheckedChanged += rdbCaliente_CheckedChanged;

            chkAzucar.Visible = false;
        }

        private void rdbCaliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCaliente.Checked == true)
            {
                lblExtra.Text = "Temperatura";
                chkAzucar.Visible = false;
            }
            else if (rdbFrio.Checked == true)
            {
                lblExtra.Text = "Hielos";
                chkAzucar.Visible = false;
            }
            else if (rdbSuero.Checked == true)
            {
                lblExtra.Text = "Electrolitos";
                chkAzucar.Visible = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //rescatamos valores
            string nombre = txtNombre.Text.Trim();
            string tamano = cmbTamano.Text.Trim();
            float precio = float.Parse(txtPrecio.Text.Trim());
            int extra = int.Parse(txtExtra.Text.Trim());

            if (rdbCaliente.Checked)
            {
                bebidas.Add(new BebidaCaliente(nombre, tamano, precio, extra));
            }
            else if (rdbFrio.Checked)
            {
                bebidas.Add(new BebidaFria(nombre, tamano, precio, extra));
            }
            else if (rdbSuero.Checked)
            {
                bebidas.Add(new BebidaSuero(nombre, tamano, precio, extra, chkAzucar.Checked));
            }

            if (bebidas[bebidas.Count - 1] is BebidaFria fria)
            {
                lsbBebidas.Items.Add(fria.Mensaje());
            }
            else if (bebidas[bebidas.Count - 1] is BebidaCaliente caliente)
            {
                lsbBebidas.Items.Add(caliente.Mensaje());
            }
            else if (bebidas[bebidas.Count - 1] is BebidaSuero suero)
            {
                lsbBebidas.Items.Add(suero.Mensaje());
            }

            lblCantidad.Text = bebidas.Count + " Bebidas Registradas";
            Limpiarcomponentes();
        }

        private void Limpiarcomponentes()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtExtra.Clear();
            cmbTamano.SelectedIndex = -1;
            chkAzucar.Checked = false;
        }

        private void lsbBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDescripcion.Text = bebidas[lsbBebidas.SelectedIndex].Preparar();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}