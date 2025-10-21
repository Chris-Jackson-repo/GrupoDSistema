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

        // Representa una fila del ListView (empresa, fecha, costo, venta)
        public record Fila(string Empresa, DateTime Fecha, decimal Costo, decimal Venta)
        {
            public decimal Resultado => Venta - Costo;
        }

        // Devuelve datos inventados para un CUIT y un rango de fechas (inclusive).
        public List<Fila> GetDatosPorCUIT(long cuit, DateTime desde, DateTime hasta)
        {
            // Datos base por CUIT (fechas fijas para poder filtrar por rango)
            List<Fila> datos = cuit switch
            {
                20345678901 => new List<Fila>
                {
                    new("Transportes Alfa",    new DateTime(2025, 1, 10), 15000m, 22000m),
                    new("Transportes Alfa",    new DateTime(2025, 2, 05), 12000m, 17000m),
                    new("Logística Beta",      new DateTime(2025, 3, 20),  8000m, 12000m),
                    new("Servicios Gamma",     new DateTime(2025, 4, 12),  5000m,  7500m),
                },
                33700050005 => new List<Fila>
                {
                    new("Transporte Delta",    new DateTime(2025, 1, 25), 20000m, 27000m),
                    new("Expreso Epsilon",     new DateTime(2025, 3, 15), 11000m, 15000m),
                    new("Logística Zeta",      new DateTime(2025, 5, 03),  7000m, 10000m),
                },
                30711222333 => new List<Fila>
                {
                    new("Carga Omega",         new DateTime(2025, 2, 18), 13000m, 18000m),
                    new("Mensajería Iota",     new DateTime(2025, 4, 30),  4000m,  6500m),
                },
                _ => new List<Fila>
                {
                    // Fallback: generar una fila genérica con la fecha 'desde' y otra en 'hasta'
                    new($"Empresa_{cuit % 10000}", desde.Date, 10000m, 14000m),
                    new($"Empresa_{cuit % 10000}", hasta.Date, 12000m, 16000m)
                }
            };

            // Normalizar fechas y filtrar por rango (inclusive)
            DateTime desdeDate = desde.Date;
            DateTime hastaDate = hasta.Date;

            var resultado = new List<Fila>();
            foreach (var fila in datos)
            {
                var f = fila.Fecha.Date;
                if (f >= desdeDate && f <= hastaDate)
                {
                    resultado.Add(fila);
                }
            }

            return resultado;
        }
    }
}
