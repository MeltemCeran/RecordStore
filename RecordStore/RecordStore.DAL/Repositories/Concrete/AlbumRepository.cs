using Microsoft.EntityFrameworkCore;
using RecordStore.DAL.Context;
using RecordStore.DAL.Entities.Concrete;
using RecordStore.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.DAL.Repositories.Concrete
{
    public class AlbumRepository : Repository<Album>,IAlbumRepository,IDisposable
    {
        private DbContext _context;
        private bool disposed = false;

        public AlbumRepository(DbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
        public ICollection<Album> InActiveAlbums()
        {
            IQueryable<Album> query = _entities.Where(a => !a.IsActive);
            return query.ToList();
        }

        public ICollection<Album> ActiveAlbums()

        {
            IQueryable<Album> query = _entities.Where(a => a.IsActive);
            return query.ToList();
        }

        public ICollection<Album> LastAddedTenAlbums()
        {
            IQueryable<Album> query = _entities.OrderByDescending(a => a.Id).Take(10);

            return query.ToList();
        }
        public ICollection<Album> DiscountByAlbum()
        {
            IQueryable<Album> query = _entities.Where(a => a.Discount != null);
            return query.ToList();

        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
