namespace G5_TPI_ClubDeportivo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        ///  
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin());
            //Application.Run(new FormVencimientos());
            //Application.Run(new FormPlanesyActividades());
            //Application.Run(new FormPago());
            //Application.Run(new FormBuscarSocio());
        }
    }
}