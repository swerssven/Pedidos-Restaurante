using System;
using System.Collections.Generic;
using System.Text;

namespace Pedidos
{
    // Clase para crear productos.
    class Producto
    {
        private String nombre;
        private double precio;
        private int cantidad;

        // Constructor que recibe el nombre y el precio del producto a crear.
        public Producto(String nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = 0;
        }
        public int getCantidad()
        {
            return cantidad;
        }

        // Método para aumentar la cantidad pedida de un producto.
        public void addCantidad()
        {
            if(cantidad < 5)
            {
                cantidad++;
            }
        }

        // Método para disminuir la cantidad pedida de un producto.
        public void restCantidad()
        {
            if (cantidad > 0)
            {
                cantidad--;
            }
        }

        // Método que nos calcula el precio total, segun cantidad y precio del producto.
        public double precioTotalProducto()
        {
            double total = precio * cantidad;
            return total;
        }
    }
}
