using RecordStore.BLL.Models.Concrete;
using RecordStore.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.BLL.Managers.Abstract
{
    public interface IReportManager
    {
        ICollection<IsActiveAlbumReport> TakeActiveAlbums();
        ICollection<IsActiveAlbumReport> TakeInActiveAlbums();
        ICollection<ReportAlbumResult> TakeLastAddedAlbums();
        ICollection<DiscountedAlbumReport> TakeDiscountedAlbums();
    }
}
