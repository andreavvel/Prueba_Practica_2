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
        //Servirán para calcular el total
        public double cantidad1=0, cantidad2=0, cantidad3=0;

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
        }

        private void btnagregar0_Click(object sender, EventArgs e)
        {
            hamburguesa.Precio = 3.25;
            pedidoactual.Item = "Hamburguesa";
            pedidoactual.Cantidad = Convert.ToInt32(cmboxhambu.Text);

            cantidad1 = hamburguesa.Precio*pedidoactual.Cantidad;

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

            cantidad2 = papas.Precio* pedidoactual.Cantidad;

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

            cantidad3 = bebida.Precio * pedidoactual.Cantidad;
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
        private void btnsig_Click(object sender, EventArgs e)
        {
            pedidoactual.Total = cantidad1 + cantidad2 + cantidad3;
            if (pedidoactual.Total == 0)
            { MessageBox.Show("No ha seleccionado nada"); }
            else
            {
                //MessageBox.Show("su total es " + total);
                string mensaje = string.Format((pedidoactual.Total).ToString());
                FormReg frmrecibe = new FormReg(mensaje); /* creo un objeto del segundo formulario,
 adonde mando información*/
                frmrecibe.Visible = true; // muestra el nuevo formulario
                this.Visible = false; // esconde el formulario actual
            }
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                Pedidos.RemoveAt(edit_indice);
                edit_indice = -1; //resetea variable a -1
                actualizarGrid();
            }
            else
            {
                MessageBox.Show("Debe dar doble click primero sobre item que desea eliminar");
            }
        }
    }
}
