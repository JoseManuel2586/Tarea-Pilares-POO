using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilares_POO
{
    public interface IPago
    {
        public void ProcesarPago(Carrito total);
    }
}
