using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace Pedidos
{
    // Clase para crear un pedido.
    class Pedido
    {
        public Producto hamburguesa ;
        public Producto papas ;
        public Producto refresco ;
        public Producto pizza ;
        public Producto nugget ;
        public Producto ensalada ;
        public Producto yogur ;
        public Producto agua ;
        
        // El constructor nos crea automaticamente todos los productos diponibles.
        public Pedido()
        {
            hamburguesa = new Producto("hamburguesa", 35);
            papas = new Producto("Papas", 15);
            refresco = new Producto("Refresco", 12);
            pizza = new Producto("Pizza", 70);
            nugget = new Producto("Nugget", 25);
            ensalada = new Producto("Ensalada", 30);
            yogur = new Producto("Yogur", 15);
            agua = new Producto("Agua", 12);
        }
    }

}
