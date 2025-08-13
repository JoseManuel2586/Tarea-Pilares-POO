using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilares_POO
{
    public abstract class Producto
    {
        public double precio;
        public string nombre;
        public string categoria;
        public bool desc;

        public Producto(double precio, string nombre, string categoria, bool desc)
        {
            this.precio = precio;
            this.nombre = nombre;
            this.categoria = categoria;
            this.desc = desc;
        }

        public abstract void Descuento();
        
    }
}
