using Tarea_Pilares_POO;

internal class Program
{
    private static void Main(string[] args)
    {
        Alimentos cocaCola = new Alimentos(15.50, "Coca Cola", "Alimentos", false);
        Alimentos manzana = new Alimentos(10, "Manzana", "Alimentos", false);
        Ropa camisa = new Ropa(150, "Camisa", "Ropa", true);
        Ropa pantalon = new Ropa(250, "Pantalon", "Ropa", false);
        Calzado tennis = new Calzado(1000, "Tennis", "Calzado", true);
        Calzado zapatosVestir = new Calzado(450, "Zapatos de Vestir", "Calzado", false);

        Cliente cliente1 = new Cliente("Jose Manuel Lopez", new PagoConTarjeta(1500));

        Carrito carrito = new Carrito();

        carrito.AgregarCarrito(cocaCola);
        cocaCola.Descuento();
        carrito.AgregarCarrito(tennis);
        tennis.Descuento();
        carrito.ListarProductos();
        carrito.AgregarCarrito(camisa);
        carrito.AgregarCarrito(cocaCola);
        carrito.ListarProductos();
        carrito.EliminarProducto(cocaCola);
        carrito.ListarProductos();
        carrito.TotalPagar();


        cliente1.formaPago.ProcesarPago(carrito);





        Console.Read();
    }
}