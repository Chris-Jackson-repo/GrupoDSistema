using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoD.Tutasa.CargarFactura
{
    internal class Factura
    {
        public int NumeroFactura { get; set; }
        public DateTime FechaFactura { get; set; }

        public DateTime FechaVencimiento { get; set; }
        public decimal ImporteTotal { get; set; }
        public Cliente Cliente { get; set; }

    }
}
