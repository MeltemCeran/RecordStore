using RecordStore.BLL.Managers.Abstract;
using RecordStore.BLL.Models.Abstract;
using RecordStore.BLL.Models.Concrete;
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

        public ICollection<IsActiveAlbumReport> TakeActiveAlbums()
        {
            return _reportService.GetActiveAlbums().Select(s => new IsActiveAlbumReport() { Name = s.Name, Singers = s.Singers, IsActive = s.IsActive }).ToList();
            
        }

        public ICollection<DiscountedAlbumReport> TakeDiscountedAlbums()
        {
            return _reportService.GetDiscountedAlbums().Select(a => new DiscountedAlbumReport { Discount = a.Discount, Name = a.Name, Singers = a.Singers }).OrderBy(a => a.Discount);
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
