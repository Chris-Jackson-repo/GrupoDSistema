using GrupoD.Tutasa.CargarFactura;
using GrupoD.Tutasa.RegEntregaCD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoD.Tutasa.CargarFacturaModelo
{
    public class CargarFacturaModelo
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
        internal CargarFacturaModelo Ejemplo()
        {
            //Ejemplo de datos precargados
            clientes[10500900700] = new Cliente
            {
                CuitEmpresa = 10500900700,
                RazonSocial = "Pepsi",
                Direccion = "Rivadavia 4321",
                Factura = new Factura 
                {
                    NumeroFactura = 5001,
                    FechaFactura = new DateTime(2024, 5, 1),
                    FechaVencimiento = new DateTime(2024, 5, 31),
                    Encomiendas = new List<Encomienda>
                    {
                        new Encomienda
                        {
                            Cantidad = 1,
                            Descripcion = "Paquete 1",
                            Precio = 150.50m
                        },
                        new Encomienda
                        {
                            Cantidad = 1,
                            Descripcion = "Paquete 2",
                            Precio = 120.00m
                        }
                    }
                }

            };
            clientes[11111111111] = new Cliente
            {
                CuitEmpresa = 11111111111,
                RazonSocial = "Coca Cola",
                Direccion = "Avenida de mayo 221",
                Factura = new Factura
                {
                    NumeroFactura = 5002,
                    FechaFactura = new DateTime(2024, 5, 1),
                    FechaVencimiento = new DateTime(2024, 5, 31),
                    Encomiendas = new List<Encomienda>
                    {
                        new Encomienda
                        {
                            Cantidad = 1,
                            Descripcion = "Paquete 1",
                            Precio = 1700
                        },
                        new Encomienda
                        {
                            Cantidad = 1,
                            Descripcion = "Paquete 2",
                            Precio = 1900
                        }
                    }
                }

            };
            return this;
        }
    }
}
