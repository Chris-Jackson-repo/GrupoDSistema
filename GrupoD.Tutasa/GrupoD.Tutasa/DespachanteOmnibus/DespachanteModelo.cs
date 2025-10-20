using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Guia = "AC901-0001",
                    CDOrigen = "CD Centro",
                    DireccionDeDestino = "Av. Primera 123",
                    TipoPaquete = "Paquete",
                    Estado = "Pendiente"
                },
                new GuiasParaDescargar
                {
                    Guia = "AC901-0002",
                    CDOrigen = "CD Norte",
                    DireccionDeDestino = "Calle Segunda 45",
                    TipoPaquete = "Sobre",
                    Estado = "Pendiente"
                }
            };

            guiasADescargarPorPatente["AE354DF"] = new List<GuiasParaDescargar>
            {
                new GuiasParaDescargar
                {
                    Guia = "AE354-0001",
                    CDOrigen = "CD Centro",
                    DireccionDeDestino = "Boulevard Tres 789",
                    TipoPaquete = "Paquete",
                    Estado = "Pendiente"
                },
                new GuiasParaDescargar
                {
                    Guia = "AE354-0002",
                    CDOrigen = "CD Sur",
                    DireccionDeDestino = "Calle Cuatro 10",
                    TipoPaquete = "Palet",
                    Estado = "Pendiente"
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
    }
}
