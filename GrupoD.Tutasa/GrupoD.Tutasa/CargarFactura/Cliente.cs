using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoD.Tutasa.CargarFactura
{
    internal class Cliente
    {
        public long CuitEmpresa {  get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public Factura Factura { get; set; }
    }
}
