using Controller;
using Controllers;
using Models.Repositories;

namespace View
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ILogic logic = new Logic(new Repository());
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginDb(logic));
        }
    }
}