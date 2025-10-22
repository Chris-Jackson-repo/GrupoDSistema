using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoD.Tutasa.ReporteCostosVentas
{
    internal class ResultadoBusqueda
    {
        public long empresa { get; set; }

        public int costo { get; set; } 

        public int ventas { get; set; }

        public int resultado => ventas - costo;

        public DateTime Fecha { get; set; }

    }
}
