using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoD.Tutasa.Almacenes
{
    internal class GuiasAlmacen
    {
        /* 
        static class GuiasAlmacen
        {
            static List<string> Guia = new List<Guia>();
            static GuiasAlmacen()
            {
                if (File.Exists("Guias.json"))
                {
                    var guiaJson = File.ReadAllText("Guias.json");
                    Guia = System.Text.Json.JsonSerializer.Deserialize<List<Guia>>(guiaJson) ?? new List<Guia>();
                }
            }
            public static void Grabar()
            {
                var guiaJson = System.Text.Json.JsonSerializer.Serialize(Guia);
                File.WriteAllText("Guias.json", guiaJson);
            }


        }
        */
        // En el program para guardar datos del almacen: GuiasAlmacen.Grabar();
    }
}
