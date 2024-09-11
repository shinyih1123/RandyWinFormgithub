using DocumentFormat.OpenXml.Bibliography;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using SkiaSharp;

namespace RandyWinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LiveCharts.Configure(config =>
           config
               // you can override the theme 
               // .AddDarkTheme()  

               // In case you need a non-Latin based font, you must register a typeface for SkiaSharp
               .HasGlobalSKTypeface(SKFontManager.Default.MatchCharacter('Ác')) // <- Chinese 
       );
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new FormFile());
            Application.Run(new Form1());
        }
    }
}