using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilares_POO
{
    public class Alimentos: Producto
    {
        public Alimentos(double precio, string nombre, string categoria, bool desc): base(precio, nombre, categoria, desc)
        {

        }

        public override void Descuento()
        {
            if (!desc)
            {
                Console.WriteLine($"*** Producto {nombre} no tiene descuento ***");
                return;
            }
            
        }
    }
}
