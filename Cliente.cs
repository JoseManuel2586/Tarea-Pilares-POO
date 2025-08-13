using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pilares_POO
{
    public class Cliente
    {
        public string nombre;
        public IPago formaPago;

        public Cliente(string nombre, IPago formaPago)
        {
            this.nombre = nombre;
            this.formaPago = formaPago;
        }
    }
}
