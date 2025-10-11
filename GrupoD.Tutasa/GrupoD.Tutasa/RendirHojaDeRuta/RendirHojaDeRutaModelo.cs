using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoD.Tutasa.RendirHojaDeRuta
{
    //DNI's de prueba: 34123113, 38123113

    public class RendirHojaDeRutaModelo
    {
        //Para que el modelo se acuerde el último DNI ingresado

        private int ultimoDniIngresado = -1;

        //Para guardar las guías por fletero (DNI)
        private Dictionary<int, List<GuiasPendientesRendicion>> guiasARendirPorFletero = new();
        private Dictionary<int, List<GuiasARealizar>> guiasARealizarPorFletero = new();

        //Creación del constructor para inicializar datos de prueba
        public RendirHojaDeRutaModelo()
        {
            guiasARendirPorFletero[34123113] = new List<GuiasPendientesRendicion>
            {
                new GuiasPendientesRendicion
                {
                    Guia = "574013982645",
                    Estado = "Pendiente",
                    DireccionDeDestino = "Calle Prueba 1",
                    Autorizado = "Fletero Uno",
                    CUIT = "20-34123113-1",
                    TipoPaquete = "TipoA"
                },
                new GuiasPendientesRendicion
                {
                    Guia = "821190547306",
                    Estado = "Pendiente",
                    DireccionDeDestino = "Calle Prueba 2",
                    Autorizado = "Fletero Uno",
                    CUIT = "20-34123113-2",
                    TipoPaquete = "TipoB"
                }
            };

            guiasARendirPorFletero[38123113] = new List<GuiasPendientesRendicion>
            {
                new GuiasPendientesRendicion
                {
                    Guia = "490517336288",
                    Estado = "Pendiente",
                    DireccionDeDestino = "Avenida Test 1",
                    Autorizado = "Fletero Dos",
                    CUIT = "20-38123113-1",
                    TipoPaquete = "TipoC"
                },
                new GuiasPendientesRendicion
                {
                    Guia = "107624953150",
                    Estado = "Pendiente",
                    DireccionDeDestino = "Avenida Test 2",
                    Autorizado = "Fletero Dos",
                    CUIT = "20-38123113-2",
                    TipoPaquete = "TipoD"
                }
            };

            guiasARealizarPorFletero[34123113] = new List<GuiasARealizar>
            {
                new GuiasARealizar
                {
                    Guia = "REALIZAR3412A",
                    Estado = "En Proceso",
                    DireccionDeDestino = "Calle Luna 100",
                    Autorizado = "Carlos López",
                    CUIT = "20-34123113-3",
                    TipoPaquete = "Tipo1"
                },
                new GuiasARealizar
                {
                    Guia = "REALIZAR3412B",
                    Estado = "En Proceso",
                    DireccionDeDestino = "Calle Sol 200",
                    Autorizado = "Ana Martínez",
                    CUIT = "20-34123113-4",
                    TipoPaquete = "Tipo2"
                }
            };

            guiasARealizarPorFletero[38123113] = new List<GuiasARealizar>
            {
                new GuiasARealizar
                {
                    Guia = "REALIZAR3812A",
                    Estado = "En Proceso",
                    DireccionDeDestino = "Avenida Estrella 300",
                    Autorizado = "Miguel Torres",
                    CUIT = "20-38123113-3",
                    TipoPaquete = "Tipo3"
                },
                new GuiasARealizar
                {
                    Guia = "REALIZAR3812B",
                    Estado = "En Proceso",
                    DireccionDeDestino = "Avenida Cometa 400",
                    Autorizado = "Sofía Ramírez",
                    CUIT = "20-38123113-4",
                    TipoPaquete = "Tipo4"
                }
            };
        }

        internal List<GuiasARealizar> ObtenerGuiasARealizar(int dni)
        {
            return guiasARealizarPorFletero[ultimoDniIngresado];


            //if (dni < 1_000_000 || dni > 99_999_999)
            //
            // MessageBox.Show("El DNI ingresado es inválido");
            // return null;
            // Ya se validó antes
            //return new List<GuiasARealizar>
            //{
            //     new GuiasARealizar { Guia = "789012", Estado = "En Proceso", DireccionDeDestino = "Calle Luna 456", Autorizado = "Carlos López", CUIT = "20-12345678-9", TipoPaquete = "Tipo1" },
            //   new GuiasARealizar { Guia = "210987", Estado = "En Proceso", DireccionDeDestino = "Avenida Sol 321", Autorizado = "Ana Martínez", CUIT = "27-98765432-1", TipoPaquete = "Tipo2" }
            // };
        }



        internal List<GuiasPendientesRendicion> ObtenerGuiasARendir(int dni)
        {
            if (dni <1_000_000 || dni > 99_999_999)
            {
               MessageBox.Show( "El DNI ingresado es inválido");
                return null;
            }

            //Si el diccionario de datos de prueba no tiene el dni, muestro error
            if (!guiasARealizarPorFletero.ContainsKey(dni))
            {
                MessageBox.Show("No se encontraron guías para el DNI ingresado.");
                return null;
            }


            //pasa la validación y guardo el último dni ingresado
            ultimoDniIngresado = dni;

            //simular la obtención de datos desde una base de datos o servicio
            return guiasARendirPorFletero[dni];




            //return new List<GuiasPendientesRendicion>
            //{
            //    new GuiasPendientesRendicion { Guia = "123456", Estado = "Pendiente", DireccionDeDestino = "Calle Falsa 123", Autorizado = "Juan Pérez" , TipoPaquete = "Tipo1"},
            //   new GuiasPendientesRendicion { Guia = "654321", Estado = "Pendiente", DireccionDeDestino = "Avenida Siempre Viva 742", Autorizado = "María Gómez", TipoPaquete = "Tipo2" }
            //};




        }


        public string AceptarYCambiarEstado(List<string> guiasSeleccionadas)
        {
            var lista = guiasARendirPorFletero[ultimoDniIngresado];
            
            foreach (var guia in lista.Where(g => guiasSeleccionadas.Contains(g.Guia)))
            {
                guia.Estado = "Rendida";
            }

            lista.RemoveAll(g => guiasSeleccionadas.Contains(g.Guia));



            return null;


        }






    }
}
