using RecordStore.BLL.Managers.Abstract;
using RecordStore.BLL.Models.Concrete;
using RecordStore.DAL.Entities.Concrete;
using RecordStore.DAL.Services.Abstract;
using RecordStore.DAL.Services.Concrete;
using RecordStore.DAL.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.BLL.Managers.Concrete
{
    public class AlbumManager : Manager<AlbumModel, AlbumService<AlbumModel>>
    {
        private readonly IUnitOfWork _unitOfWork;


        //Buraya Constructor gelmeli mi?

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
        public ICollection<Album> GetDiscountByAlbum()
        {
            return _unitOfWork.Albums.DiscountByAlbum();
        }

    }
}
