using Microsoft.EntityFrameworkCore;
using RecordStore.DAL.Entities.Concrete;
using RecordStore.DAL.Services.Abstract;
using RecordStore.DAL.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.DAL.Services.Concrete
{
    public class ReportService : IReportService
    {
        private readonly IUnitOfWork _unitOfWork;


        public ReportService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ICollection<Album> GetInActiveAlbums()
        {
            return _unitOfWork.Albums.InActiveAlbums();
        }

        public ICollection<Album> GetActiveAlbums()
        {
            return _unitOfWork.Albums.ActiveAlbums();
        }

        public ICollection<Album> GetLastAddedTenAlbums()
        {
            return _unitOfWork.Albums.LastAddedTenAlbums();
        }

        public ICollection<Album> GetDiscountedAlbums()
        {
            return _unitOfWork.Albums.DiscountByAlbum();
        }
    }
}
