using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoD.Tutasa.GenerarGuiaCD
{
    internal class Destinatario
    {
        public int DniDesti { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Provincia { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public short cpDestinatario { get; set; }
    }
}
