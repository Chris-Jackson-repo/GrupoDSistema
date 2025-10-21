using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoD.Tutasa.ReporteCostosVentas
{
    public class ReporteCostosVentasModelo
    {
        // Lista de CUITs disponibles
        public long[] CUITEmpresas { get; } = new long[]
        {
            20345678901,
            33700050005,
            30711222333
        };

        private long ultimaCUITIngresada = -1;


        // Representa una fila del ListView (empresa, fecha, costo, venta)

        // Devuelve datos inventados para un CUIT y un rango de fechas (inclusive).

        private Dictionary<long, List<Fila>> datosPorCUIT = new()
        {
            {
                20345678901, new List<Fila>
                {
                        
                                                        
                    new("Transportes Alfa",    new DateTime(2025, 1, 10), 15000m, 22000m),
                    new("Transportes Alfa",    new DateTime(2025, 2, 05), 12000m, 17000m),
                    new("Logística Beta",      new DateTime(2025, 3, 20),  8000m, 12000m),
                    new("Servicios Gamma",     new DateTime(2025, 4, 12),  5000m,  7500m),
                }
            },
            {
                33700050005, new List<Fila>
                {
                    new("Transporte Delta",    new DateTime(2025, 1, 25), 20000m, 27000m),
                    new("Expreso Epsilon",     new DateTime(2025, 3, 15), 11000m, 15000m),
                    new("Logística Zeta",      new DateTime(2025, 5, 03),  7000m, 10000m),
                }
            },
            {
                30711222333, new List<Fila>
                {
                    new("Carga Omega",         new DateTime(2025, 2, 18), 13000m, 18000m),
                    new("Mensajería Iota",     new DateTime(2025, 4, 30),  4000m,  6500m),
                }
            }
        };
        public record Fila(string Empresa, DateTime Fecha, decimal Costo, decimal Venta)
        {
            public decimal Resultado => Venta - Costo;
        }

        internal List<Fila> ObtenerDatosReporte(long cuit, DateTime desde, DateTime hasta)
        {
            ultimaCUITIngresada = cuit;
            return datosPorCUIT[ultimaCUITIngresada];
        }



        public List<Fila> GetDatosPorCUIT(long cuit, DateTime desde, DateTime hasta)
        {
            if (datosPorCUIT.TryGetValue(cuit, out var datos))
            {
                return datos.Where(fila => fila.Fecha.Date >= desde.Date && fila.Fecha.Date <= hasta.Date).ToList();
            }
            else
            {
                // Fallback: generar una fila genérica con la fecha 'desde' y otra en 'hasta'
                return new List<Fila>();



            }
        }
    }
}


