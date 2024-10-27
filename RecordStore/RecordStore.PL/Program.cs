using RecordStore.BLL.Managers.Abstract;
using RecordStore.BLL.Managers.Concrete;
using RecordStore.DAL.Context;
using RecordStore.DAL.Services.Concrete;
using RecordStore.DAL.UnitOfWorks;

namespace RecordStore.PL
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
            Application.Run(new WelcomePage());
        }
    }
}