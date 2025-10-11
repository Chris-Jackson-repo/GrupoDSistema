using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoD.Tutasa.RendirHojaDeRuta
{
    public class RendirHojaDeRutaModelo
    {
        internal List<GuiasARealizar> ObtenerGuiasARealizar(int dni)
        {
            //if (dni < 1_000_000 || dni > 99_999_999)
            //
               // MessageBox.Show("El DNI ingresado es inválido");
               // return null;
           // Ya se validó antes
            return new List<GuiasARealizar>
            {
                new GuiasARealizar { Guia = "789012", Estado = "En Proceso", DireccionDeDestino = "Calle Luna 456", Autorizado = "Carlos López", CUIT = "20-12345678-9", TipoPaquete = "Tipo1" },
                new GuiasARealizar { Guia = "210987", Estado = "En Proceso", DireccionDeDestino = "Avenida Sol 321", Autorizado = "Ana Martínez", CUIT = "27-98765432-1", TipoPaquete = "Tipo2" }
            };
        }



        internal List<GuiasPendientesRendicion> ObtenerGuiasARendir(int dni)
        {
            if (dni <1_000_000 || dni > 99_999_999)
            {
               MessageBox.Show( "El DNI ingresado es inválido");
                return null;
            }


            return new List<GuiasPendientesRendicion>
            {
                new GuiasPendientesRendicion { Guia = "123456", Estado = "Pendiente", DireccionDeDestino = "Calle Falsa 123", Autorizado = "Juan Pérez" , TipoPaquete = "Tipo1"},
                new GuiasPendientesRendicion { Guia = "654321", Estado = "Pendiente", DireccionDeDestino = "Avenida Siempre Viva 742", Autorizado = "María Gómez", TipoPaquete = "Tipo2" }
            };




        }



    }
}
