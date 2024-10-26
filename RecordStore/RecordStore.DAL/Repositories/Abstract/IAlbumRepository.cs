using RecordStore.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.DAL.Repositories.Abstract
{
    public interface IAlbumRepository:IRepository<Album>,IDisposable
    {
        public ICollection<Album> InActiveAlbums();
        public ICollection<Album> ActiveAlbums();
        public ICollection<Album> LastAddedTenAlbums();
        public ICollection<Album> DiscountByAlbum();
    }
}
