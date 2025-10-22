using GrupoD.Tutasa.RendirHojaDeRuta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoD.Tutasa.RegEntregaCD
{
    internal class RegEntregaCDModelo
    {
        //Para guardar estados de las guías
        private Dictionary<int, EstadoActual> estadosActuales = new();

        internal EstadoActual ObtenerEstadoActual(int numeroGuia)
        {                      
            if (!estadosActuales.ContainsKey(numeroGuia))
            {
                MessageBox.Show("No se encontro una guía asignada a este número.");
                return null;
            }
            return estadosActuales[numeroGuia];
        }
        internal RegEntregaCDModelo Ejemplo ()
        {
            //Ejemplo de datos precargados
            estadosActuales[1001] = new EstadoActual
            {
                Dni = 12345678,
                Estado = "Entregado"
            };
            estadosActuales[1002] = new EstadoActual
            {
                Dni = 87654321,
                Estado = "Listo para retirar"
            };
            estadosActuales[1003] = new EstadoActual
            {
                Dni = 40821500,
                Estado = "Listo para retirar"
            };

            return this;
        }

    }
}
