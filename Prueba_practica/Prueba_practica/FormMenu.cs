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
        //Empieza el indice para el DataGridView
        private int edit_indice = -1;

        //Lista para diferentes objetos comida
        public static List<Pedido> Pedidos = new List<Pedido>();

        private void actualizarGrid()
        {
            dgvpedido.DataSource = null;
            dgvpedido.DataSource = Pedidos; /*los nombres de columna que veremos 
son los de las propiedades*/
        }



        //Objetos de la clase comida
        Comida hamburguesa = new Comida();
        Comida papas = new Comida();
        Comida bebida = new Comida();
        //Objetos de la clase pedido
        Pedido pedidoactual = new Pedido();
        
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

        private void btnagregar0_Click(object sender, EventArgs e)
        {
            hamburguesa.Precio = 3.25;
            pedidoactual.Item = "Hamburguesa";
            pedidoactual.Cantidad = Convert.ToInt32(cmboxhambu.Text);

            //creo un objeto de la clase pedido y guardo a través de las propiedades
            Pedido ped = new Pedido();
            ped.Item = pedidoactual.Item;
            ped.Cantidad = pedidoactual.Cantidad;
            ped.Precioindiv = hamburguesa.Precio;
            ped.Total = ped.Cantidad * ped.Precioindiv;

            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                Pedidos[edit_indice] = ped;
                edit_indice = -1;
            }
            else
            {
                Pedidos.Add(ped); /*al arreglo de Pedidos le agrego el objeto creado 
con todos los datos que recolecté*/
            }

            actualizarGrid();//llamamos al procedimiento que guarda en datagrid
            //limpiar();//mandamos a llamar la función que limpia

        }

        private void btnagregar1_Click(object sender, EventArgs e)
        {
            papas.Precio = 1.99;
            pedidoactual.Item = "Papitas fritas";
            pedidoactual.Cantidad = Convert.ToInt32(cmboxpapas.Text);

            //creo un objeto de la clase pedido y guardo a través de las propiedades
            Pedido ped = new Pedido();
            ped.Item = pedidoactual.Item;
            ped.Cantidad = pedidoactual.Cantidad;
            ped.Precioindiv = papas.Precio;
            ped.Total = ped.Cantidad * ped.Precioindiv;

            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                Pedidos[edit_indice] = ped;
                edit_indice = -1;
            }
            else
            {
                Pedidos.Add(ped); /*al arreglo de Pedidos le agrego el objeto creado 
con todos los datos que recolecté*/
            }
            actualizarGrid();//llamamos al procedimiento que guarda en datagrid
        }

        private void btnagregar2_Click(object sender, EventArgs e)
        {
            bebida.Precio = 1.50;
            pedidoactual.Item = "Bebida";
            pedidoactual.Cantidad = Convert.ToInt32(cmboxbebida.Text);

            //creo un objeto de la clase pedido y guardo a través de las propiedades
            Pedido ped = new Pedido();
            ped.Item = pedidoactual.Item;
            ped.Cantidad = pedidoactual.Cantidad;
            ped.Precioindiv = bebida.Precio;
            ped.Total = ped.Cantidad * ped.Precioindiv;

            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                Pedidos[edit_indice] = ped;
                edit_indice = -1;
            }
            else
            {
                Pedidos.Add(ped); /*al arreglo de Pedidos le agrego el objeto creado 
con todos los datos que recolecté*/
            }
            actualizarGrid();//llamamos al procedimiento que guarda en datagrid
        }

        private void btnsig_Click(object sender, EventArgs e)
        {
            double total= pedidoactual.CalcularTotal(pedidoactual.CalcularTotal_1(hamburguesa.Precio, pedidoactual.Cantidad), pedidoactual.CalcularTotal_2(papas.Precio, pedidoactual.Cantidad), pedidoactual.CalcularTotal_3(bebida.Precio, pedidoactual.Cantidad));
            if(total==0)
            { MessageBox.Show("No ha seleccionado nada"); }
            else 
            {   
                MessageBox.Show("su total es " + total); 

            }
        }

        private void dgvpedido_DoubleClick(object sender, EventArgs e)
        {
            //Guarda el item en el DGV
            DataGridViewRow seleccion = dgvpedido.SelectedRows[0];
            int pos = dgvpedido.Rows.IndexOf(seleccion); //almacena en cual fila estoy
            edit_indice = pos; //copio esa variable en índice editado
            Pedido ped = Pedidos[pos]; /*esta variable de tipo persona, se carga con los 
valores que le pasa el listado*/

            pedidoactual.Item = ped.Item;
            hamburguesa.Precio = ped.Precioindiv;
            pedidoactual.Cantidad = ped.Cantidad;
        }
    }
}
