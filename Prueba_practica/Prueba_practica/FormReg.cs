using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prueba_practica
{
    public partial class FormReg : Prueba_practica.FormBase
    {
        public FormReg(string textx)
        {
            InitializeComponent();
            lbltotal.Text = textx; // Asignamos lo recibido al label
        }

        private void btndomicilio_Click(object sender, EventArgs e)
        {
            lblenvio.Text = "2.50";
            double totalcompra = double.Parse(lbltotal.Text);
            double precioenvio = double.Parse(lblenvio.Text);
            lblfinal.Text = (totalcompra + precioenvio).ToString();
        }

        private void btnllevar_Click(object sender, EventArgs e)
        {
            lblenvio.Text = "0.00";
            lblfinal.Text = lbltotal.Text;
        }

        private void btnfin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por su compra!");
            Application.Exit();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
