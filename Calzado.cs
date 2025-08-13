using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilares_POO
{
    public class Calzado: Producto
    {
        public Calzado(double precio, string nombre, string categoria, bool desc): base(precio, nombre, categoria, desc)
        {

        }

        public override void Descuento()
        {
            if (!desc)
            {
                Console.WriteLine($"*** Producto {nombre} no tiene descuento ***");
                return;
            }
            precio = precio - (precio * 0.20);
            Console.WriteLine($"*** Se le aplico un 20% de descuento a su producto, Precio anterior: {Math.Round(precio/0.80,2)} Precio nuevo: {Math.Round(precio,2)} ***");
        }
    }
}
