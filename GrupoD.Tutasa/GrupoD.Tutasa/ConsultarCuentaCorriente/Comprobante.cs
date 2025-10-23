using GrupoD.Tutasa.CargarFactura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoD.Tutasa.ConsultarCuentaCorriente
{
    internal class Comprobante
    {
        public DateTime Fecha { get; set; }
        public string DetalleComprobante { get; set; }
        public decimal Importe { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
