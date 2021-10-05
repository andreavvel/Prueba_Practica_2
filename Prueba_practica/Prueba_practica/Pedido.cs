using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_practica
{
    public class Pedido
    {

        private int cantidadhambu;
        public int CantidadHambu
        {
            get { return cantidadhambu; }
            set { cantidadhambu = value; }
        }

        private int cantidadpapas;
        public int Cantidadpapas
        {
            get { return cantidadpapas; }
            set { cantidadpapas = value; }
        }

        private int cantidadbebida;
        public int Cantidadbebida
        {
            get { return cantidadbebida; }
            set { cantidadbebida = value; }
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
