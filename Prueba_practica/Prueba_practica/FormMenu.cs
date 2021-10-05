using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prueba_practica
{
    public partial class FormMenu : Prueba_practica.FormBase
    {
        Comida hamburguesa = new Comida();
        Comida papas = new Comida();
        Comida bebida = new Comida();
        Pedido pedidoactual = new Pedido();
        Pedido total = new Pedido();
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show
                ("¿Desea salir de la aplicación?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            { this.Close(); }
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            hamburguesa.Precio = 3.25;
            pedidoactual.CantidadHambu = Convert.ToInt32(cmboxhambu.Text);
        }

        private void btnagregar1_Click(object sender, EventArgs e)
        {
            papas.Precio = 1.99;
            pedidoactual.Cantidadpapas = Convert.ToInt32(cmboxpapas.Text);
        }

        private void btnagregar2_Click(object sender, EventArgs e)
        {
            bebida.Precio = 1.50;
            pedidoactual.Cantidadbebida = Convert.ToInt32(cmboxbebida.Text);
        }

        private void btnsig_Click(object sender, EventArgs e)
        {
            double total= pedidoactual.CalcularTotal(pedidoactual.CalcularTotal_1(hamburguesa.Precio, pedidoactual.CantidadHambu), pedidoactual.CalcularTotal_2(papas.Precio, pedidoactual.Cantidadpapas), pedidoactual.CalcularTotal_3(bebida.Precio, pedidoactual.Cantidadbebida));
            MessageBox.Show("su total es " + total);
        }
    }
}
