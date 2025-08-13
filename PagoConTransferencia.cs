using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilares_POO
{
    public class PagoConTransferencia: IPago
    {
        public double transferencia;

        public PagoConTransferencia(double transferencia)
        {
            this.transferencia = transferencia;
        }
        public void ProcesarPago(Carrito total)
        {
            Console.WriteLine($"Forma de pago: Transferencia - Total Pagado: {total}");
        }
    }
}
