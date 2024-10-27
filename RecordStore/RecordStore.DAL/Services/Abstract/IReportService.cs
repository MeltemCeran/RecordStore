using RecordStore.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.DAL.Services.Abstract
{
    public interface IReportService
    {
        public ICollection<Album> GetInActiveAlbums();
        public ICollection<Album> GetActiveAlbums();
        public ICollection<Album> GetLastAddedTenAlbums();
        public ICollection<Album> GetDiscountedAlbums();
    }
}
