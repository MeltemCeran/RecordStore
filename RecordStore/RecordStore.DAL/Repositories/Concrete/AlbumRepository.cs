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
            IQueryable<Album> query = _entities.Select(a => new Album { Name = a.Name, Singers = a.Singers, IsActive = a.IsActive })
                .Where(a => !a.IsActive);
            return query.ToList();
        }


        public ICollection<Album> ActiveAlbums()
        {
            IQueryable<Album> query = _entities.Select(a => new Album { Name = a.Name, Singers = a.Singers, IsActive = a.IsActive })
                .Where(a => a.IsActive);
            return query.ToList();
        }

        public ICollection<Album> LastAddedTenAlbums()
        {
            IQueryable<Album> query = _entities.OrderByDescending(a => a.Id).Take(10)
                .Select(a => new Album { Id = a.Id, Name = a.Name, Singers = a.Singers });

            return query.ToList();

        }
        public ICollection<Album> DiscountByAlbum()
        {
            IQueryable<Album> query = _entities.Select(a => new Album { Discount = a.Discount, Name = a.Name, Singers = a.Singers })
                .Where(a => a.Discount != null)
                .OrderBy(a => a.Discount);

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
