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
        ICollection<Album> TakeActiveAlbums();
        ICollection<Album> TakeInActiveAlbums();
        ICollection<Album> TakeLastAddedAlbums();
        ICollection<Album> TakeDiscountedAlbums();
    }
}
