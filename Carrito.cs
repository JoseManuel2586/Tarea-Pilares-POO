using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilares_POO
{
    public class Carrito
    {
        public List<Producto> productos = new List<Producto>{};
        public double totalPagar;
        public void AgregarCarrito(Producto producto)
        {
            bool rev = producto is Alimentos || producto is Calzado || producto is Ropa;
            if (!rev)
            {
                Console.WriteLine("Solo se pueden agregar valores de productos validos");
                return;
            }
            productos.Add(producto);
            Console.WriteLine($"Producto {producto.nombre} agregado a Carrito exitosamente");
            Console.WriteLine("---------------------------------------------------------------------------------");
        }

        public void EliminarProducto(Producto producto)
        {
            bool rev = producto is Alimentos || producto is Calzado || producto is Ropa;
            if (!rev)
            {
                Console.WriteLine("El valor indicado no es un producto valido");
                return;
            }
            int index = productos.FindIndex(i => i.nombre == producto.nombre);
            if(index >= 0)
            {
                productos.RemoveRange(index, 1);
                Console.WriteLine("El producto ha sido eliminado exitosamente");
                Console.WriteLine("---------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("El producto indicado no aparece dentro del listado");
                Console.WriteLine("---------------------------------------------------------------------------------");
            }
        }

        public void ListarProductos()
        {
            if(productos.Count() == 0)
            {
                Console.WriteLine("No hay productos agregados al Carrito");
            }
            else
            {
                foreach(var prod in productos)
                {
                    Console.WriteLine($"Nombre: {prod.nombre} - Precio: {prod.precio} - Categoria: {prod.categoria} - Tiene Descuento: {prod.desc}");
                }
                Console.WriteLine("---------------------------------------------------------------------------------");
            }
        }

        public void TotalPagar()
        {
            if(productos.Count() == 0)
            {
                Console.WriteLine("No hay productos agregados al Carrito");
            }
            else
            {
                double total = productos.Aggregate(0.0,(acc, item) =>
                {
                    return acc += item.precio;
                });
                totalPagar = Math.Round(total * 1.12,2);
                Console.WriteLine($"Su total a pagar mas impuestos es de: {totalPagar} ");
            }
                
        }

    }
}
