using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoD.Tutasa.DespachanteOmnibus
{
    public class DespachanteModelo
    {

        private string ultimaPatenteIngresada = string.Empty;

        private Dictionary<string, List<GuiasParaDescargar>> guiasADescargarPorPatente = new();
        private Dictionary<string, List<GuiasParaCargar>> guiasACargarPorPatente = new();

        // Constructor: inicializa datos de prueba
        public DespachanteModelo()
        {
            // normalizamos las claves a mayúsculas para evitar problemas de casing
            guiasADescargarPorPatente["AC901ZW"] = new List<GuiasParaDescargar>
            {
                new GuiasParaDescargar
                {
                    Guia = "AC9010001",
                    CDOrigen = "CD Centro",
                    DireccionDeDestino = "Av. Primera 123",
                    TipoPaquete = "Paquete",
                    
                },
                new GuiasParaDescargar
                {
                    Guia = "AC9010002",
                    CDOrigen = "CD Norte",
                    DireccionDeDestino = "Calle Segunda 45",
                    TipoPaquete = "Sobre",
                    
                }
            };

            guiasADescargarPorPatente["AE354DF"] = new List<GuiasParaDescargar>
            {
                new GuiasParaDescargar
                {
                    Guia = "AE3540001",
                    CDOrigen = "CD Centro",
                    DireccionDeDestino = "Boulevard Tres 789",
                    TipoPaquete = "Paquete",
                    
                },
                new GuiasParaDescargar
                {
                    Guia = "AE3540002",
                    CDOrigen = "CD Sur",
                    DireccionDeDestino = "Calle Cuatro 10",
                    TipoPaquete = "Palet",
                    
                }
            };

            guiasACargarPorPatente["AC901ZW"] = new List<GuiasParaCargar>
            {
                new GuiasParaCargar
                {
                    Guia = "AE354-0002",
                    CDDestino = "CD Norte",
                    DireccionDeDestino = "Calle Falsa 123",
                    TipoPaquete = "Sobre",
                    
                },
                new GuiasParaCargar
                {
                    Guia = "AE3540003",
                    CDDestino = "CD Sur",
                    DireccionDeDestino = "Avenida Siempreviva 45",
                    TipoPaquete = "Caja",
                    
                }
            };
            guiasACargarPorPatente["AE354DF"] = new List<GuiasParaCargar>
            {
                new GuiasParaCargar
                {
                    Guia = "AE354-0004",
                    CDDestino = "CD Centro",
                    DireccionDeDestino = "Plaza Mayor s/n",
                    TipoPaquete = "Paquete",
                    
                },
                new GuiasParaCargar
                {
                    Guia = "AE354-0005",
                    CDDestino = "CD Este",
                    DireccionDeDestino = "Ruta 9 Km 10",
                    TipoPaquete = "Sobre",
                    
                }


            };
        }

        
        internal List<GuiasParaDescargar> ObtenerGuiasADescargarPorPatente(string patente)
        {
           if (patente.Length > 7 )
            {
                MessageBox.Show("La patente no puede tener más de 7 caracteres.", "Error");
                return null;
            }

           
           if (!guiasADescargarPorPatente.ContainsKey(patente))
            {
                MessageBox.Show("No se encontraron guías para la patente ingresada.", "Información");
                return null;
            }


            //pasa la validación y guardo la última patente ingresada
            ultimaPatenteIngresada = patente;
            return guiasADescargarPorPatente[ultimaPatenteIngresada];


        }




        internal List<GuiasParaCargar> ObtenerGuiasACargarPorPatente(string patente)
        {

            return guiasACargarPorPatente[ultimaPatenteIngresada];
        }


        public string AceptarYCambiarEstado(List<string> guiasSeleccionadas)
        {

            var listacarga = guiasACargarPorPatente[ultimaPatenteIngresada];
            var listadescarga = guiasADescargarPorPatente[ultimaPatenteIngresada];

            // Simular el cambio de estado en la base de datos
            foreach (var guia in listacarga.Where(g => guiasSeleccionadas.Contains(g.Guia)))
            {
                // Aquí se cambiaría el estado de la guía en la base de datos
                Console.WriteLine($"Guía {guia} marcada como cargada.");
            }

            foreach (var guia in listadescarga.Where(g => guiasSeleccionadas.Contains(g.Guia)))
            {
                // Aquí se cambiaría el estado de la guía en la base de datos
                Console.WriteLine($"Guía {guia} marcada como descargada.");
            }

            listacarga.RemoveAll(g => guiasSeleccionadas.Contains(g.Guia));
            listadescarga.RemoveAll(g => guiasSeleccionadas.Contains(g.Guia));

            return null;

        }





    }
}
