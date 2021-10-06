using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_practica
{
    public class Pedido
    {
        private string item;
        public string Item
        {
            get { return item; }
            set { item = value; }
        }
        private double precioindiv;
        public double Precioindiv
        {
            get { return precioindiv; }
            set { precioindiv = value; }
        }

        private int cantidad;
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private double total;
        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        //Metodo para calcular total de orden
        public double CalcularTotal_1(double cantidad, double precio)
        {
            double totalpedido = cantidad * precio;
            return totalpedido;
        }
        public double CalcularTotal_2(double cantidad, double precio)
        {
            double totalpedido = cantidad * precio;
            return totalpedido;
        }

        public double CalcularTotal_3(double cantidad, double precio)
        {
            double totalpedido = cantidad * precio;
            return totalpedido;
        }

        public double CalcularTotal(double total1, double total2, double total3)
        {
            double totalpedido = total1 + total2 + total3;
            return totalpedido;
        }
    }
}
