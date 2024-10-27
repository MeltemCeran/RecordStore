using RecordStore.BLL.Managers.Abstract;
using RecordStore.DAL.Entities.Concrete;
using RecordStore.DAL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.BLL.Managers.Concrete
{
    public class ReportManager : IReportManager
    {
        private readonly IReportService _reportService;
        public ReportManager(IReportService reportService)
        {
            _reportService = reportService;
        }

        public ICollection<Album> TakeActiveAlbums()
        {
            return _reportService.GetActiveAlbums();
        }

        public ICollection<Album> TakeDiscountedAlbums()
        {
            return _reportService.GetDiscountedAlbums();
        }

        public ICollection<Album> TakeInActiveAlbums()
        {
            return _reportService.GetInActiveAlbums();
        }

        public ICollection<Album> TakeLastAddedAlbums()
        {
            return _reportService.GetLastAddedTenAlbums();
        }
    }
}
