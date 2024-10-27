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
            //var dbContext = new RecordStoreDbContext(); // Kendi DbContext sýnýfýnýzý kullanýn
            //var unitOfWork = new UnitOfWork(dbContext); // IUnitOfWork uyumlu nesne
            //var reportService = new ReportService(unitOfWork); // IReportService uyumlu nesne
            //var reportManager = new ReportManager(reportService); // IReportManager uyumlu nesne

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginPage());
        }
    }
}