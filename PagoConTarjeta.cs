using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilares_POO
{
    public class PagoConTarjeta: IPago
    {
        public double saldo;
        
        public PagoConTarjeta(double saldo)
        {
            this.saldo = saldo;
        }
        public void ProcesarPago(Carrito total)
        {
            bool rev = total.totalPagar > saldo;
            if (rev)
            {
                Console.WriteLine($"No tiene saldo disponible para realizar el pago");
            }
            else
            {
                saldo = Math.Round(saldo - total.totalPagar,2);
                Console.WriteLine($"Forma de pago: Tarjeta - Total Pagado: {total.totalPagar}");
                Console.WriteLine($"El saldo de su tarjeta es de: {saldo}");
            }
                
        }
        
    }
}
