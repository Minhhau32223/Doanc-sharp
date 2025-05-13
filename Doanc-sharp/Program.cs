using Doanc_sharp.src.DAO;
using Doanc_sharp.src.DTO;
using MySqlX.XDevAPI.Common;

namespace Doanc_sharp
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
            Application.Run(new Loginform());
          
        }
    }
}