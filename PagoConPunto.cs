using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilares_POO
{
    internal class PagoConPuntos: IPago
    {
        public double puntos;

        public PagoConPuntos(double puntos)
        {
            this.puntos = puntos;
        }
        public void ProcesarPago(Carrito total)
        {
            Console.WriteLine($"Forma de pago: Con Puntos - Total Pagado: {total}");
        }
    }
}
