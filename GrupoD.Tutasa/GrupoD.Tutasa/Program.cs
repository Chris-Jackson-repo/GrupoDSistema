//using GrupoD.Tutasa.RendirHojaDeRuta;
//using GrupoD.Tutasa.CargarFactura;
//using GrupoD.Tutasa.DespachanteOmnibus;
//using GrupoD.Tutasa.ReporteCostosVentas;
//using GrupoD.Tutasa.CargarFactura;
using GrupoD.Tutasa.GenerarGuiaCD;


namespace GrupoD.Tutasa.CargarFactura
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new GenerarGuiaCDForm());
        }
    }
}