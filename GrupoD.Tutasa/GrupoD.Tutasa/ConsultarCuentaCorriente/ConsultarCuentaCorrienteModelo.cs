using GrupoD.Tutasa.CargarFactura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoD.Tutasa.ConsultarCuentaCorriente
{
    internal class ConsultarCuentaCorrienteModelo
    {
        private Dictionary<long, Cliente> clientes = new();
        internal int NumeroFactura { get; set; } = 1;
        internal Cliente ObtenerCliente(long cuit)
        {
            if (!clientes.ContainsKey(cuit))
            {
                MessageBox.Show("No se encontro un cliente asignado a este CUIT.");
                return null;
            }
            return clientes[cuit];
        }
        internal ConsultarCuentaCorrienteModelo Ejemplo()
        {
            //Ejemplo de datos precargados
            clientes[33333333333] = new Cliente
            {
                CuitEmpresa = 33333333333,
                RazonSocial = "Adidas",
                Direccion = "Rivadavia 5821",
                Comprobantes = new List<Comprobante>
                {
                new Comprobante
                    {
                        Fecha = new DateTime(2025, 4, 15),
                        DetalleComprobante = "F58902",
                        Importe = 8000,
                        FechaVencimiento =  new DateTime(2025, 5, 15)
                    },
                new Comprobante
                    {
                        Fecha = new DateTime(2025, 5, 10),
                        DetalleComprobante = "F58903",
                        Importe = 12000.50m,
                        FechaVencimiento =  new DateTime(2025, 6, 10)
                    },
                }

            };
            clientes[22222222222] = new Cliente
            {
                CuitEmpresa = 22222222222,
                RazonSocial = "Nike",
                Direccion = "Cabildo 1221",
                Comprobantes = new List<Comprobante>
                {
                new Comprobante
                    {
                        Fecha = new DateTime(2025, 2, 18),
                        DetalleComprobante = "F58902",
                        Importe = 15000.21m,
                        FechaVencimiento =  new DateTime(2025, 3, 18)
                    },
                }

            };
            return this;
        }
    }
}
