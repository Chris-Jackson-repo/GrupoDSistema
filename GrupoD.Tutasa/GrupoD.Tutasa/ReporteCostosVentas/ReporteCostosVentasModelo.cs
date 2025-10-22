using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        private Dictionary<long, List<ResultadoBusqueda>> resultadosPorCUIT = new();

        public ReporteCostosVentasModelo()
        {

            resultadosPorCUIT[20345678901] = new List<ResultadoBusqueda>
            {
                new ResultadoBusqueda { empresa = 20345678901, costo = 1200, ventas= 2000,  Fecha = new DateTime(2025, 10, 10) },
                new ResultadoBusqueda { empresa = 20345678901, costo = 600, ventas= 900, Fecha = new DateTime(2025, 10, 15) },
                new ResultadoBusqueda { empresa = 20345678901, costo = 800, ventas= 1000, Fecha = new DateTime(2025, 10, 18) },
                new ResultadoBusqueda { empresa = 20345678901, costo = 500, ventas= 300, Fecha = new DateTime(2025, 9, 30) }
            };

            // Datos de ejemplo para 33700050005
            resultadosPorCUIT[33700050005] = new List<ResultadoBusqueda>
            {
                new ResultadoBusqueda { empresa = 33700050005, costo = 400,  ventas = 1200, Fecha = new DateTime(2025, 10, 01) },
                new ResultadoBusqueda { empresa = 33700050005, costo = 300,  ventas = 700, Fecha = new DateTime(2025, 10, 12) },
                new ResultadoBusqueda { empresa = 33700050005, costo = 1500, ventas = 1000,  Fecha = new DateTime(2025, 9, 25) },
                new ResultadoBusqueda { empresa = 33700050005, costo = 200,  ventas = 500,   Fecha = new DateTime(2025, 11, 05) }
            };

            // Datos de ejemplo para 30711222333
            resultadosPorCUIT[30711222333] = new List<ResultadoBusqueda>
            {
                new ResultadoBusqueda { empresa = 30711222333, costo = 0,    ventas = 0,   Fecha = new DateTime(2025, 8, 15) },
                new ResultadoBusqueda { empresa = 30711222333, costo = 700,  ventas = 1500,    Fecha = new DateTime(2025, 10, 05) },
                new ResultadoBusqueda { empresa = 30711222333, costo = 250,  ventas = 250,  Fecha = new DateTime(2025, 10, 20) },
                new ResultadoBusqueda { empresa = 30711222333, costo = 900,  ventas = 1200,   Fecha = new DateTime(2025, 11, 10) }
            };





        }

        internal List<ResultadoBusqueda> ObtenerResultadosParaCUITYFechas(long cuit, DateTime fechaDesde, DateTime fechaHasta)
        {
            // Normalizar fechas a .Date para comparar sin horas
            var desde = fechaDesde.Date;
            var hasta = fechaHasta.Date;

            if (desde > hasta)
            {
                // Si el llamador valida correctamente las fechas, esto debería no ocurrir;
                // devolver lista vacía cuando el rango es inválido.
                return new List<ResultadoBusqueda>();
            }

            if (!resultadosPorCUIT.TryGetValue(cuit, out var lista))
            {
                return new List<ResultadoBusqueda>();
            }

            return lista
                .Where(r => r.Fecha.Date >= desde && r.Fecha.Date <= hasta)
                .ToList();
        }
    }
}


