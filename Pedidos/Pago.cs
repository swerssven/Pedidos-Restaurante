using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Pedidos
{
    // Clase para crear un pago.
    class Pago
    {
        private double subTotal;
        private double iva;
        private double totalIva;
        private double total;
        private double cambio;
        private int codigoPostal;

        public Pago()
        {
            subTotal = 0;
            iva = 0.16;
            totalIva = 0;
            total = 0;
            cambio = 0;
            codigoPostal = 0;
        }


        // Método para calcular el subtotal, suma todos los totales de cada producto.
        public double getSubTotal(Pedido pedido)
        {
            subTotal = pedido.hamburguesa.precioTotalProducto() +
                       pedido.papas.precioTotalProducto() +
                       pedido.refresco.precioTotalProducto() +
                       pedido.pizza.precioTotalProducto() +
                       pedido.nugget.precioTotalProducto() +
                       pedido.ensalada.precioTotalProducto() +
                       pedido.yogur.precioTotalProducto() +
                       pedido.agua.precioTotalProducto();
            return subTotal;
        }

        // Método para calcular el IVA, subtotal * IVA.
        public double getIva()
        {
            totalIva = subTotal * iva;
            return totalIva;
        }

        // Método para calcular Total a pagar. IVA + subtotal.
        public double getTotal()
        {
            total = subTotal + totalIva;
            return total;
        }

        public double getCambio()
        {
            return cambio;
        }

        public void setCodigoPostal(int codigoPostal)
        {
            this.codigoPostal = codigoPostal;
        }

        //Método calcula el cambio segun lo que ha pagado el cliente.
        public void calculaCambio(double pago)
        {
            if (codigoPostal != 0)
            {
                cambio = pago - total;
            }
            else 
            {
                MessageBox.Show("Introduzca el código postal", "Aviso!");
            }
        }
    }
}