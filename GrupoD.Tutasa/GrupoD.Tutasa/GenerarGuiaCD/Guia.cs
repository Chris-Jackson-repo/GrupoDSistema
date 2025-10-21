using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoD.Tutasa.GenerarGuiaCD
{
    internal class Guia
    {
        
        
        public string TamañoEncomienda { get; internal set; }
        public string TipoEntrega { get; internal set; }
        public string CuitCliente { get; internal set; }
        public long DniDestinatario { get; internal set; }
        public string NombreDestinatario { get; internal set; }
        public string ApellidoDestinatario { get; internal set; }
        public string ProvinciaDestinatario { get; internal set; }
        public string CiudadDestinatario { get; internal set; }
        public string DireccionDestinatario { get; internal set; }
        public string CodigoPostalDestinatario { get; internal set; }
        public DateTime FechaGeneracion { get; set; } = DateTime.Now;

    }
}
