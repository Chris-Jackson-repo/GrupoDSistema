using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoD.Tutasa.GenerarGuiaCD
{
    internal class Cliente
    {
        public long Cuit {  get; set; }
        public string RazonSocial { get; set; }
        public string Provincia { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public short CodigoPostal {  get; set; }
    }
}
